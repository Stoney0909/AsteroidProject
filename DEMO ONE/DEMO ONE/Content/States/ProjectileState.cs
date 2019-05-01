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


        public void Spawn(Player player, List<Sprite> Obj, GameTime gameTime)
        {
            if (player.Fire() == true)
            {
                Projectile projectile = new Projectile(player.position.X, player.position.Y, image, 1);
                projectile.damage = player.damage;
                
                projectile.velocity.X = Convert.ToSingle(Math.Sin(player.angle)) * 10;
                projectile.velocity.Y = Convert.ToSingle(-Math.Cos(player.angle)) * 10;
                Obj.Add(projectile);
            }
            
        }

        /*
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
        */
    }
}
