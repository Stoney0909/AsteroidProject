using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Movement;
using DEMO_ONe.Content.Enemy;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using System;


namespace DEMO_ONe.Content.Players
{
    class Projectile : Sprite
    {
        public int damage;
        LinearMover movement = new LinearMover();

        public Projectile(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        {

        }


        
        public override void SAFCCollision(Sprite sprite)
        {
            
            if (sprite is Asteroid)
            {
                double dx = (sprite.position.X  - this.position.X);
                double dy = (sprite.position.Y - this.position.Y);
                float distance = Convert.ToSingle(Math.Sqrt((dx * dx) + (dy * dy)));
                if (distance < this.radius)
                {
                    hit = true;
                    sprite.hit = true;
                }
            }
            else
                return;

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
        

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, Color.White);
        }
        public Projectile(float x = 0, float y = 0, int fireRate = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float vel = 0, float accelX = 0, float accelY = 0)
        {
            position.X = x;
            position.Y = y;
            image = newImage;
            this.damage = damage;
        }


    }
}
