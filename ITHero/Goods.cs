using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero {
	/// <summary>
	/// 物品类
	/// </summary>
	class Goods {
		public string name;			//物品名称
		public GoodsType type;		//物品类型
		public int money;			//物品价格
		public int saleMoney;		//出售价格
		public string details;		//物品说明
		/// <summary>
		/// 使用物品，返回使用结果字符串
		/// </summary>
		/// <param name="hero">使用者</param>
		public string Use(Player hero) {
			string str = "";	//提示信息
			//根据不同物品，增加使用者不同的属性值
			Random rand = new Random();
			int num = rand.Next(1, 10);		//使用物品时增加的属性值
			switch(this.type) {
				case GoodsType.Prestige:
					hero.prestige += num;
					str = "恭喜你增加了" + num + "点威望值，当前威望为" + hero.prestige + "!";
					break;
				case GoodsType.Morality:
					hero.morality += num;
					str = "恭喜你增加了" + num + "点道德值，当前道德为" + hero.morality + "!";
					break;
				case GoodsType.Charm:
					hero.charm += num;
					str = "恭喜你增加了" + num + "点魅力值，当前魅力为" + hero.charm + "!";
					break;
				case GoodsType.Power:
					hero.power += num;
					str = "恭喜你增加了" + num + "点力量值，当前力量为" + hero.power + "!";
					break;
				case GoodsType.Luck:
					hero.luck += num;
					str = "恭喜你增加了" + num + "点运气值，当前运气为" + hero.luck + "!";
					break;
				case GoodsType.Intellect:
					hero.intellect += num;
					str = "恭喜你增加了" + num + "点智力值，当前智力为" + hero.intellect + "!";
					break;
			}
			return str;
		}
	}
}
