using DEMO_ONe.Content.Sprites;
//using DEMO_ONe.Content.

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace DEMO_ONe.Content.Players
{
    class Projectile : Sprite
    {
        public int damage;
        


        public Projectile(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        {
            velocity.X = 50;
            velocity.Y = 50;
            health = 5;
        }

        public Projectile(float x = 0, float y = 0, float angle = 0, int fireRate = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float vel = 0, float accelX = 0, float accelY = 0)
        {
            position.X = x;
            position.Y = y;
            this.angle = angle;
            image = newImage;
            this.damage = damage;
        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}