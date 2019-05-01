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

                projectile = new Projectile(player.position.X-(player.image.Width/player.animation.Columns), (player.position.Y-(player.image.Height/player.animation.Rows)), image, 10);


                projectile.Origin.X = (player.image.Width / (player.animation.Columns*13));
                projectile.Origin.Y = (player.image.Height / (player.animation.Rows*13));

                projectile.position = player.position - projectile.Origin;
                projectile.angle = player.angle;
                projectile.damage = player.damage;
                projectile.maxSpeed = player.maxSpeed * 3f;
                projectile.hit = false;
                projectile.radius = 15;
                Obj.Add(projectile);
            }

        }



        public void Update(Player player, Projectile projectile)
        {

        }
    }
}
