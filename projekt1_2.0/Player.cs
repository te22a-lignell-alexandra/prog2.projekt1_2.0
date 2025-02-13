using Raylib_cs;
using System.Net.Http.Headers;
using System.Numerics;

public class Player : Character, ILivingThing
{
    public Player(string imgR, string imgL, Rectangle rect) : base(imgR, imgL, rect){}
    private int jumpTimer = 0;
    private bool canJump = true;

    public void Move() //gör att spelaren kan röra sig höger/vänster
    {
        movement = Vector2.Zero;

        if (Raylib.IsKeyDown(KeyboardKey.A)) //gå åt vänster
        {
            movement.X = -1;
            isFacingRight = false;
        }
        if (Raylib.IsKeyDown(KeyboardKey.D)) //gå åt höger
        {
            movement.X = 1;
            isFacingRight = true;
        }

        if ((Raylib.IsKeyPressed(KeyboardKey.Space) || Raylib.IsKeyPressed(KeyboardKey.W)) && canJump == true)
        {
            jumpTimer = 30;
        }

        if (jumpTimer > 0)
        {
            movement.Y--;
            jumpTimer--;
            canJump = false;
        }

        if (jumpTimer == 0 && rectangle.Y < 500)
        {
            movement.Y++;
        }
        else if (canJump == false && rectangle.Y == 500)
        {
            canJump = true;
        }
        else if (rectangle.Y > 500)
        {
            rectangle.Y = 500;
        }

        if (movement.Length() > 0) //hastighet baserat på speed och samma hastighet oavset hur man rör sig
        {
            movement *= speed;
        }

        Console.WriteLine(rectangle.Y);

        rectangle.X += movement.X;
        rectangle.Y += movement.Y;
    }


    public void Attack()
    {

    }

    public void TakeDamage()
    {

    }
}
