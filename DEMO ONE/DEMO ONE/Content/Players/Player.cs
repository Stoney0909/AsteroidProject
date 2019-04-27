using DEMO_ONe.Content.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DEMO_ONe.Content.Players
{
     public class Player : Sprite
    {
        public int damage;
        public int coolDown;
        public int timer;
        public double score;
        public double money;
        public float rotationSpeed, maxSpeed, speedUpRate, slowDownRate;
        public int level;
        Projectile projectile = new Projectile();


        public Player(float newX, float newY, Texture2D newImage, int newHealth)
            : base(newX, newY, newImage, newHealth)
        {
            rotationSpeed = 0.6f;
            speedUpRate = 3.0f;
            slowDownRate = 0.5f;
            maxSpeed = 50;
            acceleration = 1;
            

        }

        public Player(float x = 0, float y = 0, float angle = 0, int coolDown = 0, Texture2D newImage = null, int damage = 0, float vel = 0, float accel = 1, int newlevel = 1)
        {
            position.X = x;
            position.Y = y;
            this.coolDown = coolDown;
            this.angle = angle;
            image = newImage;
            this.damage = damage;
            //velocity = vel;
            //acceleration = accel;
            timer = 0;
            level = newlevel;
        }

        public override void Update(GameTime gameTime)
        {
            position.X += velocity.X;
            position.Y += velocity.Y;



            //position.X = velocity.X * acceleration.X * gameTime.ElapsedGameTime.Milliseconds;
            //position.Y = velocity.Y * acceleration.Y * gameTime.ElapsedGameTime.Milliseconds;

            //velocity.X *= acceleration.X * gameTime.ElapsedGameTime.Milliseconds;
            //velocity.Y *= acceleration.Y * gameTime.ElapsedGameTime.Milliseconds;


            //position.X += velocity.X;//* (gameTime.ElapsedGameTime.Milliseconds / 100);
            //position.Y += velocity.Y;//* (gameTime.ElapsedGameTime.Milliseconds / 100);

            timer += 1;
        }

        public bool Fire()
        {
            if(timer >= coolDown)
            {
                timer = 0;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PlayerUpgrade()
        {
            Player playercopy = new Player();//sends another player through
            playercopy.health = health;
            playercopy.damage = damage;
            playercopy.coolDown = coolDown;

            CU characterupgrade = new CU(playercopy);
            characterupgrade.ShowDialog();

            health = playercopy.health;// change this player stats
            damage = playercopy.damage;
            coolDown = playercopy.coolDown;
            //level++;
        }

        public Sprite Shoot()
        {
            var bullet = projectile.Clone() as Projectile;

            bullet.position.X = 300;
            bullet.position.Y = 300;
            bullet.Colour = Color.Yellow;
            bullet.Parent = this;

            //Children.Add(bullet);

            return this;
        }
    }
}
