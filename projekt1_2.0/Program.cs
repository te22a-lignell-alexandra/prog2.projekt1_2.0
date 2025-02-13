using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(1000, 800, "Game");
Raylib.SetTargetFPS(60);

Player player = new Player("papillon.png", "papillon_right.png", new Rectangle(64, 500, 64, 64));
Wall floor = new Wall(new Rectangle(0, 550, 1000, 30));

while (!Raylib.WindowShouldClose())
{
    player.Move();



    
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.SkyBlue);
    player.DrawCharacter();
    Raylib.DrawRectangleRec(new Rectangle(0, 559, 1000, 30), Color.Brown);

    Raylib.EndDrawing();

}