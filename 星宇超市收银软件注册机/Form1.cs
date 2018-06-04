using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 星宇超市收银软件注册机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hardIDtext.Text = VerifyHandler.GetHardID();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            if (string.IsNullOrEmpty(name)){
                MessageBox.Show("请输入用户名！");
                return;
            }
            string hardID = VerifyHandler.GetHardID();

            key.Text = VerifyHandler.GetSNByHardID(hardID, name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(key.Text);
            MessageBox.Show("复制成功！");
        }
    }
}
