using DEMO_ONe.Content.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEMO_ONe.Content.Players
{
     class Player : Sprite
    {
        public float angle;
        public int damage;
        public int coolDown;
        public int timer;
        public double score;
        public double money;
        public float maxVel;

        public Player(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        { }



        public Player(float x = 0, float y = 0, float angle = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float velX = 0, float velY = 0, float accelX = 0, float accelY = 0, float maxVel = 0)
        {
            position.X = x;
            position.Y = y;
            this.coolDown = coolDown;
            this.angle = angle;
            image = newImage;
            this.damage = damage;
            velocity.Y = velY;
            velocity.X = velX;
            acceleration.X = accelX;
            acceleration.Y = accelY;
            timer = 0;
            this.maxVel = maxVel;
        }

        public override void Update(GameTime gameTime)
        {
            //velocity.X = acceleration.X * dt.ElapsedGameTime.Milliseconds;
            //velocity.Y = acceleration.Y * dt.ElapsedGameTime.Milliseconds;

            position.X += velocity.X;//* (gameTime.ElapsedGameTime.Milliseconds / 100);
            position.Y += velocity.Y;//* (gameTime.ElapsedGameTime.Milliseconds / 100);

            timer += 1;
        }
        
        public bool Fire()
        {
            if(timer >= coolDown)
            {
                timer = 0; 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
