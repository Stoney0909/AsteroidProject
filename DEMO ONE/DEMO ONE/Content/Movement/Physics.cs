using DEMO_ONe.Content.Players;



using Microsoft.Xna.Framework;

using System;

namespace DEMO_ONe.Content.Movement
{
    class Physics
    {
        public void Mover(Player player, bool[] Direction,GameTime gameTime)
        {
            // player.position.X = Math.Sin(player.angle)+(player.acceleration*);
            if (Direction[0] == true)
            {

                player.velocity.X = 75*(Convert.ToSingle(Math.Sin(Convert.ToDouble(player.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);
                player.velocity.Y = -75*(Convert.ToSingle(Math.Cos(Convert.ToDouble(player.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);

                /*
                player.velocity.X += 75 * (Convert.ToSingle(Math.Sin(Convert.ToDouble(player.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);
                player.velocity.Y -= 75 * (Convert.ToSingle(Math.Cos(Convert.ToDouble(player.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);
                */

            }
            else
            {
                player.velocity.X = 0;
                player.velocity.Y = 0;
            }
            if (Direction[1] == true)
            {
                player.angle -= .6f * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
            if (Direction[2] == true)
            {
                player.angle += .6f * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
        }
    }
}
