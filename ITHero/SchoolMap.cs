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
	class SchoolMap : BaseMap
	{
		public SchoolMap()
		{
			Init();
		}
		public SchoolMap(int id,string name) : base(id,name)
		{
			Init();
		}
		/// <summary>
		/// 初始化所有建筑物
		/// </summary>
		public void Init()
		{
			this.BuildsList.Clear();
			Classroom classroom = new Classroom(1000,"教学楼","好好学习，天天向上");
			Eatery eatery = new Eatery(1001,"食堂","人是铁，饭是钢，一顿不吃饿得慌");
			this.BuildsList.Add(classroom.Id,classroom);
			this.BuildsList.Add(eatery.Id,eatery);
		}
	}
}
