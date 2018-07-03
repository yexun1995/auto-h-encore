using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Diagnostics;

namespace auto_h_encore {
    public static class Utility {
        private static WebClient web = new WebClient();
        private static HttpClient http = new HttpClient();

        public static string GetEncKey(string aid) {
            try {
                string page = http.GetStringAsync(Reference.url_cma + aid).Result;
                return page.Substring(page.Length - 65, 64);
            } catch (Exception) {
                MessageBox.Show("获取 CMA 解密 key 失败");
                return "";
            }
        }

        public static void DownloadFile(Form1 form, bool incrementProgress, string url, string output) {
            while (true)
                try {
                    form.info("正在下载 " + output.Replace('/', '\\').Split('\\').Last());
                    web.DownloadFile(url, output);
                    form.info("      完成!");
                    if (incrementProgress) form.incrementProgress();
                    return;
                } catch (WebException ex) {
                    if (MessageBox.Show("下载失败 " + url + "\r\n\r\n确保已联网并重试. 如果依旧失败, 去 Github 提交错误报告.", "错误", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                        throw ex;
                }
        }

        public static void ExtractFile(Form1 form, bool incrementProgress, string filePath, string outputDirectory) {
            try {
                form.info("解包 " + filePath.Replace('/', '\\').Split('\\').Last());
                ZipFile.ExtractToDirectory(filePath, outputDirectory);
                form.info("      完成!");
                if (incrementProgress) form.incrementProgress();
                return;
            } catch (DirectoryNotFoundException ex) {
                MessageBox.Show("已建立的目录消失了.请重启程序,不要修改其安装目录内任何文件.");
                throw ex;
            } catch (UnauthorizedAccessException ex) {
                MessageBox.Show("本程序不具备其安装目录的写入权限.请将本程序移动到你拥有写入权限的目录,或者以管理员权限运行.");
                throw ex;
            } catch (FileNotFoundException ex) {
                MessageBox.Show("已下载的文件消失了.请重启程序,不要修改其安装目录内任何文件.");
                throw ex;
            } catch (IOException ex) {
                MessageBox.Show("出现错误:\r\n\r\n" + ex.Message);
                throw ex;
            } catch (InvalidDataException ex) {
                MessageBox.Show("某项下载失败了, 请重启应用并确保网络连接正常.");
                throw ex;
            }

        }

        public static void PackageFiles(Form1 form, bool incrementProgress, string workingDirectory, string encryptionKey, string type) {
            try {
                form.info("打包 h-encore " + type + " 利用 psvimgtools...");
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.WorkingDirectory = workingDirectory;
                psi.FileName = Reference.path_psvimgtools + "psvimg-create.exe";
                psi.Arguments = "-n " + type + " -K " + encryptionKey + " " + type + " PCSG90096/" + type;
                Process process = Process.Start(psi);
                process.WaitForExit();
                form.info("      完成!");
                if (incrementProgress) form.incrementProgress();
                return;
            } catch (FileNotFoundException ex) {
                MessageBox.Show("已下载的文件消失了.请重启程序,不要修改其安装目录内任何文件.");
                throw ex;
            }
        }
    }
}
