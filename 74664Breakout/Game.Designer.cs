
namespace _74664Breakout
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gamePlatform = new System.Windows.Forms.PictureBox();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.gameLives = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gamePlatform
            // 
            this.gamePlatform.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gamePlatform.Location = new System.Drawing.Point(487, 652);
            this.gamePlatform.Name = "gamePlatform";
            this.gamePlatform.Size = new System.Drawing.Size(200, 25);
            this.gamePlatform.TabIndex = 1;
            this.gamePlatform.TabStop = false;
            this.gamePlatform.Click += new System.EventHandler(this.gamePlatform_Click);
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Crimson;
            this.gameBall.Location = new System.Drawing.Point(573, 420);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(30, 30);
            this.gameBall.TabIndex = 0;
            this.gameBall.TabStop = false;
            // 
            // gameLives
            // 
            this.gameLives.AutoSize = true;
            this.gameLives.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameLives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameLives.Location = new System.Drawing.Point(12, 685);
            this.gameLives.Name = "gameLives";
            this.gameLives.Size = new System.Drawing.Size(0, 35);
            this.gameLives.TabIndex = 2;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.gameLives);
            this.Controls.Add(this.gamePlatform);
            this.Controls.Add(this.gameBall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.gamePlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox gamePlatform;
        private System.Windows.Forms.Label gameLives;
    }
}