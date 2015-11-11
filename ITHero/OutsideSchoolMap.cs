using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 校外地图类
	/// </summary>
	class OutsideSchoolMap : BaseMap
	{
		public OutsideSchoolMap()
		{
			
		}
		public OutsideSchoolMap(int id,string name):base(id,name)
		{
			
		}
		///<summary>
		/// 初始化所有建筑物
		/// </summary>
		protected override void Init()
		{
			this.BuildsList.Clear();
			SoftwarePark sp = new SoftwarePark(2000,"软件园","充满机遇和挑战，实现梦想的地方");
			HappyValley hv = new HappyValley(2001,"游乐园","小到8岁，大到80岁，都能在这里找到快乐");
			this.BuildsList.Add(sp.Id,sp);
			this.BuildsList.Add(hv.Id,hv);
		}
	}
}
