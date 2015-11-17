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
			this.lblName.Text = GameManager.GameInfo.Hero.Name;
			if(GameManager.GameInfo.Hero.Gender == Gender.Female)
			{
				this.lblGander.Text = "女";
				this.picGander.Image = imgListGander.Images[1];
			}
			else
			{
				this.lblGander.Text = "男";
				this.picGander.Image = imgListGander.Images[0];
			}
			this.lblMoney.Text = GameManager.GameInfo.Hero.Money.ToString();
			this.lblPrestige.Text = GameManager.GameInfo.Hero.Prestige.ToString();
			this.lblMorality.Text = GameManager.GameInfo.Hero.Morality.ToString();
			this.lblCharm.Text = GameManager.GameInfo.Hero.Charm.ToString();
			this.lblPower.Text = GameManager.GameInfo.Hero.Power.ToString();
			this.lblLuck.Text = GameManager.GameInfo.Hero.Luck.ToString();
			this.lblIntellect.Text = GameManager.GameInfo.Hero.Intellect.ToString();
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
			if(result == DialogResult.OK)
			{
				Application.Exit();
			}
		}
		//读档（请编码实现）
		private void lblLoad_Click(object sender, EventArgs e)
		{
			//获取当前应用程序下的data文件夹
			ofDlg.InitialDirectory=Application.StartupPath+@"\data\";
			DialogResult result = ofDlg.ShowDialog();
			if(result == DialogResult.OK)
			{
				//读取玩家存档信息
				GameManager.Load(ofDlg.FileName);
				//跳转到寝室
				BedroomForm bForm = new BedroomForm();
				bForm.StartPosition = FormStartPosition.Manual;
				bForm.Location = new Point(this.Location.X,this.Location.Y);
				bForm.Show();
				close = true;
				this.Close();
			}
		}
		//存档（请编码实现）
		private void lblSave_Click(object sender, EventArgs e)
		{
			GameManager.Save();
			MessageBox.Show("保存成功！","系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
			GoodsWarehouse gw = GameManager.GameInfo.AllGoodsList;
			//显示包裹中所有物品数量
			this.lblBreadNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[gw.Bread].ToString();
			this.lblCalciumNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[gw.Calcium].ToString();
			this.lblFlowerNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[gw.Flower].ToString();
			this.lblLotteryNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[gw.Lottery].ToString();
			this.lblQQNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[gw.QQStar].ToString();
			this.lblBadgeNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[gw.Badge].ToString();
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
			if(close != true)
			{
				Application.Exit();
			}
		}
		#region//使用物品
		private void lblBread_Click(object sender, EventArgs e)
		{
			//调用物品对象的使用方法（请编码实现）
			string strInfo = GameManager.GameInfo.AllGoodsList.Bread.Use(GameManager.GameInfo.Hero);
			//显示使用后的数量（请编码实现）
			lblBreadNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[GameManager.GameInfo.AllGoodsList.Bread].ToString();
			//显示使用信息
			MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void lblCalcium_Click(object sender, EventArgs e)
		{
			//调用物品对象的使用方法（请编码实现）
			string strInfo = GameManager.GameInfo.AllGoodsList.Calcium.Use(GameManager.GameInfo.Hero);
			//显示使用后的数量（请编码实现）
			lblCalciumNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[GameManager.GameInfo.AllGoodsList.Calcium].ToString();
			//显示使用信息
			MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void lblFlower_Click(object sender, EventArgs e)
		{
			//调用物品对象的使用方法（请编码实现）
			string strInfo = GameManager.GameInfo.AllGoodsList.Flower.Use(GameManager.GameInfo.Hero);
			//显示使用后的数量（请编码实现）
			lblFlowerNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[GameManager.GameInfo.AllGoodsList.Flower].ToString();
			//显示使用信息
			MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void lblLottery_Click(object sender, EventArgs e)
		{
			//调用物品对象的使用方法（请编码实现）
			string strInfo = GameManager.GameInfo.AllGoodsList.Lottery.Use(GameManager.GameInfo.Hero);
			//显示使用后的数量（请编码实现）
			lblLotteryNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[GameManager.GameInfo.AllGoodsList.Lottery].ToString();
			//显示使用信息
			MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void lblQQStar_Click(object sender, EventArgs e)
		{
			//调用物品对象的使用方法（请编码实现）
			string strInfo = GameManager.GameInfo.AllGoodsList.QQStar.Use(GameManager.GameInfo.Hero);
			//显示使用后的数量（请编码实现）
			lblQQNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[GameManager.GameInfo.AllGoodsList.QQStar].ToString();
			//显示使用信息
			MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void lblBadge_Click(object sender, EventArgs e)
		{
			//调用物品对象的使用方法（请编码实现）
			string strInfo = GameManager.GameInfo.AllGoodsList.Badge.Use(GameManager.GameInfo.Hero);
			//显示使用后的数量（请编码实现）
			lblBadgeNum.Text = "x" + GameManager.GameInfo.Pack.GoodsList[GameManager.GameInfo.AllGoodsList.Badge].ToString();
			//显示使用信息
			MessageBox.Show(strInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
	}
}
