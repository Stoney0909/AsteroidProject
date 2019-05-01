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
        public LinearMover()
        {

        }

        public override void Move(Sprite obj, GameTime gameTime)
        {
            
            obj.velocity.X = (Convert.ToSingle(Math.Sin(Convert.ToDouble(obj.angle))) * obj.maxSpeed) * (gameTime.ElapsedGameTime.Milliseconds / 100.0f);
            obj.velocity.Y = -((Convert.ToSingle(Math.Cos(Convert.ToDouble(obj.angle))) * obj.maxSpeed) * (gameTime.ElapsedGameTime.Milliseconds / 100.0f));

        }
    }
}
