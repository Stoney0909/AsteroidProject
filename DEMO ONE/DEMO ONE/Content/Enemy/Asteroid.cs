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
        LinearMover movement = new LinearMover();
        public float rotation;
        public int Size;

        public Asteroid()
        {

        }

        public Asteroid(float newX, float newY,int newSize, int newAngle, Texture2D newImage)
            :base(newX,newY,newImage)
        {
            health = 1;
            rotationSpeed = .05f;
            maxSpeed = 15;
            position.X = newX;
            position.Y = newY;
            image = newImage;
        }

        public Asteroid(Texture2D newImage)
        {
            image = newImage;

        }

        public override void Update(GameTime gameTime)
        {
            movement.Move(this, gameTime);




            Origin.X = image.Width / (2);
            Origin.Y = image.Height / (2);


            rotation += rotationSpeed;
                //position.X += velocity.X;
                //position.Y += velocity.Y;


            position.X += velocity.X;
            position.Y += velocity.Y;


        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, new Rectangle(0, 0, image.Width, image.Height), Color.White, rotation, scale:new Vector2(3, 3), origin:Origin, effects:SpriteEffects.None, layerDepth:1);
        }

    }
}
