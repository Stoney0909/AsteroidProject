﻿using Microsoft.Xna.Framework;
using DEMO_ONe.Content.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content.Movement
{
    abstract class ObjectMover
    {
        public abstract void Move(Sprite obj, GameTime gameTime);
    }
}
