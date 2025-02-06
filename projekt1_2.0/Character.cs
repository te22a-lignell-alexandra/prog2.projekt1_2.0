using Raylib_cs;
using System.Numerics;

public class Character
{
    protected Texture2D imageR;
    protected Texture2D imageL;
    protected Rectangle rectangle;
    public Character(string imgR, string imgL, Rectangle rect)
    {
        imageL = Raylib.LoadTexture(imgR);
        imageR = Raylib.LoadTexture(imgL);
        rectangle = rect;
    }
    protected Vector2 movement = new Vector2(0, 0);
    protected float speed = 5;
    protected bool isFacingRight = true;
    protected int hp;

    public void DrawCharacter() //ritar karaktären höger och vänster beroende på vilket håll man går åt
    {
        if (isFacingRight)
        {
            Raylib.DrawTexture(imageR, (int)rectangle.X, (int)rectangle.Y, Color.White);
        }
        if (!isFacingRight)
        {
            Raylib.DrawTexture(imageL, (int)rectangle.X, (int)rectangle.Y, Color.White);
        }
    }
}
