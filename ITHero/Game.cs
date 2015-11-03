using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 保存当前游戏信息
	/// </summary>
	class Game
	{
		public GoodsWarehouse AllGoodsList;     //物品库对象
		public Player Hero;         //英雄对象
		public Parcel Pack;         //背包对象
		public int TotalDays;       //总天数
		public int Days;            //离毕业剩余天数
		public int StudyCount;      //每天的学习次数
		public int StudyNumber;     //每天剩余的学习次数
		public int WorkCount;       //每天的打工次数
		public int WorkNumber;      //每天剩余的打工次数
		public int PlayCount;       //每天的游玩次数
		public int PlayNumber;      //每天剩余额游玩次数
		/// <summary>
		/// 初始化游戏数据
		/// </summary>
		public void Init()
		{
			Hero = new Player();
			Pack = new Parcel();
			this.TotalDays = 60;
			this.Days = this.TotalDays;
			this.StudyCount = 3;
			this.StudyNumber = this.StudyCount;
			this.WorkCount = 3;
			this.WorkNumber = this.WorkCount;
			this.PlayNumber = this.PlayCount;
			//初始化物品库
			AllGoodsList = new GoodsWarehouse();
			AllGoodsList.Init();
			//初始化包裹（默认每种物品一个）
			Pack.goodsList = new Goods[6];
			Pack.goodsList[0] = AllGoodsList.Bread;
			Pack.goodsList[1] = AllGoodsList.Calcium;
			Pack.goodsList[2] = AllGoodsList.Flower;
			Pack.goodsList[3] = AllGoodsList.Lottery;
			Pack.goodsList[4] = AllGoodsList.QQStar;
			Pack.goodsList[5] = AllGoodsList.Badge;
			Pack.goodsNumberList = new int[6];
			for(int i = 0; i < Pack.goodsList.Length; i++) {
				Pack.goodsNumberList[i] = 1;
			}
		}
	}
}
