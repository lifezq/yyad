namespace yyad
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form1" />
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The 文件ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The 新建ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，新建！");
        }

        /// <summary>
        /// The 打开ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，打开！");
        }

        /// <summary>
        /// The button1_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，开始！");

            int n = Int32.Parse(textBox1.Text);
            string output = " ";
            int[] number = new int[n];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = i;
            }

            for (int i = number.Length - 1, j = 1; i >= 0; i--, j++)
            {
                if (j % 5 == 0)
                    output += number[i] + "\n";
                else
                    output += number[i] + "\t";
            }

            MessageBox.Show(string.Format(output));
        }

        /// <summary>
        /// The 查找ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，查找！");
        }

        /// <summary>
        /// The 剪切ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，剪切！");
        }

        /// <summary>
        /// The 复制ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，复制！");
        }

        /// <summary>
        /// The 全选ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，开始！");
        }

        /// <summary>
        /// The 保存ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您好，保存！");
        }

        /// <summary>
        /// The 另存为ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goto gh;
            MessageBox.Show("您好，另存为！");
        gh:
            MessageBox.Show("goto您好，另存为！");
        }
    }
}
