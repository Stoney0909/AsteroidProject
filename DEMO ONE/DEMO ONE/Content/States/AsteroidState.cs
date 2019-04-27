using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DEMO_ONe.Content;
using DEMO_ONe.Content.Enemy;
using DEMO_ONe.Content.Movement;
using DEMO_ONe.Content.Sprites;

namespace DEMO_ONe.Content.States
{
    class AsteroidState
    {
        Asteroid asteroid = new Asteroid();
        Rnd rnd = new Rnd();

        Texture2D[] AsteroidSize = new Texture2D[6];
        List<Asteroid> asteroids = new List<Asteroid> { };
        float asteroidPositionX, asteroidPositionY;

        int screenX, screenY, screenOffset;


        public AsteroidState()
        { }


        public AsteroidState(int newScreenX, int newScreenY, int newScreenOffset)
        {
            screenX = newScreenX;
            screenY = newScreenY;
            screenOffset = newScreenOffset;
        }



        public void Load(Texture2D newimage)
        {
            asteroid = new Asteroid(newimage);

        }

        public void Spawn()
        {
            float newAngle = rnd.Range(0, 360);//FIX ME
            int side = rnd.Range(0, 4);

            

            switch (side)
            {
                case 0:
                {
                    asteroidPositionX = -screenOffset;
                    asteroidPositionY = rnd.Range(-screenOffset, screenY + screenOffset);
                    break;
                }
                case 1:
                {
                    asteroidPositionX = screenX + screenOffset;
                    asteroidPositionY = rnd.Range(-screenOffset, screenY + screenOffset);
                    break;
                }
                case 2:
                {
                    asteroidPositionX = rnd.Range(-screenOffset, screenX + screenOffset);
                    asteroidPositionY = screenY - screenOffset;
                    break;
                }
                case 3:
                {
                    asteroidPositionX = rnd.Range(-screenOffset, screenX + screenOffset);
                    asteroidPositionY = -screenOffset;
                    break;
                }
                default:
                {
                    Console.WriteLine("Asteroid spawn out of range.");
                    break;
                }
            }

            Asteroid Asteroid = new Asteroid(300,300,asteroid.image);
            asteroid.angle = newAngle;
            asteroids.Add(Asteroid);
        }


        public void Update(GameTime gameTime)
        {
            //DELETE FROM LIST
            for (int i = 0; i < asteroids.Count; i++)
            {
                asteroids[i].Update(gameTime);
                asteroids[i].rotation += asteroids[i].rotationSpeed;
            }
        }



        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            for (int i = 0; i < asteroids.Count; i++)
            {

                spriteBatch.Draw(asteroids[i].image, asteroids[i].position, asteroids[i].sourceRectangle, Color.White, asteroids[i].rotation, asteroids[i].Origin, 1.0f, SpriteEffects.None, 1);

            }

        }

        public List<Sprite> GetSprite()
        {
            List<Sprite> sprites = new List<Sprite> { };

            foreach (var c in asteroids)
            {
                sprites.Add(c);
            }
            return sprites;
        }
    }
}