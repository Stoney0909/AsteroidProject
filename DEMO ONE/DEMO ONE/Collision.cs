﻿using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.States;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe
{
    class Collision
    {
        /*
        Sprite sprite;

        public Matrix Transform
        {
            get
            {
                return Matrix.CreateTranslation(new Vector3(-sprite.Origin, 0)) *
                  Matrix.CreateRotationZ(sprite.angle) *
                  Matrix.CreateTranslation(new Vector3(sprite.position, 0));
            }
        }
    

        public bool Intersects(Sprite sprite)
        {
            // Calculate a matrix which transforms from A's local space into
            // world space and then into B's local space
            var transformAToB = this.Transform * Matrix.Invert(sprite.Transform);

            // When a point moves in A's local space, it moves in B's local space with a
            // fixed direction and distance proportional to the movement in A.
            // This algorithm steps through A one pixel at a time along A's X and Y axes
            // Calculate the analogous steps in B:
            var stepX = Vector2.TransformNormal(Vector2.UnitX, transformAToB);
            var stepY = Vector2.TransformNormal(Vector2.UnitY, transformAToB);

            // Calculate the top left corner of A in B's local space
            // This variable will be reused to keep track of the start of each row
            var yPosInB = Vector2.Transform(Vector2.Zero, transformAToB);

            for (int yA = 0; yA < this.Rectangle.Height; yA++)
            {
                // Start at the beginning of the row
                var posInB = yPosInB;

                for (int xA = 0; xA < this.Rectangle.Width; xA++)
                {
                    // Round to the nearest pixel
                    var xB = (int)Math.Round(posInB.X);
                    var yB = (int)Math.Round(posInB.Y);

                    if (0 <= xB && xB < sprite.Rectangle.Width &&
                        0 <= yB && yB < sprite.Rectangle.Height)
                    {
                        // Get the colors of the overlapping pixels
                        var colourA = this.TextureData[xA + yA * this.Rectangle.Width];
                        var colourB = sprite.TextureData[xB + yB * sprite.Rectangle.Width];

                        // If both pixel are not completely transparent
                        if (colourA.A != 0 && colourB.A != 0)
                        {
                            return true;
                        }
                    }

                    // Move to the next pixel in the row
                    posInB += stepX;
                }

                // Move to the next row
                yPosInB += stepY;
            }

            // No intersection found
            return false;
        }

        public virtual void OnCollide(Sprite sprite)
        {

        }


    */
    }
}
