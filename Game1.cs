using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace intro_to_monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D housesTexture;
        Texture2D patrickTexture;
        Texture2D spongebobTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            this.Window.Title = "My First Monogame Project";
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            housesTexture = Content.Load<Texture2D>("houses");
            patrickTexture = Content.Load<Texture2D>("patrick");
            spongebobTexture = Content.Load<Texture2D>("spongebob");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Azure);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(housesTexture, new Vector2(0,0), Color.White);
            _spriteBatch.End();


            _spriteBatch.Begin();
            _spriteBatch.Draw(patrickTexture, new Vector2(0,200), Color.White);
            _spriteBatch.End();

            _spriteBatch.Begin();
            _spriteBatch.Draw(spongebobTexture, new Vector2(450, 250), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
