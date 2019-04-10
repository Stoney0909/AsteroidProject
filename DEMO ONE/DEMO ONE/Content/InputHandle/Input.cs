using DEMO_ONe.Content.Physicss;
using DEMO_ONe.Content.Players;
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
                                       false };//RIGHT



        public Input()
        {}



        public void KeyDown(Player player)
        {
            newState = Mouse.GetState();

            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Console.WriteLine(Direction[0]);
                Direction[0] = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Direction[1] = true;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Direction[2] = true;
            }
            Console.WriteLine(Direction[0] + " | " + Direction[1] + " | " + Direction[2] + " | " + newState.X + " | " + newState.Y);
            Movement(player);
        }



        private void Movement(Player player)
        {
            physics.Mover(player, Direction);
            KeyUp();
        }



        private void KeyUp()
        {
            if (Keyboard.GetState().IsKeyUp(Keys.W))
            {
                Direction[0] = false;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.A))
            {
                Direction[1] = false;
            }
            if (Keyboard.GetState().IsKeyUp(Keys.D))
            {
                Direction[2] = false;
            }
        }


    }
}
