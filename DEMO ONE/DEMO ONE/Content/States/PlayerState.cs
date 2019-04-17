using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.Animations;
using DEMO_ONe.Content.InputHandle;

namespace DEMO_ONe.Content.States
{
    class PlayerState
    {
        Player player = new Player();
        Input input = new Input();

        Animation animation;
        Vector2 Origin;


        public PlayerState()
        { }



        public void Load(float newX , float newY,int Rows,int Columns,Texture2D newimage, int newHealth)
        {
            player = new Player(newX, newY, newimage, newHealth);
            animation = new Animation(newimage, Rows, Columns);
            Origin.X = player.image.Width / (animation.Columns * 2);
            
            Origin.Y = player.image.Height / (animation.Rows * 2);
        }
        


        public void Update(GameTime gameTime)
        {
            input.KeyDown(player,gameTime);

            if (player.velocity.X!=0 || player.velocity.Y !=0)
            {
                animation.Update(player,gameTime);
            }
            else
            {
                 animation.SetCurrentFrame(0);
            }

            player.Update(gameTime);
        }



        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {

            spriteBatch.Draw(player.image, animation.GetDestinationRectangle(player.position), animation.GetSourceRectangle(), Color.White, player.angle, Origin, SpriteEffects.None, 1);

        }



        public Sprite GetSprite()
        {
            return player;
        }
    }
}
