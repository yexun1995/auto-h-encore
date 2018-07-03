using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_h_encore {
    public partial class FormAID : Form {
        public FormAID() {
            InitializeComponent();

            lblGuide.Text = "运行之前: \r\n1. 安装 QCMA\r\n2. 打开 QCMA\r\n3. USB连接你的PSV和电脑 并启动 内容管理 应用\r\n4. 选择 复制内容 使Vita和PC连接\r\n   如果你的 Vita 提示更新系统, 关闭Vita的 Wifi 并重启动Vita\r\n5. 右键点击 QCMA 任务栏图标, 选择 设置 命令\r\n6. 复制 应用 / 备份 目录地址并输入到本程序 数据备份目录 位置 \r\n7. PC端打开上一步提到的应用备份目录并进入 APP 文件夹\r\n8. 你的 AID 是APP文件夹下的文件夹名称 (应当是 16位 字符)";
        }

        private void btnOpenGuide_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/TheOfficialFloW/h-encore/blob/master/README.md");
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
