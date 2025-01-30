using Raylib_cs;
using System.Numerics;

namespace projekt1
{
    public class Character
    {
        private Texture2D characterImageLeft = Raylib.LoadTexture("papillon.png");
        private Texture2D characterImageRight = Raylib.LoadTexture("papillon_right.png");
        private Rectangle characterRect = new Rectangle(0, 550, 64, 64);
        private Vector2 movement = new Vector2(0, 0);
        private float speed = 5;
        private bool isFacingRight = true;


        public void Movement()
        {
            movement = Vector2.Zero;

            if (Raylib.IsKeyDown(KeyboardKey.A))
            {
                movement.X = -1;
                isFacingRight = false;
            }
            if (Raylib.IsKeyDown(KeyboardKey.D))
            {
                movement.X = 1;
                isFacingRight = true;
            }
            if (movement.Length() > 0)
            {
                movement = Vector2.Normalize(movement) * speed;
            }

            characterRect.X += movement.X;
            characterRect.Y += movement.Y;
        }

        public void DrawCharacter()
        {
            if (isFacingRight)
            {
                Raylib.DrawTexture(characterImageRight, (int)characterRect.X, (int)characterRect.Y, Color.White);
            }
            if (!isFacingRight)
            {
                Raylib.DrawTexture(characterImageLeft, (int)characterRect.X, (int)characterRect.Y, Color.White);
            }
        }
    }
}