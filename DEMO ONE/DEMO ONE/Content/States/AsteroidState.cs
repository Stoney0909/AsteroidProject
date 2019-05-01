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

            int newAngle = rnd.Range(0, 360);
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
            int Asize;

            if (AsteroidSize.ElementAt(size).Name[0] == 'S')
            {
                Asize = 0;
            }
            else if (AsteroidSize.ElementAt(size).Name[0] == 'M')
            {
                Asize = 1;
            }
            else
            {
                Asize = 2;
            }

            asteroid = new Asteroid(asteroidPositionX, asteroidPositionY, Asize, newAngle, AsteroidSize.ElementAt(size));
            asteroid.radius = AsteroidSize.ElementAt(size).Height;
            asteroid.angle = newAngle;
            asteroids.Add(asteroid);
            
        }

        public void SpawnCheck(Asteroid obj, List<Sprite> objList)
        {
            if (obj.Size > 0)
            {
                Spawn(obj, objList);
            }
        }

        public void Spawn(Asteroid obj,List<Sprite>objList)
        {
            int newAngle = rnd.Range(0, 360);
            int size, size2;
            int Asize;

            if (obj.Size == 2)
            {
                size = rnd.Range(1, 2);
                size2 = rnd.Range(1, 2);
                Asize = 1;
            }
            else
            {
                size = rnd.Range(3, 6);
                size2 = rnd.Range(1, 2);
                Asize = 0;
            }

            asteroid = new Asteroid(obj.position.X, obj.position.Y, Asize, newAngle, AsteroidSize.ElementAt(size));
            asteroid.radius = AsteroidSize.ElementAt(size).Height;
            asteroid.angle = -obj.angle-15;

            objList.Add(asteroid);

            asteroid = new Asteroid(obj.position.X, obj.position.Y, Asize, newAngle, AsteroidSize.ElementAt(size2));
            asteroid.radius = AsteroidSize.ElementAt(size).Height;
            asteroid.angle = -obj.angle+15;

            objList.Add(asteroid);

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
            asteroids.Clear();
            return sprites;
        }
    }
}