namespace FighterJetGame
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void mainGameTimerEvnt(object sender, EventArgs e)
        {
            txtScore.Text = score.ToString();

            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;

            if (enemyOne.Top > 680 || enemyTwo.Top > 680 || enemyThree.Top > 680)
            {
                gameOver();
            }

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 600)
            {
                player.Left += playerSpeed;
            }

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -450;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -450;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (score == 5)
            {
                enemySpeed = 7;
                playerSpeed = 13;
            }

            if (score == 15)
            {
                enemySpeed = 8;
                playerSpeed = 14;
            }

            if (score == 25)
            {
                enemySpeed = 9;
                playerSpeed = 15;
            }

            if (score == 45)
            {
                enemySpeed = 10;
                playerSpeed = 16;
            }

            if (score == 55)
            {
                enemySpeed = 11;
                playerSpeed = 17;
            }

            if (score == 65)
            {
                enemySpeed = 12;
                playerSpeed = 18;
            }

            if (score == 75)
            {
                enemySpeed = 13;
                playerSpeed = 19;
            }

            if (score == 85)
            {
                enemySpeed = 14;
                playerSpeed = 20;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;

            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;

            txtScore.Text = score.ToString();
        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text = Environment.NewLine + "Game Over !" + Environment.NewLine + "Press enter to play again.";

        }

        private void bullet_Click(object sender, EventArgs e)
        {

        }
    }
}