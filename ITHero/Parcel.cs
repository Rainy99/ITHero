using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 包裹类
	/// </summary>
	class Parcel
	{
		public Dictionary<Goods,int>  GoodsList;       //物品数组,物品存为key,数量存为value
		public List<int> GoodsNumberList;   //物品数量数组
	}
}
