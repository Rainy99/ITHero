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
		public GoodsWarehouse AllGoodsList = new GoodsWarehouse();     //物品库对象
		public Player Hero;         //英雄对象
		public Parcel Pack;         //背包对象
		public int TotalDays;       //总天数
		public int Days;            //离毕业剩余天数
		public int StudyCount;      //每天的学习次数
		public int StudyNumber;     //每天剩余的学习次数
		public int WorkCount;       //每天的打工次数
		public int WorkNumber;      //每天剩余的打工次数
		public int PlayCount;       //每天的游玩次数
		public int PlayNumber;      //每天剩余的游玩次数
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
			AllGoodsList.Init();
			//初始化包裹（默认每种物品一个）
			Pack.GoodsList = new System.Collections.ArrayList();
			Pack.GoodsList.Add(AllGoodsList.Bread);
			Pack.GoodsList.Add(AllGoodsList.Calcium);
			Pack.GoodsList.Add(AllGoodsList.Flower);
			Pack.GoodsList.Add(AllGoodsList.Lottery);
			Pack.GoodsList.Add(AllGoodsList.QQStar);
			Pack.GoodsList.Add(AllGoodsList.Badge);
			Pack.GoodsNumberList = new System.Collections.ArrayList();
			for(int i = 0; i < Pack.GoodsList.Count; i++)
			{
				Pack.GoodsNumberList.Add(1);
			}
		}
	}
}
