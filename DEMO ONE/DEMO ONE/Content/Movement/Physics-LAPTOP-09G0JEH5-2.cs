using DEMO_ONe.Content.States;
using DEMO_ONe.Content.Players;


using Microsoft.Xna.Framework;

using System;

namespace DEMO_ONe.Content.Movement
{
    class Physics
    {
        public void Mover(PlayerState player, bool[] Direction,GameTime gameTime)
        {
            Player ship = player.GetSprite();
            // player.position.X = Math.Sin(player.angle)+(player.acceleration*);
            if (Direction[0] == true)
            {

                ship.velocity.X = 75*(Convert.ToSingle(Math.Sin(Convert.ToDouble(ship.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);
                ship.velocity.Y = -75*(Convert.ToSingle(Math.Cos(Convert.ToDouble(ship.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);

                /*
                player.velocity.X += 75 * (Convert.ToSingle(Math.Sin(Convert.ToDouble(player.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);
                player.velocity.Y -= 75 * (Convert.ToSingle(Math.Cos(Convert.ToDouble(player.angle))) * (gameTime.ElapsedGameTime.Milliseconds) / 100);
                */

            }
            else
            {
                ship.velocity.X = 0;
                ship.velocity.Y = 0;
            }
            if (Direction[1] == true)
            {
                ship.angle -= .6f * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
            if (Direction[2] == true)
            {
                ship.angle += .6f * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
        }
    }
}
