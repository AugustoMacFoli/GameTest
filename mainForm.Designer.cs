namespace GameTest
{
    partial class scenario
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
            this.components = new System.ComponentModel.Container();
            this.floor = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelShootCount = new System.Windows.Forms.Label();
            this.labelActiveBulletCount = new System.Windows.Forms.Label();
            this.labelShootCountValue = new System.Windows.Forms.Label();
            this.labelActiveBulletCountValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.floor.Location = new System.Drawing.Point(0, 411);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(803, 39);
            this.floor.TabIndex = 0;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.MediumBlue;
            this.player.Location = new System.Drawing.Point(102, 320);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 91);
            this.player.TabIndex = 1;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labelShootCount
            // 
            this.labelShootCount.AutoSize = true;
            this.labelShootCount.Location = new System.Drawing.Point(26, 23);
            this.labelShootCount.Name = "labelShootCount";
            this.labelShootCount.Size = new System.Drawing.Size(92, 20);
            this.labelShootCount.TabIndex = 2;
            this.labelShootCount.Text = "Shoot count:";
            // 
            // labelActiveBulletCount
            // 
            this.labelActiveBulletCount.AutoSize = true;
            this.labelActiveBulletCount.Location = new System.Drawing.Point(26, 57);
            this.labelActiveBulletCount.Name = "labelActiveBulletCount";
            this.labelActiveBulletCount.Size = new System.Drawing.Size(136, 20);
            this.labelActiveBulletCount.TabIndex = 3;
            this.labelActiveBulletCount.Text = "Active Bullet count:";
            // 
            // labelShootCountValue
            // 
            this.labelShootCountValue.AutoSize = true;
            this.labelShootCountValue.Location = new System.Drawing.Point(124, 23);
            this.labelShootCountValue.Name = "labelShootCountValue";
            this.labelShootCountValue.Size = new System.Drawing.Size(17, 20);
            this.labelShootCountValue.TabIndex = 4;
            this.labelShootCountValue.Text = "0";
            // 
            // labelActiveBulletCountValue
            // 
            this.labelActiveBulletCountValue.AutoSize = true;
            this.labelActiveBulletCountValue.Location = new System.Drawing.Point(168, 57);
            this.labelActiveBulletCountValue.Name = "labelActiveBulletCountValue";
            this.labelActiveBulletCountValue.Size = new System.Drawing.Size(17, 20);
            this.labelActiveBulletCountValue.TabIndex = 5;
            this.labelActiveBulletCountValue.Text = "0";
            // 
            // scenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelActiveBulletCountValue);
            this.Controls.Add(this.labelShootCountValue);
            this.Controls.Add(this.labelActiveBulletCount);
            this.Controls.Add(this.labelShootCount);
            this.Controls.Add(this.player);
            this.Controls.Add(this.floor);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scenario";
            this.Text = "GameTest";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scenario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel floor;
        private Panel player;
        private System.Windows.Forms.Timer gameTimer;
        private Label labelShootCount;
        private Label labelActiveBulletCount;
        private Label labelShootCountValue;
        private Label labelActiveBulletCountValue;
    }
}