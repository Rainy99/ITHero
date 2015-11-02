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
    public partial class BedroomForm : Form
    {
        bool close = false;
        public BedroomForm()
        {
            InitializeComponent();
        }
        private void BedroomForm_Load(object sender, EventArgs e)
        {
            ShowHeroInfo();
        }
        //显示英雄属性
        private void ShowHeroInfo()
        {
            //显示英雄信息（请编码实现）
            this.lblName.Text = GameManager.GameInfo.Hero.name;
			if(GameManager.GameInfo.Hero.gender == Gender.Female) 
			{
				this.lblGander.Text = "女";
				this.picGander.Image = imgListGander.Images[1];
			}
			else 
			{
				this.lblGander.Text = "男";
				this.picGander.Image = imgListGander.Images[0];
			}
			this.lblMoney.Text = GameManager.GameInfo.Hero.money.ToString();
			this.lblPrestige.Text = GameManager.GameInfo.Hero.prestige.ToString();
			this.lblMorality.Text = GameManager.GameInfo.Hero.morality.ToString();
			this.lblCharm.Text = GameManager.GameInfo.Hero.charm.ToString();
			this.lblPower.Text = GameManager.GameInfo.Hero.power.ToString();
			this.lblLuck.Text = GameManager.GameInfo.Hero.luck.ToString();
			this.lblIntellect.Text = GameManager.GameInfo.Hero.intellect.ToString();
            //显示英雄信息面板
            this.pnlHeroInfo.Visible = true;

        }

        //关闭英雄信息面板
        private void lblHeroInfoClose_Click(object sender, EventArgs e)
        {
            this.pnlHeroInfo.Visible = false;
        }
        //结束游戏
        private void lblGameOver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要离开游戏吗？", "系统提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //读档（请编码实现）
        private void lblLoad_Click(object sender, EventArgs e)
        {
        }
        //存档（请编码实现）
        private void lblSave_Click(object sender, EventArgs e)
        {
        }
        //剩余天数（请编码实现）
        private void lblDays_Click(object sender, EventArgs e)
        {
        }
        //外出
        private void lblOut_Click(object sender, EventArgs e)
        {
            SchoolForm sForm = new SchoolForm();
            sForm.StartPosition = FormStartPosition.Manual;    //设置窗体第一次出现的位置
            sForm.Location = new Point(this.Location.X, this.Location.Y);   //设置窗体出现的坐标
            sForm.Show();

            close = true;
            this.Close();
        }
        //睡觉
        private void lblSleep_Click(object sender, EventArgs e)
        {
            //1. 学习、打工和游玩次数还原（请编码实现）
            //2. 离毕业天数减1（请编码实现）
            //3. 判断离毕业天数是否为0，如果是则扣除各属性50%后还原离毕业天数并给出提示
            
        }
        //包裹
        private void lblParcel_Click(object sender, EventArgs e)
        {
            //显示包裹中所有物品数量

            this.pnlParcel.Visible = true;
        }
        //人物状态
        private void lblHeroInfo_Click(object sender, EventArgs e)
        {
            ShowHeroInfo();
            this.pnlHeroInfo.Visible = true;
        }

        private void lblParcelClose_Click(object sender, EventArgs e)
        {
            this.pnlParcel.Visible = false;
        }

        private void BedroomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断如果点击窗体右上角关闭按钮则返回主界面
            if (close != true)
            {
                Application.Exit();
            }
        }
        #region//使用物品
        private void lblBread_Click(object sender, EventArgs e)
        {
            //调用物品对象的使用方法（请编码实现）
            string strInfo = "";
            //显示使用后的数量（请编码实现）
            //显示使用信息
            MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblCalcium_Click(object sender, EventArgs e)
        {
            //调用物品对象的使用方法（请编码实现）
            string strInfo = "";
            //显示使用后的数量（请编码实现）
            //显示使用信息
            MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblFlower_Click(object sender, EventArgs e)
        {
            //调用物品对象的使用方法（请编码实现）
            string strInfo = "";
            //显示使用后的数量（请编码实现）
            //显示使用信息
            MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblLottery_Click(object sender, EventArgs e)
        {
            //调用物品对象的使用方法（请编码实现）
            string strInfo = "";
            //显示使用后的数量（请编码实现）
            //显示使用信息
            MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblQQStar_Click(object sender, EventArgs e)
        {
            //调用物品对象的使用方法（请编码实现）
            string strInfo = "";
            //显示使用后的数量（请编码实现）
            //显示使用信息
            MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lblBadge_Click(object sender, EventArgs e)
        {
            //调用物品对象的使用方法（请编码实现）
            string strInfo = "";
            //显示使用后的数量（请编码实现）
            //显示使用信息
            MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
