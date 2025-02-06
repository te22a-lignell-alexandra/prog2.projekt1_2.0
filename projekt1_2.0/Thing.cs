using Raylib_cs;

public class Thing
{
    public Thing(Rectangle Rect)
    {
        Rectangle rect = Rect;
    }

    public bool Collision(Rectangle characterRect, Rectangle rect)
    {
        if (Raylib.CheckCollisionRecs(characterRect, rect))
        {
            return true;
        }
        else return false;
    }
}
