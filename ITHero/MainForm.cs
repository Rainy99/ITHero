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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //初始化游戏（请编码实现）
			GameManager.GameInfo.Init();
            //设置Panel的背景色为半透明效果
            this.pnlCreateHero.BackColor = Color.FromArgb(188, Color.Black); 
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            this.pnlCreateHero.Visible = true;      //显示创建英雄面板
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.pnlCreateHero.Visible = false;     //隐藏创建英雄面板
        }
        //“继续”按钮
        private void btnNext_Click(object sender, EventArgs e)
        {
            //判断姓名是否为空
            if (txtName.Text.Trim().Length > 0)
            {
                //保存英雄信息（请编码实现）
                GameManager.GameInfo.Hero.Name = txtName.Text;
				GameManager.GameInfo.Hero.Gender = rdoMale.Checked ? Gender.Male:Gender.Female;
                //切换下一界面
                CreateHeroForm chForm = new CreateHeroForm();
                chForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
                chForm.Location = new Point(this.Location.X, this.Location.Y);  //设置窗体出现的坐标
                chForm.Show();      //显示下一窗体
                this.pnlCreateHero.Visible = false;     //隐藏创建英雄面板
                this.Hide();        //隐藏本窗体
            }
            else
            {
                MessageBox.Show("请输入姓名！", "系统提示", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 读档（请编码实现）
        /// </summary>
        private void lblLoad_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 游戏选项
        /// </summary>
        private void lblOptions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("即将开放，敬请期待！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 退出游戏
        /// </summary>
        private void lblEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要离开游戏吗？", "系统提示",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
