using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Movement;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe.Content.States
{
    class ProjectileState
    {
        //Projectile projectile = new Projectile();
        List<Projectile> lazer = new List<Projectile> { };
        
        LinearMover linearMover;
        public Texture2D image;

        public void Load(Texture2D newimage)
        {
            image = newimage;
        }


        public void Spawn(Player player)
        {
            if (player.Fire() == true)
            {
                Projectile projectile = new Projectile(player.position.X, player.position.Y, image, 1);
                projectile.angle = player.angle;
                projectile.damage = player.damage;
                lazer.Add(projectile);
            }
            
        }

        public void Update(GameTime gameTime)
        {
            for (int i = 0; i < lazer.Count; i++)
            {
                lazer[i].health -= (gameTime.ElapsedGameTime.Milliseconds / 100.0f);
                if (lazer[i].health <= 0)
                {
                    lazer.RemoveAt(i);
                }
                lazer[i].Update(gameTime);
            }
        }
        public List<Sprite> GetSprite()
        {
            List<Sprite> sprites = new List<Sprite> { };

            foreach (var c in lazer)
            {
                sprites.Add(c);
            }
            return sprites;
        }

    }
}
