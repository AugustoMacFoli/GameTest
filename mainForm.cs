namespace GameTest
{
    public partial class scenario : Form
    {
        private readonly int gravity = 5;
        private readonly int playerHorizontalSpeed = 20;
        private readonly int playerJumpSize = 10;
        private readonly int playerJumpSpeed = 10;
        private readonly int bulletSpeed = 100;
        private Queue<int> playerJump = new Queue<int>();
        private Queue<Control> trash = new Queue<Control>();

        public scenario()
        {
            InitializeComponent();
        }

        private void scenario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                jump();

            if (e.KeyCode == Keys.Left)
                moveLeft();

            if (e.KeyCode == Keys.Right)
                moveRight();

            if (e.KeyCode == Keys.Enter)
                shoot();
        }

        private void moveLeft()
        {
            player.Left -= playerHorizontalSpeed;
        }

        private void moveRight()
        {
            player.Left += playerHorizontalSpeed;
        }

        private void jump()
        {
            if (!playerJump.Any() && floor.Bounds.IntersectsWith(player.Bounds))
            {
                for (int i = 1; i < playerJumpSize; i++)
                {
                    playerJump.Enqueue(playerJumpSpeed);
                }
            }
        }

        private void shoot()
        {
            var bullet = new Panel();
            bullet.Width = 5;
            bullet.Height = 5;
            bullet.Top = player.Top + 25;
            bullet.Left = player.Left + 50;
            bullet.BackColor = Color.Red;
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);
            this.labelShootCountValue.Text = (Convert.ToInt32(this.labelShootCountValue.Text) + 1).ToString();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            handleJump();
            handleGravity();
            handleBullets();
            handleTrash();
        }

        private void handleJump()
        {
            if (playerJump.Any())
                player.Top -= playerJump.Dequeue();
        }

        private void handleGravity()
        {
            if (!playerJump.Any() && !floor.Bounds.IntersectsWith(player.Bounds))
                player.Top += gravity;
        }

        private void handleBullets()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag == "bullet")
                    control.Left += bulletSpeed;

                if (control.Tag == "bullet" && control.Right >= scenario.ActiveForm.Right)
                    trash.Enqueue(control);
            }
        }

        private void handleTrash()
        {
            while (trash.Any())
            {
                this.Controls.Remove(trash.Dequeue());
            }
            labelActiveBulletCountValue.Text =
                this.Controls.OfType<Panel>().Where(x => x.Tag == "bullet").Count().ToString();
        }
    }
}