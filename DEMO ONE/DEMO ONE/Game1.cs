using DEMO_ONe.Content.States;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.Animations;
using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Enemy;
using DEMO_ONe.Content.Level;
using DEMO_ONe.Content.InputHandle;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;

using System;


namespace DEMO_ONe
{
    public class Game1 : Game
    {
        MouseState newState;

        public const int ScreenX = 1200;
        public const int ScreenY = 800;
        public const int ScreenOffSet = 50;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        bool onetime = true;

        List<Sprite> Allobject= new List<Sprite> { };

        PlayerState ship = new PlayerState();
        AsteroidState asteroid = new AsteroidState(ScreenX,ScreenY,ScreenOffSet);
        ProjectileState projectile = new ProjectileState();

        SpriteFont font;
        Level level = new Level();

        string playerName;
        public bool keepPlaying = true;

        public Game1(string playerName)
        {
            this.playerName = playerName;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }



        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = ScreenX;
            graphics.PreferredBackBufferHeight = ScreenY;
            this.IsMouseVisible = true;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            font = Content.Load<SpriteFont>("Score");

            //SHIP IMPIMINTATION
            Texture2D Ship = Content.Load<Texture2D>("ship");
            ship.Load(300, 300, 2, 2, Ship, 3);
            //END SHIP IMP

            //Player Projectile
            Texture2D PlayerLazer = Content.Load<Texture2D>("PlayerProjectile clone (5)");
            projectile.image = PlayerLazer;

            //loads astriod
            Texture2D LargeAstriod = Content.Load<Texture2D>("Large_Asteroid");
            Texture2D MediumAstriod1 = Content.Load<Texture2D>("Medium_Asteroid_1");
            Texture2D MediumAstriod2 = Content.Load<Texture2D>("Medium_Asteroid_2");
            Texture2D SmallAstriod1 = Content.Load<Texture2D>("Small_Asteroid_1");
            Texture2D SmallAstriod2 = Content.Load<Texture2D>("Small_Asteroid_2");
            Texture2D SmallAstriod3 = Content.Load<Texture2D>("Small_Asteroid_3");
            Texture2D SmallAstriod4 = Content.Load<Texture2D>("Small_Asteroid_4");

            asteroid.Load(LargeAstriod);//load pictures of asteroids
            asteroid.Load(MediumAstriod1);
            asteroid.Load(MediumAstriod2);
            asteroid.Load(SmallAstriod1);
            asteroid.Load(SmallAstriod2);
            asteroid.Load(SmallAstriod3);
            asteroid.Load(SmallAstriod4);

            for (int i = 0; i < 15; i++)
            {
                asteroid.Spawn();//spawn Asteroids
            }


            Allobject.Add(ship.GetPlayer());

            foreach (var obj in asteroid.GetSprite())
            {
                Allobject.Add(obj);
            }


        }



        public List<Sprite> GetAllobj()
        {
            return Allobject;
        }



        protected override void Update(GameTime gameTime)
        {
            //Reject code from input
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                projectile.Spawn(ship.GetPlayer(), Allobject, gameTime);

            }
            if (Keyboard.GetState().IsKeyDown(Keys.U))
            {
                ship.CU();
            }

            //Checks if ship is dead
            if (ship.Dead() && onetime)
            {
                keepPlaying = ship.keepPlaying;
                onetime = false;
                ship.lose(playerName);
                this.Exit();

            }



            newState = Mouse.GetState();




            //CHECKS COLLISON with player
            for (int i = 1; i < Allobject.Count; i++)
            {
                Allobject[0].SAFCCollision(Allobject[i]);
            }

            ship.Update(gameTime);

            //Checks if projectile did a thing
            for (int i = 1; i < Allobject.Count; i++)
            {
                for (int j = 0; j < Allobject.Count; j++)
                {
                    Allobject[i].SAFCCollision(Allobject[j]);
                }
            }

            //Deletes stuff
            for (int i = 0; i < Allobject.Count; i++)
            {
                if ((Allobject[i].hit == true || Allobject[i].health <=0))
                {
                    if (Allobject[i] is Player)
                    {
                        continue;
                    }
                    if (Allobject[i] is Asteroid)
                    {
                        ship.score += 10;
                        ship.money += 10;
                        asteroid.SpawnCheck(Allobject[i] as Asteroid, Allobject);
                    }
                        Allobject.RemoveAt(i);
                }
            }

            //CHECKS size of astriod




            //updates code
            for (int i = 0; i < Allobject.Count; i++)
            {
                Allobject[i].Update(gameTime);


                //LOOPS ALL OBJS
                if (Allobject[i].position.X > ScreenX + ScreenOffSet)
                {
                    Allobject[i].position.X = -ScreenOffSet;
                }

                else if (Allobject[i].position.X < -ScreenOffSet)
                {
                    Allobject[i].position.X = ScreenX + ScreenOffSet;
                }

                if (Allobject[i].position.Y > ScreenY + ScreenOffSet)
                {
                    Allobject[i].position.Y = -ScreenOffSet;
                }
                else if (Allobject[i].position.Y < -ScreenOffSet)
                {
                    Allobject[i].position.Y = ScreenY + ScreenOffSet;
                }

            }

            int count = 0;
            for (int i = 1; i < Allobject.Count; i++)//spawn more asteroids when there is none left
            {
                if (Allobject[i] is Asteroid)
                    count++;
            }
            if (count == 0)
            {

                    for (int i = 0; i < 15; i++)
                    {
                        asteroid.Spawn();//spawn Asteroids
                    }

                    foreach (var obj in asteroid.GetSprite())
                    {
                        Allobject.Add(obj);
                    }
            }

            base.Update(gameTime);
        }



        protected override void Draw(GameTime gameTime)
        {

            //makes the background a color
            GraphicsDevice.Clear(new Color(20, 24, 28, 255));



            spriteBatch.Begin();

            for (int i = 0; i < Allobject.Count; i++)
            {
                Allobject[i].Draw(spriteBatch);
            }

            spriteBatch.DrawString(font, "Score: " +Convert.ToString(ship.score), new Vector2(0, 0), Color.White);
            spriteBatch.DrawString(font, "Money: " + Convert.ToString(ship.money), new Vector2(0, 20), Color.White);
            spriteBatch.DrawString(font, "Lives: " + Convert.ToString(ship.GetPlayer().health), new Vector2(0, 40), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }



        protected override void UnloadContent()
        {

        }
    }
}
