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
    public partial class SchoolForm : Form
    {
        bool close = false;
        public SchoolForm()
        {
            InitializeComponent();
        }
        private void SchoolForm_Load(object sender, EventArgs e)
        {
            
        }
        private void lblBedroom_Click(object sender, EventArgs e)
        {
            BedroomForm bForm = new BedroomForm();
            bForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            bForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            bForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
        private void SchoolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断如果点击窗体右上角关闭按钮则返回主界面
            if (close != true)
            {
                Application.Exit();
            }
        }

        private void lblDoor_Click(object sender, EventArgs e)
        {
            OutsideSchoolForm osForm = new OutsideSchoolForm();
            osForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            osForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            osForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
        /// <summary>
        /// 操场、图书馆和医务室暂未开放
        /// </summary>
        private void lblPlayground_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即将开放，敬请期待！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 教学楼
        /// </summary>
        private void lblClassroom_Click(object sender, EventArgs e)
        {
            BuildingForm bForm = new BuildingForm();
            bForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            bForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            bForm.Tag = 1000;
            bForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
        /// <summary>
        /// 食堂
        /// </summary>
        private void lblEatery_Click(object sender, EventArgs e)
        {
            BuildingForm bForm = new BuildingForm();
            bForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            bForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            bForm.Tag = 1001;
            bForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
    }
}
