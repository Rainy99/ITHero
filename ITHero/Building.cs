using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{	
	/// <summary>
	/// 建筑类父类
	/// </summary>
	class Building
	{
		public Building()
		{}
		public Building(int id,string name,string introduction)
		{
			this.Id = id;
			this.Name = name;
			this.Introduction = introduction;
		}
		private int id;					//编号
		private string name;			//名称
		private string introduction;	//简介
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
		public string Introduction
		{
			get { return introduction; }
			set { introduction = value; }
		}
	}
}
