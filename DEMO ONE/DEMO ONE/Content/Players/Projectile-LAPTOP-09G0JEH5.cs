using DEMO_ONe.Content.Sprites;
//using DEMO_ONe.Content.

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace DEMO_ONe.Content.Players
{
    class Projectile : Sprite
    {
        public float angle;
        public int damage;

        public Projectile(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        { }

        public Projectile(Texture2D newImage)
        {
            image = newImage;
            health = 1;
        }

        public Projectile(float x = 0, float y = 0, float angle = 0, int fireRate = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float velX = 0, float velY = 0, float accelX = 0, float accelY = 0)
        {
            position.X = x;
            position.Y = y;
            this.angle = angle;
            image = newImage;
            this.damage = damage;
            velocity.Y = velY;
            velocity.X = velX;
        }

        public override void Update(GameTime gameTime)
        {
            position.X += velocity.X;//* (gameTime.ElapsedGameTime.Milliseconds / 100);
            position.Y += velocity.Y; //* (gameTime.ElapsedGameTime.Milliseconds / 100);
        }
    }
}