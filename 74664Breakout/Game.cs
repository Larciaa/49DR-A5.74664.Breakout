using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _74664Breakout
{
    public partial class Game : Form
    {
        public int blocksCounting;
        public int ySpeed;
        public int xSpeed;
        public int invisibleBlocks = 0;
        public PictureBox[,] blocks;
        public Level level;
        Random random = new Random();
        public Point ballLocation = new Point(282, 200);
        public int hearts;
        public int blocksWidth;
        public int blocksHeight;
        public int blocksWidthSpace;
        public int blocksHeightSpace;
        public int row;
        public int col;

        public Game(Level level)
        {
            ySpeed = 2;
            xSpeed = 2;
            hearts = level.hearts;
            blocksWidth = level.blocksWidth;
            blocksHeight = level.blocksHeight;
            blocksWidthSpace = level.blocksWidthSpace;
            blocksHeightSpace = level.blocksHeightSpace;
            row = level.row;
            col = level.col;
            setBlocks();
            InitializeComponent();
           
        }
        private void setBlocks()
        {
            blocks = new PictureBox[row, col];
            
            for (int x=0; x < row; x++)
            {
                for ( int y=0; y < col; y++)
                {
                    blocks[x, y] = new PictureBox();
                    blocks[x, y].Width = blocksWidth;
                    blocks[x, y].Height = blocksHeight;
                    blocks[x, y].Top = (blocksHeight+blocksHeightSpace) * x;
                    blocks[x, y].Left = (blocksWidth+blocksWidthSpace) * y;
                    blocks[x, y].BackColor = Color.FromArgb(random.Next(100, 150), random.Next(100, 150), random.Next(225, 256));
                    blocks[x, y].BorderStyle = BorderStyle.FixedSingle;

                    this.Controls.Add(blocks[x, y]);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameLives.Text = "Lives: " +  hearts;
            gameBall.Top += ySpeed;
            gameBall.Left += xSpeed;
            if (gameBall.Bottom > this.ClientSize.Height)
            {
                ySpeed = -ySpeed;
            }
            if (gameBall.Top < 0)
            {
                ySpeed = -ySpeed;
            }
            if (gameBall.Right > this.ClientSize.Width)
            {
                xSpeed = -xSpeed;
            }
            if (gameBall.Left < 0)
            {
                xSpeed = -xSpeed;
            }
            if (gameBall.Bounds.IntersectsWith(gamePlatform.Bounds) == true)
            {   
                if (ySpeed < 0)
                {
                    xSpeed = -xSpeed;
                } 
                else
                {
                    if (xSpeed < 0)
                    {
                        ySpeed = -ySpeed;
                    }
                    else
                    {
                        xSpeed = -xSpeed;
                    }
                }

            }

            for (int x = 0; x < row; x++)
            {
                for (int y=0; y < col; y++)
                {
                    if (gameBall.Bounds.IntersectsWith(blocks[x, y].Bounds) && (blocks[x, y].Visible == true))
                    {
                        blocks[x, y].Visible = false;
                        ySpeed = -ySpeed;
                        invisibleBlocks++;
                        if (invisibleBlocks == (row*col))
                        {
                            gameOver();
                            MessageBox.Show("You are winner! Close game to continue.");
                        }
                    }
                }
            }
            if (gameBall.Top + gameBall.Height > ClientSize.Height)
            {
                hearts = hearts - 1;
                if (hearts == 0)
                {
                    gameLives.Text = "Lives: " + hearts;
                    gameOver();
                    MessageBox.Show("You lose! Close game to continue.");
                }
                else
                {
                    gameBall.Location = ballLocation;
                    ySpeed = -ySpeed;
                }
            }
        }

        private void game_MouseMove(object sender, MouseEventArgs e)
        {
            gamePlatform.Left = e.X - (gamePlatform.Width / 2);
        }

        private void gamePlatform_Click(object sender, EventArgs e)
        {

        }
        private void gameOver()
        {
            timer1.Stop();
            gamePlatform.Visible = false;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameOver();
        }
    }
}
