
namespace _74664Breakout
{
    partial class mainMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.menu = new System.Windows.Forms.Panel();
            this.menuExit = new System.Windows.Forms.PictureBox();
            this.menuRules = new System.Windows.Forms.PictureBox();
            this.menuStart = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.PictureBox();
            this.levels = new System.Windows.Forms.Panel();
            this.levelsEasyShow = new System.Windows.Forms.PictureBox();
            this.levelsHardShow = new System.Windows.Forms.PictureBox();
            this.levelsMediumShow = new System.Windows.Forms.PictureBox();
            this.levelsHard = new System.Windows.Forms.PictureBox();
            this.levelsMedium = new System.Windows.Forms.PictureBox();
            this.levelsBack = new System.Windows.Forms.PictureBox();
            this.levelsEasy = new System.Windows.Forms.PictureBox();
            this.rules = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rulesBack = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.levels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelsEasyShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsHardShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsMediumShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsHard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsEasy)).BeginInit();
            this.rules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBack)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Controls.Add(this.menuExit);
            this.menu.Controls.Add(this.menuRules);
            this.menu.Controls.Add(this.menuStart);
            this.menu.Location = new System.Drawing.Point(0, 215);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1174, 600);
            this.menu.TabIndex = 2;
            // 
            // menuExit
            // 
            this.menuExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuExit.Image = global::_74664Breakout.Properties.Resources.fixedExit1;
            this.menuExit.Location = new System.Drawing.Point(350, 333);
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(500, 132);
            this.menuExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuExit.TabIndex = 6;
            this.menuExit.TabStop = false;
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            this.menuExit.MouseLeave += new System.EventHandler(this.menuExit_MouseLeave);
            this.menuExit.MouseHover += new System.EventHandler(this.menuExit_MouseHover);
            // 
            // menuRules
            // 
            this.menuRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuRules.Image = global::_74664Breakout.Properties.Resources.fixedRules;
            this.menuRules.Location = new System.Drawing.Point(350, 175);
            this.menuRules.Name = "menuRules";
            this.menuRules.Size = new System.Drawing.Size(500, 132);
            this.menuRules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuRules.TabIndex = 5;
            this.menuRules.TabStop = false;
            this.menuRules.Click += new System.EventHandler(this.menuRules_Click);
            this.menuRules.MouseLeave += new System.EventHandler(this.menuRules_MouseLeave);
            this.menuRules.MouseHover += new System.EventHandler(this.menuRules_MouseHover);
            // 
            // menuStart
            // 
            this.menuStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStart.Image = global::_74664Breakout.Properties.Resources.fixedStart1;
            this.menuStart.Location = new System.Drawing.Point(350, 17);
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(500, 132);
            this.menuStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuStart.TabIndex = 0;
            this.menuStart.TabStop = false;
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            this.menuStart.MouseLeave += new System.EventHandler(this.menuStart_MouseLeave);
            this.menuStart.MouseHover += new System.EventHandler(this.menuStart_MouseHover);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Image = global::_74664Breakout.Properties.Resources.gameTitle;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1174, 210);
            this.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Title.TabIndex = 3;
            this.Title.TabStop = false;
            // 
            // levels
            // 
            this.levels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.levels.BackColor = System.Drawing.Color.Transparent;
            this.levels.Controls.Add(this.levelsEasyShow);
            this.levels.Controls.Add(this.levelsHardShow);
            this.levels.Controls.Add(this.levelsMediumShow);
            this.levels.Controls.Add(this.levelsHard);
            this.levels.Controls.Add(this.levelsMedium);
            this.levels.Controls.Add(this.levelsBack);
            this.levels.Controls.Add(this.levelsEasy);
            this.levels.Location = new System.Drawing.Point(0, 215);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(1174, 600);
            this.levels.TabIndex = 4;
            // 
            // levelsEasyShow
            // 
            this.levelsEasyShow.Image = global::_74664Breakout.Properties.Resources.levelsEasyShow;
            this.levelsEasyShow.Location = new System.Drawing.Point(23, 127);
            this.levelsEasyShow.Name = "levelsEasyShow";
            this.levelsEasyShow.Size = new System.Drawing.Size(356, 190);
            this.levelsEasyShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsEasyShow.TabIndex = 12;
            this.levelsEasyShow.TabStop = false;
            // 
            // levelsHardShow
            // 
            this.levelsHardShow.Image = global::_74664Breakout.Properties.Resources.levelsHardShow;
            this.levelsHardShow.Location = new System.Drawing.Point(795, 127);
            this.levelsHardShow.Name = "levelsHardShow";
            this.levelsHardShow.Size = new System.Drawing.Size(356, 190);
            this.levelsHardShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsHardShow.TabIndex = 11;
            this.levelsHardShow.TabStop = false;
            // 
            // levelsMediumShow
            // 
            this.levelsMediumShow.Image = global::_74664Breakout.Properties.Resources.levelsMediumShow;
            this.levelsMediumShow.Location = new System.Drawing.Point(409, 127);
            this.levelsMediumShow.Name = "levelsMediumShow";
            this.levelsMediumShow.Size = new System.Drawing.Size(356, 190);
            this.levelsMediumShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsMediumShow.TabIndex = 10;
            this.levelsMediumShow.TabStop = false;
            // 
            // levelsHard
            // 
            this.levelsHard.Image = global::_74664Breakout.Properties.Resources.levelsHard;
            this.levelsHard.Location = new System.Drawing.Point(795, 17);
            this.levelsHard.Name = "levelsHard";
            this.levelsHard.Size = new System.Drawing.Size(356, 94);
            this.levelsHard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsHard.TabIndex = 8;
            this.levelsHard.TabStop = false;
            this.levelsHard.Click += new System.EventHandler(this.levelsHard_Click);
            this.levelsHard.MouseLeave += new System.EventHandler(this.levelsHard_MouseLeave);
            this.levelsHard.MouseHover += new System.EventHandler(this.levelsHard_MouseHover);
            // 
            // levelsMedium
            // 
            this.levelsMedium.Image = global::_74664Breakout.Properties.Resources.levelsMedium;
            this.levelsMedium.Location = new System.Drawing.Point(409, 17);
            this.levelsMedium.Name = "levelsMedium";
            this.levelsMedium.Size = new System.Drawing.Size(356, 94);
            this.levelsMedium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsMedium.TabIndex = 7;
            this.levelsMedium.TabStop = false;
            this.levelsMedium.Click += new System.EventHandler(this.levelsMedium_Click);
            this.levelsMedium.MouseLeave += new System.EventHandler(this.levelsMedium_MouseLeave);
            this.levelsMedium.MouseHover += new System.EventHandler(this.levelsMedium_MouseHover);
            // 
            // levelsBack
            // 
            this.levelsBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelsBack.Image = global::_74664Breakout.Properties.Resources.back;
            this.levelsBack.Location = new System.Drawing.Point(350, 333);
            this.levelsBack.Name = "levelsBack";
            this.levelsBack.Size = new System.Drawing.Size(500, 132);
            this.levelsBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsBack.TabIndex = 6;
            this.levelsBack.TabStop = false;
            this.levelsBack.Click += new System.EventHandler(this.levelsBack_Click);
            this.levelsBack.MouseLeave += new System.EventHandler(this.levelsBack_MouseLeave);
            this.levelsBack.MouseHover += new System.EventHandler(this.levelsBack_MouseHover);
            // 
            // levelsEasy
            // 
            this.levelsEasy.Image = ((System.Drawing.Image)(resources.GetObject("levelsEasy.Image")));
            this.levelsEasy.Location = new System.Drawing.Point(23, 17);
            this.levelsEasy.Name = "levelsEasy";
            this.levelsEasy.Size = new System.Drawing.Size(356, 94);
            this.levelsEasy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.levelsEasy.TabIndex = 0;
            this.levelsEasy.TabStop = false;
            this.levelsEasy.Click += new System.EventHandler(this.levelsEasy_Click);
            this.levelsEasy.MouseLeave += new System.EventHandler(this.levelsEasy_MouseLeave);
            this.levelsEasy.MouseHover += new System.EventHandler(this.levelsEasy_MouseHover);
            // 
            // rules
            // 
            this.rules.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rules.BackColor = System.Drawing.Color.Transparent;
            this.rules.Controls.Add(this.pictureBox1);
            this.rules.Controls.Add(this.rulesBack);
            this.rules.Location = new System.Drawing.Point(0, 215);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(1174, 600);
            this.rules.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_74664Breakout.Properties.Resources.rulesPic2;
            this.pictureBox1.Location = new System.Drawing.Point(242, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // rulesBack
            // 
            this.rulesBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesBack.Image = global::_74664Breakout.Properties.Resources.back;
            this.rulesBack.Location = new System.Drawing.Point(350, 333);
            this.rulesBack.Name = "rulesBack";
            this.rulesBack.Size = new System.Drawing.Size(500, 132);
            this.rulesBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rulesBack.TabIndex = 6;
            this.rulesBack.TabStop = false;
            this.rulesBack.Click += new System.EventHandler(this.rulesBack_Click);
            this.rulesBack.MouseLeave += new System.EventHandler(this.rulesBack_MouseLeave);
            this.rulesBack.MouseHover += new System.EventHandler(this.rulesBack_MouseHover);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = global::_74664Breakout.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.levels);
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.levels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelsEasyShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsHardShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsMediumShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsHard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelsEasy)).EndInit();
            this.rules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.PictureBox menuStart;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.PictureBox menuExit;
        private System.Windows.Forms.PictureBox menuRules;
        private System.Windows.Forms.Panel levels;
        private System.Windows.Forms.PictureBox levelsMedium;
        private System.Windows.Forms.PictureBox levelsBack;
        private System.Windows.Forms.PictureBox levelsEasy;
        private System.Windows.Forms.PictureBox levelsHard;
        private System.Windows.Forms.PictureBox levelsMediumShow;
        private System.Windows.Forms.PictureBox levelsHardShow;
        private System.Windows.Forms.PictureBox levelsEasyShow;
        private System.Windows.Forms.Panel rules;
        private System.Windows.Forms.PictureBox rulesBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

