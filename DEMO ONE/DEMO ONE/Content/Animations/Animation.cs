using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using DEMO_ONe.Content.Players;

namespace DEMO_ONe.Content.Animations
{
    public class Animation
    {

        //SET HOW THE IMAGES ARE CALCULATED
        public Texture2D image { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        //frames
        private int currentFrame;
        private int totalFrames;
        int column, row, height, width;

        //Slow Down Frame animation
        private int timeSinceLastFrame = 0;

        private int millisecondsPerFrame = 50;


        public Animation(Texture2D texture, int rows, int columns)
        {
            image = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = rows * columns;
        }

        public void Update(Player player,GameTime gameTime)
        {

            width = image.Width / Columns;
            height = image.Height / Rows;
            row = (int)((float)currentFrame / Columns);
            column = currentFrame % Columns;

            timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (timeSinceLastFrame > millisecondsPerFrame)
            {
                timeSinceLastFrame -= millisecondsPerFrame;

                timeSinceLastFrame = 0;

                //TODO
                //STOP ANIMATION WHEN NOT MOVING

                    currentFrame++;

                    if (currentFrame == totalFrames)
                    {
                        currentFrame = 0;
                    }
                
            }
        }

        public void SetCurrentFrame(int newCurrentFrame)
        {
            width = image.Width / Columns;
            height = image.Height / Rows;
            row = (int)((float)currentFrame / Columns);
            column = currentFrame % Columns;
            timeSinceLastFrame = 0;
            currentFrame = newCurrentFrame;
        }


        public Rectangle GetSourceRectangle()
        {
            Rectangle sourceRectangle =  new Rectangle(width * column, height * row, width, height);
            return sourceRectangle;
        }

        public Rectangle GetDestinationRectangle(Vector2 position)
        {
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);
            return destinationRectangle;
        }
            //spriteBatch.Draw(image, destinationRectangle, sourceRectangle, Color.White);
    }
}
