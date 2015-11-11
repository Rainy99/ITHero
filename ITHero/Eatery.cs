using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 食堂类
	/// </summary>
	class Eatery:Building
	{
		public Eatery()
		{
			this.GoodsList = new Dictionary<string, Goods>();
		}
		public Eatery(int id, string name, string introduction):base(id,name,introduction)
		{
			this.GoodsList = new Dictionary<string,Goods>();
		}
		public Dictionary<string, Goods> GoodsList;
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">横坐标</param>
		///<param name="y">纵坐标</param>
		public override void ReturnMap(int x, int y)
		{
			SchoolForm sForm = new SchoolForm();
			sForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;	//设置窗体起始位置
			sForm.Location = new System.Drawing.Point(x, y);							//设置窗体出现的坐标
			sForm.Show();
		}
		///<summary>
		///初始化物品集合
		///</summary>
		public void Init()
		{
			GoodsWarehouse gw = GameManager.GameInfo.AllGoodsList;
			this.GoodsList.Add(gw.Bread.Name, gw.Bread);
			this.GoodsList.Add(gw.Calcium.Name, gw.Calcium);
			this.GoodsList.Add(gw.Flower.Name, gw.Flower);
			this.GoodsList.Add(gw.Lottery.Name, gw.Lottery);
			this.GoodsList.Add(gw.QQStar.Name, gw.QQStar);
			this.GoodsList.Add(gw.Badge.Name, gw.Badge);
		}
		///<summary>
		///回购物品（玩家买入）
		///</summary>
		///<param name="goods">回购的商品</param>
		///<returns>回购是否成功</returns>
		public bool Buy(Goods goods)
		{
			//有此物品并且玩家的金钱足够
			if(GameManager.GameInfo.Pack.GoodsList.ContainsKey(goods) && GameManager.GameInfo.Hero.Money - goods.Money >= 0)
			{
				//判断包裹中对应物品的位置
				GameManager.GameInfo.Hero.Money -= goods.Money;		//减去物品金额
				GameManager.GameInfo.Pack.GoodsList[goods]++;		//包裹物品数量加1
				return true;
			}
			return false;
		}
		///<summary>
		///出售物品（玩家出售）
		///</summary>
		///<param name="goods">出售的商品</param>
		///<returns>出售的商品</returns>
		public bool Sell(Goods goods)
		{
			//判断包裹中对应物品的位置，数量大于0则可出售
			if(GameManager.GameInfo.Pack.GoodsList.ContainsKey(goods) && GameManager.GameInfo.Pack.GoodsList[goods] > 0)
			{
				GameManager.GameInfo.Hero.Money += goods.SaleMoney;		//增加物品出售金额
				GameManager.GameInfo.Pack.GoodsList[goods]--;		//包裹物品数量减1
				return true;
			}
			return false;
		}



	}
}
