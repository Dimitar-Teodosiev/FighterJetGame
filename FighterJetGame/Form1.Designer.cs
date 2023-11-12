namespace FighterJetGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            enemyOne = new PictureBox();
            enemyTwo = new PictureBox();
            enemyThree = new PictureBox();
            bullet = new PictureBox();
            player = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // enemyOne
            // 
            enemyOne.Image = Properties.Resources.enemy;
            enemyOne.Location = new Point(60, 54);
            enemyOne.Name = "enemyOne";
            enemyOne.Size = new Size(100, 85);
            enemyOne.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyOne.TabIndex = 0;
            enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            enemyTwo.Image = Properties.Resources.enemy;
            enemyTwo.Location = new Point(312, 54);
            enemyTwo.Name = "enemyTwo";
            enemyTwo.Size = new Size(100, 85);
            enemyTwo.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyTwo.TabIndex = 0;
            enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            enemyThree.Image = Properties.Resources.enemy;
            enemyThree.Location = new Point(585, 54);
            enemyThree.Name = "enemyThree";
            enemyThree.Size = new Size(100, 85);
            enemyThree.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyThree.TabIndex = 0;
            enemyThree.TabStop = false;
            // 
            // bullet
            // 
            bullet.Image = Properties.Resources.bullet;
            bullet.Location = new Point(357, 463);
            bullet.Name = "bullet";
            bullet.Size = new Size(7, 27);
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.TabIndex = 0;
            bullet.TabStop = false;
            bullet.Click += bullet_Click;
            // 
            // player
            // 
            player.Image = Properties.Resources.player;
            player.Location = new Point(302, 531);
            player.Name = "player";
            player.Size = new Size(110, 98);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(1, 160);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(704, 330);
            txtScore.TabIndex = 1;
            txtScore.Text = "0";
            txtScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvnt;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(704, 641);
            Controls.Add(player);
            Controls.Add(bullet);
            Controls.Add(enemyThree);
            Controls.Add(enemyTwo);
            Controls.Add(enemyOne);
            Controls.Add(txtScore);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Figher Jet Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)enemyOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox enemyOne;
        private PictureBox enemyTwo;
        private PictureBox enemyThree;
        private PictureBox bullet;
        private PictureBox player;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}