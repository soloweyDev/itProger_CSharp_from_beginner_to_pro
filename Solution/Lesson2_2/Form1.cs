using System;
using System.Drawing;
using System.Windows.Forms;
/*
При нажатии на клавишу G сделайте паузу в игре.Когда игра находиться в паузе и пользователь нажимает на клавишу P, игра снова продолжается
с того же момента, где была остановлена.Дополнительно сделайте так, чтобы в паузе платформа и мяч были не видимы.
*/
namespace Lesson2_2
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
            loseLabel.Visible = false;
            loseLabel.Left = (background.Width / 2) - (loseLabel.Width / 2);
            loseLabel.Top = (background.Height / 2) - (loseLabel.Height / 2);
            pause.Left = (background.Width / 2) - (pause.Width / 2);
            pause.Top = (background.Height / 2) - (pause.Height / 2);
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
                case Keys.R:
                    gameBall.Top = 50;
                    gameBall.Left = 70;
                    speed_hor = 2;
                    speed_vertical = 2;
                    score = 0;
                    loseLabel.Visible = false;
                    timer.Enabled = true;
                    result.Text = "Результат: 0";
                    break;
                case Keys.G:
                    timer.Enabled = false;
                    pause.Visible = true;
                    gamePanel.Visible = false;
                    gameBall.Visible = false;
                    break;
                case Keys.P:
                    timer.Enabled = true;
                    pause.Visible = false;
                    gamePanel.Visible = true;
                    gameBall.Visible = true;
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
            {
                loseLabel.Visible = true;
                timer.Enabled = false;
            }

            if(gameBall.Bottom >= gamePanel.Top && gameBall.Bottom <= gamePanel.Bottom 
                && gameBall.Left >= gamePanel.Left && gameBall.Right <= gamePanel.Right)
            {
                speed_hor += 2;
                speed_vertical += 2;
                speed_vertical *= -1;
                score += 1;
                result.Text = "Результат: " + score.ToString();

                Random randColor = new Random();
                background.BackColor = Color.FromArgb(randColor.Next(150, 255), randColor.Next(150, 255), randColor.Next(150, 255));
            }
        }
    }
}