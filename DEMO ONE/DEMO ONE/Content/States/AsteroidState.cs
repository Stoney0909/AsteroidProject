using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DEMO_ONe.Content;
using DEMO_ONe.Content.Physicss;
using DEMO_ONe.Content.Sprites;

namespace DEMO_ONe.Content.States
{
    class AsteroidState
    {
        Texture2D[] AsteroidSize = new Texture2D[6];
        List<Sprite> Asteroids;
        Asteroid Asteroid = new Asteroid();

        public AsteroidState()
        {
            
        }

        void Update()
        {
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
    }
}
