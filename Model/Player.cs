namespace GameTest.Model
{
    public class Player
    {
        public readonly int playerHorizontalSpeed = 20;
        public readonly int playerJumpSize = 10;
        public readonly int playerJumpSpeed = 10;
        public readonly int bulletSpeed = 100;
        public Queue<int> playerJump = new Queue<int>();

        public void Jump()
        {
            for (int i = 1; i < playerJumpSize; i++)
            {
                playerJump.Enqueue(playerJumpSpeed);
            }
        }

        public bool IsJumping()
        {
            return playerJump.Any();
        }

        public bool IsLanding()
        {
            return !playerJump.Any();
        }
    }
}
