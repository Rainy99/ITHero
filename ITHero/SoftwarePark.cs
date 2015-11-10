using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 软件园类
	/// </summary>
	class SoftwarePark:Building
	{
		public SoftwarePark()
		{}
		public SoftwarePark(int id,string name,string introduction):base(id,name,introduction)
		{}
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">界面出现的横坐标</param>
		///<param name="y">界面出现的纵坐标</param>
		public void ReturnMap(int x,int y)
		{
			OutsideSchoolForm osForm = new OutsideSchoolForm();
			osForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			osForm.Location = new System.Drawing.Point(x,y);
			osForm.Show();
		}
		///<summary>
		///随机运气效果
		///</summary>
		///<returns>返回结果</returns>
		public string Luck()
		{
			StringBuilder strInfo = new StringBuilder();	//奖励字符串
			//1.随机奖励500~2000金钱
			//2.10%几率完成优秀获得双倍金钱
			//3.30%几率失败，失败扣除奖金的一半
			//4.更新玩家金钱
			//5.返回结果信息
			return strInfo.ToString();
		}
	}
}
