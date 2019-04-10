using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEMO_ONe.Content
{
    class Asteroid : Sprite
    {
        public float velocity;
        public Texture2D image; // small, medium, or large

         public Asteroid()
         {
            health = 1;
            position.X = 800;
            position.Y = 600;
            velocity = 100;
         }

        public Asteroid(float x, float y, Texture2D image)
        {
            this.position.X = x;
            this.position.Y = y;
            this.image = image;
        }
    }
}
