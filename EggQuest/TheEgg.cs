using CollisionExample.Collisions;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace EggQuest
{
    public class TheEgg
    {
        /// <summary>
        /// the position of the egg. im assuiming it will be in 2d quardinents
        /// </summary>
        public Vector2 Position;
        /// <summary>
        /// the sprite for the egg. i would assume its a 3d model but spritebatch dosnt take texture3d .
        /// </summary>
        public Texture2D texture;
        /// <summary>
        /// the velocity of the egg.
        /// </summary>
        public Vector2 velocity;
        /// <summary>
        /// constructor of the egg
        /// </summary>
        public TheEgg() {
            Position = new Vector2(100, 100); //where the egg spawns
            velocity = new Vector2(2,2); ///the initial speed and direction of the egg
        }
        /// <summary>
        /// Loads the sprite texture using the provided ContentManager
        /// </summary>
        /// <param name="content">The ContentManager to load with</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Whatever file the egg is");

        }

        /// <summary>
        /// Updates the sprite's position based on user input
        /// </summary>
        /// <param name="gameTime">The GameTime</param>
        public void Update(GameTime gameTime, int screenWidth, int screenHeight)
        {
            Position += velocity;

            // code to make the egg a dvd bouncing logo
            int EggWidth = 1;
            int EggHeight = 1;
            if (Position.X <= 0 || Position.X + EggWidth >= screenWidth)
            {
                velocity.X *= -1; 
            }

            if (Position.Y <= 0 || Position.Y + EggHeight >= screenHeight)
            {
                velocity.Y *= -1; 
            }
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
