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
        Texture2D[] AsteroidSize = new Texture2D[6];
        List<Sprite> Asteroids;
        Asteroid asteroid = new Asteroid();
        //Game1 Game = new Game1();
        Rnd rnd = new Rnd();
        int screenX;
        int screenY;
        int screenOffset;

        public AsteroidState(int newScreenX,int newScreenY, int newScreenOffset)
        {
            screenX = newScreenX;
            screenY = newScreenY;
            screenOffset = newScreenOffset;
        }

        public void Load(float newX, float newY, Texture2D newimage)
        {
            asteroid = new Asteroid(newX, newY, newimage);
        }

        void Update(GameTime gameTime)
        {
            asteroid.Update(gameTime);

            //TO DO
            /*for (int i = 0; i < Asteroids.Count(); i++)
            {
                    Asteroids[i].draw(gameTime, );
            }*/
        }
        
        void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < Asteroids.Count(); i++)
            {
                Asteroids[i].Draw(spriteBatch);
            }
        }

        void CollisionDetector()
        {
            //TO DO
            /*for (int i = 0; i < Asteroids.Count(); i++)
            {
                
            }*/
        }

        void Spawn()
        {
            Asteroid Asteroid = new Asteroid();
            Asteroid.image = AsteroidSize[5];
            Asteroid.angle = rnd.Range(0, 360);//FIX ME

            int side = rnd.Range(0, 4);

            switch (side)
            {
                case 0:
                    {
                        Asteroid.position.X = -screenOffset;
                        Asteroid.position.Y = rnd.Range(-screenOffset, screenY + screenOffset);
                        break;
                    }
                case 1:
                    {
                        Asteroid.position.X = screenX + screenOffset;
                        Asteroid.position.Y = rnd.Range(-screenOffset, screenY + screenOffset);
                        break;
                    }
                case 2:
                    {
                        Asteroid.position.X = rnd.Range(-screenOffset, screenX + screenOffset);
                        Asteroid.position.Y = screenY - screenOffset;
                        break;
                    }
                case 3:
                    {
                        Asteroid.position.X = rnd.Range(-screenOffset, screenX + screenOffset);
                        Asteroid.position.Y = -screenOffset;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Asteroid spawn out of range.");
                        break;
                    }
            }
        }
    }
}
