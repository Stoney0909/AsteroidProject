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
        private SpriteBatch spriteBatch;
        int health;

        public Sprite()
        {
            position.X = 300;
            position.Y = 300;
        }
        public Sprite(float newX, float newY, Texture2D newImage, int newHealth)
        {
            position.X = newX;
            position.Y = newY;
            image = newImage;
            health = newHealth;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, Color.White);
            
        }


    }
}
