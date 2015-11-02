using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero {
	/// <summary>
	/// 物品库类
	/// </summary>
	class GoodsWarehouse {
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
			Bread.name = "面包";
			Bread.type = GoodsType.Power;
			Bread.money = 680;
			Bread.saleMoney = Bread.money / 10;
			Bread.details = "知道金刚吗，它就是经常吃这个，才能在大厦顶打飞机的！（增加力量）";
			//钙片
			Calcium = new Goods();
			Calcium.name = "钙片";
			Calcium.type = GoodsType.Charm;
			Calcium.money = 1080;
			Calcium.saleMoney = Calcium.money / 10;
			Calcium.details  = "吃一片，腰不酸、腿不疼，小脸蛋也更迷人啦！（增加魅力）";
			//小红花
			Flower = new Goods();
			Flower.name = "小红花";
			Flower.type = GoodsType.Morality;
			Flower.money = 1280;
			Flower.saleMoney = Flower.money / 10;
			Flower.details = "戴朵小红花，人见人夸！（增加道德）";
            //彩票
            Lottery = new Goods();
            Lottery.name = "彩票";
            Lottery.type = GoodsType.Luck;
            Lottery.money = 1680;
            Lottery.saleMoney = Lottery.money / 10;
            Lottery.details = "想有车有房有肉汤就靠它了！（增加运气）";
            //QQ星
            QQStar = new Goods();
            QQStar.name = "QQ星";
            QQStar.type = GoodsType.Intellect;
            QQStar.money = 1880;
            QQStar.saleMoney = QQStar.money / 10;
            QQStar.details = "自从喝了它，妈妈再也不担心我的学习了！（增加智力）";
            //徽章
            Badge = new Goods();
            Badge.name = "徽章";
            Badge.type = GoodsType.Prestige;
            Badge.saleMoney  = Badge.money / 10;
            Badge.details = "荣耀的象征，成功人士的标记！（增加威望）";

		}
	}
}
