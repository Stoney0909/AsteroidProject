using DEMO_ONe.Content.Players;

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content.States
{
    class PlayerState
    {
        Player player;
        Texture2D image;


       public PlayerState(float newX , float newY ,Texture2D newimage)
        {
            
            Player player = new Player(newX, newY, image, 100);
        }



    }
}
