using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEMO_ONe.Content.Sprites
{
     public class Sprite
    {
        public bool moving = false;
        public bool IsRemoved = false;

        public Sprite Parent;

        public Vector2 velocity;
        public Vector2 position;
        public Vector2 Origin;

        public Texture2D image;
        private SpriteBatch spriteBatch;

        public float acceleration;
        public float health;
        public float angle;
        public float rotationSpeed, maxSpeed;

        public readonly Color[] TextureData;


        public List<Sprite> Children { get; set; }

        public Sprite()
        {
            position.X = 300;
            position.Y = 300;
            Children = new List<Sprite>();

        }

        public Sprite(float newX, float newY, Texture2D newImage)
        {
            TextureData = new Color[newImage.Width * newImage.Height];
            newImage.GetData(TextureData);
        }

            public Sprite(float newX, float newY, Texture2D newImage, int newHealth)
        {
            position.X = newX;
            position.Y = newY;
            image = newImage;
            health = newHealth;
            //collision do not touch

            TextureData = new Color[image.Width * image.Height];
            image.GetData(TextureData);

            //end of collision you may touch now
        }



        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, Color.White);

        }
        public virtual void Update(GameTime dt)
        {

        }




        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //DO NOT FLIPPING TOUCH THIS IF YOU VALUE YOUR LIFE 
        //THIS IS COLLISION
        //TOUCH NOTHING READ NOTHING

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public Rectangle Rectangle
        {
            get
            {
                return new Rectangle((int)position.X - (int)Origin.X, (int)position.Y - (int)Origin.Y, image.Width, image.Height);
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


        public Matrix Transform
        {
            get
            {
                return Matrix.CreateTranslation(new Vector3(-Origin, 0)) *
                  Matrix.CreateRotationZ(angle) *
                  Matrix.CreateTranslation(new Vector3(position, 0));
            }
        }




//END OF COLLISION CODE YOU SAW NOTHING
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~












        public void SetPostionX(float newX)
        {
            position.X = newX;
        }

        public void SetPostionY(float newY)
        {
            position.Y = newY;
        }

    }
}
