using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _74664Breakout
{

    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            levels.Hide();
            rules.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void menuStart_MouseHover(object sender, EventArgs e)
        {
            menuStart.Image = Properties.Resources.fixedStartHov1;
        }

        private void menuExit_MouseHover(object sender, EventArgs e)
        {
            menuExit.Image = Properties.Resources.fixedExitHov1;
        }

        private void menuStart_MouseLeave(object sender, EventArgs e)
        {
            menuStart.Image = Properties.Resources.fixedStart1;
        }

        private void menuExit_MouseLeave(object sender, EventArgs e)
        {
            menuExit.Image = Properties.Resources.fixedExit1;
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            levels.Show();
            menu.Hide();
            Title.Image = Properties.Resources.gameLevels;
        }


        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void levelsEasy_MouseHover(object sender, EventArgs e)
        {
            levelsEasy.Image = Properties.Resources.levelsEasyHov;
        }

        private void levelsMedium_MouseHover(object sender, EventArgs e)
        {
            levelsMedium.Image = Properties.Resources.levelsMediumHov;
        }

        private void levelsHard_MouseHover(object sender, EventArgs e)
        {
            levelsHard.Image = Properties.Resources.levelsHardHov;
        }

        private void levelsEasy_MouseLeave(object sender, EventArgs e)
        {
            levelsEasy.Image = Properties.Resources.levelsEasy;
        }

        private void levelsMedium_MouseLeave(object sender, EventArgs e)
        {
            levelsMedium.Image = Properties.Resources.levelsMedium;
        }

        private void levelsHard_MouseLeave(object sender, EventArgs e)
        {
            levelsHard.Image = Properties.Resources.levelsHard;
        }

        private void levelsEasy_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            level.hearts = 3;
            level.row = 3;
            level.col = 5;
            level.blocksWidth = 214;
            level.blocksHeight = 65;
            level.blocksWidthSpace = 25;
            level.blocksHeightSpace = 20;
            Game game = new Game(level);
            game.ShowDialog();
        }

        private void levelsMedium_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            level.hearts = 2;
            level.row = 5;
            level.col = 6;
            level.blocksWidth = 181;
            level.blocksHeight = 40;
            level.blocksWidthSpace = 17;
            level.blocksHeightSpace = 13;
            Game game = new Game(level);
            game.ShowDialog();
        }

        private void levelsHard_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            level.hearts = 1;
            level.row = 5;
            level.col = 10;
            level.blocksWidth = 100;
            level.blocksHeight = 35;
            level.blocksWidthSpace = 19;
            level.blocksHeightSpace = 10;
            Game game = new Game(level);
            game.ShowDialog();
        }

        private void levelsBack_MouseHover(object sender, EventArgs e)
        {
            levelsBack.Image = Properties.Resources.backHov;
        }

        private void levelsBack_MouseLeave(object sender, EventArgs e)
        {
            levelsBack.Image = Properties.Resources.back;
        }

        private void levelsBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            levels.Hide();
            Title.Image = Properties.Resources.gameTitle;
        }

        private void rulesBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            rules.Hide();
            Title.Image = Properties.Resources.gameTitle;
        }

        private void rulesBack_MouseHover(object sender, EventArgs e)
        {
            rulesBack.Image = Properties.Resources.backHov;
        }

        private void rulesBack_MouseLeave(object sender, EventArgs e)
        {
            rulesBack.Image = Properties.Resources.back;
        }

        private void menuRules_Click(object sender, EventArgs e)
        {
            menu.Hide();
            rules.Show();
            Title.Image = Properties.Resources.gameRules;
        }

        private void menuRules_MouseHover(object sender, EventArgs e)
        {
            menuRules.Image = Properties.Resources.fixedRulesHov;
        }

        private void menuRules_MouseLeave(object sender, EventArgs e)
        {
            menuRules.Image = Properties.Resources.fixedRules;
        }
    }

    public class Level
    {
        public int hearts;
        public int row;
        public int col;
        public int blocksWidth;
        public int blocksHeight;
        public int blocksWidthSpace;
        public int blocksHeightSpace;
    }
}
