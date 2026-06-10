namespace WordCards
{
    partial class frmEditWord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWord
            // 
            this.grpWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(74)))));
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpWord.Font = new System.Drawing.Font("微軟正黑體", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.grpWord.Location = new System.Drawing.Point(9, 30);
            this.grpWord.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpWord.Name = "grpWord";
            this.grpWord.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpWord.Size = new System.Drawing.Size(286, 51);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字（唯讀）";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWord.Enabled = false;
            this.txtWord.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.txtWord.Location = new System.Drawing.Point(6, 17);
            this.txtWord.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(274, 29);
            this.txtWord.TabIndex = 0;
            // 
            // grpPhonogram
            // 
            this.grpPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(74)))));
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPhonogram.Font = new System.Drawing.Font("微軟正黑體", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.grpPhonogram.Location = new System.Drawing.Point(9, 85);
            this.grpPhonogram.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpPhonogram.Size = new System.Drawing.Size(286, 49);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.txtPhonogram.Location = new System.Drawing.Point(6, 16);
            this.txtPhonogram.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(274, 29);
            this.txtPhonogram.TabIndex = 0;
            // 
            // grpExplain
            // 
            this.grpExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(74)))));
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpExplain.Font = new System.Drawing.Font("微軟正黑體", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.grpExplain.Location = new System.Drawing.Point(9, 189);
            this.grpExplain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpExplain.Size = new System.Drawing.Size(286, 130);
            this.grpExplain.TabIndex = 3;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.txtExplain.Location = new System.Drawing.Point(6, 17);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(274, 106);
            this.txtExplain.TabIndex = 0;
            // 
            // grpSoundPath
            // 
            this.grpSoundPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(48)))), ((int)(((byte)(74)))));
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSoundPath.Font = new System.Drawing.Font("微軟正黑體", 10.5F, System.Drawing.FontStyle.Bold);
            this.grpSoundPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.grpSoundPath.Location = new System.Drawing.Point(9, 134);
            this.grpSoundPath.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grpSoundPath.Size = new System.Drawing.Size(286, 51);
            this.grpSoundPath.TabIndex = 2;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.txtSoundPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoundPath.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtSoundPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.txtSoundPath.Location = new System.Drawing.Point(6, 17);
            this.txtSoundPath.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(274, 29);
            this.txtSoundPath.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(145)))), ((int)(((byte)(15)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnSave.Location = new System.Drawing.Point(235, 326);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.btnCancel.Location = new System.Drawing.Point(9, 326);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 31);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("微軟正黑體", 13.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 25);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "  編輯單字";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmEditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(309, 376);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpSoundPath);
            this.Controls.Add(this.grpPhonogram);
            this.Controls.Add(this.grpWord);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 403);
            this.Name = "frmEditWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "編輯單字";
            this.grpWord.ResumeLayout(false);
            this.grpWord.PerformLayout();
            this.grpPhonogram.ResumeLayout(false);
            this.grpPhonogram.PerformLayout();
            this.grpExplain.ResumeLayout(false);
            this.grpExplain.PerformLayout();
            this.grpSoundPath.ResumeLayout(false);
            this.grpSoundPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox  grpWord;
        private System.Windows.Forms.GroupBox  grpPhonogram;
        private System.Windows.Forms.TextBox   txtPhonogram;
        private System.Windows.Forms.TextBox   txtWord;
        private System.Windows.Forms.GroupBox  grpExplain;
        private System.Windows.Forms.TextBox   txtExplain;
        private System.Windows.Forms.GroupBox  grpSoundPath;
        private System.Windows.Forms.TextBox   txtSoundPath;
        private System.Windows.Forms.Button    btnSave;
        private System.Windows.Forms.Button    btnCancel;
        private System.Windows.Forms.Label     lblTitle;
    }
}
