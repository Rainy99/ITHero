namespace ITHero
{
    partial class ExamPassForm
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
			this.lblNewGame = new System.Windows.Forms.Label();
			this.lblExit = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNewGame
			// 
			this.lblNewGame.BackColor = System.Drawing.Color.Transparent;
			this.lblNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblNewGame.Image = global::ITHero.Properties.Resources.再来一次;
			this.lblNewGame.Location = new System.Drawing.Point(280, 380);
			this.lblNewGame.Name = "lblNewGame";
			this.lblNewGame.Size = new System.Drawing.Size(229, 72);
			this.lblNewGame.TabIndex = 0;
			this.lblNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
			// 
			// lblExit
			// 
			this.lblExit.BackColor = System.Drawing.Color.Transparent;
			this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblExit.Image = global::ITHero.Properties.Resources.退出游戏;
			this.lblExit.Location = new System.Drawing.Point(550, 380);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(229, 72);
			this.lblExit.TabIndex = 1;
			this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
			// 
			// ExamPassForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ITHero.Properties.Resources.毕业界面;
			this.ClientSize = new System.Drawing.Size(944, 502);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.lblNewGame);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ExamPassForm";
			this.Text = "IT英雄—恭喜通关";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamPassForm_FormClosing);
			this.Load += new System.EventHandler(this.ExamPassForm_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblExit;
    }
}