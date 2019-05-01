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
using Microsoft.Xna.Framework.Input;



namespace DEMO_ONe.Content.States
{
    class ProjectileState
    {
        //Projectile projectile = new Projectile();
        List<Projectile> lazer = new List<Projectile> { };

        MouseState newState;
        Projectile projectile;
        
        public Texture2D image;


        public void Load(Texture2D newimage)
        {
            image = newimage;
        }


        public void Spawn(Player player, List<Sprite> Obj, GameTime gameTime)
        {

            newState = Mouse.GetState();
            Console.WriteLine(player.position.X + " | " + player.position.Y + " | " + newState.X + " | " + newState.Y);

            if (player.Fire() == true)
            {

                projectile = new Projectile(player.position.X-(player.image.Width/player.animation.Columns), (player.position.Y-(player.image.Height/player.animation.Rows)), image, 1);


                projectile.Origin.X = (player.image.Width / (player.animation.Columns*13));
                projectile.Origin.Y = (player.image.Height / (player.animation.Rows*13));

                projectile.position = player.position - projectile.Origin;
                

                projectile.damage = player.damage;

                projectile.velocity.X = Convert.ToSingle(Math.Sin(player.angle)) * 25;
                projectile.velocity.Y = Convert.ToSingle(-Math.Cos(player.angle)) * 25;

                Obj.Add(projectile);
            }

        }



        public void Update(Player player, Projectile projectile)
        {
            //projectile.Origin.X = player.image.Width / (player.animation.Columns * 2);
            //projectile.Origin.Y = player.image.Height / (player.animation.Rows * 2);
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
