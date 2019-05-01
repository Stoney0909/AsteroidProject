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
        public bool keepPlaying = true;
        public double score;
        public double money;
        public PlayerState()
        {

        }


        public void Load(float newX , float newY,int Rows,int Columns,Texture2D newimage, int newHealth)//constructor
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
        public void lose(string playername)//loads the end screen and closes the game
        {
            Save_Load playersave = new Save_Load(playername, GetPlayer().score);
            ENDGAME endGame = new ENDGAME(playersave);

            endGame.ShowDialog();
            keepPlaying = endGame.keepPlaying;
        }
        public bool Dead()//Checks to see if there is health left
        {
            if (player.health == 0)
            {
                return true;
            }
            return false;
        }
        public void CU()
        {
            player.money = money;
            player.PlayerUpgrade(money);
            money = player.money;
        }
    }
}
