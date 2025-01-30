using Raylib_cs;
using System.Numerics;


public class Character
{




    private Texture2D characterImageLeft = Raylib.LoadTexture("papillon.png");
    private Texture2D characterImageRight = Raylib.LoadTexture("papillon_right.png");
    private Rectangle characterRect = new Rectangle(64, 500, 64, 64);
    private Vector2 movement = new Vector2(0, 0);
    private float speed = 5;
    private bool isFacingRight = true;


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

        characterRect.X += movement.X;
        characterRect.Y += movement.Y;
    }

    

    public void DrawCharacter(Texture2D imgR, Texture2D imgL, Rectangle rect) //ritar karaktären höger och vänster beroende på vilket håll man går åt
    {
        if (isFacingRight)
        {
            Raylib.DrawTexture(imgR, (int)rect.X, (int)rect.Y, Color.White);
        }
        if (!isFacingRight)
        {
            Raylib.DrawTexture(imgL, (int)rect.X, (int)rect.Y, Color.White);
        }
    }
}
