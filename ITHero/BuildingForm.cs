using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHero
{
    public partial class BuildingForm : Form
    {
        bool close = false;
        public BuildingForm()
        {
            InitializeComponent();
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            //判断显示对应建筑物
            int id = (int)this.Tag;
            switch (id)
            {
                case 1000:
                    pnlClassroom.Visible = true; break;     //教室
                case 1001:
                    pnlEatery.Visible = true; break;        //食堂
                case 2000:
                    pnlSoftwarePark.Visible = true; break;  //软件园
                case 2001:
                    pnlHappyValley.Visible = true; break;   //游乐园
            }
        }
        private void BuildingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //判断如果点击窗体右上角关闭按钮则返回主界面
            if (close != true)
            {
                Application.Exit();
            }
        }
        
        private void lbl_MouseDown(object sender, MouseEventArgs e)
        {
            ((Label)sender).BorderStyle = BorderStyle.Fixed3D;
        }
        private void lbl_MouseUp(object sender, MouseEventArgs e)
        {
            ((Label)sender).BorderStyle = BorderStyle.None;
        }
        #region 教学楼功能区
        /// <summary>
        /// 上课可以得到1～5个随机物品，并有极小机率直接提升随机属性
        /// </summary>
        private void lblStudy_Click(object sender, EventArgs e)
        {
            //判断学习次数，如果能学习则调用教学楼的随机运气方法，否则提示无法学习（请编码实现）

        }
        /// <summary>
        /// 考试
        /// </summary>
        private void lblExam_Click(object sender, EventArgs e)
        {
            //判断是否可以参考考试，所有属性都>=300可考试，否则提示未达到要求（请编码实现）
            
        }       
        /// <summary>
        /// 离开教学楼返回学校
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            //调用教学楼的返回地图方法（请编码实现）

            close = true;       //允许关闭本窗体
            this.Close();
        }
        #endregion
        #region 食堂功能区
        /// <summary>
        /// 点击打开超市面板
        /// </summary>
        private void lblSupermarket_Click(object sender, EventArgs e)
        {
            //1. 显示英雄金钱（请编码实现）
            //2. 显示超市物品信息（请编码实现）

            //3. 显示超市面板
            pnlSupermarket.Visible = true;
        }
        /// <summary>
        /// 离开食堂返回学校
        /// </summary>
        private void lblEateryExit_Click(object sender, EventArgs e)
        {
            //调用食堂返回地图方法（请编码实现）

            close = true;       //允许关闭本窗体
            this.Close();
        }
        /// <summary>
        /// 关闭超市面板
        /// </summary>
        private void lblParcelClose_Click(object sender, EventArgs e)
        {
            pnlSupermarket.Visible = false;
        }
        /// <summary>
        /// 买面包
        /// </summary>
        private void lblBreadBuy_Click(object sender, EventArgs e)
        {
            //调用本窗体的Buy方法（请编码实现）
        }
        /// <summary>
        /// 卖面包
        /// </summary>
        private void lblBreadSell_Click(object sender, EventArgs e)
        {
            //调用本窗体的Sell方法（请编码实现）
        }
        private void lblCalciumBuy_Click(object sender, EventArgs e)
        {
            //调用本窗体的Buy方法（请编码实现）
        }
        private void lblCalciumSell_Click(object sender, EventArgs e)
        {
            //调用本窗体的Sell方法（请编码实现）
        }
        private void lblFlowerBuy_Click(object sender, EventArgs e)
        {
            //调用本窗体的Buy方法（请编码实现）
        }
        private void lblFlowerSell_Click(object sender, EventArgs e)
        {
            //调用本窗体的Sell方法（请编码实现）
        }
        private void lblLotteryBuy_Click(object sender, EventArgs e)
        {
            //调用本窗体的Buy方法（请编码实现）

        }
        private void lblLotterySell_Click(object sender, EventArgs e)
        {
            //调用本窗体的Sell方法（请编码实现）
        }
        private void lblQQStarBuy_Click(object sender, EventArgs e)
        {
            //调用本窗体的Buy方法（请编码实现）

        }
        private void lblQQStarSell_Click(object sender, EventArgs e)
        {
            //调用本窗体的Sell方法（请编码实现）
        }
        private void lblBadgeBuy_Click(object sender, EventArgs e)
        {
            //调用本窗体的Buy方法（请编码实现）

        }
        private void lblBadgeSell_Click(object sender, EventArgs e)
        {
            //调用本窗体的Sell方法（请编码实现）
        }
		/// <summary>
		/// 回购物品（请编码实现）
		/// </summary>
		/// <param name="goods">物品对象</param>
		private void Buy()
		{ }
		/// <summary>
		/// 出售物品（请编码实现）
		/// </summary>
		/// <param name="goods">物品对象</param>
		private void Sell()
		{ }
        #endregion
        #region 软件园功能区
        /// <summary>
        /// 打工（请编码实现）
        /// </summary>
        private void lblWork_Click(object sender, EventArgs e)
        {
            //1.判断玩家智力是否大于150
            //2.如果大于150，再次判断是打工剩余次数
            //3.如果还有剩余次数则调用软件园的随机运气方法
            
        }
        /// <summary>
        /// 离开软件园返回校外地图
        /// </summary>
        private void lblSoftwareParkExit_Click(object sender, EventArgs e)
        {
            //调用软件园的返回地图方法（请编码实现）

            close = true;       //允许关闭本窗体
            this.Close();
        }
        #endregion
        #region 游乐园功能区
        /// <summary>
        /// 游玩（请编码实现）
        /// </summary>
        private void lblPlay_Click(object sender, EventArgs e)
        {
            //判断剩余游玩次数，如果大于0则调用游乐园的随机运气方法
            
        }
        /// <summary>
        /// 离开游乐园返回校外地图
        /// </summary>
        private void lblHappyValleyExit_Click(object sender, EventArgs e)
        {
            //调用游乐园的返回地图方法（请编码实现）

            close = true;       //允许关闭本窗体
            this.Close();
        }
        #endregion
    }
}
                
