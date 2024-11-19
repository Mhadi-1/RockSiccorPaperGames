namespace RockSiccorPaperGames
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rdi_Rock = new System.Windows.Forms.RadioButton();
            this.rdi_Paper = new System.Windows.Forms.RadioButton();
            this.rdi_Siccer = new System.Windows.Forms.RadioButton();
            this.lableControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lblWinnerPlayer = new DevExpress.XtraEditors.LabelControl();
            this.lblWinnerComputer = new DevExpress.XtraEditors.LabelControl();
            this.lblDrawGame = new DevExpress.XtraEditors.LabelControl();
            this.numericRangeControlClient1 = new DevExpress.XtraEditors.NumericRangeControlClient();
            this.lblRouunds = new DevExpress.XtraEditors.LabelControl();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.labelPlayerName = new DevExpress.XtraEditors.LabelControl();
            this.LablePlayerWin = new DevExpress.XtraEditors.LabelControl();
            this.labeComputerWin = new DevExpress.XtraEditors.LabelControl();
            this.labelComputer = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pb_computer = new System.Windows.Forms.PictureBox();
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_computer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(212, 70);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(575, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chooice Your Type ";
            // 
            // rdi_Rock
            // 
            this.rdi_Rock.AutoSize = true;
            this.rdi_Rock.BackColor = System.Drawing.Color.YellowGreen;
            this.rdi_Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdi_Rock.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold);
            this.rdi_Rock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rdi_Rock.Location = new System.Drawing.Point(93, 153);
            this.rdi_Rock.Name = "rdi_Rock";
            this.rdi_Rock.Size = new System.Drawing.Size(118, 40);
            this.rdi_Rock.TabIndex = 1;
            this.rdi_Rock.TabStop = true;
            this.rdi_Rock.Tag = "Rock";
            this.rdi_Rock.Text = "Rock";
            this.rdi_Rock.UseVisualStyleBackColor = false;
            this.rdi_Rock.CheckedChanged += new System.EventHandler(this.Radio_Change);
            this.rdi_Rock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdi_Paper_MouseClick);
            // 
            // rdi_Paper
            // 
            this.rdi_Paper.AutoSize = true;
            this.rdi_Paper.BackColor = System.Drawing.Color.YellowGreen;
            this.rdi_Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdi_Paper.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold);
            this.rdi_Paper.ForeColor = System.Drawing.Color.Navy;
            this.rdi_Paper.Location = new System.Drawing.Point(417, 153);
            this.rdi_Paper.Name = "rdi_Paper";
            this.rdi_Paper.Size = new System.Drawing.Size(139, 40);
            this.rdi_Paper.TabIndex = 2;
            this.rdi_Paper.TabStop = true;
            this.rdi_Paper.Tag = "Paper";
            this.rdi_Paper.Text = "Paper";
            this.rdi_Paper.UseVisualStyleBackColor = false;
            this.rdi_Paper.CheckedChanged += new System.EventHandler(this.Radio_Change);
            this.rdi_Paper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdi_Paper_MouseClick);
            // 
            // rdi_Siccer
            // 
            this.rdi_Siccer.AutoSize = true;
            this.rdi_Siccer.BackColor = System.Drawing.Color.YellowGreen;
            this.rdi_Siccer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdi_Siccer.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Bold);
            this.rdi_Siccer.ForeColor = System.Drawing.Color.Teal;
            this.rdi_Siccer.Location = new System.Drawing.Point(700, 153);
            this.rdi_Siccer.Name = "rdi_Siccer";
            this.rdi_Siccer.Size = new System.Drawing.Size(167, 40);
            this.rdi_Siccer.TabIndex = 3;
            this.rdi_Siccer.TabStop = true;
            this.rdi_Siccer.Tag = "Siccoer";
            this.rdi_Siccer.Text = "Siccoer";
            this.rdi_Siccer.UseVisualStyleBackColor = false;
            this.rdi_Siccer.CheckedChanged += new System.EventHandler(this.Radio_Change);
            this.rdi_Siccer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdi_Paper_MouseClick);
            // 
            // lableControl1
            // 
            this.lableControl1.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableControl1.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lableControl1.Appearance.Options.UseFont = true;
            this.lableControl1.Appearance.Options.UseForeColor = true;
            this.lableControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lableControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lableControl1.LineVisible = true;
            this.lableControl1.Location = new System.Drawing.Point(469, 345);
            this.lableControl1.Margin = new System.Windows.Forms.Padding(4);
            this.lableControl1.Name = "lableControl1";
            this.lableControl1.Size = new System.Drawing.Size(63, 39);
            this.lableControl1.TabIndex = 6;
            this.lableControl1.Text = "Vs";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(988, 724);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(294, 39);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Computer";
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.Appearance.Options.UseForeColor = true;
            this.lblUserName.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblUserName.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblUserName.LineVisible = true;
            this.lblUserName.Location = new System.Drawing.Point(144, 724);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(248, 39);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Playerd";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Goudy Stout", 8F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(438, 471);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 48);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Interval = 300;
            this.tmrChangeImage.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "stone.png");
            this.imgList.Images.SetKeyName(1, "Paper.png");
            this.imgList.Images.SetKeyName(2, "Rock.png");
            // 
            // lblWinnerPlayer
            // 
            this.lblWinnerPlayer.Appearance.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Bold);
            this.lblWinnerPlayer.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinnerPlayer.Appearance.Options.UseFont = true;
            this.lblWinnerPlayer.Appearance.Options.UseForeColor = true;
            this.lblWinnerPlayer.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblWinnerPlayer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblWinnerPlayer.LineVisible = true;
            this.lblWinnerPlayer.Location = new System.Drawing.Point(144, 792);
            this.lblWinnerPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.lblWinnerPlayer.Name = "lblWinnerPlayer";
            this.lblWinnerPlayer.Size = new System.Drawing.Size(71, 53);
            this.lblWinnerPlayer.TabIndex = 10;
            this.lblWinnerPlayer.Text = "Vs";
            // 
            // lblWinnerComputer
            // 
            this.lblWinnerComputer.Appearance.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Bold);
            this.lblWinnerComputer.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblWinnerComputer.Appearance.Options.UseFont = true;
            this.lblWinnerComputer.Appearance.Options.UseForeColor = true;
            this.lblWinnerComputer.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblWinnerComputer.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblWinnerComputer.LineVisible = true;
            this.lblWinnerComputer.Location = new System.Drawing.Point(988, 792);
            this.lblWinnerComputer.Margin = new System.Windows.Forms.Padding(4);
            this.lblWinnerComputer.Name = "lblWinnerComputer";
            this.lblWinnerComputer.Size = new System.Drawing.Size(71, 53);
            this.lblWinnerComputer.TabIndex = 11;
            this.lblWinnerComputer.Text = "Vs";
            // 
            // lblDrawGame
            // 
            this.lblDrawGame.Appearance.Font = new System.Drawing.Font("Lato Black", 10F, System.Drawing.FontStyle.Bold);
            this.lblDrawGame.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDrawGame.Appearance.Options.UseFont = true;
            this.lblDrawGame.Appearance.Options.UseForeColor = true;
            this.lblDrawGame.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblDrawGame.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblDrawGame.LineVisible = true;
            this.lblDrawGame.Location = new System.Drawing.Point(417, 296);
            this.lblDrawGame.Margin = new System.Windows.Forms.Padding(4);
            this.lblDrawGame.Name = "lblDrawGame";
            this.lblDrawGame.Size = new System.Drawing.Size(0, 24);
            this.lblDrawGame.TabIndex = 12;
            // 
            // lblRouunds
            // 
            this.lblRouunds.Appearance.Font = new System.Drawing.Font("Algerian", 13F, System.Drawing.FontStyle.Bold);
            this.lblRouunds.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblRouunds.Appearance.Options.UseFont = true;
            this.lblRouunds.Appearance.Options.UseForeColor = true;
            this.lblRouunds.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblRouunds.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lblRouunds.LineVisible = true;
            this.lblRouunds.Location = new System.Drawing.Point(417, 4);
            this.lblRouunds.Margin = new System.Windows.Forms.Padding(4);
            this.lblRouunds.Name = "lblRouunds";
            this.lblRouunds.Size = new System.Drawing.Size(0, 29);
            this.lblRouunds.TabIndex = 13;
            // 
            // PnlGame
            // 
            this.PnlGame.Controls.Add(this.labelPlayerName);
            this.PnlGame.Controls.Add(this.LablePlayerWin);
            this.PnlGame.Controls.Add(this.labeComputerWin);
            this.PnlGame.Controls.Add(this.labelComputer);
            this.PnlGame.Controls.Add(this.labelControl2);
            this.PnlGame.Controls.Add(this.labelControl1);
            this.PnlGame.Controls.Add(this.lblRouunds);
            this.PnlGame.Controls.Add(this.pb_computer);
            this.PnlGame.Controls.Add(this.lblDrawGame);
            this.PnlGame.Controls.Add(this.rdi_Rock);
            this.PnlGame.Controls.Add(this.rdi_Paper);
            this.PnlGame.Controls.Add(this.rdi_Siccer);
            this.PnlGame.Controls.Add(this.btnStart);
            this.PnlGame.Controls.Add(this.pb_player);
            this.PnlGame.Controls.Add(this.lableControl1);
            this.PnlGame.Location = new System.Drawing.Point(21, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(973, 603);
            this.PnlGame.TabIndex = 14;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold);
            this.labelPlayerName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlayerName.Appearance.Options.UseFont = true;
            this.labelPlayerName.Appearance.Options.UseForeColor = true;
            this.labelPlayerName.Location = new System.Drawing.Point(82, 480);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(294, 39);
            this.labelPlayerName.TabIndex = 18;
            this.labelPlayerName.Text = "Computer";
            // 
            // LablePlayerWin
            // 
            this.LablePlayerWin.Appearance.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Bold);
            this.LablePlayerWin.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.LablePlayerWin.Appearance.Options.UseFont = true;
            this.LablePlayerWin.Appearance.Options.UseForeColor = true;
            this.LablePlayerWin.Location = new System.Drawing.Point(82, 525);
            this.LablePlayerWin.Name = "LablePlayerWin";
            this.LablePlayerWin.Size = new System.Drawing.Size(0, 40);
            this.LablePlayerWin.TabIndex = 17;
            // 
            // labeComputerWin
            // 
            this.labeComputerWin.Appearance.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Bold);
            this.labeComputerWin.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.labeComputerWin.Appearance.Options.UseFont = true;
            this.labeComputerWin.Appearance.Options.UseForeColor = true;
            this.labeComputerWin.Location = new System.Drawing.Point(619, 525);
            this.labeComputerWin.Name = "labeComputerWin";
            this.labeComputerWin.Size = new System.Drawing.Size(0, 40);
            this.labeComputerWin.TabIndex = 16;
            // 
            // labelComputer
            // 
            this.labelComputer.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold);
            this.labelComputer.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelComputer.Appearance.Options.UseFont = true;
            this.labelComputer.Appearance.Options.UseForeColor = true;
            this.labelComputer.Location = new System.Drawing.Point(619, 480);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(294, 39);
            this.labelComputer.TabIndex = 15;
            this.labelComputer.Text = "Computer";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(82, 499);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 39);
            this.labelControl2.TabIndex = 14;
            // 
            // pb_computer
            // 
            this.pb_computer.Location = new System.Drawing.Point(630, 263);
            this.pb_computer.Name = "pb_computer";
            this.pb_computer.Size = new System.Drawing.Size(262, 194);
            this.pb_computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_computer.TabIndex = 5;
            this.pb_computer.TabStop = false;
            // 
            // pb_player
            // 
            this.pb_player.Image = global::RockSiccorPaperGames.Properties.Resources.stone;
            this.pb_player.Location = new System.Drawing.Point(93, 263);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(262, 194);
            this.pb_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_player.TabIndex = 4;
            this.pb_player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 622);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.lblWinnerComputer);
            this.Controls.Add(this.lblWinnerPlayer);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.labelControl3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RockSiccorPaper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_computer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rdi_Rock;
        private System.Windows.Forms.RadioButton rdi_Paper;
        private System.Windows.Forms.RadioButton rdi_Siccer;
        private System.Windows.Forms.PictureBox pb_player;
        private System.Windows.Forms.PictureBox pb_computer;
        private DevExpress.XtraEditors.LabelControl lableControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrChangeImage;
        private System.Windows.Forms.ImageList imgList;
        private DevExpress.XtraEditors.LabelControl lblWinnerPlayer;
        private DevExpress.XtraEditors.LabelControl lblWinnerComputer;
        private DevExpress.XtraEditors.LabelControl lblDrawGame;
        private DevExpress.XtraEditors.NumericRangeControlClient numericRangeControlClient1;
        private DevExpress.XtraEditors.LabelControl lblRouunds;
        private System.Windows.Forms.Panel PnlGame;
        private DevExpress.XtraEditors.LabelControl labeComputerWin;
        private DevExpress.XtraEditors.LabelControl labelComputer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelPlayerName;
        private DevExpress.XtraEditors.LabelControl LablePlayerWin;
    }
}

