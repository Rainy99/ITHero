using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ITHero
{	
	/// <summary>
	/// 地图类父类
	/// </summary>
	[Serializable]
	abstract class BaseMap
	{
		public Dictionary<int, Building> BuildsList;
		public BaseMap()
		{
			this.BuildsList = new Dictionary<int,Building>();
			Init();
		}
		public BaseMap(int id,string name):this()
		{
			this.Id = id;
			this.Name = name;
		}
		private int id;
		private string name;
		
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
		protected abstract void Init();
	}
}
