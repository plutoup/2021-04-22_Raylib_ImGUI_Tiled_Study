using System;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace _2021_04_22_Raylib_ImGUI_Tiled_Study
{
    public class program
    {
        public static void Main()
        {
            int width = GetScreenWidth();
            int height = GetScreenHeight();

            InitWindow(width, height, String.Empty);

            player PLAYER = new player();

            entity_manager.load_entities(player.global_position);

            ToggleFullscreen();

            SetTargetFPS(60);

            while(!WindowShouldClose())
            {
                BeginDrawing();
                ClearBackground(new Color(0x58, 0x6a, 0x6a, 0xff));
                entity_manager.draw_entities(PLAYER.camera_target["player one"], 0.0f, 1.0f);
                EndDrawing();
            }

            entity_manager.unload_entities();
            CloseWindow();
        }
    }
}