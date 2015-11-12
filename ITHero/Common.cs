using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{	
	/// <summary>
	/// 运气接口
	/// </summary>
	interface ILuck
	{
		string Luck();
	}
	///	<summary>
	///	性别类型
	///	</summary>
	enum Gender
	{
		Male,	//男
		Female	//女
	}

	///	<summary>
	///	物品类型
	///	</summary>
	enum GoodsType
	{
		Prestige,	//加威望
		Morality,	//加道德
		Charm,		//加魅力
		Power,		//加力量
		Luck,		//加运气
		Intellect	//加智力
	}
}
