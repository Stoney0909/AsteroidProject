using DEMO_ONe.Content.States;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.Animations;
using DEMO_ONe.Content.Sprites;
using DEMO_ONe.Content.Enemy;

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

        List<Sprite> Allobject= new List<Sprite> { };

        PlayerState ship = new PlayerState();
        AsteroidState asteroid = new AsteroidState(ScreenX,ScreenY,ScreenOffSet);

        ProjectileState projectile = new ProjectileState();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }



        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = ScreenX;
            graphics.PreferredBackBufferHeight = ScreenY;
            Thread thread = new Thread(new ThreadStart(TestColide));
            thread.Start();
            this.IsMouseVisible = true;
            graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            

            //SHIP IMPIMINTATION
            Texture2D Ship = Content.Load<Texture2D>("ship");
            ship.Load(300, 300, 2, 2, Ship, 100);
            //END SHIP IMP

            //Player Projectile
            Texture2D PlayerLazer = Content.Load<Texture2D>("PlayerProjectile clone (5)");
            projectile.image = PlayerLazer;

            //loads astriod
            Texture2D delete = Content.Load<Texture2D>("dont");
            asteroid.Load(delete);
            asteroid.Spawn();




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
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            newState = Mouse.GetState();
            


            ship.Update(gameTime);

            //updates code
            for (int i = 0; i < Allobject.Count; i++)
            {
                if(Allobject.Count > 2)
                Console.WriteLine(Allobject[0].position.X + " | " + Allobject[0].position.Y + " | " +Allobject[2].position.X + " | " + Allobject[2].position.Y + " | "+ newState.X + " | " + newState.Y);

                Allobject[i].Update(gameTime);

                if (Allobject[i] is Projectile)
                {
                    projectile.Update(Allobject[0] as Player, Allobject[i] as Projectile);
                }

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


                /*if (Allobject[i] is Projectile)
                {
                    if (Allobject[i].health <= 0)
                    {
                        Allobject.RemoveAt(i);
                    }
                }
                */

            }

  

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                //System.Console.WriteLine(Allobject.Count);
                projectile.Spawn(ship.GetPlayer(),Allobject, gameTime);
                
            }

            

            base.Update(gameTime);
        }

        protected void TestColide()
        {
            //Collisiont system
            while (true)
            {
                for (int i = 1; i < Allobject.Count; i++)
                {
                    if (Allobject[0].Intersects(Allobject[i]))
                    {
                        Allobject[0].OnCollide(Allobject[i]);
                    }
                }
            }
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



            spriteBatch.End();

            base.Draw(gameTime);
        }



        protected override void UnloadContent()
        {

        }
    }
}
