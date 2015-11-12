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
	class Classroom : Building, ILuck
	{
		public Classroom()
		{ }
		public Classroom(int id, string name, string introduction)
			: base(id, name, introduction)
		{ }
		///<summary>
		///返回地图
		///</summary>
		///<param name="x">横坐标</param>
		///<param name="y">纵坐标</param>
		public override void ReturnMap(int x, int y)
		{
			SchoolForm sForm = new SchoolForm();
			sForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;	//设置窗体第一次出现的位置
			sForm.Location = new System.Drawing.Point(x, y);							//设置窗体出现的坐标
			sForm.Show();
		}
		///<summary>
		///随机运气效果
		///</summary>
		///<returns>返回结果</returns>
		public string Luck()
		{
			StringBuilder strInfo = new StringBuilder();	//奖励字符串
			Goods goods = new Goods();
			Random rand = new Random();
			//1.生成随机奖励物品
			int tmp = rand.Next(1000) % 6;
			switch(tmp)
			{
				case 0:
					goods = GameManager.GameInfo.AllGoodsList.Bread;
					break;
				case 1:
					goods = GameManager.GameInfo.AllGoodsList.Calcium;
					break;
				case 2:
					goods = GameManager.GameInfo.AllGoodsList.Flower;
					break;
				case 3:
					goods = GameManager.GameInfo.AllGoodsList.Lottery;
					break;
				case 4:
					goods = GameManager.GameInfo.AllGoodsList.QQStar;
					break;
				case 5:
					goods = GameManager.GameInfo.AllGoodsList.Badge;
					break;
			}
			//2.生成随机奖励物品数量（1~5之间）
			int number = rand.Next(1000) % 5 +1;
			strInfo.Append("恭喜你获得"+ number + "个"+goods.Name+"。");
			//3.奖励物品添加到包裹
			GameManager.GameInfo.Pack.GoodsList[goods] += number;
			//4.10%几率另外提升随机属性
			int randnum = rand.Next(1000);
			if(randnum<=100)
			{
				int value = rand.Next(10)+1;
				switch(tmp)
				{	
					case 0:
						GameManager.GameInfo.Hero.Power += value;		//提升力量
						strInfo.Append("\n小宇宙爆发额外获得了"+value+"点力量。");
						break;
					case 1:
						GameManager.GameInfo.Hero.Charm += value;		//提升魅力
						strInfo.Append("\n小宇宙爆发额外获得了" + value + "点魅力。");
						break;
					case 2:
						GameManager.GameInfo.Hero.Morality += value;		//提升道德
						strInfo.Append("\n小宇宙爆发额外获得了" + value + "点道德。");
						break;
					case 3:
						GameManager.GameInfo.Hero.Luck += value;		//提升运气
						strInfo.Append("\n小宇宙爆发额外获得了" + value + "点运气。");
						break;
					case 4:
						GameManager.GameInfo.Hero.Intellect += value;		//提升智力
						strInfo.Append("\n小宇宙爆发额外获得了" + value + "点智力。");
						break;
					case 5:
						GameManager.GameInfo.Hero.Prestige += value;		//提升威望
						strInfo.Append("\n小宇宙爆发额外获得了" + value + "点威望。");
						break;
						
				}
			}
			//5.返回结果信息
			return strInfo.ToString();
		}
	}
}
