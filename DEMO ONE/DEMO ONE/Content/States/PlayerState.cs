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

        Animation animation;
        Input input = new Input();


        public PlayerState()
        {
        }



        public void Load(float newX , float newY,int Rows,int Columns,Texture2D newimage, int newHealth)
        {
            player = new Player(newX, newY, newimage, newHealth);
            animation = new Animation(newimage, Rows, Columns);
            
        }
        
        public void Update(GameTime gameTime)
        {
            input.KeyDown(player,gameTime);
            animation.Update(gameTime);
        }


        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {

            spriteBatch.Draw(player.image, animation.GetDestinationRectangle(player.position), animation.GetSourceRectangle(), Color.White);

        }


        public Sprite GetSprite()
        {
            return player;
        }
    }
}
