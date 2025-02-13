using Raylib_cs;

public class Wall : Thing
{
    public Wall(Rectangle Rect) : base(Rect){}

    public Rectangle Rectangle(){return rect;}
}
