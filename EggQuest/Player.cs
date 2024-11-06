using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace EggQuest
{
    public class Player
    {
        /// <summary>
        /// the position of the player.
        /// </summary>
        public Vector2 Position;
        /// <summary>
        /// the sprite for the player.
        /// </summary>
        public Texture2D texture;
        /// <summary>
        /// constructor of the player
        /// </summary>
        public Player()
        {
            Position = new Vector2(50, 50); //where the player spawns
        }
        /// <summary>
        /// Loads the sprite texture using the provided ContentManager
        /// </summary>
        /// <param name="content">The ContentManager to load with</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Whatever file the player is");

        }

        /// <summary>
        /// Updates the sprite's position based on user input
        /// </summary>
        /// <param name="gameTime">The GameTime</param>
        public void Update(GameTime gameTime, int screenWidth, int screenHeight)
        {
  

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.W)) Position.Y -= 5;
            if (keyboardState.IsKeyDown(Keys.S)) Position.Y += 5;
            if (keyboardState.IsKeyDown(Keys.A)) Position.X -= 5;
            if (keyboardState.IsKeyDown(Keys.D)) Position.X += 5;

        }
        /// <summary>
        /// Draws the sprite using the supplied SpriteBatch
        /// </summary>
        /// <param name="gameTime">The game time</param>
        /// <param name="spriteBatch">The spritebatch to render with</param>
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, Color.White);
        }
    }
}
