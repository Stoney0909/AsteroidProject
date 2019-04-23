using DEMO_ONe.Content.Sprites;

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content.Movement
{
    class LinearMover : ObjectMover
    {
        public override void Move(Sprite obj, GameTime gameTime)
        {
            //obj.position.X += obj.velocity * gameTime.ElapsedGameTime.Milliseconds;
        }
    }
}
