using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 游乐园
	/// </summary>
	class HappyValley
	{
		public HappyValley()
		{}
		public HappyValley(int id,string name,string introduction)
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
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">界面出现的横坐标</param>
		///<param name="y">界面出现的纵坐标</param>
		public void ReturnMap(int x, int y)
		{
			OutsideSchoolForm osForm = new OutsideSchoolForm();
			osForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			osForm.Location = new System.Drawing.Point(x, y);
			osForm.Show();
		}
		///<summary>
		///随机效果
		///</summary>
		///<returns>返回结果</returns>
		public string Luck()
		{
			StringBuilder strInfo = new StringBuilder();	//奖励字符串
			//1.随机获得的属性值
			//2.30%几率受伤，受伤扣除属性值
			//3.随机增加的属性项
			//4.返回结果信息
			return strInfo.ToString();
		}
	}
}
