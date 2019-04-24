using DEMO_ONe.Content.Movement;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace DEMO_ONe.Content.InputHandle
{
    class Input
    {
        MouseState newState;
        
        Physics physics= new Physics();
        

        bool[] Direction = new bool[] {false,//UP
                                       false,//LEFT
                                       false};//RIGHT



        public Input()
        {}



        public void KeyDown(Player player,GameTime gameTime)
        {
            newState = Mouse.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Direction[0] = true;
                player.moving = true;
            }
            else
            {
                Direction[0] = false;
                player.moving = false;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Direction[1] = true;
            }
            else
            {
                Direction[1] = false;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Direction[2] = true;
            }
            else
            {
                Direction[2] = false;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                //TODO
                //ADD PROJECTILE FIRING HERE
                
            }
            Movement(player,gameTime);
        }



        private void Movement(Player player, GameTime gameTime)
        {
            physics.Mover(player, Direction, gameTime);
        }
    }
}
