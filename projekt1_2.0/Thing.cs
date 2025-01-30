using Raylib_cs;

public class Thing
{
    public Thing(float x, float y, float b, float h)
    {
        Rectangle rect = new Rectangle(new(x,y), b, h);
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
