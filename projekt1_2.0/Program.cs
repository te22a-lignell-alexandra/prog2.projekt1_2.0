using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(1000, 800, "Game");
Raylib.SetTargetFPS(60);

Player player = new Player("papillon.png", "papillon_right.png", new Rectangle(64, 500, 64, 64));

while (!Raylib.WindowShouldClose())
{
    player.Movement();



    
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.SkyBlue);
    player.DrawCharacter();

    Raylib.EndDrawing();

}