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
	[Serializable]
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
		public override void ReturnMap(int x,int y)
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
			Random rand = new Random();
			//1.随机奖励500~2000金钱
			int tmpMoney = rand.Next(500,2001);
			//2.10%几率完成优秀获得双倍金钱
			int randnum =rand.Next(1000);
			if(randnum / 10 == 6)		//随机数个位数是6时获得双倍金钱
			{
				tmpMoney = tmpMoney * 2;
				strInfo.Append("项目如期完成，恭喜你获得" + tmpMoney / 2+"张毛爷爷。");
				strInfo.Append("\n因表现优异，老板额外奖励" + tmpMoney / 2+"张毛爷爷。");
			}
			//3.30%几率失败，失败扣除奖金的一半
			else if(randnum / 10 % 3 == 0)	//随机数个位数是3、6、9时打工失败
			{
				tmpMoney = (-tmpMoney) / 2;
				strInfo.Append("很抱歉，因你的项目失败，扣除" + tmpMoney+"张毛爷爷。");
			}
			else
			{
				strInfo.Append("项目如期完成，恭喜你获得" + tmpMoney + "张毛爷爷。");
			}
			//4.更新玩家金钱
			GameManager.GameInfo.Hero.Money += tmpMoney;
			//5.打工次数减1
			GameManager.GameInfo.WorkNumber--;
			//6.返回结果信息
			return strInfo.ToString();
		}
	}
}
