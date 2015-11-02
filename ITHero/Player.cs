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
        public string name;         //姓名
        public Gender gender;       //性别
        public int prestige;        //威望
        public int morality;        //道德
        public int charm;           //魅力
        public int power;           //力量
        public int luck;            //运气
        public int intellect;       //智力
        public int money;           //金钱
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
    }
}
