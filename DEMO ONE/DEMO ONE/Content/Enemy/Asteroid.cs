using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Movement;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEMO_ONe.Content.Enemy
{
    class Asteroid : Sprite
    {
        Random rnd = new Random();
        LinearMover movement;

        public Asteroid()
        {
           health = 1;
           if (rnd.Next(0,1) == 1)
            {
                position.X = rnd.Next(0,1200);
                position.Y = 0;
            }
           position.X = 800;
           position.Y = 600;
           velocity.X = 15;
           velocity.Y = 15;
        }

        public Asteroid(float x, float y, Texture2D image)
        {
            this.position.X = x;
            this.position.Y = y;
            this.image = image;
        }

        public override void Update(GameTime gameTime)
        {
            movement.Move(this, gameTime);
             
        
            position.X += velocity.X;
            position.Y += velocity.Y;
        }


    }
}
