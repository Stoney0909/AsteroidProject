using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEMO_ONe.Content.Sprites
{
    public class Sprite
    {
        protected Vector2 position;
        protected Texture2D image;
        protected float angle;
        private SpriteBatch spriteBatch;


        public Sprite()
        {
            position.X = 300;
            position.Y = 300;
        }
        public Sprite(float newX, float newY, Texture2D newImage)
        {
            position.X = newX;
            position.Y = newY;
            image = newImage;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, Color.White);
            
        }


    }
}
