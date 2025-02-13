using Raylib_cs;

public class Thing
{
    protected Rectangle rect;
    public Thing(Rectangle Rect)
    {
        rect = Rect;
    }

    public bool Collision(Rectangle characterRect, Rectangle rect)
    {
        if (Raylib.CheckCollisionRecs(characterRect, rect))
        {
            return true;
        }
        else return false;
    }

    public Rectangle GetRect()
    {
        return rect;
    }
}
