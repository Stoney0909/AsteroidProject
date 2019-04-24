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
        


        public PlayerState()
        { }


        public Matrix Transform
        {
            get
            {
                return Matrix.CreateTranslation(new Vector3(-player.Origin, 0)) * 
                    Matrix.CreateRotationZ(player.angle) *
                    Matrix.CreateTranslation(new Vector3(player.position, 0));
            }
        }





        public void Load(float newX , float newY,int Rows,int Columns,Texture2D newimage, int newHealth)
        {
            player = new Player(newX, newY, newimage, newHealth);
            animation = new Animation(newimage, Rows, Columns);
            player.Origin.X = player.image.Width / (animation.Columns * 2);
            
            player.Origin.Y = player.image.Height / (animation.Rows * 2);


        }
        


        public void Update(GameTime gameTime)
        {
            input.KeyDown(player,gameTime);

            if (player.moving)
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

            spriteBatch.Draw(player.image, animation.GetDestinationRectangle(player.position), animation.GetSourceRectangle(), Color.White, player.angle, player.Origin, SpriteEffects.None, 1);

        }



        public Sprite GetSprite()
        {
            return player;
        }
    }
}
