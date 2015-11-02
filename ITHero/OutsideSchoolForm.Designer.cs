namespace ITHero
{
    partial class OutsideSchoolForm
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
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblHappyValley = new System.Windows.Forms.Label();
            this.lblSoftwarePark = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSchool
            // 
            this.lblSchool.BackColor = System.Drawing.Color.Transparent;
            this.lblSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSchool.Location = new System.Drawing.Point(638, 152);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(172, 86);
            this.lblSchool.TabIndex = 7;
            this.lblSchool.Click += new System.EventHandler(this.lblSchool_Click);
            // 
            // lblHappyValley
            // 
            this.lblHappyValley.BackColor = System.Drawing.Color.Transparent;
            this.lblHappyValley.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHappyValley.Location = new System.Drawing.Point(137, 201);
            this.lblHappyValley.Name = "lblHappyValley";
            this.lblHappyValley.Size = new System.Drawing.Size(94, 86);
            this.lblHappyValley.TabIndex = 8;
            this.lblHappyValley.Click += new System.EventHandler(this.lblHappyValley_Click);
            // 
            // lblSoftwarePark
            // 
            this.lblSoftwarePark.BackColor = System.Drawing.Color.Transparent;
            this.lblSoftwarePark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSoftwarePark.Location = new System.Drawing.Point(367, 259);
            this.lblSoftwarePark.Name = "lblSoftwarePark";
            this.lblSoftwarePark.Size = new System.Drawing.Size(149, 173);
            this.lblSoftwarePark.TabIndex = 9;
            this.lblSoftwarePark.Click += new System.EventHandler(this.lblSoftwarePark_Click);
            // 
            // lblHospital
            // 
            this.lblHospital.BackColor = System.Drawing.Color.Transparent;
            this.lblHospital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHospital.Location = new System.Drawing.Point(666, 369);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(121, 102);
            this.lblHospital.TabIndex = 10;
            this.lblHospital.Click += new System.EventHandler(this.lblHospital_Click);
            // 
            // OutsideSchoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITHero.Properties.Resources.校外地图;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.lblSoftwarePark);
            this.Controls.Add(this.lblHappyValley);
            this.Controls.Add(this.lblSchool);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OutsideSchoolForm";
            this.Text = "IT英雄—校外";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutsideSchoolForm_FormClosing);
            this.Load += new System.EventHandler(this.OutsideSchoolForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblHappyValley;
        private System.Windows.Forms.Label lblSoftwarePark;
        private System.Windows.Forms.Label lblHospital;
    }
}