using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;

namespace MyGame
{
    internal class GameOverScene : Scene
    {
        public GameOverScene(int score)
        {
            GameOverMessage gameOverMessage = new GameOverMessage(score);
            AddGameObject(gameOverMessage);
        }
    }
}
