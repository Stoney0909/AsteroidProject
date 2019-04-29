using DEMO_ONe.Content.Players;



using Microsoft.Xna.Framework;

using System;

namespace DEMO_ONe.Content.Movement
{
    
    class Physics
    {
       
        public void Mover(Player player, bool[] Direction, GameTime gameTime)
        {

            double PlayerCosine = -Math.Cos(Convert.ToDouble(player.angle) * player.acceleration);
            double PlayerSin = -PlayerCosine + .707110678118;


            // player.position.X = Math.Sin(player.angle)+(player.acceleration*);
            if (Direction[0] == true)
            {
                //player.velocity.X = 1;
                //player.acceleration = 1;

                player.velocity.X = (Convert.ToSingle(PlayerSin) * (gameTime.ElapsedGameTime.Milliseconds /100.0f));
                player.velocity.Y = -(Convert.ToSingle(PlayerCosine) * (gameTime.ElapsedGameTime.Milliseconds /100.0f));

                if (player.acceleration > player.maxSpeed)
                {
                    //Sets max speed
                    player.acceleration = player.maxSpeed;
                }
                else
                {
                    //Accelerates the ship
                    player.acceleration += player.speedUpRate;
                }


            }
            //else slows down the ship
            else
            {
                //player.velocity.X = 0;
                if (player.acceleration != 5 && player.acceleration > 0)
                {
                    player.acceleration -= player.slowDownRate;
                }
                else
                {
                    player.acceleration = 0;
                }
            }


            //Console.WriteLine(player.acceleration + " | " + player.position.X + " | " + player.position.Y + " | "+ (gameTime.ElapsedGameTime.Milliseconds/100.0f));

            player.velocity.X = (Convert.ToSingle(Math.Sin(Convert.ToDouble(player.angle))) * player.acceleration)* (gameTime.ElapsedGameTime.Milliseconds / 100.0f);
            player.velocity.Y = -((Convert.ToSingle(Math.Cos(Convert.ToDouble(player.angle))) * player.acceleration)* (gameTime.ElapsedGameTime.Milliseconds / 100.0f));


            if (Direction[1] == true)
            {
                player.angle -= player.rotationSpeed * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }
            if (Direction[2] == true)
            {
                player.angle += player.rotationSpeed * (gameTime.ElapsedGameTime.Milliseconds) / 100;
            }

        }
    }
}
