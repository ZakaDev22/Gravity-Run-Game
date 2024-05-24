namespace Gravity_Run_Game
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbHithScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbSpeed = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.pcplayyerButtun = new System.Windows.Forms.PictureBox();
            this.lbPlayerButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcplayyerButtun)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(-6, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(922, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Player.Image = global::Gravity_Run_Game.Properties.Resources.run_up0;
            this.Player.Location = new System.Drawing.Point(197, 43);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(59, 74);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Gravity_Run_Game.Properties.Resources.box;
            this.pictureBox4.Location = new System.Drawing.Point(402, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "obstacle";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Gravity_Run_Game.Properties.Resources.box;
            this.pictureBox5.Location = new System.Drawing.Point(665, 339);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "obstacle";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(12, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(88, 24);
            this.lbScore.TabIndex = 5;
            this.lbScore.Text = "Score: 0";
            // 
            // lbHithScore
            // 
            this.lbHithScore.AutoSize = true;
            this.lbHithScore.BackColor = System.Drawing.Color.Transparent;
            this.lbHithScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHithScore.ForeColor = System.Drawing.Color.White;
            this.lbHithScore.Location = new System.Drawing.Point(12, 423);
            this.lbHithScore.Name = "lbHithScore";
            this.lbHithScore.Size = new System.Drawing.Size(138, 24);
            this.lbHithScore.TabIndex = 6;
            this.lbHithScore.Text = "High Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpeed.ForeColor = System.Drawing.Color.White;
            this.lbSpeed.Location = new System.Drawing.Point(702, 423);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(105, 24);
            this.lbSpeed.TabIndex = 7;
            this.lbSpeed.Text = "Speed: x1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Gravity_Run_Game.Properties.Resources.b1;
            this.pictureBox3.Location = new System.Drawing.Point(597, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Beast";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.White;
            this.lbLevel.Location = new System.Drawing.Point(714, 9);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(83, 24);
            this.lbLevel.TabIndex = 9;
            this.lbLevel.Text = "Level: 1";
            // 
            // pcplayyerButtun
            // 
            this.pcplayyerButtun.BackColor = System.Drawing.Color.Transparent;
            this.pcplayyerButtun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcplayyerButtun.Image = global::Gravity_Run_Game.Properties.Resources.Papirus_Team_Papirus_Apps_Xt7_player_mpv_512;
            this.pcplayyerButtun.Location = new System.Drawing.Point(367, 180);
            this.pcplayyerButtun.Name = "pcplayyerButtun";
            this.pcplayyerButtun.Size = new System.Drawing.Size(103, 93);
            this.pcplayyerButtun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcplayyerButtun.TabIndex = 10;
            this.pcplayyerButtun.TabStop = false;
            // 
            // lbPlayerButton
            // 
            this.lbPlayerButton.AutoSize = true;
            this.lbPlayerButton.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayerButton.Font = new System.Drawing.Font("MS Gothic", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerButton.ForeColor = System.Drawing.Color.Yellow;
            this.lbPlayerButton.Location = new System.Drawing.Point(292, 289);
            this.lbPlayerButton.Name = "lbPlayerButton";
            this.lbPlayerButton.Size = new System.Drawing.Size(273, 19);
            this.lbPlayerButton.TabIndex = 11;
            this.lbPlayerButton.Text = "Click (P) Button To Play";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gravity_Run_Game.Properties.Resources.background_still;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 457);
            this.Controls.Add(this.lbPlayerButton);
            this.Controls.Add(this.pcplayyerButtun);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.lbHithScore);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Player);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GRAVITY RUN GAME";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcplayyerButtun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbHithScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.PictureBox pcplayyerButtun;
        private System.Windows.Forms.Label lbPlayerButton;
    }
}

