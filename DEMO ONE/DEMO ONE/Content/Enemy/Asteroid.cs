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
        {
            health = 1;
            rotationSpeed = 10f;
            maxSpeed = 50;
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
            //movement.Move(this, gameTime);

            sourceRectangle = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
            destinationRectangle = new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height);
            Origin.X = image.Width / (2);
            Origin.Y = image.Height / (2);

            //position.X += velocity.X;
            //position.Y += velocity.Y;

            rotation += rotationSpeed;
            position.X += 5;
            position.Y += 5;
        }


        public override void Draw(SpriteBatch spriteBatch)
        {


            spriteBatch.Draw(image, destinationRectangle, sourceRectangle, Color.White, rotation, Origin, SpriteEffects.None, 1);



        }

    }
}
