using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Enemy;

namespace DEMO_ONe.Content.Level
{
    class Level
    {
        int totalAsteroids;

        public Level()
        {

        }

        //public


        public void SpawnAsteroid(List<Sprite> allObjects, int numAsteroids)
        {
            for (int i = 0; i < numAsteroids; i++)
            {
                Asteroid asteroid = new Asteroid();
                allObjects.Add(asteroid);
            }
        }



        public void Update(List<Sprite> allObjects)
        {
            int count = 0;
            for (int i = 1; i < allObjects.Count; i++)
            {
                if (allObjects[i] is Asteroid)
                    count++;
            }
            if (count == 0)
            {
                SpawnAsteroid(allObjects, 14);
            }
        }

        public void Draw(GraphicsDevice screen)
        {

        }
    }
}
