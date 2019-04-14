using DEMO_ONe.Content.Players;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content.Movement
{
    class Physics
    {


        public void Mover(Player player, bool[] Direction,GameTime gameTime)
        {
            // player.position.X = Math.Sin(player.angle)+(player.acceleration*);
            if (Direction[0] == true)
            {
                player.position.Y -= 100 * (gameTime.ElapsedGameTime.Milliseconds)/100;
            }
            if (Direction[1] == true)
            {
                player.position.X -= 100 * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
            if (Direction[2] == true)
            {
                player.position.X += 100 * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
            
        }
    }
}
