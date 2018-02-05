using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using T_WIN_EpiBubble_2017.Classes;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace T_WIN_EpiBubble_2017
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        #region Variables
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private int number = 10;
        private const int windowWidth = 690;
        private const int windowHeight = 800;
        private Vector2 pointerLocation; // Location in the window for the launcher
        private Vector2 launcherLocation; // Location fixed for the launcher's spinning
        private Vector2 bubbleLocation;
        private Texture2D bubble, pizzaCat, pointText;
        private Arrow launcher;
        private Bubble munition, nextMunition;
        private Config carrow;
        private List<Color> colorBubble;
        private List<Bubble> oldBubbles;
        private List<Bubble> targetBubbles;
        private SpriteFont font, bigTitle;
        public static Int32 limitLeft = 0;
        // public static Int32 limitRight = 190;
        public static Int32 limitTop = 30;
        public static Int32 sizeBubble = 42;
        #endregion

        #region Game1()
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Window.Title = "EpiBoobs";

            colorBubble = new List<Color>
            {
                Color.Black,
                Color.Silver,
                Color.Gray,
                Color.White,
                Color.Maroon,
                Color.Red,
                Color.Purple,
                Color.Fuchsia,
                Color.Green,
                Color.Lime,
                Color.Yellow,
                Color.Blue,
                Color.Cyan
            };
        }
        #endregion

        #region protected override void Initialize()
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = windowWidth;    // Set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = windowHeight;  // Set this value to the desired height of your window
            graphics.ApplyChanges();
            
            pointerLocation = new Vector2(windowWidth / 2, windowHeight - 40); // New Vector with the middle of the window's width and window's height with 30px less
            bubbleLocation = new Vector2(pointerLocation.X - 20, pointerLocation.Y - 20);
            carrow = new Config("ArrowColor.txt");
            launcher = new Arrow(launcherLocation, carrow.ReadFile());
            newBubbleLauncher();
            oldBubbles = new List<Bubble>();
            targetBubbles = new List<Bubble>();
            
            base.Initialize();
        }
        #endregion

        #region protected override void LoadContent()
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Texture
            launcher.texture = Content.Load<Texture2D>("images/arrow");
            bubble = Content.Load<Texture2D>("images/bubble");
            pizzaCat = Content.Load<Texture2D>("images/pizzacat");
            pointText = Content.Load<Texture2D>("images/1x1");

            // Font
            font = Content.Load<SpriteFont>("font/NumberOfBubbles");
            bigTitle = Content.Load<SpriteFont>("font/BigText");
            
            launcherLocation = new Vector2(launcher.texture.Width / 2, launcher.texture.Height - 30);
            sizeBubble = bubble.Width;
        }
        #endregion

        #region protected override void UnloadContent()
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        #endregion

        #region protected override void Update(GameTime gameTime)
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == Microsoft.Xna.Framework.Input.ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Escape))
                Exit();

            /* // The launcher don't move correctly with the mouse
            MouseState mouse = Mouse.GetState();
            mousePosition = new Vector2(mouse.X, mouse.Y);

            Vector2 direction = mousePosition - launcher.place;
            direction.Normalize();

            launcher.spinning = (float)Math.Atan2(
                          direction.Y,
                          direction.X);
            */

            if (number > 0 && munition.move == false)
            {
                launcher.elapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (launcher.elapsed > 0.05f)
                {
                    if (Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Left) && launcher.spinning > -1.3f)
                    {
                        launcher.spinning -= 0.1f;
                    }
                    if (Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Right) && launcher.spinning < 1.3f)
                    {
                        launcher.spinning += 0.1f;
                    }
                    launcher.elapsed = 0f;
                }

                if (Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Space) ||
                    Mouse.GetState().LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed
                    && Mouse.GetState().X >= 0
                    && Mouse.GetState().Y >= 0
                    && Mouse.GetState().X <= windowWidth
                    && Mouse.GetState().Y >= 30
                    && Mouse.GetState().Y <= windowHeight)
                {
                    munition.move = true;
                    // Shoot bubble depending on the rotation of the pointer.
                    // 1.5f is the speed.
                    Matrix m = Matrix.CreateRotationZ(launcher.spinning);
                    munition.axe.X += m.M12 * 7f;
                    munition.axe.Y -= m.M11 * 7f;
                }
            }

            if (munition.place.X < -8 || munition.place.X > (windowWidth - bubble.Width))
            {
                // The bubble bounce on the left and go at the top
                munition.axe.X *= -1;
            }

            munition.Shift();

            if ((munition.place.Y <= limitTop && munition.axe.Y < limitLeft)
                    || (munition.place.Y > 0 + pizzaCat.Height && munition.axe.Y > 0))
            {
                associateBubble();
            }
            else
            {
                // Check collision with all bubbles stuck
                for (int i = 0; i <= oldBubbles.Count - 1; i++)
                {
                    if (oldBubbles[i] != munition)
                    {
                        if (shockBubbles(munition, oldBubbles[i]))
                        {
                            associateBubble();
                            break;
                        }
                    }
                }
            }
            base.Update(gameTime);
        }
        #endregion

        #region protected override void Draw(GameTime gameTime)
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            String title = "You have no more bubbles !";

            // Measure the size of text in the given font
            Vector2 titleSize = bigTitle.MeasureString(title);

            spriteBatch.Begin();
            spriteBatch.Draw(pizzaCat, new Rectangle(0, 30, windowWidth, windowHeight - 170), Color.White * 0.8f);
            spriteBatch.Draw(launcher.texture, pointerLocation, null, launcher.color, launcher.spinning, launcherLocation, 1f, SpriteEffects.None, 1);

            spriteBatch.DrawString(font, "Bubble Count : " + number, new Vector2(30, 6), Color.Black);
            if (number == 0)
            {
                spriteBatch.DrawString(bigTitle, "You have no more bubbles !", new Vector2(((windowWidth / 2) - (titleSize.X / 2)), (windowHeight / 2) - 7), Color.Black);
            }

            if (munition != null)
            {
                spriteBatch.Draw(bubble, munition.place, munition.color);
                spriteBatch.Draw(bubble, nextMunition.place, nextMunition.color);
            }
            foreach (Bubble oldBubble in oldBubbles)
            {
                spriteBatch.Draw(bubble, oldBubble.place, null, oldBubble.color, 0f, Vector2.Zero, 1f, SpriteEffects.None, 1);
            }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j <= 15; j++)
                {
                    int posx = (j * bubble.Height) + limitLeft + ((i % 2) * (bubble.Height / 2));
                    int posy = i * bubble.Height + limitTop;

                    Rectangle dRect = new Rectangle(posx, posy,
                         bubble.Height, bubble.Height);

                    spriteBatch.Draw(pointText,
                        new Rectangle(dRect.X, dRect.Y, bubble.Width, bubble.Height),
                        Color.White * 0f);
                }
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
        #endregion

        #region public void newBubbleLauncher()
        /// <summary>
        /// This is called to create new bubble to shoot.
        /// </summary>
        public void newBubbleLauncher()
        {
            if (munition == null)
            {
                munition = new Bubble(bubbleLocation, colorBubble[new Random().Next(0, colorBubble.Count)]);
            }
            else
            {
                munition = nextMunition;
                munition.place = bubbleLocation;
            }
            nextMunition = new Bubble(new Vector2(bubbleLocation.X + 80, bubbleLocation.Y), colorBubble[new Random().Next(0, colorBubble.Count)]);
        }
        #endregion

        #region public void addLineOfTarget(int posx, int posy)
        /// <summary>
        /// This is called to add a bubble line to the targetBubble
        /// </summary>
        public void addLineOfTarget(int posx, int posy, int num)
        {
            targetBubbles.Add(new Bubble(new Vector2(posx, posy), colorBubble[num]));
        }
        #endregion

        #region public void glueBubbleBurbuja(Bubble aBubble)
        /// <summary>
        /// This function place the munition bubble when it arrive at the top of the window.
        /// </summary>
        /// <param name="aBubble"></param>
        public void glueBubble(Bubble aBubble)
        {
            aBubble.place = positionBox((Int32)aBubble.boxPlace.X, (Int32)aBubble.boxPlace.Y);
            targetBubbles.Add(aBubble);
        }
        #endregion

        #region private Vector2 positionBox(int x, int y)
        /// <summary>
        /// Fhis function give the new position of the munition bubble.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private Vector2 positionBox(int x, int y)
        {
            return new Vector2((x * sizeBubble) + limitLeft + ((y % 2) * (sizeBubble / 2)), y * sizeBubble + limitTop);
        }
        #endregion

        #region public Boolean shockBubbles(Bubble thisBubble, Bubble thing)
        /// <summary>
        /// This function detect when a bubble is shocked with other thing like top of window or other bubble.
        /// </summary>
        /// <param name="thisBubble"></param>
        /// <param name="thing"></param>
        /// <returns></returns>
        public Boolean shockBubbles(Bubble thisBubble, Bubble thing)
        {
            float bx = thing.place.X - thisBubble.place.X;
            float by = thing.place.Y - thisBubble.place.Y;
            Int32 radio1 = bubble.Width / 2;
            Int32 radio2 = bubble.Height / 2;
            Int32 radioTotal = radio1 + radio2;
            double diff1 = Math.Pow(bx, 2) + Math.Pow(by, 2);
            double radioE = Math.Pow(radioTotal, 2);
            if (diff1 <= radioE)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
        #endregion

        #region 
        /// <summary>
        /// This function glues the munition bubbles with other.
        /// </summary>
        public void associateBubble()
        {
            munition.newPlace();
            glueBubble(munition);
            oldBubbles.Add(munition);
            newBubbleLauncher();
            number = number - 1;
        }
        #endregion
    }
}
