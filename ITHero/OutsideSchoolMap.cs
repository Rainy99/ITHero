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
	class OutsideSchoolMap
	{
		public OutsideSchoolMap()
		{
			this.BuildsList = new Hashtable();
		}
		public OutsideSchoolMap(int id,string name)
		{
			this.Id = id;
			this.Name = name;
			this.BuildsList = new Hashtable();
		}
		private int id;
		private string name;
		public Hashtable BuildsList;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		/// <summary>
		/// 初始化所有建筑物
		/// </summary>
		public void Init()
		{
			SoftwarePark softwarePark = new SoftwarePark(2000,"软件园","充满机遇和挑战，实现梦想的地方");
			HappyValley happyValley = new HappyValley(2001,"游乐园","小到8岁，大到80岁，都能在这里找到快乐");
			this.BuildsList.Add(softwarePark.Id,softwarePark);
			this.BuildsList.Add(happyValley.Id,happyValley);
		}
	}
}
