namespace ITHero
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStart = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.pnlCreateHero = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblGander = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.pnlCreateHero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStart.Location = new System.Drawing.Point(173, 206);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(130, 40);
            this.lblStart.TabIndex = 0;
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblLoad
            // 
            this.lblLoad.BackColor = System.Drawing.Color.Transparent;
            this.lblLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoad.Location = new System.Drawing.Point(323, 206);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(130, 40);
            this.lblLoad.TabIndex = 0;
            this.lblLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoad.Click += new System.EventHandler(this.lblLoad_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.Color.Transparent;
            this.lblOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOptions.Location = new System.Drawing.Point(173, 269);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(130, 40);
            this.lblOptions.TabIndex = 0;
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOptions.Click += new System.EventHandler(this.lblOptions_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEnd.Location = new System.Drawing.Point(323, 269);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(130, 40);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnd.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // pnlCreateHero
            // 
            this.pnlCreateHero.BackColor = System.Drawing.Color.Transparent;
            this.pnlCreateHero.Controls.Add(this.btnCancel);
            this.pnlCreateHero.Controls.Add(this.btnNext);
            this.pnlCreateHero.Controls.Add(this.rdoFemale);
            this.pnlCreateHero.Controls.Add(this.rdoMale);
            this.pnlCreateHero.Controls.Add(this.lblGander);
            this.pnlCreateHero.Controls.Add(this.txtName);
            this.pnlCreateHero.Controls.Add(this.lblName);
            this.pnlCreateHero.Font = new System.Drawing.Font("方正舒体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlCreateHero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCreateHero.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateHero.Name = "pnlCreateHero";
            this.pnlCreateHero.Size = new System.Drawing.Size(944, 502);
            this.pnlCreateHero.TabIndex = 1;
            this.pnlCreateHero.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.Location = new System.Drawing.Point(479, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.ForeColor = System.Drawing.Color.DimGray;
            this.btnNext.Location = new System.Drawing.Point(332, 278);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 31);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "继  续";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoFemale.Location = new System.Drawing.Point(506, 210);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(43, 20);
            this.rdoFemale.TabIndex = 3;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoMale.Location = new System.Drawing.Point(410, 210);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 20);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // lblGander
            // 
            this.lblGander.AutoSize = true;
            this.lblGander.BackColor = System.Drawing.Color.Transparent;
            this.lblGander.Font = new System.Drawing.Font("方正舒体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGander.Location = new System.Drawing.Point(327, 208);
            this.lblGander.Name = "lblGander";
            this.lblGander.Size = new System.Drawing.Size(76, 22);
            this.lblGander.TabIndex = 2;
            this.lblGander.Text = "性别：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(409, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 29);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("方正舒体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(327, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // ofDlg
            // 
            this.ofDlg.Filter = "存档文件|*.dat|所有文件|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITHero.Properties.Resources.进入界面;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.pnlCreateHero);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT英雄";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCreateHero.ResumeLayout(false);
            this.pnlCreateHero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Panel pnlCreateHero;
        private System.Windows.Forms.Label lblGander;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.OpenFileDialog ofDlg;
    }
}

