using DEMO_ONe.Content.States;
using DEMO_ONe.Content.Players;

using DEMO_ONe.Content.InputHandle;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace DEMO_ONe
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Player player = new Player();

        Input input = new Input();
        public const int ScreenX = 1200;
        public const int ScreenY = 800;
        double timeSinceLastFrame;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            graphics.PreferredBackBufferWidth = ScreenX;
            graphics.PreferredBackBufferHeight = ScreenY;

            this.IsMouseVisible = true;
            graphics.ApplyChanges();
            base.Initialize();
        }



        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            var EnemyProjectile = Content.Load<Texture2D>("Ship");
            player = new Player(300,300,EnemyProjectile);

        }


        protected override void Update(GameTime gameTime)
        {
            timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            input.KeyDown(player);
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
         
            //makes the background a color
            GraphicsDevice.Clear(Color.DarkCyan);
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;


            spriteBatch.Begin();



            player.Draw(spriteBatch);



            spriteBatch.End();
            // test.Draw(GraphicsDevice);

            base.Draw(gameTime);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
    }
}
