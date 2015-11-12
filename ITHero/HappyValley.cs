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
	class HappyValley : Building
	{
		public HappyValley()
		{ }
		public HappyValley(int id, string name, string introduction)
			: base(id, name, introduction)
		{ }
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">界面出现的横坐标</param>
		///<param name="y">界面出现的纵坐标</param>
		public override void ReturnMap(int x, int y)
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
			Random rand = new Random();
			//1.随机获得的属性值
			int value = rand.Next(1,11);
			//2.30%几率受伤，受伤扣除属性值
			int randnum = rand.Next(1000);
			if(randnum / 10 % 3 == 0)		//随机数个位是3的位数时表示受伤
			{
				strInfo.Append("玩危险游戏时意外受伤，扣除" + value + "点");
				value = -value;
			}
			else
			{
				strInfo.Append("玩游戏得到了锻炼，增加" + value + "点");
			}
			//3.随机增加的属性项
			int tmp = rand.Next(1000) % 6;
			switch(tmp)
			{
					case 0:
						GameManager.GameInfo.Hero.Power += value;		//提升力量
						strInfo.Append("力量。");
					break;
					case 1:
						GameManager.GameInfo.Hero.Charm += value;		//提升魅力
						strInfo.Append("魅力。");
						break;
					case 2:
						GameManager.GameInfo.Hero.Morality += value;		//提升道德
						strInfo.Append("道德。");
						break;
					case 3:
						GameManager.GameInfo.Hero.Luck += value;		//提升运气
						strInfo.Append("运气。");
						break;
					case 4:
						GameManager.GameInfo.Hero.Intellect += value;		//提升智力
						strInfo.Append("智力。");
						break;
					case 5:
						GameManager.GameInfo.Hero.Prestige += value;		//提升威望
						strInfo.Append("威望。");
						break;
			}
			//4.返回结果信息
			return strInfo.ToString();
		}
	}
}
