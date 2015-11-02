namespace ITHero
{
    partial class SchoolForm
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
            this.lblBedroom = new System.Windows.Forms.Label();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.lblEatery = new System.Windows.Forms.Label();
            this.lblInfirmary = new System.Windows.Forms.Label();
            this.lblClassroom = new System.Windows.Forms.Label();
            this.lblPlayground = new System.Windows.Forms.Label();
            this.lblDoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBedroom
            // 
            this.lblBedroom.BackColor = System.Drawing.Color.Transparent;
            this.lblBedroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBedroom.Location = new System.Drawing.Point(652, 154);
            this.lblBedroom.Name = "lblBedroom";
            this.lblBedroom.Size = new System.Drawing.Size(56, 93);
            this.lblBedroom.TabIndex = 0;
            this.lblBedroom.Click += new System.EventHandler(this.lblBedroom_Click);
            // 
            // lblLibrary
            // 
            this.lblLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLibrary.Location = new System.Drawing.Point(481, 207);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(88, 83);
            this.lblLibrary.TabIndex = 1;
            this.lblLibrary.Click += new System.EventHandler(this.lblPlayground_Click);
            // 
            // lblEatery
            // 
            this.lblEatery.BackColor = System.Drawing.Color.Transparent;
            this.lblEatery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEatery.Location = new System.Drawing.Point(762, 301);
            this.lblEatery.Name = "lblEatery";
            this.lblEatery.Size = new System.Drawing.Size(88, 65);
            this.lblEatery.TabIndex = 2;
            this.lblEatery.Click += new System.EventHandler(this.lblEatery_Click);
            // 
            // lblInfirmary
            // 
            this.lblInfirmary.BackColor = System.Drawing.Color.Transparent;
            this.lblInfirmary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfirmary.Location = new System.Drawing.Point(659, 381);
            this.lblInfirmary.Name = "lblInfirmary";
            this.lblInfirmary.Size = new System.Drawing.Size(88, 84);
            this.lblInfirmary.TabIndex = 3;
            this.lblInfirmary.Click += new System.EventHandler(this.lblPlayground_Click);
            // 
            // lblClassroom
            // 
            this.lblClassroom.BackColor = System.Drawing.Color.Transparent;
            this.lblClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClassroom.Location = new System.Drawing.Point(306, 228);
            this.lblClassroom.Name = "lblClassroom";
            this.lblClassroom.Size = new System.Drawing.Size(135, 153);
            this.lblClassroom.TabIndex = 4;
            this.lblClassroom.Click += new System.EventHandler(this.lblClassroom_Click);
            // 
            // lblPlayground
            // 
            this.lblPlayground.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayground.Location = new System.Drawing.Point(187, 266);
            this.lblPlayground.Name = "lblPlayground";
            this.lblPlayground.Size = new System.Drawing.Size(59, 35);
            this.lblPlayground.TabIndex = 5;
            this.lblPlayground.Click += new System.EventHandler(this.lblPlayground_Click);
            // 
            // lblDoor
            // 
            this.lblDoor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDoor.Location = new System.Drawing.Point(134, 365);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(112, 116);
            this.lblDoor.TabIndex = 6;
            this.lblDoor.Click += new System.EventHandler(this.lblDoor_Click);
            // 
            // SchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITHero.Properties.Resources.学校地图;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.lblDoor);
            this.Controls.Add(this.lblPlayground);
            this.Controls.Add(this.lblClassroom);
            this.Controls.Add(this.lblInfirmary);
            this.Controls.Add(this.lblEatery);
            this.Controls.Add(this.lblLibrary);
            this.Controls.Add(this.lblBedroom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SchoolForm";
            this.Text = "IT英雄—学校";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SchoolForm_FormClosing);
            this.Load += new System.EventHandler(this.SchoolForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBedroom;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.Label lblEatery;
        private System.Windows.Forms.Label lblInfirmary;
        private System.Windows.Forms.Label lblClassroom;
        private System.Windows.Forms.Label lblPlayground;
        private System.Windows.Forms.Label lblDoor;
    }
}