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
	public partial class BuildingForm : Form
	{
		Eatery eatery = new Eatery();
		bool close = false;
		public BuildingForm()
		{
			InitializeComponent();
		}

		private void BuildingForm_Load(object sender, EventArgs e)
		{
			eatery.Init();
			//判断显示对应建筑物
			int id = (int)this.Tag;
			switch(id)
			{
				case 1000:
					pnlClassroom.Visible = true;
					break;     //教室
				case 1001:
					pnlEatery.Visible = true;
					break;        //食堂
				case 2000:
					pnlSoftwarePark.Visible = true;
					break;  //软件园
				case 2001:
					pnlHappyValley.Visible = true;
					break;   //游乐园
			}
		}
		private void BuildingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//判断如果点击窗体右上角关闭按钮则返回主界面
			if(close != true)
			{
				Application.Exit();
			}
		}

		private void lbl_MouseDown(object sender, MouseEventArgs e)
		{
			((Label)sender).BorderStyle = BorderStyle.Fixed3D;
		}
		private void lbl_MouseUp(object sender, MouseEventArgs e)
		{
			((Label)sender).BorderStyle = BorderStyle.None;
		}
		#region 教学楼功能区
		/// <summary>
		/// 上课可以得到1～5个随机物品，并有极小机率直接提升随机属性
		/// </summary>
		private void lblStudy_Click(object sender, EventArgs e)
		{
			//判断学习次数，如果能学习则调用教学楼的随机运气方法，否则提示无法学习（请编码实现）
			if(GameManager.GameInfo.StudyNumber > 0)
			{
				string srtInfo = ((ILuck)GameManager.GameInfo.CurrentMap.BuildsList[1000]).Luck();
				GameManager.GameInfo.StudyNumber--;		//学习次数减1
				MessageBox.Show(srtInfo.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("你感到精神疲惫、头疼欲裂，完全无法学习！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		/// <summary>
		/// 考试
		/// </summary>
		private void lblExam_Click(object sender, EventArgs e)
		{
			//判断是否可以参考考试，所有属性都>=300可考试，否则提示未达到要求（请编码实现）

		}
		/// <summary>
		/// 离开教学楼返回学校
		/// </summary>
		private void lblExit_Click(object sender, EventArgs e)
		{
			//调用教学楼的返回地图方法（请编码实现）
			GameManager.GameInfo.CurrentMap.BuildsList[1000].ReturnMap(this.Location.X, this.Location.Y);
			close = true;       //允许关闭本窗体
			this.Close();
		}
		#endregion
		#region 食堂功能区
		/// <summary>
		/// 点击打开超市面板
		/// </summary>
		private void lblSupermarket_Click(object sender, EventArgs e)
		{
			//1. 显示英雄金钱（请编码实现）
			lblHeroMoney.Text = GameManager.GameInfo.Hero.Money.ToString();
			//2. 显示超市物品信息（请编码实现）
			lblBreadName.Text = GameManager.GameInfo.AllGoodsList.Bread.Name;
			lblBreadDetails.Text = GameManager.GameInfo.AllGoodsList.Bread.Details;
			lblBreadMoney.Text = GameManager.GameInfo.AllGoodsList.Bread.Money + "￥";
			lblCalciumName.Text = GameManager.GameInfo.AllGoodsList.Calcium.Name;
			lblCalciumDetails.Text = GameManager.GameInfo.AllGoodsList.Calcium.Details;
			lblCalciumMoney.Text = GameManager.GameInfo.AllGoodsList.Calcium.Money + "￥";
			lblFlowerName.Text = GameManager.GameInfo.AllGoodsList.Flower.Name;
			lblFlowerDetails.Text = GameManager.GameInfo.AllGoodsList.Flower.Details;
			lblFlowerMoney.Text = GameManager.GameInfo.AllGoodsList.Flower.Money + "￥";
			lblLotteryName.Text = GameManager.GameInfo.AllGoodsList.Lottery.Name;
			lblLotteryDetails.Text = GameManager.GameInfo.AllGoodsList.Lottery.Details;
			lblLotteryMoney.Text = GameManager.GameInfo.AllGoodsList.Lottery.Money + "￥";
			lblQQStarName.Text = GameManager.GameInfo.AllGoodsList.QQStar.Name;
			lblQQStarDetails.Text = GameManager.GameInfo.AllGoodsList.QQStar.Details;
			lblQQStarMoney.Text = GameManager.GameInfo.AllGoodsList.QQStar.Money + "￥";
			lblBadgeName.Text = GameManager.GameInfo.AllGoodsList.Badge.Name;
			lblBadgeDetails.Text = GameManager.GameInfo.AllGoodsList.Badge.Details;
			lblBadgeMoney.Text = GameManager.GameInfo.AllGoodsList.Badge.Money + "￥";
			//3. 显示超市面板
			pnlSupermarket.Visible = true;
		}
		/// <summary>
		/// 离开食堂返回学校
		/// </summary>
		private void lblEateryExit_Click(object sender, EventArgs e)
		{
			//调用食堂返回地图方法（请编码实现）
			GameManager.GameInfo.CurrentMap.BuildsList[1001].ReturnMap(this.Location.X, this.Location.Y);
			close = true;       //允许关闭本窗体
			this.Close();
		}
		/// <summary>
		/// 关闭超市面板
		/// </summary>
		private void lblParcelClose_Click(object sender, EventArgs e)
		{
			pnlSupermarket.Visible = false;
		}
		/// <summary>
		/// 买面包
		/// </summary>
		private void lblBreadBuy_Click(object sender, EventArgs e)
		{
			//调用本窗体的Buy方法（请编码实现）
			this.Buy(GameManager.GameInfo.AllGoodsList.Bread);
		}
		/// <summary>
		/// 卖面包
		/// </summary>
		private void lblBreadSell_Click(object sender, EventArgs e)
		{
			//调用本窗体的Sell方法（请编码实现）
			this.Sell(GameManager.GameInfo.AllGoodsList.Bread);
		}
		private void lblCalciumBuy_Click(object sender, EventArgs e)
		{
			//调用本窗体的Buy方法（请编码实现）
			this.Buy(GameManager.GameInfo.AllGoodsList.Calcium);
		}
		private void lblCalciumSell_Click(object sender, EventArgs e)
		{
			//调用本窗体的Sell方法（请编码实现）
			this.Sell(GameManager.GameInfo.AllGoodsList.Calcium);
		}
		private void lblFlowerBuy_Click(object sender, EventArgs e)
		{
			//调用本窗体的Buy方法（请编码实现）
			this.Buy(GameManager.GameInfo.AllGoodsList.Flower);
		}
		private void lblFlowerSell_Click(object sender, EventArgs e)
		{
			//调用本窗体的Sell方法（请编码实现）
			this.Sell(GameManager.GameInfo.AllGoodsList.Flower);
		}
		private void lblLotteryBuy_Click(object sender, EventArgs e)
		{
			//调用本窗体的Buy方法（请编码实现）
			this.Buy(GameManager.GameInfo.AllGoodsList.Lottery);
		}
		private void lblLotterySell_Click(object sender, EventArgs e)
		{
			//调用本窗体的Sell方法（请编码实现）
			this.Sell(GameManager.GameInfo.AllGoodsList.Lottery);
		}
		private void lblQQStarBuy_Click(object sender, EventArgs e)
		{
			//调用本窗体的Buy方法（请编码实现）
			this.Buy(GameManager.GameInfo.AllGoodsList.QQStar);
		}
		private void lblQQStarSell_Click(object sender, EventArgs e)
		{
			//调用本窗体的Sell方法（请编码实现）
			this.Sell(GameManager.GameInfo.AllGoodsList.QQStar);
		}
		private void lblBadgeBuy_Click(object sender, EventArgs e)
		{
			//调用本窗体的Buy方法（请编码实现）
			this.Buy(GameManager.GameInfo.AllGoodsList.Badge);
		}
		private void lblBadgeSell_Click(object sender, EventArgs e)
		{
			//调用本窗体的Sell方法（请编码实现）
			this.Sell(GameManager.GameInfo.AllGoodsList.Badge);
		}
		/// <summary>
		/// 回购物品（请编码实现）
		/// </summary>
		/// <param name="goods">物品对象</param>
		private void Buy(Goods goods)
		{
			if(eatery.Sell(goods))
			{
				lblHeroMoney.Text = GameManager.GameInfo.Hero.Money.ToString();		//显示更新后玩家金钱
				MessageBox.Show("购买了1个" + goods.Name + "!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("你是不是忘记带钱了!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		/// <summary>
		/// 出售物品（请编码实现）
		/// </summary>
		/// <param name="goods">物品对象</param>
		private void Sell(Goods goods)
		{
			if(eatery.Buy(goods))
			{
				lblHeroMoney.Text = GameManager.GameInfo.Hero.Money.ToString();		//显示更新后玩家金钱
				MessageBox.Show("售出了1个" + goods.Name + "!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("抱歉，你身上没有" + goods.Name + "了！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		#endregion
		#region 软件园功能区
		/// <summary>
		/// 打工（请编码实现）
		/// </summary>
		private void lblWork_Click(object sender, EventArgs e)
		{
			//1.判断玩家智力是否大于150
			if(GameManager.GameInfo.Hero.Intellect >= 150)
			{
				//2.如果大于150，再次判断是打工剩余次数
				if (GameManager.GameInfo.WorkNumber>0)
				{
					//3.如果还有剩余次数则调用软件园的随机运气方法
					string strInfo = ((ILuck)GameManager.GameInfo.CurrentMap.BuildsList[2000]).Luck();
					GameManager.GameInfo.WorkNumber--;	//打工次数减1
					MessageBox.Show(strInfo.ToString(),"系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("你感到精疲力尽。全身无力，需要好好休息了！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("以你现在的智力水平很难完成我们的项目啊！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		/// <summary>
		/// 离开软件园返回校外地图
		/// </summary>
		private void lblSoftwareParkExit_Click(object sender, EventArgs e)
		{
			//调用软件园的返回地图方法（请编码实现）
			GameManager.GameInfo.CurrentMap.BuildsList[2000].ReturnMap(this.Location.X, this.Location.Y);
			close = true;       //允许关闭本窗体
			this.Close();
		}
		#endregion
		#region 游乐园功能区
		/// <summary>
		/// 游玩（请编码实现）
		/// </summary>
		private void lblPlay_Click(object sender, EventArgs e)
		{
			//判断剩余游玩次数，如果大于0则调用游乐园的随机运气方法
			if (GameManager.GameInfo.PlayNumber > 0)
			{
				string strInfo = ((ILuck)GameManager.GameInfo.CurrentMap.BuildsList[2001]).Luck();
				GameManager.GameInfo.PlayNumber--;	//游玩次数减1
				MessageBox.Show(strInfo.ToString(),"系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("天色已晚，肚子叫你回家吃饭了！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		/// <summary>
		/// 离开游乐园返回校外地图
		/// </summary>
		private void lblHappyValleyExit_Click(object sender, EventArgs e)
		{
			//调用游乐园的返回地图方法（请编码实现）
			GameManager.GameInfo.CurrentMap.BuildsList[2001].ReturnMap(this.Location.X, this.Location.Y);
			close = true;       //允许关闭本窗体
			this.Close();
		}
		#endregion
	}
}
                
