using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 学校地图类
	/// </summary>
	class SchoolMap
	{
		public SchoolMap()
		{
			this.BuildsList = new Hashtable();
		}
		public SchoolMap(int id,string name)
		{	
			this.Id = id;
			this.Name = name;
			this.BuildsList = new Hashtable();
		}
		private int id;
		private string name;
		public Hashtable BuildsList;	//建筑物集合
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
			Classroom classroom = new Classroom(1000,"教学楼","好好学习，天天向上");
			Eatery eatery = new Eatery(1001,"食堂","人是铁，饭是钢，一顿不吃饿得慌");
			this.BuildsList.Add(classroom.Id,classroom);
			this.BuildsList.Add(eatery.Id,eatery);
		}
	}
}
