using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace MyGame
{
    internal class MovingBackground
    {
        private const float Speed = 0.3f;
        
        private readonly Sprite background = new();
        public MovingBackground(Vector2f pos)
        {
            background.Texture = Game.GetTexture("background.png");
            background.Position = new Vector2f(300, 400);
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(background);
        }
        public override void Update(Time elapsed)
        {
            int Elapsed = elapsed.AsMilliseconds();
            Vector2f pos = background.Position;
            float x = pos.X;
            float y = pos.Y;

            if (Keyboard.IsKeyPressed(Keyboard.Key.Left)) { x -= Speed * Elapsed; }
            if (Keyboard.IsKeyPressed(Keyboard.Key.Right)) { x += Speed * Elapsed; }
            background.Position = new Vector2f(pos.X - Speed * Elapsed, pos.Y);
        }
    }
}
