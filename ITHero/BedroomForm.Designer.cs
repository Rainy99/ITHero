namespace ITHero
{
    partial class BedroomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedroomForm));
			this.imgListGander = new System.Windows.Forms.ImageList(this.components);
			this.pnlBedroomInfo = new System.Windows.Forms.Panel();
			this.lblGameOver = new System.Windows.Forms.Label();
			this.lblLoad = new System.Windows.Forms.Label();
			this.lblSave = new System.Windows.Forms.Label();
			this.lblDays = new System.Windows.Forms.Label();
			this.lblOut = new System.Windows.Forms.Label();
			this.lblParcel = new System.Windows.Forms.Label();
			this.lblSleep = new System.Windows.Forms.Label();
			this.lblHeroInfo = new System.Windows.Forms.Label();
			this.pnlParcel = new System.Windows.Forms.Panel();
			this.lblParcelClose = new System.Windows.Forms.Label();
			this.lblLotteryNum = new System.Windows.Forms.Label();
			this.lblFlowerNum = new System.Windows.Forms.Label();
			this.lblBadgeNum = new System.Windows.Forms.Label();
			this.lblCalciumNum = new System.Windows.Forms.Label();
			this.lblQQNum = new System.Windows.Forms.Label();
			this.lblBreadNum = new System.Windows.Forms.Label();
			this.lblBadge = new System.Windows.Forms.Label();
			this.lblLottery = new System.Windows.Forms.Label();
			this.lblQQStar = new System.Windows.Forms.Label();
			this.lblCalcium = new System.Windows.Forms.Label();
			this.lblFlower = new System.Windows.Forms.Label();
			this.lblBread = new System.Windows.Forms.Label();
			this.pnlHeroInfo = new System.Windows.Forms.Panel();
			this.picGander = new System.Windows.Forms.PictureBox();
			this.lblHeroInfoClose = new System.Windows.Forms.Label();
			this.lblGander = new System.Windows.Forms.Label();
			this.lblMoney = new System.Windows.Forms.Label();
			this.lblMorality = new System.Windows.Forms.Label();
			this.lblIntellect = new System.Windows.Forms.Label();
			this.lblPrestige = new System.Windows.Forms.Label();
			this.lblPower = new System.Windows.Forms.Label();
			this.lblLuck = new System.Windows.Forms.Label();
			this.lblCharm = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.ofDlg = new System.Windows.Forms.OpenFileDialog();
			this.pnlBedroomInfo.SuspendLayout();
			this.pnlParcel.SuspendLayout();
			this.pnlHeroInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picGander)).BeginInit();
			this.SuspendLayout();
			// 
			// imgListGander
			// 
			this.imgListGander.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListGander.ImageStream")));
			this.imgListGander.TransparentColor = System.Drawing.Color.Transparent;
			this.imgListGander.Images.SetKeyName(0, "man.png");
			this.imgListGander.Images.SetKeyName(1, "woman.png");
			// 
			// pnlBedroomInfo
			// 
			this.pnlBedroomInfo.BackgroundImage = global::ITHero.Properties.Resources.卧室;
			this.pnlBedroomInfo.Controls.Add(this.lblGameOver);
			this.pnlBedroomInfo.Controls.Add(this.lblLoad);
			this.pnlBedroomInfo.Controls.Add(this.lblSave);
			this.pnlBedroomInfo.Controls.Add(this.lblDays);
			this.pnlBedroomInfo.Controls.Add(this.lblOut);
			this.pnlBedroomInfo.Controls.Add(this.lblParcel);
			this.pnlBedroomInfo.Controls.Add(this.lblSleep);
			this.pnlBedroomInfo.Controls.Add(this.lblHeroInfo);
			this.pnlBedroomInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlBedroomInfo.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBedroomInfo.Name = "pnlBedroomInfo";
			this.pnlBedroomInfo.Size = new System.Drawing.Size(944, 502);
			this.pnlBedroomInfo.TabIndex = 1;
			// 
			// lblGameOver
			// 
			this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
			this.lblGameOver.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblGameOver.Location = new System.Drawing.Point(766, 404);
			this.lblGameOver.Name = "lblGameOver";
			this.lblGameOver.Size = new System.Drawing.Size(60, 60);
			this.lblGameOver.TabIndex = 3;
			this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
			// 
			// lblLoad
			// 
			this.lblLoad.BackColor = System.Drawing.Color.Transparent;
			this.lblLoad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLoad.Location = new System.Drawing.Point(672, 404);
			this.lblLoad.Name = "lblLoad";
			this.lblLoad.Size = new System.Drawing.Size(60, 60);
			this.lblLoad.TabIndex = 3;
			this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLoad.Click += new System.EventHandler(this.lblLoad_Click);
			// 
			// lblSave
			// 
			this.lblSave.BackColor = System.Drawing.Color.Transparent;
			this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSave.Location = new System.Drawing.Point(600, 404);
			this.lblSave.Name = "lblSave";
			this.lblSave.Size = new System.Drawing.Size(60, 60);
			this.lblSave.TabIndex = 3;
			this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
			// 
			// lblDays
			// 
			this.lblDays.BackColor = System.Drawing.Color.Transparent;
			this.lblDays.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblDays.Location = new System.Drawing.Point(482, 404);
			this.lblDays.Name = "lblDays";
			this.lblDays.Size = new System.Drawing.Size(60, 60);
			this.lblDays.TabIndex = 3;
			this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDays.Click += new System.EventHandler(this.lblDays_Click);
			// 
			// lblOut
			// 
			this.lblOut.BackColor = System.Drawing.Color.Transparent;
			this.lblOut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblOut.Location = new System.Drawing.Point(368, 404);
			this.lblOut.Name = "lblOut";
			this.lblOut.Size = new System.Drawing.Size(60, 60);
			this.lblOut.TabIndex = 3;
			this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblOut.Click += new System.EventHandler(this.lblOut_Click);
			// 
			// lblParcel
			// 
			this.lblParcel.BackColor = System.Drawing.Color.Transparent;
			this.lblParcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblParcel.Location = new System.Drawing.Point(222, 404);
			this.lblParcel.Name = "lblParcel";
			this.lblParcel.Size = new System.Drawing.Size(60, 60);
			this.lblParcel.TabIndex = 3;
			this.lblParcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblParcel.Click += new System.EventHandler(this.lblParcel_Click);
			// 
			// lblSleep
			// 
			this.lblSleep.BackColor = System.Drawing.Color.Transparent;
			this.lblSleep.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSleep.Location = new System.Drawing.Point(295, 404);
			this.lblSleep.Name = "lblSleep";
			this.lblSleep.Size = new System.Drawing.Size(60, 60);
			this.lblSleep.TabIndex = 3;
			this.lblSleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSleep.Click += new System.EventHandler(this.lblSleep_Click);
			// 
			// lblHeroInfo
			// 
			this.lblHeroInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblHeroInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblHeroInfo.Location = new System.Drawing.Point(120, 404);
			this.lblHeroInfo.Name = "lblHeroInfo";
			this.lblHeroInfo.Size = new System.Drawing.Size(60, 60);
			this.lblHeroInfo.TabIndex = 3;
			this.lblHeroInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblHeroInfo.Click += new System.EventHandler(this.lblHeroInfo_Click);
			// 
			// pnlParcel
			// 
			this.pnlParcel.BackgroundImage = global::ITHero.Properties.Resources.包裹;
			this.pnlParcel.Controls.Add(this.lblParcelClose);
			this.pnlParcel.Controls.Add(this.lblLotteryNum);
			this.pnlParcel.Controls.Add(this.lblFlowerNum);
			this.pnlParcel.Controls.Add(this.lblBadgeNum);
			this.pnlParcel.Controls.Add(this.lblCalciumNum);
			this.pnlParcel.Controls.Add(this.lblQQNum);
			this.pnlParcel.Controls.Add(this.lblBreadNum);
			this.pnlParcel.Controls.Add(this.lblBadge);
			this.pnlParcel.Controls.Add(this.lblLottery);
			this.pnlParcel.Controls.Add(this.lblQQStar);
			this.pnlParcel.Controls.Add(this.lblCalcium);
			this.pnlParcel.Controls.Add(this.lblFlower);
			this.pnlParcel.Controls.Add(this.lblBread);
			this.pnlParcel.Location = new System.Drawing.Point(0, 0);
			this.pnlParcel.Name = "pnlParcel";
			this.pnlParcel.Size = new System.Drawing.Size(944, 502);
			this.pnlParcel.TabIndex = 2;
			this.pnlParcel.Visible = false;
			// 
			// lblParcelClose
			// 
			this.lblParcelClose.AutoSize = true;
			this.lblParcelClose.BackColor = System.Drawing.Color.Transparent;
			this.lblParcelClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblParcelClose.Font = new System.Drawing.Font("华文隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblParcelClose.ForeColor = System.Drawing.Color.DarkRed;
			this.lblParcelClose.Location = new System.Drawing.Point(804, 86);
			this.lblParcelClose.Name = "lblParcelClose";
			this.lblParcelClose.Size = new System.Drawing.Size(71, 30);
			this.lblParcelClose.TabIndex = 5;
			this.lblParcelClose.Text = "关闭";
			this.lblParcelClose.Click += new System.EventHandler(this.lblParcelClose_Click);
			// 
			// lblLotteryNum
			// 
			this.lblLotteryNum.BackColor = System.Drawing.Color.Transparent;
			this.lblLotteryNum.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLotteryNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
			this.lblLotteryNum.Location = new System.Drawing.Point(622, 322);
			this.lblLotteryNum.Margin = new System.Windows.Forms.Padding(0);
			this.lblLotteryNum.Name = "lblLotteryNum";
			this.lblLotteryNum.Size = new System.Drawing.Size(80, 19);
			this.lblLotteryNum.TabIndex = 4;
			this.lblLotteryNum.Text = "x 0";
			this.lblLotteryNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFlowerNum
			// 
			this.lblFlowerNum.BackColor = System.Drawing.Color.Transparent;
			this.lblFlowerNum.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFlowerNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
			this.lblFlowerNum.Location = new System.Drawing.Point(256, 322);
			this.lblFlowerNum.Margin = new System.Windows.Forms.Padding(0);
			this.lblFlowerNum.Name = "lblFlowerNum";
			this.lblFlowerNum.Size = new System.Drawing.Size(80, 19);
			this.lblFlowerNum.TabIndex = 4;
			this.lblFlowerNum.Text = "x 0";
			this.lblFlowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBadgeNum
			// 
			this.lblBadgeNum.BackColor = System.Drawing.Color.Transparent;
			this.lblBadgeNum.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBadgeNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
			this.lblBadgeNum.Location = new System.Drawing.Point(622, 430);
			this.lblBadgeNum.Margin = new System.Windows.Forms.Padding(0);
			this.lblBadgeNum.Name = "lblBadgeNum";
			this.lblBadgeNum.Size = new System.Drawing.Size(80, 19);
			this.lblBadgeNum.TabIndex = 4;
			this.lblBadgeNum.Text = "x 0";
			this.lblBadgeNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCalciumNum
			// 
			this.lblCalciumNum.BackColor = System.Drawing.Color.Transparent;
			this.lblCalciumNum.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCalciumNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
			this.lblCalciumNum.Location = new System.Drawing.Point(622, 214);
			this.lblCalciumNum.Margin = new System.Windows.Forms.Padding(0);
			this.lblCalciumNum.Name = "lblCalciumNum";
			this.lblCalciumNum.Size = new System.Drawing.Size(80, 19);
			this.lblCalciumNum.TabIndex = 4;
			this.lblCalciumNum.Text = "x 0";
			this.lblCalciumNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblQQNum
			// 
			this.lblQQNum.BackColor = System.Drawing.Color.Transparent;
			this.lblQQNum.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQQNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
			this.lblQQNum.Location = new System.Drawing.Point(256, 430);
			this.lblQQNum.Margin = new System.Windows.Forms.Padding(0);
			this.lblQQNum.Name = "lblQQNum";
			this.lblQQNum.Size = new System.Drawing.Size(80, 19);
			this.lblQQNum.TabIndex = 4;
			this.lblQQNum.Text = "x 0";
			this.lblQQNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBreadNum
			// 
			this.lblBreadNum.BackColor = System.Drawing.Color.Transparent;
			this.lblBreadNum.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBreadNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
			this.lblBreadNum.Location = new System.Drawing.Point(256, 214);
			this.lblBreadNum.Margin = new System.Windows.Forms.Padding(0);
			this.lblBreadNum.Name = "lblBreadNum";
			this.lblBreadNum.Size = new System.Drawing.Size(80, 19);
			this.lblBreadNum.TabIndex = 4;
			this.lblBreadNum.Text = "x 0";
			this.lblBreadNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBadge
			// 
			this.lblBadge.BackColor = System.Drawing.Color.Transparent;
			this.lblBadge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblBadge.Location = new System.Drawing.Point(733, 395);
			this.lblBadge.Name = "lblBadge";
			this.lblBadge.Size = new System.Drawing.Size(73, 39);
			this.lblBadge.TabIndex = 3;
			this.lblBadge.Tag = "5";
			this.lblBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblBadge.Click += new System.EventHandler(this.lblBadge_Click);
			// 
			// lblLottery
			// 
			this.lblLottery.BackColor = System.Drawing.Color.Transparent;
			this.lblLottery.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLottery.Location = new System.Drawing.Point(733, 286);
			this.lblLottery.Name = "lblLottery";
			this.lblLottery.Size = new System.Drawing.Size(73, 39);
			this.lblLottery.TabIndex = 3;
			this.lblLottery.Tag = "3";
			this.lblLottery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblLottery.Click += new System.EventHandler(this.lblLottery_Click);
			// 
			// lblQQStar
			// 
			this.lblQQStar.BackColor = System.Drawing.Color.Transparent;
			this.lblQQStar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblQQStar.Location = new System.Drawing.Point(367, 395);
			this.lblQQStar.Name = "lblQQStar";
			this.lblQQStar.Size = new System.Drawing.Size(73, 39);
			this.lblQQStar.TabIndex = 3;
			this.lblQQStar.Tag = "4";
			this.lblQQStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblQQStar.Click += new System.EventHandler(this.lblQQStar_Click);
			// 
			// lblCalcium
			// 
			this.lblCalcium.BackColor = System.Drawing.Color.Transparent;
			this.lblCalcium.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCalcium.Location = new System.Drawing.Point(733, 177);
			this.lblCalcium.Name = "lblCalcium";
			this.lblCalcium.Size = new System.Drawing.Size(73, 39);
			this.lblCalcium.TabIndex = 3;
			this.lblCalcium.Tag = "1";
			this.lblCalcium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCalcium.Click += new System.EventHandler(this.lblCalcium_Click);
			// 
			// lblFlower
			// 
			this.lblFlower.BackColor = System.Drawing.Color.Transparent;
			this.lblFlower.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblFlower.Location = new System.Drawing.Point(367, 286);
			this.lblFlower.Name = "lblFlower";
			this.lblFlower.Size = new System.Drawing.Size(73, 39);
			this.lblFlower.TabIndex = 3;
			this.lblFlower.Tag = "2";
			this.lblFlower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblFlower.Click += new System.EventHandler(this.lblFlower_Click);
			// 
			// lblBread
			// 
			this.lblBread.BackColor = System.Drawing.Color.Transparent;
			this.lblBread.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblBread.Location = new System.Drawing.Point(367, 177);
			this.lblBread.Name = "lblBread";
			this.lblBread.Size = new System.Drawing.Size(73, 39);
			this.lblBread.TabIndex = 3;
			this.lblBread.Tag = "0";
			this.lblBread.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblBread.Click += new System.EventHandler(this.lblBread_Click);
			// 
			// pnlHeroInfo
			// 
			this.pnlHeroInfo.BackgroundImage = global::ITHero.Properties.Resources.玩家属性;
			this.pnlHeroInfo.Controls.Add(this.picGander);
			this.pnlHeroInfo.Controls.Add(this.lblHeroInfoClose);
			this.pnlHeroInfo.Controls.Add(this.lblGander);
			this.pnlHeroInfo.Controls.Add(this.lblMoney);
			this.pnlHeroInfo.Controls.Add(this.lblMorality);
			this.pnlHeroInfo.Controls.Add(this.lblIntellect);
			this.pnlHeroInfo.Controls.Add(this.lblPrestige);
			this.pnlHeroInfo.Controls.Add(this.lblPower);
			this.pnlHeroInfo.Controls.Add(this.lblLuck);
			this.pnlHeroInfo.Controls.Add(this.lblCharm);
			this.pnlHeroInfo.Controls.Add(this.lblName);
			this.pnlHeroInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlHeroInfo.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeroInfo.Name = "pnlHeroInfo";
			this.pnlHeroInfo.Size = new System.Drawing.Size(944, 502);
			this.pnlHeroInfo.TabIndex = 0;
			this.pnlHeroInfo.Visible = false;
			// 
			// picGander
			// 
			this.picGander.BackColor = System.Drawing.Color.Transparent;
			this.picGander.Location = new System.Drawing.Point(116, 166);
			this.picGander.Name = "picGander";
			this.picGander.Size = new System.Drawing.Size(115, 102);
			this.picGander.TabIndex = 2;
			this.picGander.TabStop = false;
			// 
			// lblHeroInfoClose
			// 
			this.lblHeroInfoClose.AutoSize = true;
			this.lblHeroInfoClose.BackColor = System.Drawing.Color.Transparent;
			this.lblHeroInfoClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblHeroInfoClose.Font = new System.Drawing.Font("华文隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblHeroInfoClose.ForeColor = System.Drawing.Color.DarkRed;
			this.lblHeroInfoClose.Location = new System.Drawing.Point(790, 440);
			this.lblHeroInfoClose.Name = "lblHeroInfoClose";
			this.lblHeroInfoClose.Size = new System.Drawing.Size(71, 30);
			this.lblHeroInfoClose.TabIndex = 1;
			this.lblHeroInfoClose.Text = "关闭";
			this.lblHeroInfoClose.Click += new System.EventHandler(this.lblHeroInfoClose_Click);
			// 
			// lblGander
			// 
			this.lblGander.AutoSize = true;
			this.lblGander.BackColor = System.Drawing.Color.Transparent;
			this.lblGander.Font = new System.Drawing.Font("华文隶书", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblGander.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblGander.Location = new System.Drawing.Point(615, 190);
			this.lblGander.Name = "lblGander";
			this.lblGander.Size = new System.Drawing.Size(29, 19);
			this.lblGander.TabIndex = 0;
			this.lblGander.Text = "男";
			// 
			// lblMoney
			// 
			this.lblMoney.BackColor = System.Drawing.Color.Transparent;
			this.lblMoney.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblMoney.Location = new System.Drawing.Point(311, 228);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(91, 19);
			this.lblMoney.TabIndex = 0;
			this.lblMoney.Text = "100";
			this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMorality
			// 
			this.lblMorality.BackColor = System.Drawing.Color.Transparent;
			this.lblMorality.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMorality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblMorality.Location = new System.Drawing.Point(615, 302);
			this.lblMorality.Name = "lblMorality";
			this.lblMorality.Size = new System.Drawing.Size(47, 19);
			this.lblMorality.TabIndex = 0;
			this.lblMorality.Text = "10";
			// 
			// lblIntellect
			// 
			this.lblIntellect.BackColor = System.Drawing.Color.Transparent;
			this.lblIntellect.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIntellect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblIntellect.Location = new System.Drawing.Point(615, 398);
			this.lblIntellect.Name = "lblIntellect";
			this.lblIntellect.Size = new System.Drawing.Size(47, 19);
			this.lblIntellect.TabIndex = 0;
			this.lblIntellect.Text = "10";
			// 
			// lblPrestige
			// 
			this.lblPrestige.BackColor = System.Drawing.Color.Transparent;
			this.lblPrestige.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrestige.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblPrestige.Location = new System.Drawing.Point(330, 302);
			this.lblPrestige.Name = "lblPrestige";
			this.lblPrestige.Size = new System.Drawing.Size(47, 19);
			this.lblPrestige.TabIndex = 0;
			this.lblPrestige.Text = "10";
			// 
			// lblPower
			// 
			this.lblPower.BackColor = System.Drawing.Color.Transparent;
			this.lblPower.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblPower.Location = new System.Drawing.Point(615, 350);
			this.lblPower.Name = "lblPower";
			this.lblPower.Size = new System.Drawing.Size(47, 19);
			this.lblPower.TabIndex = 0;
			this.lblPower.Text = "10";
			// 
			// lblLuck
			// 
			this.lblLuck.BackColor = System.Drawing.Color.Transparent;
			this.lblLuck.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLuck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblLuck.Location = new System.Drawing.Point(330, 398);
			this.lblLuck.Name = "lblLuck";
			this.lblLuck.Size = new System.Drawing.Size(47, 19);
			this.lblLuck.TabIndex = 0;
			this.lblLuck.Text = "10";
			// 
			// lblCharm
			// 
			this.lblCharm.BackColor = System.Drawing.Color.Transparent;
			this.lblCharm.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCharm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblCharm.Location = new System.Drawing.Point(330, 350);
			this.lblCharm.Name = "lblCharm";
			this.lblCharm.Size = new System.Drawing.Size(47, 19);
			this.lblCharm.TabIndex = 0;
			this.lblCharm.Text = "10";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("华文隶书", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(106)))), ((int)(((byte)(16)))));
			this.lblName.Location = new System.Drawing.Point(330, 190);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(49, 19);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "无名";
			// 
			// ofDlg
			// 
			this.ofDlg.Filter = "存档文件|*.dat|所有文件|*.*";
			// 
			// BedroomForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(944, 502);
			this.Controls.Add(this.pnlParcel);
			this.Controls.Add(this.pnlHeroInfo);
			this.Controls.Add(this.pnlBedroomInfo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BedroomForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IT英雄—寝室";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BedroomForm_FormClosing);
			this.Load += new System.EventHandler(this.BedroomForm_Load);
			this.pnlBedroomInfo.ResumeLayout(false);
			this.pnlParcel.ResumeLayout(false);
			this.pnlParcel.PerformLayout();
			this.pnlHeroInfo.ResumeLayout(false);
			this.pnlHeroInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picGander)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeroInfo;
        private System.Windows.Forms.Label lblGander;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblMorality;
        private System.Windows.Forms.Label lblIntellect;
        private System.Windows.Forms.Label lblPrestige;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.Label lblCharm;
        private System.Windows.Forms.Label lblHeroInfoClose;
        private System.Windows.Forms.Panel pnlBedroomInfo;
        private System.Windows.Forms.PictureBox picGander;
        private System.Windows.Forms.ImageList imgListGander;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblParcel;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.Label lblHeroInfo;
        private System.Windows.Forms.Panel pnlParcel;
        private System.Windows.Forms.Label lblBadge;
        private System.Windows.Forms.Label lblLottery;
        private System.Windows.Forms.Label lblQQStar;
        private System.Windows.Forms.Label lblCalcium;
        private System.Windows.Forms.Label lblFlower;
        private System.Windows.Forms.Label lblBread;
        private System.Windows.Forms.Label lblFlowerNum;
        private System.Windows.Forms.Label lblQQNum;
        private System.Windows.Forms.Label lblBreadNum;
        private System.Windows.Forms.Label lblLotteryNum;
        private System.Windows.Forms.Label lblBadgeNum;
        private System.Windows.Forms.Label lblCalciumNum;
        private System.Windows.Forms.Label lblParcelClose;
        private System.Windows.Forms.OpenFileDialog ofDlg;
    }
}