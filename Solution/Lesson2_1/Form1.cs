using System;
using System.Windows.Forms;
/*
 Создайте функционал, который позволит перемещать игровую платформу при помощи клавиш - W, A, S и D. Платформа будет передвигаться
 влево-вправо при помощи A и D, при этом она не должна выходить за рамки окна программы. При нажатии на W и S, платформа должна
 передвигаться вверх-вниз.
 */
namespace Lesson2_1
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 2;
        private int speed_hor = 2;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamePanel.Top = background.Bottom - (background.Bottom / 10);
            gamePanel.Left = background.Right / 2;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.W:
                    gamePanel.Top -= 30;
                    if (gamePanel.Top < background.Top)
                        gamePanel.Top = background.Top;
                    break;
                case Keys.S:
                    gamePanel.Top += 30;
                    if (gamePanel.Bottom > background.Bottom)
                        gamePanel.Top = background.Bottom - gamePanel.Height;
                    break;
                case Keys.A:
                    gamePanel.Left -= 30;
                    if (gamePanel.Left < background.Left)
                        gamePanel.Left = background.Left;
                    break;
                case Keys.D:
                    gamePanel.Left += 30;
                    if (gamePanel.Right > background.Right)
                        gamePanel.Left = background.Right - gamePanel.Width;
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);

            gameBall.Left += speed_hor;
            gameBall.Top += speed_vertical;

            if (gameBall.Left <= background.Left)
                speed_hor *= -1;

            if (gameBall.Right >= background.Right)
                speed_hor *= -1;

            if (gameBall.Top <= background.Top)
                speed_vertical *= -1;

            if (gameBall.Bottom >= background.Bottom)
                timer.Enabled = false;

            if(gameBall.Bottom >= gamePanel.Top && gameBall.Bottom <= gamePanel.Bottom 
                && gameBall.Left >= gamePanel.Left && gameBall.Right <= gamePanel.Right)
            {
                speed_hor += 2;
                speed_vertical += 2;
                speed_vertical *= -1;
                score += 1;
            }
        }
    }
}
