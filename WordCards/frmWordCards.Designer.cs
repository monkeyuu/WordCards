namespace WordCards
{
    partial class frmWordCards
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWordCards));
            this.sssWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstWordList = new System.Windows.Forms.ListBox();
            this.palMain = new System.Windows.Forms.Panel();
            this.palCard = new System.Windows.Forms.Panel();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblDivider = new System.Windows.Forms.Label();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.timePlayer = new System.Windows.Forms.Timer(this.components);
            this.lblSideTitle = new System.Windows.Forms.Label();
            this.sssWord.SuspendLayout();
            this.palMain.SuspendLayout();
            this.palCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // sssWord
            // 
            this.sssWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.sssWord.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.sssWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.sssWord.Location = new System.Drawing.Point(0, 278);
            this.sssWord.Name = "sssWord";
            this.sssWord.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.sssWord.Size = new System.Drawing.Size(564, 22);
            this.sssWord.TabIndex = 0;
            // 
            // tsslMessage
            // 
            this.tsslMessage.Font = new System.Drawing.Font("微軟正黑體", 9.75F);
            this.tsslMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(175)))), ((int)(((byte)(210)))));
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(62, 17);
            this.tsslMessage.Text = "Message";
            // 
            // lstWordList
            // 
            this.lstWordList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lstWordList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWordList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(235)))));
            this.lstWordList.FormattingEnabled = true;
            this.lstWordList.ItemHeight = 20;
            this.lstWordList.Location = new System.Drawing.Point(0, 0);
            this.lstWordList.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lstWordList.Name = "lstWordList";
            this.lstWordList.Size = new System.Drawing.Size(160, 278);
            this.lstWordList.TabIndex = 1;
            this.lstWordList.Click += new System.EventHandler(this.lstWordList_Click);
            this.lstWordList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstWordList_MouseDoubleClick);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.palMain.Controls.Add(this.palCard);
            this.palMain.Controls.Add(this.btnAutoPlay);
            this.palMain.Controls.Add(this.txtHelp);
            this.palMain.Controls.Add(this.picLogo);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(160, 0);
            this.palMain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.palMain.Name = "palMain";
            this.palMain.Padding = new System.Windows.Forms.Padding(15, 14, 13, 10);
            this.palMain.Size = new System.Drawing.Size(404, 278);
            this.palMain.TabIndex = 2;
            // 
            // palCard
            // 
            this.palCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.palCard.Controls.Add(this.txtWord);
            this.palCard.Controls.Add(this.lblDivider);
            this.palCard.Controls.Add(this.txtPhonogram);
            this.palCard.Controls.Add(this.txtExplain);
            this.palCard.Location = new System.Drawing.Point(15, 14);
            this.palCard.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.palCard.Name = "palCard";
            this.palCard.Padding = new System.Windows.Forms.Padding(15, 14, 11, 10);
            this.palCard.Size = new System.Drawing.Size(290, 250);
            this.palCard.TabIndex = 10;
            // 
            // txtWord
            // 
            this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Font = new System.Drawing.Font("微軟正黑體", 32F, System.Drawing.FontStyle.Bold);
            this.txtWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.txtWord.Location = new System.Drawing.Point(15, 16);
            this.txtWord.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtWord.Name = "txtWord";
            this.txtWord.ReadOnly = true;
            this.txtWord.Size = new System.Drawing.Size(258, 57);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "abacus";
            // 
            // lblDivider
            // 
            this.lblDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.lblDivider.Location = new System.Drawing.Point(15, 69);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(258, 2);
            this.lblDivider.TabIndex = 10;
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.txtPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
            this.txtPhonogram.Location = new System.Drawing.Point(15, 78);
            this.txtPhonogram.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.ReadOnly = true;
            this.txtPhonogram.Size = new System.Drawing.Size(258, 29);
            this.txtPhonogram.TabIndex = 1;
            this.txtPhonogram.Text = "ˋæbəkəs";
            // 
            // txtExplain
            // 
            this.txtExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Font = new System.Drawing.Font("微軟正黑體", 13F);
            this.txtExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.txtExplain.Location = new System.Drawing.Point(15, 110);
            this.txtExplain.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.ReadOnly = true;
            this.txtExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplain.Size = new System.Drawing.Size(258, 124);
            this.txtExplain.TabIndex = 2;
            this.txtExplain.Text = "<aba-=abax-:一種計算工具>+<-us: calculus 小圓石>";
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnAutoPlay.FlatAppearance.BorderSize = 0;
            this.btnAutoPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(145)))), ((int)(((byte)(15)))));
            this.btnAutoPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(60)))));
            this.btnAutoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoPlay.Font = new System.Drawing.Font("微軟正黑體", 13.5F, System.Drawing.FontStyle.Bold);
            this.btnAutoPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.btnAutoPlay.Location = new System.Drawing.Point(317, 93);
            this.btnAutoPlay.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(69, 26);
            this.btnAutoPlay.TabIndex = 4;
            this.btnAutoPlay.Text = "▶  Play";
            this.btnAutoPlay.UseVisualStyleBackColor = false;
            this.btnAutoPlay.Click += new System.EventHandler(this.btnAutoPlay_Click);
            // 
            // txtHelp
            // 
            this.txtHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.txtHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHelp.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(185)))));
            this.txtHelp.Location = new System.Drawing.Point(305, 199);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(104, 101);
            this.txtHelp.TabIndex = 5;
            this.txtHelp.Text = "Enter  →  下一個\r\nSpace  →  重覆播放\r\n雙擊單字  →  編輯";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.Image = global::WordCards.Properties.Resources.WordCards_Logo;
            this.picLogo.Location = new System.Drawing.Point(322, 14);
            this.picLogo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(65, 70);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // timePlayer
            // 
            this.timePlayer.Interval = 2000;
            this.timePlayer.Tick += new System.EventHandler(this.timePlayer_Tick);
            // 
            // lblSideTitle
            // 
            this.lblSideTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.lblSideTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSideTitle.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblSideTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.lblSideTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.Size = new System.Drawing.Size(100, 44);
            this.lblSideTitle.TabIndex = 0;
            this.lblSideTitle.Text = "  WORD LIST";
            this.lblSideTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmWordCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(564, 300);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.lstWordList);
            this.Controls.Add(this.sssWord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MinimumSize = new System.Drawing.Size(470, 339);
            this.Name = "frmWordCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "單字卡";
            this.Load += new System.EventHandler(this.frmWordCards_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmWordCards_KeyPress);
            this.sssWord.ResumeLayout(false);
            this.sssWord.PerformLayout();
            this.palMain.ResumeLayout(false);
            this.palMain.PerformLayout();
            this.palCard.ResumeLayout(false);
            this.palCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip        sssWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ListBox            lstWordList;
        private System.Windows.Forms.Panel              palMain;
        private System.Windows.Forms.Panel              palCard;
        private System.Windows.Forms.PictureBox         picLogo;
        private System.Windows.Forms.TextBox            txtExplain;
        private System.Windows.Forms.TextBox            txtPhonogram;
        private System.Windows.Forms.TextBox            txtWord;
        private System.Windows.Forms.Label              lblDivider;
        private System.Windows.Forms.TextBox            txtHelp;
        private System.Windows.Forms.Button             btnAutoPlay;
        private System.Windows.Forms.Timer              timePlayer;
        private System.Windows.Forms.Label              lblSideTitle;
    }
}
