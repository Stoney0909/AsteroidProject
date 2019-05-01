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

        List<Texture2D> AsteroidSize = new List<Texture2D> { };

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
            AsteroidSize.Add(newimage);
        }

        public void Spawn()
        {

            int newAngle = rnd.Range(0, 360);//FIX ME
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

            int size = rnd.Range(0, AsteroidSize.Count);

            Asteroid Asteroid = new Asteroid(asteroidPositionX, asteroidPositionY, size, newAngle, AsteroidSize.ElementAt(size));
            asteroid.angle = newAngle;
            asteroids.Add(Asteroid);
        }


        public void Update(GameTime gameTime)
        {
            //DELETE FROM LIST

            asteroid.Update(gameTime);
            asteroid.rotation += asteroid.rotationSpeed;
            
        }



        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
                
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