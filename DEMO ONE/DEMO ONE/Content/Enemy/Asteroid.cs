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
        public Rectangle sourceRectangle, destinationRectangle;

        public Asteroid()
        {

        }

        public Asteroid(float newX, float newY, Texture2D newImage)
            :base(newX,newY,newImage)
        {
            health = 1;
            rotationSpeed = .1f;
            maxSpeed = 5;
            position.X = newX;
            position.Y = newY;
            image = newImage;
            sourceRectangle = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
        }

        public Asteroid(Texture2D newImage)
        {
            image = newImage;
            sourceRectangle = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);

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
            spriteBatch.Draw(image, position, sourceRectangle, Color.White, rotation, Origin, 1.0f, SpriteEffects.None, 1);
        }

    }
}
