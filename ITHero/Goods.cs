using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 物品类
	/// </summary>
	class Goods
	{
		private string name;		//物品名称
		private GoodsType type;		//物品类型
		private int money;			//物品价格
		private int saleMoney;		//出售价格
		private string details;		//物品说明

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public GoodsType Type
		{
			get
			{
				return type;
			}
			set
			{
				type = value;
			}
		}
		public int Money
		{
			get
			{
				return money;
			}
			set
			{
				money = (value >= 0 ? value : 0);
			}
		}
		public int SaleMoney
		{
			get
			{
				return saleMoney;
			}
			set
			{
				saleMoney = (value >= 0 ? value : 0);
			}
		}
		public string Details
		{
			get
			{
				return details;
			}
			set
			{
				details = value;
			}
		}
		public Goods()
		{
		}
		public Goods(string name, GoodsType type, int money, int saleMoney, string details)
		{
			this.Name = name;
			this.Type = type;
			this.Money = money;
			this.SaleMoney = saleMoney;
			this.Details = details;
		}
		/// <summary>
		/// 使用物品，返回使用结果字符串
		/// </summary>
		/// <param name="hero">使用者</param>
		public string Use(Player hero)
		{
			return this.Use(hero, 1);
		}
		/// <summary>
		/// 使用物品，返回使用结果字符串
		/// </summary>
		/// <param name="hero">使用者</param>
		/// <param name="goodsNumber">使用数量</param>
		public string Use(Player hero, int goodsNumber)
		{
			string str = "";	//提示信息
			//根据不同物品，增加使用者不同的属性值
			Random rand = new Random();
			int num = rand.Next(1, 10);		//使用物品时增加的属性值
			num = num * goodsNumber;		//乘以使用数量
			switch(this.type) {
				case GoodsType.Prestige:
					hero.Prestige += num;
					str = "恭喜你增加了" + num + "点威望值，当前威望为" + hero.Prestige + "!";
					break;
				case GoodsType.Morality:
					hero.Morality += num;
					str = "恭喜你增加了" + num + "点道德值，当前道德为" + hero.Morality + "!";
					break;
				case GoodsType.Charm:
					hero.Charm += num;
					str = "恭喜你增加了" + num + "点魅力值，当前魅力为" + hero.Charm + "!";
					break;
				case GoodsType.Power:
					hero.Power += num;
					str = "恭喜你增加了" + num + "点力量值，当前力量为" + hero.Power + "!";
					break;
				case GoodsType.Luck:
					hero.Luck += num;
					str = "恭喜你增加了" + num + "点运气值，当前运气为" + hero.Luck + "!";
					break;
				case GoodsType.Intellect:
					hero.Intellect += num;
					str = "恭喜你增加了" + num + "点智力值，当前智力为" + hero.Intellect + "!";
					break;
			}
			return str;
		}
	}
}
