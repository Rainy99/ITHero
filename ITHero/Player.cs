using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHero
{
	/// <summary>
	/// 玩家英雄类
	/// </summary>
	class Player
	{
		private string name;         //姓名
		private Gender gender;       //性别
		private int prestige;        //威望
		private int morality;        //道德
		private int charm;           //魅力
		private int power;           //力量
		private int luck;            //运气
		private int intellect;       //智力
		private int money;           //金钱

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public Gender Gender
		{
			get
			{
				return gender;
			}
			set
			{
				gender = value;
			}
		}
		public int Prestige
		{
			get
			{
				return prestige;
			}
			set
			{
				prestige = value;
			}
		}
		public int Morality
		{
			get
			{
				return morality;
			}
			set
			{
				morality = value;
			}
		}
		public int Charm
		{
			get
			{
				return charm;
			}
			set
			{
				charm = value;
			}
		}
		public int Power
		{
			get
			{
				return power;
			}
			set
			{
				power = value;
			}
		}
		public int Luck
		{
			get
			{
				return luck;
			}
			set
			{
				luck = value;
			}
		}
		public int Intellect
		{
			get
			{
				return intellect;
			}
			set
			{
				intellect = value;
			}
		}
		public int Money
		{
			get
			{
				return money;
			}
			set
			{
				money = value;
			}
		}
		/// <summary>
		/// 自动生成属性
		/// </summary>
		public void Create()
		{
			Random rand = new Random();
			this.prestige = rand.Next(0, 50);
			this.morality = rand.Next(0, 50);
			this.charm = rand.Next(0, 50);
			this.power = rand.Next(0, 50);
			this.luck = rand.Next(0, 50);
			this.intellect = rand.Next(0, 50);
			this.money = rand.Next(0, 50);
		}
		public Player()
		{
		}
		public Player(string name, Gender gender)
		{
			this.Name = name;
			this.Gender = gender;
		}
		/// <summary>
		/// 回答问题后对属性有加成
		/// </summary>
		public void Create(int prestige, int morality, int charm, int power, int luck, int intellect, int money)
		{
			this.Create();
			this.Prestige += prestige;
			this.Morality += morality;
			this.Charm += charm;
			this.Power += power;
			this.Luck += luck;
			this.Intellect += intellect;
			this.Money += money;
		}
	}
}
