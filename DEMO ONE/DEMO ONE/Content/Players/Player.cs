﻿using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Animations;
using DEMO_ONe.Content.Enemy;


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
        public string name;
        public int damage;
        public int coolDown;
        public int timer;
        public double score;
        public double money;
        public float speedUpRate, slowDownRate;
        public int level;

        public Animation animation;

        Projectile projectile = new Projectile();

        public Player(float newX, float newY, Texture2D newImage, int newHealth, int Rows, int Columns)
            : base(newX, newY, newImage, newHealth)
        {
            rotationSpeed = 0.6f;
            speedUpRate = 3.0f;
            slowDownRate = 0.5f;
            maxSpeed = 50;
            acceleration = 1;
            coolDown = 10;
            animation = new Animation(newImage, Rows, Columns);

            Origin.X = image.Width / (animation.Columns * 2);
            Origin.Y = image.Height / (animation.Rows * 2);
        }

        public Player(float x = 0, float y = 0, float angle = 0, int coolDown = 5000, Texture2D newImage = null, int damage = 0, float vel = 0, float accel = 1, int newlevel = 1)
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



        public override void SAFCCollision(Sprite sprite)
        {
            base.SAFCCollision(sprite);
        }







        public override void Update(GameTime gameTime)
        {

            position.X += velocity.X;
            position.Y += velocity.Y;


            if (moving)
            {
                animation.Update(this, gameTime);
            }
            else
            {
                animation.SetCurrentFrame(0);
            }


            Origin.X = image.Width / (animation.Columns * 2);
            Origin.Y = image.Height / (animation.Rows * 2);


            timer += 1;
        }



        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, animation.GetDestinationRectangle(position), animation.GetSourceRectangle(), Color.White, angle, Origin, SpriteEffects.None, 1);
            //spriteBatch.Draw(image, position, Color.White);
        }

        public bool Fire()
        {
            if (timer >= coolDown)
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

            CharacterUpgrade characterupgrade = new CharacterUpgrade(health, coolDown, money);//spawn in the charcter upgrade screen
            characterupgrade.ShowDialog();

            health = characterupgrade.health;// change this player stats
            coolDown = characterupgrade.coolDown;
            money = characterupgrade.money;

        }

    }
}
