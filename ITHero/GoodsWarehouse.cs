using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 物品库类
	/// </summary>
	[Serializable]
	class GoodsWarehouse
	{
		public Goods Bread;		//面包
		public Goods Calcium;	//钙片
		public Goods Flower;	//小红花
		public Goods Lottery;	//彩票
		public Goods QQStar;	//QQ星
		public Goods Badge;		//徽章
		/// <summary>
		/// 初始化所有物品
		/// </summary>
		public void Init()
		{
			//面包
			Bread = new Goods();
			Bread.Name = "面包";
			Bread.Type = GoodsType.Power;
			Bread.Money = 680;
			Bread.SaleMoney = Bread.Money / 10;
			Bread.Details = "知道金刚吗，它就是经常吃这个，才能在大厦顶打飞机的！（增加力量）";
			//钙片
			Calcium = new Goods();
			Calcium.Name = "钙片";
			Calcium.Type = GoodsType.Charm;
			Calcium.Money = 1080;
			Calcium.SaleMoney = Calcium.Money / 10;
			Calcium.Details = "吃一片，腰不酸、腿不疼，小脸蛋也更迷人啦！（增加魅力）";
			//小红花
			Flower = new Goods();
			Flower.Name = "小红花";
			Flower.Type = GoodsType.Morality;
			Flower.Money = 1280;
			Flower.SaleMoney = Flower.Money / 10;
			Flower.Details = "戴朵小红花，人见人夸！（增加道德）";
			//彩票
			Lottery = new Goods();
			Lottery.Name = "彩票";
			Lottery.Type = GoodsType.Luck;
			Lottery.Money = 1680;
			Lottery.SaleMoney = Lottery.Money / 10;
			Lottery.Details = "想有车有房有肉汤就靠它了！（增加运气）";
			//QQ星
			QQStar = new Goods();
			QQStar.Name = "QQ星";
			QQStar.Type = GoodsType.Intellect;
			QQStar.Money = 1880;
			QQStar.SaleMoney = QQStar.Money / 10;
			QQStar.Details = "自从喝了它，妈妈再也不担心我的学习了！（增加智力）";
			//徽章
			Badge = new Goods();
			Badge.Name = "徽章";
			Badge.Type = GoodsType.Prestige;
			Badge.SaleMoney = Badge.Money / 10;
			Badge.Details = "荣耀的象征，成功人士的标记！（增加威望）";

		}
	}
}
