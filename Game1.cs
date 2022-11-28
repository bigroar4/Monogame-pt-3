using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_pt_3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D tribblegrerytexture, tribblebrowntexture, tribbleorangetexture, tribblecreamtexture;
        Rectangle greyrect, orangerect, brownrect, creamrect;
        Vector2 greySpeed,orangeSpeed,creamSpeed,brownSpeed;
        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            greyrect = new Rectangle(300, 10, 100, 100);
            greySpeed = new Vector2(0, 3);
            orangerect = new Rectangle(10, 300, 100, 100);
            orangeSpeed = new Vector2(3, 3);
            creamrect = new Rectangle(400, 300, 100, 100);
            creamSpeed = new Vector2(3, 3);
            brownrect = new Rectangle(400, 250, 100, 100);
            brownSpeed = new Vector2(3, 0);




            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);



            tribblegrerytexture = Content.Load<Texture2D>("tribblegrey");
            tribbleorangetexture = Content.Load<Texture2D>("tribbleorange");
            tribblecreamtexture = Content.Load<Texture2D>("tribblecream");
            tribblebrowntexture = Content.Load<Texture2D>("tribblebrown");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            greyrect.X += (int)greySpeed.X;
            if(greyrect.Right > _graphics.PreferredBackBufferWidth || greyrect.X < 0 )
                greySpeed.X *= -1;
            greyrect.Y += (int)greySpeed.Y;
            if (greyrect.Bottom > _graphics.PreferredBackBufferHeight || greyrect.Y < 0)
                greySpeed *= -1;
            base.Update(gameTime);
            orangerect.X += (int)orangeSpeed.X;
            if (orangerect.Right > _graphics.PreferredBackBufferWidth || orangerect.X < 0)
                orangeSpeed.X *= -1;
            orangerect.Y += (int)orangeSpeed.Y;
            if (orangerect.Bottom > _graphics.PreferredBackBufferHeight || orangerect.Y < 0)
                orangeSpeed *= -1;
            base.Update(gameTime);
            creamrect.X += (int)creamSpeed.X;
            if (creamrect.Right > _graphics.PreferredBackBufferWidth || creamrect.X < 0)
                creamSpeed.X *= -1;
            creamrect.Y += (int)creamSpeed.Y;
            if (creamrect.Bottom > _graphics.PreferredBackBufferHeight || creamrect.Y < 0)
                creamSpeed *= -1;
            base.Update(gameTime);
            brownrect.X += (int)brownSpeed.X;
            if (brownrect.Right > _graphics.PreferredBackBufferWidth || brownrect.X < 0)
                brownSpeed.X *= -1;
            brownrect.Y += (int)brownSpeed.Y;
            if (brownrect.Bottom > _graphics.PreferredBackBufferHeight || brownrect.Y < 0)
                brownSpeed *= -1;


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(tribblegrerytexture, greyrect, Color.White);
            _spriteBatch.Draw(tribbleorangetexture, orangerect, Color.White);
            _spriteBatch.Draw(tribblecreamtexture, creamrect, Color.White);
            _spriteBatch.Draw(tribblebrowntexture, brownrect, Color.White);






            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}