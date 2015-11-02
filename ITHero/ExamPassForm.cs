using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHero
{
    public partial class ExamPassForm : Form
    {
        bool close = false;
        public ExamPassForm()
        {
            InitializeComponent();
        }

        private void ExamPassForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重新游戏
        /// </summary>
        private void lblNewGame_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            mForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            mForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            mForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
        /// <summary>
        /// 离开游戏
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要离开游戏吗？", "系统提示",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ExamPassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断如果点击窗体右上角关闭按钮则返回主界面
            if (close != true)
            {
                Application.Exit();
            }
        }
    }
}
