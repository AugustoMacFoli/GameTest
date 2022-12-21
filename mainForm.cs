namespace GameTest
{
    public partial class scenario : Form
    {
        private readonly int gravity = 5;
        private readonly int playerHorizontalSpeed = 20;
        private readonly int playerJumpSize = 10;
        private readonly int playerJumpSpeed = 10;
        private Queue<int> playerJump = new Queue<int>();

        public scenario()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (playerJump.Any())
                player.Top -= playerJump.Dequeue();

            if (!playerJump.Any() && !floor.Bounds.IntersectsWith(player.Bounds))
                player.Top += gravity;
        }

        private void scenario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                if (!playerJump.Any())
                    for (int i = 1; i < playerJumpSize; i++)
                        playerJump.Enqueue(playerJumpSpeed);

            if (e.KeyCode == Keys.Left)
                player.Left -= playerHorizontalSpeed;

            if (e.KeyCode == Keys.Right)
                player.Left += playerHorizontalSpeed;
        }
    }
}