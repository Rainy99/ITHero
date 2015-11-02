namespace ITHero
{
    partial class CreateHeroForm
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
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblAuto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestions
            // 
            this.lblQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestions.Location = new System.Drawing.Point(377, 147);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(200, 55);
            this.lblQuestions.TabIndex = 1;
            this.lblQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestions.Click += new System.EventHandler(this.lblQuestions_Click);
            // 
            // lblAuto
            // 
            this.lblAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAuto.Location = new System.Drawing.Point(377, 236);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(200, 55);
            this.lblAuto.TabIndex = 2;
            this.lblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuto.Click += new System.EventHandler(this.lblAuto_Click);
            // 
            // CreateHeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITHero.Properties.Resources.属性生成方式界面;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.lblQuestions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateHeroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT英雄—生成属性";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateHeroForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateHeroForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblAuto;
    }
}