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
            this.player.Location = new System.Drawing.Point(348, 320);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 91);
            this.player.TabIndex = 1;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player);
            this.Controls.Add(this.floor);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "scenario";
            this.Text = "GameTest";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scenario_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel floor;
        private Panel player;
        private System.Windows.Forms.Timer gameTimer;
    }
}