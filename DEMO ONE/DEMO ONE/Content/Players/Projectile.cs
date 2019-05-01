﻿using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Movement;
//using DEMO_ONe.Content.

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using System;


namespace DEMO_ONe.Content.Players
{
    class Projectile : Sprite
    {
        public int damage;
        LinearMover movement = new LinearMover();
        float baseX, baseY;

        public Projectile(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        {
            baseX = newX;
            baseY = newY;
        }

        public Projectile(float x = 0, float y = 0, int fireRate = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float vel = 0, float accelX = 0, float accelY = 0)
        {
            position.X = x;
            position.Y = y;
            image = newImage;
            this.damage = damage;
        }






        public override void Update(GameTime gameTime)
        {
            health -= (gameTime.ElapsedGameTime.Milliseconds / 100.0f);
            if (health >= 0)
            {
                movement.Move(this, gameTime);
                position.X += velocity.X;
                position.Y += velocity.Y;
            }
     
        }

        public void setVel(float velX, float velY)
        {
            velocity.X = velX;
            velocity.Y = velY;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(image, new Rectangle((int)position.X, (int)position.Y, image.Width, image.Height), null, Color.White, angle, Origin, SpriteEffects.None, 0);
            spriteBatch.Draw(image, position, Color.White);
        }


    }
}
