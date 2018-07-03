using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Security.Cryptography;

namespace auto_h_encore {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            lblVersion.Text = "自动 h-encore 版本 " + Reference.version;
            lblInfo.Text = "运行之前: \r\n1. 安装 QCMA\r\n2. 打开 QCMA\r\n3. USB连接你的PSV和电脑 并启动 内容管理 应用\r\n4. 选择 复制内容 使Vita和PC连接\r\n   如果你的 Vita 提示更新系统, 关闭Vita的 Wifi 并重启Vita\r\n\r\n一切就绪后,正确输入顶部的信息以启用开始按钮\r\n\r\n如果开始按钮未被启用,请确保你的 AID 为16字符并且你选择了正确的 PS Vita 备份目录 (里面应当有一个 APP 文件夹).";
        }

        private void VerifyUserInfo() {
            if (txtAID.Text.Length == 16 && Directory.Exists(txtQCMA.Text + "\\APP\\")) btnStart.Enabled = true;
            else btnStart.Enabled = false;
        }

        private void generateDirectories(string AID) {
            //TODO: Needs code cleanup pretty bad...
            if (cbxDelete.Checked) {
                info("删除旧文件...");
                if (Directory.Exists(Reference.path_data)) Directory.Delete(Reference.path_data, true);
                for (int i = 0; i < 4; i++) {
                    if (!FileSystem.FileExists(Global.fileOverrides[i])) Global.fileOverrides[i] = "";
                }
                
            } else {

                string path = "";
                string cleanName;
                string md5;

                for (int id = 0; id < 4; id++) {

                    switch (id) {
                        case 0:
                            path = Reference.path_downloads + "hencore.zip";
                            break;
                        case 1:
                            path = Reference.path_downloads + "pkg2zip.zip";
                            break;
                        case 2:
                            path = Reference.path_downloads + "psvimgtools.zip";
                            break;
                        case 3:
                            path = Reference.path_downloads + "bittersmile.pkg";
                            break;
                    }

                    cleanName = path.Replace('/', '\\').Split('\\').Last();

                    if (Global.fileOverrides[id] != null && Global.fileOverrides[id] != "") {
                        info("File import for file " + cleanName + " valid.");
                        continue;
                    }

                    if (FileSystem.FileExists(path)) {
                        md5 = Utility.MD5Checksum(path);
                        if (Reference.hashes[id] == md5) {
                            info("文件 " + cleanName + " 已下载并且有效, 不再重新下载");
                            Global.fileOverrides[id] = path;
                        } else {
                            info("文件 " + cleanName + " 已下载但 hash 不匹配, 将要重新下载.");
                        }
                    } else {
                        info("文件 " + cleanName + " 未下载或者导入, 将开始下载.");
                    }
                }

                if (Directory.Exists(Reference.path_hencore)) Directory.Delete(Reference.path_hencore, true);
                if (Directory.Exists(Reference.path_psvimgtools)) Directory.Delete(Reference.path_psvimgtools, true);
            }

            if (Directory.Exists(txtQCMA.Text + "\\APP\\" + AID + "\\PCSG90096\\")) {
                if (MessageBox.Show("你必须删除 QCMA 目录内已存在的 bittersmile 备份. 如果你想保留它，请立刻手动转移删除么?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    FileSystem.DeleteDirectory(txtQCMA.Text + "\\APP\\" + txtAID.Text + "\\PCSG90096\\", DeleteDirectoryOption.DeleteAllContents);
                } else {
                    throw new IOException("目录已存在");
                }
            }

            info("生成工作目录...");
            if (FileSystem.FileExists(Reference.fpath_pkg2zip)) FileSystem.DeleteFile(Reference.fpath_pkg2zip);
            Directory.CreateDirectory(Reference.path_data);
            Directory.CreateDirectory(Reference.path_hencore);
            Directory.CreateDirectory(Reference.path_psvimgtools);
            Directory.CreateDirectory(Reference.path_downloads);
            incrementProgress();
        }

        private void downloadFiles() {

            for (int id = 0; id < 4; id++) {
                string cleanName = Reference.raws[id].Replace('/', '\\').Split('\\').Last();
                if (Global.fileOverrides[id] != null && Global.fileOverrides[id] != "") {
                    if (Global.fileOverrides[id] == Reference.raws[id]) info("文件 " + cleanName + " 在正确的位置, 跳过");
                    else {
                        info("导入 " + cleanName);
                        FileSystem.CopyFile(Global.fileOverrides[id], Reference.raws[id], true);
                        info("      完成!");
                    }
                } else {
                    Utility.DownloadFile(this, Reference.downloads[id], Reference.raws[id]);
                }
                incrementProgress();

                if (id != 3) Utility.ExtractFile(this, true, Reference.raws[id], Reference.paths[id]);
            }
        }

        private void PackageHencore(string encKey) {
            Utility.PackageFiles(this, true, Reference.path_hencore + "h-encore\\", encKey, "app");
            Utility.PackageFiles(this, true, Reference.path_hencore + "h-encore\\", encKey, "appmeta");
            Utility.PackageFiles(this, true, Reference.path_hencore + "h-encore\\", encKey, "license");
            Utility.PackageFiles(this, true, Reference.path_hencore + "h-encore\\", encKey, "savedata");
        }


        private void toggleControls(bool state) {
            if (InvokeRequired) {
                Invoke(new Action(() => {
                    btnStart.Enabled = state;
                    txtAID.Enabled = state;
                    txtQCMA.Enabled = state;
                    btnBrowseQCMA.Enabled = state;
                    barProgress.Value = 0;
                }));
            } else {
                btnStart.Enabled = state;
                txtAID.Enabled = state;
                txtQCMA.Enabled = state;
                btnBrowseQCMA.Enabled = state;
                barProgress.Value = 0;
            }
        }
        

        private void lblHowToAID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FormAID frmAid = new FormAID();
            frmAid.ShowDialog();
        }

        private void txtAID_TextChanged(object sender, EventArgs e) {
            VerifyUserInfo();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            toggleControls(false);

            //run code on new thread to keep UI responsive
            Task.Factory.StartNew(new Action(() => {
                
                try {
                    generateDirectories(txtAID.Text);
                    downloadFiles();
                } catch (Exception ex) {
                    //MessageBox.Show(ex.Message);
                    toggleControls(true);
                    return;
                }
                

                try {
                    info("正在利用 pkg2zip 解包 bittersmile 试玩版...");
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.WorkingDirectory = Reference.path_downloads;
                    psi.Arguments = "-x bittersmile.pkg";
                    psi.FileName = Reference.fpath_pkg2zip;
                    Process process = Process.Start(psi);
                    process.WaitForExit();
                    info("      完成!");
                    incrementProgress();
                } catch (FileNotFoundException) {
                    MessageBox.Show("已下载文件丢失. 请重启本程序 并且 不要修改程序目录内文件.");
                    toggleControls(true);
                    return;
                }

                if (cbxTrim.Checked) {
                    info("删减 bitter smile 试玩版中...");
                    string path = Reference.path_downloads + "app\\PCSG90096\\";
                    FileSystem.DeleteFile(path + "resource\\movie\\Opening.mp4");
                    foreach (string k in FileSystem.GetFiles(path + "resource\\sound\\bgm\\")) FileSystem.DeleteFile(k);
                    FileSystem.DeleteDirectory(path + "resource\\sound\\voice\\01\\", DeleteDirectoryOption.DeleteAllContents);
                    FileSystem.DeleteDirectory(path + "resource\\sound\\se\\", DeleteDirectoryOption.DeleteAllContents);
                    FileSystem.DeleteDirectory(path + "resource\\image\\bg\\", DeleteDirectoryOption.DeleteAllContents);
                    FileSystem.DeleteDirectory(path + "resource\\image\\tachie\\", DeleteDirectoryOption.DeleteAllContents);
                    info("      Done!");
                }

                try {
                    foreach (string k in FileSystem.GetFiles(Reference.path_downloads + "app\\PCSG90096\\")) {
                        info("移动 " + k.Split('\\').Last() + " 到 h-encore 工作目录...");
                        FileSystem.MoveFile(k, Reference.path_hencore + "\\h-encore\\app\\ux0_temp_game_PCSG90096_app_PCSG90096\\" + k.Split('\\').Last());
                    }
                } catch (DirectoryNotFoundException ex) {
                    MessageBox.Show("已建立的目录丢失. 请重启本程序 并且 不要修改程序目录内文件.");
                    toggleControls(true);
                    return;
                } catch (UnauthorizedAccessException ex) {
                    MessageBox.Show("本程序无法写入工作目录. 请将本程序移动到你拥有读写权限的目录, 或者以管理员权限运行本程序.");
                    toggleControls(true);
                    return;
                } catch (IOException ex) {
                    MessageBox.Show("出现错误:\r\n\r\n" + ex.Message);
                    toggleControls(true);
                    return;
                }

                try {
                    foreach (string k in FileSystem.GetDirectories(Reference.path_downloads + "app\\PCSG90096\\")) {
                        info("移动 " + k.Split('\\').Last() + " 到 h-encore 工作目录...");
                        FileSystem.MoveDirectory(k, Reference.path_hencore + "\\h-encore\\app\\ux0_temp_game_PCSG90096_app_PCSG90096\\" + k.Split('\\').Last());
                    }
                } catch (DirectoryNotFoundException ex) {
                    MessageBox.Show("已建立的目录丢失. 请重启本程序 并且 不要修改程序目录内文件.");
                    toggleControls(true);
                    return;
                } catch (UnauthorizedAccessException ex) {
                    MessageBox.Show("本程序无法写入工作目录. 请将本程序移动到你拥有读写权限的目录, 或者以管理员权限运行本程序.");
                    toggleControls(true);
                    return;
                } catch (IOException ex) {
                    MessageBox.Show("出现错误:\r\n\r\n" + ex.Message);
                    toggleControls(true);
                    return;
                }

                incrementProgress();

                try {
                    info("移动 license 文件...");
                    FileSystem.MoveFile(Reference.path_hencore + "\\h-encore\\app\\ux0_temp_game_PCSG90096_app_PCSG90096\\sce_sys\\package\\temp.bin", Reference.path_hencore + "\\h-encore\\license\\ux0_temp_game_PCSG90096_license_app_PCSG90096\\6488b73b912a753a492e2714e9b38bc7.rif");
                    info("      完成!");
                    incrementProgress();
                } catch (DirectoryNotFoundException ex) {
                    MessageBox.Show("已建立的目录丢失. 请重启本程序 并且 不要修改程序目录内文件.");
                    toggleControls(true);
                    return;
                } catch (UnauthorizedAccessException ex) {
                    MessageBox.Show("本程序无法写入工作目录. 请将本程序移动到你拥有读写权限的目录, 或者以管理员权限运行本程序.");
                    toggleControls(true);
                    return;
                } catch (IOException ex) {
                    MessageBox.Show("出现错误:\r\n\r\n" + ex.Message);
                    toggleControls(true);
                    return;
                }

                string encKey;

                try {
                    info("利用 AID " + txtAID.Text + "获取 CMA 解密 key ");
                    encKey = Utility.GetEncKey(txtAID.Text);
                    if (encKey.Length != 64) return;
                    info("已获取 CMA 解密 key " + encKey);
                    incrementProgress();
                } catch (Exception) {
                    toggleControls(true);
                    return;
                }
                
                try {
                    PackageHencore(encKey);
                } catch (Exception) {
                    toggleControls(true);
                    return;
                }

                try {
                    info("正在移动 h-encore 文件到 QCMA APP 备份目录...\r\n");
                    FileSystem.MoveDirectory(Reference.path_hencore + "h-encore\\PCSG90096\\", txtQCMA.Text + "\\APP\\" + txtAID.Text + "\\PCSG90096\\");
                    incrementProgress();
                    info("auto h-encore 操作完成!!");
                } catch (DirectoryNotFoundException ex) {
                    MessageBox.Show("找不到你的 QCMA 目录! 确保你选择了正确的目录,且该目录未被删除!");
                    toggleControls(true);
                    return;
                } catch (UnauthorizedAccessException ex) {
                    MessageBox.Show("本程序无法写入你的 QCMA 备份目录. 请在 QCMA 设置界面修改该目录为你拥有读写权限的目录, 或者以管理员权限运行本程序, 或者禁用该目录的只读权限.");
                    toggleControls(true);
                    return;
                } catch (IOException ex) {
                    MessageBox.Show("出现错误:\r\n\r\n" + ex.Message);
                    toggleControls(true);
                    return;
                }

                Invoke(new Action(() => MessageBox.Show("即将完成 h-encore 安装:\r\n"
                    + "1. 右键点击 QCMA 任务栏图标并选择刷新数据库\r\n"
                    + "2. 用USB连接 你的电脑 和 PSV\r\n"
                    + "3. 打开Vita端 内容管理 程序并点击 复制内容\r\n"
                    + "     如果 Vita 提示你需要更新系统, 关闭 Wifi 后重启 Vita\r\n"
                    + "4. 在 内容管理 程序界面, 选择 PC -> PS Vita System\r\n"
                    + "5. 选择 应用程序\r\n"
                    + "6. 选择 PS Vita\r\n"
                    + "7. 选择 h-encore 并点击 复制\r\n"
                    + "8. 启动 h-encore 程序\r\n"
                    + "     如果初次启动崩溃, 尝试重启Vita后再运行该程序\r\n\r\n"
                    + "完成!")));

                toggleControls(true);
            }));
            
        }

        public void incrementProgress() {
            if (InvokeRequired) Invoke(new Action(() => barProgress.Value++));
            else barProgress.Value++;
        }

        public void info(string message) {
            if (InvokeRequired) Invoke(new Action(() => txtLog.AppendText("[" + DateTime.Now.ToLongTimeString() + "] " + message + "\r\n")));
            else txtLog.AppendText("[" + DateTime.Now.ToLongTimeString() + "] " + message + "\r\n");

        }

        private void btnBrowseQCMA_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择你的 PS Vita/APP 目录 (可以在 QCMA 设置界面找到)";
            dialog.ShowDialog();
            txtQCMA.Text = dialog.SelectedPath;
        }

        private void txtQCMA_TextChanged(object sender, EventArgs e) {
            VerifyUserInfo();
        }

        private void btnImport_Click(object sender, EventArgs e) {
            FormFiles frm = new FormFiles();
            frm.ShowDialog();
        }
    }
}
