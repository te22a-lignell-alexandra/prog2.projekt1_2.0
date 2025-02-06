using Raylib_cs;
using System.Numerics;

public class Player : Character
{
    public Player(string imgR, string imgL, Rectangle rect) : base(imgR, imgL, rect){}

    public void Movement() //gör att spelaren kan röra sig höger/vänster
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

        rectangle.X += movement.X;
        rectangle.Y += movement.Y;
    }
}
