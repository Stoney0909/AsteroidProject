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
            player = new Player(newX, newY, newimage, newHealth, Rows, Columns);
        }
        


        public void Update(GameTime gameTime)
        {
            input.KeyDown(player,gameTime);

        }

        

        public Player GetPlayer()
        {
            return player;
        }
    }
}
