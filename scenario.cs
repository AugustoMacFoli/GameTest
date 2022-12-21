using GameTest.Model;

namespace GameTest
{
    public partial class scenario : Form
    {
        private readonly int gravity = 5;
        private Player player = new Player();
        private Queue<Control> trash = new Queue<Control>();

        public scenario()
        {
            InitializeComponent();
        }

        private void scenario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                jump();

            if (e.KeyCode == Keys.Left)
                moveLeft();

            if (e.KeyCode == Keys.Right)
                moveRight();

            if (e.KeyCode == Keys.Space)
                shoot();

            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void moveLeft()
        {
            if (playerControl.Bounds.Left - player.playerHorizontalSpeed >= floor.Bounds.Left)
            {
                playerControl.Left -= player.playerHorizontalSpeed;
            }
        }

        private void moveRight()
        {
            if (playerControl.Bounds.Right + player.playerHorizontalSpeed <= floor.Bounds.Right)
            {
                playerControl.Left += player.playerHorizontalSpeed;
            }
        }

        private void jump()
        {
            if (floor.Bounds.IntersectsWith(playerControl.Bounds))
            {
                player.Jump();
            }
        }

        private void shoot()
        {
            var bullet = new Panel();
            bullet.Width = 5;
            bullet.Height = 5;
            bullet.Top = playerControl.Top + 25;
            bullet.Left = playerControl.Left + 50;
            bullet.BackColor = Color.Red;
            bullet.Tag = "bullet";
            Controls.Add(bullet);
            labelShootCountValue.Text = (Convert.ToInt32(labelShootCountValue.Text) + 1).ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            handleJump();
            handleGravity();
            handleBullets();
            cleanScenario();
        }

        private void handleJump()
        {
            if (player.IsJumping())
                playerControl.Top -= player.playerJump.Dequeue();
        }

        private void handleGravity()
        {
            if (player.IsLanding() && !floor.Bounds.IntersectsWith(playerControl.Bounds))
                playerControl.Top += gravity;
        }

        private void handleBullets()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "bullet")
                    control.Left += player.bulletSpeed;

                if (control.Tag == "bullet" && control.Right >= ActiveForm.Right)
                    trash.Enqueue(control);
            }
        }

        private void cleanScenario()
        {
            while (trash.Any())
                Controls.Remove(trash.Dequeue());

            labelActiveBulletCountValue.Text =
                Controls.OfType<Panel>().Where(x => x.Tag == "bullet").Count().ToString();
        }
    }
}