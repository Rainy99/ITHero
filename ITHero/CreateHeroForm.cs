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
    public partial class CreateHeroForm : Form
    {
        bool close = false;     //定义变量判断是否点击右上角的“X”关闭窗体

        public CreateHeroForm()
        {
            InitializeComponent();
        }
        //“听天由命”按钮
        private void lblAuto_Click(object sender, EventArgs e)
        {
            //调用英雄初始化属性方法（请编码实现）
			GameManager.GameInfo.Hero.Create();
            BedroomForm bForm = new BedroomForm();
            bForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            bForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            bForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }

        private void CreateHeroForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateHeroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断如果点击窗体右上角关闭按钮则返回主界面
            if(close!=true)
            {
                Application.Exit();
            }
        }

        private void lblQuestions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即将开放，敬请期待！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
