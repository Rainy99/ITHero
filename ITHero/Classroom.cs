using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{	
	/// <summary>
	/// 教学楼类
	/// </summary>
	class Classroom:Building
	{
		public Classroom()
		{}
		public Classroom(int id, string name, string introduction): base(id, name, introduction)
		{}
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">横坐标</param>
		///<param name="y">纵坐标</param>
		public override void ReturnMap(int x,int y)
		{
			SchoolForm sForm = new SchoolForm();
			sForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;	//设置窗体第一次出现的位置
			sForm.Location = new System.Drawing.Point(x,y);							//设置窗体出现的坐标
			sForm.Show();
		}
		///<summary>
		///随机运气效果
		///</summary>
		///<returns>返回结果</returns>
		public string Luck()
		{
			StringBuilder strInfo = new StringBuilder();	//奖励字符串
			//1.生成随机奖励物品
			//2.生成随机奖励物品数量（1~5之间）
			//3.奖励物品添加到包裹
			//4.10%几率另外提升随机属性
			//5.返回结果信息
			return strInfo.ToString();
		}
	}
}
