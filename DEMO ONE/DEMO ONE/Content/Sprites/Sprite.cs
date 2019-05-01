﻿using DEMO_ONe.Content.Enemy;
using DEMO_ONe.Content.Players;
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
        public bool moving = false;
        public bool hit = false;

        public Sprite Parent;
        public float radius;
        public Vector2 velocity;
        public Vector2 position;
        public Vector2 Origin;

        public Texture2D image;

        public float acceleration;
        public float health;
        public float angle;
        public float rotationSpeed, maxSpeed;
        

        

        public Sprite()
        {

        }

        public Sprite(float newX, float newY, Texture2D newImage)
        {

        }

        public Sprite(float newX, float newY, Texture2D newImage, int newHealth)
        {
            position.X = newX;
            position.Y = newY;
            image = newImage;
            health = newHealth;
        }

        public virtual void SAFCCollision(Sprite sprite)
        {
           /* if (sprite is Player || sprite is Projectile)
            {
                double dx = (sprite.position.X - this.position.X);
                double dy = (sprite.position.Y - this.position.Y);
                float distance = Convert.ToSingle(Math.Sqrt((dx * dx) + (dy * dy)));
                if (distance < this.radius)
                {
                    hit = true;
                    sprite.hit = true;
                }
            }
            else
                return;*/
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, Color.White);

        }
        public virtual void Update(GameTime gameTime)
        {

        }
        


        public void SetPostionX(float newX)
        {
            position.X = newX;
        }

        public void SetPostionY(float newY)
        {
            position.Y = newY;
        }

    }
}
