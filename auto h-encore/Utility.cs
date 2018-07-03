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
using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;

namespace auto_h_encore {
    public static class Utility {
        private static WebClient web = new WebClient();
        private static HttpClient http = new HttpClient();

        public static string GetEncKey(string aid) {
            try {
                string page = http.GetStringAsync(Reference.url_cma + aid).Result;
                return page.Substring(page.Length - 65, 64);
            } catch (Exception) {
                //10020100
                ErrorHandling.ShowError("10020100", "获取 CMA 加密密钥失败. 确保已联网并重试.");
                return "";
            }
        }

        public static void DownloadFile(Form1 form, string url, string output) {
            while (true)
                try {
                    form.info("正在下载 " + output.Replace('/', '\\').Split('\\').Last());
                    web.DownloadFile(url, output);
                    form.info("      完成!");
                    return;
                } catch (WebException ex) {
                    //01010100
                    if (MessageBox.Show("错误 10010101\r\n\r\n下载文件 " + url + "\r\n\r\n失败.确保已联网并重试. 如果依旧失败, 请在Github问题跟踪器上创建一个问题.", "错误", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
                        throw ex;
                } catch (Exception ex) {
                    //FFFF0108
                    ErrorHandling.ShowError("FFFF0108", "意外错误: " + ex.Message);
                    throw ex;
                }
        }

        public static void ExtractFile(Form1 form, bool incrementProgress, string filePath, string outputDirectory) {
            try {
                form.info("解压 " + filePath.Replace('/', '\\').Split('\\').Last());
                ZipFile.ExtractToDirectory(filePath, outputDirectory);
                form.info("      完成!");
                if (incrementProgress) form.incrementProgress();
                return;
            } catch (DirectoryNotFoundException ex) {
                //20010102
                ErrorHandling.ShowError("20010102", "创建的文件丢失. 请重试 并且 不要碰程序目录.");
                throw ex;
            } catch (UnauthorizedAccessException ex) {
                //20020103
                ErrorHandling.ShowError("20020103", "本程序没有对其安装目录的写入权限. 请尝试以管理员身份重新运行本程序.");
                throw ex;
            } catch (FileNotFoundException ex) {
                //20030104
                ErrorHandling.ShowError("20030104", "创建的文件丢失. 请重试 并且 不要碰程序目录.");
                throw ex;
            } catch (InvalidDataException ex) {
                //20040105
                ErrorHandling.ShowError("20040105", "下载内容已损坏. 确保您的网络稳定, 然后重试.");
                throw ex;
            } catch (IOException ex) {
                //20FF0106
                ErrorHandling.ShowError("20FF0106", "意外错误: " + ex.Message);
                throw ex;
            } catch (Exception ex) {
                //FFFF0107
                ErrorHandling.ShowError("FFFF0107", "意外错误: " + ex.Message);
                throw ex;
            }

        }

        public static void PackageFiles(Form1 form, bool incrementProgress, string workingDirectory, string encryptionKey, string type) {
            try {
                form.info("利用 psvimgtools " + type + " 打包 h-encore...");
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.WorkingDirectory = workingDirectory;
                psi.FileName = Reference.path_psvimgtools + "psvimg-create.exe";
                psi.Arguments = "-n " + type + " -K " + encryptionKey + " " + type + " PCSG90096/" + type;
                Process process = Process.Start(psi);
                process.WaitForExit();
                form.info("      完成!");
                form.incrementProgress();
                return;
            } catch (FileNotFoundException ex) {
                //20030109
                ErrorHandling.ShowError("20030109", "创建的文件丢失. 请重试 并且 不要碰程序目录.");
                throw ex;
            } catch (Exception ex) {
                //FFFF010A
                ErrorHandling.ShowError("FFFF010A", "意外错误: " + ex.Message);
                throw ex;
            }
        }

        public static string BrowseFile(string title, string extension, string restrictions) {
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = restrictions;
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.DefaultExt = extension;
                dialog.Multiselect = false;
                dialog.Title = title;
                dialog.ShowDialog();
                return dialog.FileName;
            } catch (Exception ex) {
                //FFFF010B
                ErrorHandling.ShowError("FFFF010B", "意外错误: " + ex.Message);
                throw ex;
            }            
        }

        public static string MD5Checksum(string path) {
            try {
                using (MD5 md5 = MD5.Create()) {
                    using (FileStream stream = File.OpenRead(path)) {
                        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                    }
                }
            } catch (System.Reflection.TargetInvocationException ex) {
                //3001010C
                ErrorHandling.ShowError("3001010C", "执行 MD5 校验失败. 请重试.");
                throw ex;
            } catch (DirectoryNotFoundException ex) {
                //2001010D
                ErrorHandling.ShowError("2001010D", "创建的目录丢失. 请重试 并且 不要碰程序目录.");
                throw ex;
            } catch (UnauthorizedAccessException ex) {
                //2002010E
                ErrorHandling.ShowError("2002010E", "本程序没有对其安装目录的写入权限. 请尝试以管理员身份重新运行本程序.");
                throw ex;
            } catch (FileNotFoundException ex) {
                //2003010F
                ErrorHandling.ShowError("2003010F", "创建的文件丢失. 请重试 并且 不要碰程序目录.");
                throw ex;
            } catch (Exception ex) {
                //FFFF0110
                ErrorHandling.ShowError("FFFF0110", "意外错误: " + ex.Message);
                throw ex;
            }

        }
    }
}
