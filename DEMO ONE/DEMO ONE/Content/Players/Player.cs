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
    public class Player : Sprite
    {
        public new double angle;
        public int damage;
        public int coolDown;
        public int fireRate;
        public Vector2 velocity;
        public Vector2 acceleration;
        public double score;
        public double money;


     

        public Player(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        { }
        
        public Player(float x = 0, float y = 0, double angle = 0, int fireRate = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float velX = 0, float velY = 0, float accelX = 0, float accelY = 0)
        {
            position.X = x;
            position.Y = y;
            this.fireRate = fireRate;
            this.coolDown = coolDown;
            this.angle = angle;
            image = newImage;
            this.damage = damage;
            velocity.Y = velY;
            velocity.X = velX;
            acceleration.X = accelX;
            acceleration.Y = accelY;
        }

        public override void Update(GameTime dt)
        {
            velocity.X = acceleration.X * dt.ElapsedGameTime.Milliseconds;
            velocity.Y = acceleration.Y * dt.ElapsedGameTime.Milliseconds;

            position.X = velocity.X * dt.ElapsedGameTime.Milliseconds;
            position.Y = velocity.Y * dt.ElapsedGameTime.Milliseconds;
        }






    }
}
