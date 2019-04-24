using DEMO_ONe.Content.States;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.Animations;
using DEMO_ONe.Content.Sprites;

using DEMO_ONe.Content.InputHandle;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace DEMO_ONe
{
    public class Game1 : Game
    {
        public const int ScreenX = 1200;
        public const int ScreenY = 800;
        public const int ScreenOffSet = 50;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        List<Sprite> Allobject= new List<Sprite> { };
        PlayerState ship = new PlayerState();
        Projectile projectile = new Projectile();



        public Game1()
        {
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

        public int GetScreenOffset()
        {
            return ScreenOffSet;
        }

        public int GetScreenX()
        {
            return ScreenX;
        }

        public int GetScreenY()
        {
            return ScreenY;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            
            //SHIP IMPIMINTATION
            Texture2D Ship = Content.Load<Texture2D>("Ship");
            ship.Load(300, 300, 2, 2, Ship, 100);
            //END SHIP IMP

            //Player Projectile
            Texture2D PlayerLazer = Content.Load<Texture2D>("PlayerProjectile");
            projectile.image = PlayerLazer;

            //ship.LoadProjectile(projectile);



            Sprite player = ship.GetSprite();
            LoadObjects(player);
        }

        void LoadObjects(Sprite Obj)
        {
            Allobject.Add(Obj);
        }


        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            ship.Update(gameTime);


            for (int i = 0; i < Allobject.Count; i++)
            {
                if (Allobject[i].position.X > ScreenX + ScreenOffSet)
                {
                    Allobject[i].position.X=-ScreenOffSet;
                }

                else if (Allobject[i].position.X < -ScreenOffSet)
                {
                    Allobject[i].position.X=ScreenX + ScreenOffSet;
                }

                if (Allobject[i].position.Y > ScreenY + ScreenOffSet)
                {
                    Allobject[i].position.Y=-ScreenOffSet;
                }
                else if (Allobject[i].position.Y < -ScreenOffSet)
                {
                    Allobject[i].position.Y=ScreenY + ScreenOffSet;
                }
            }

            base.Update(gameTime);
        }



        protected override void Draw(GameTime gameTime)
        {

            //makes the background a color
            GraphicsDevice.Clear(new Color(20, 24, 28, 255));
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;


            spriteBatch.Begin();

            ship.Draw(spriteBatch,gameTime);

            spriteBatch.End();

            base.Draw(gameTime);
        }



        protected override void UnloadContent()
        {

        }
    }
}
