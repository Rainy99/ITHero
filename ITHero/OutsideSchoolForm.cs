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
    public partial class OutsideSchoolForm : Form
    {
        bool close = false;
        public OutsideSchoolForm()
        {
            InitializeComponent();
        }

        private void OutsideSchoolForm_Load(object sender, EventArgs e)
        {

        }

        private void lblSchool_Click(object sender, EventArgs e)
        {
            SchoolForm sForm = new SchoolForm();
            sForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            sForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            sForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
        private void OutsideSchoolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断如果点击窗体右上角关闭按钮则返回主界面
            if (close != true)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// 医院
        /// </summary>
        private void lblHospital_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即将开放，敬请期待！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 软件园
        /// </summary>
        private void lblSoftwarePark_Click(object sender, EventArgs e)
        {
			GameManager.GameInfo.CurrentMap = new SchoolMap(2,"校外地图");	//保存学校地图对象
            BuildingForm bForm = new BuildingForm();
            bForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            bForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            bForm.Tag = 2000;
            bForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }
        /// <summary>
        /// 游乐园
        /// </summary>
        private void lblHappyValley_Click(object sender, EventArgs e)
        {
			GameManager.GameInfo.CurrentMap = new SchoolMap(2, "校外地图");	//保存学校地图对象
            BuildingForm bForm = new BuildingForm();
            bForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            bForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            bForm.Tag = 2001;
            bForm.Show();

            close = true;       //允许关闭本窗体
            this.Close();
        }

    }
}
