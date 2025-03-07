﻿using GameEngine;
using SFML.Window;
using SFML.System;

namespace MyGame
{
    internal class GameScene : Scene
    {
        private int _lives = 3;
        private int _score;
        public GameScene()
        {
            Ship ship = new Ship();
            AddGameObject(ship);
            MeteorSpawner meteorSpawner = new MeteorSpawner();
            AddGameObject(meteorSpawner);

            Score score = new Score(new Vector2f(10.0f, 10.0f));
            AddGameObject(score);
        }
        public int GetScore()
        {
            return _score;
        }
        public void IncreasedScore()
        {
            ++_score;
        }
        public int GetLives()
        {
            return _lives;
        }
        public void DecreaseLives()
        {
            --_lives;

            if (_lives == 0)
            {
                GameOverScene gameOverScene= new GameOverScene(_score);
                Game.SetScene(gameOverScene);
            }
        }
    }
}