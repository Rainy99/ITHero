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
	class Eatery
	{
		public Eatery()
		{
			this.GoodsList = new ArrayList();
		}
		public Eatery(int id,string name,string introduction)
		{
			this.Id = id;
			this.Name = name;
			this.Introduction = introduction;
			this.GoodsList = new ArrayList();
		}
		private int id;
		private string name;
		private string introduction;
		public ArrayList GoodsList;
		public int Id
		{
			get{return id;}
			set{id = value;}
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Introduction
		{
			get { return introduction; }
			set { introduction = value; }
		}
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">横坐标</param>
		///<param name="y">纵坐标</param>
		public void ReturnMap(int x,int y)
		{
			SchoolForm sForm = new SchoolForm();
			sForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;	//设置窗体起始位置
			sForm.Location = new System.Drawing.Point(x,y);							//设置窗体出现的坐标
			sForm.Show();
		}
		///<summary>
		///初始化物品集合
		///</summary>
		public void Init()
		{
			GoodsWarehouse gw = GameManager.GameInfo.AllGoodsList;
			this.GoodsList.Add(gw.Bread);
			this.GoodsList.Add(gw.Calcium);
			this.GoodsList.Add(gw.Flower);
			this.GoodsList.Add(gw.Lottery);
			this.GoodsList.Add(gw.QQStar);
			this.GoodsList.Add(gw.Badge);
		}
		///<summary>
		///出售物品（玩家购买）
		///</summary>
		///<param name="goods">出售的商品</param>
		///<returns>出售是否成功</returns>
		public bool Sell(Goods goods)
		{
			//有此物品并且玩家的金钱足够
			if(GameManager.GameInfo.Hero.Money - goods.Money >=0)
			{
				for(int i = 0; i < GameManager.GameInfo.Pack.GoodsList.Count; i++)
				{
					//判断包裹中对应物品的位置
					if(((Goods)GameManager.GameInfo.Pack.GoodsList[i]).Name.Equals(goods.Name))
					{
						GameManager.GameInfo.Hero.Money -= goods.Money;		//减去物品金额
						GameManager.GameInfo.Pack.GoodsNumberList[i] = ((int)GameManager.GameInfo.Pack.GoodsNumberList[i]) +1;		//包裹物品数量加1
						return true;
					}
				}
			}
			return false;
		}
		///<summary>
		///回购物品（玩家出售）
		///</summary>
		///<param name="goods">回购的商品</param>
		///<returns>回购是否成功</returns>
		public bool Buy(Goods goods)
		{
			for(int i = 0; i < GameManager.GameInfo.Pack.GoodsList.Count; i++)
			{
				//判断包裹中对应物品的位置，数量大于0则可出售
				if(((Goods)GameManager.GameInfo.Pack.GoodsList[i]).Name.Equals(goods.Name) && ((int)GameManager.GameInfo.Pack.GoodsNumberList[i]) > 0)
				{
					GameManager.GameInfo.Hero.Money += goods.SaleMoney;		//增加物品出售金额
					GameManager.GameInfo.Pack.GoodsNumberList[i] = ((int)GameManager.GameInfo.Pack.GoodsNumberList[i]) - 1;		//包裹物品数量减1
					return true;
				}
			}
			return false;
		}
	}
}
