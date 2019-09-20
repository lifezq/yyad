using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yyad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，新建！");
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，打开！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，开始！");
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，查找！");
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，剪切！");
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，复制！");
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，开始！");
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，保存！");
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，另存为！");
        }
    }
}
