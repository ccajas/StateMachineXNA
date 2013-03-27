using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA
{
    public class PlayingField : DrawableGameComponent
    {
        public List<GameObject> GameObjects = new List<GameObject>();
        public Random Rng = new Random();

		/// Playing field background texture
		private static Texture2D pixel;

		/// Field dimensions
		public Vector2 fieldArea;

		/// To draw the field with
		private SpriteBatch spriteBatch;

		/// <summary>
		/// Create the playing field
		/// </summary>
        public PlayingField(Game game, GraphicsDevice graphics) 
			: base(game)
        {
			fieldArea = new Vector2(graphics.Viewport.Width, graphics.Viewport.Height);
			spriteBatch = new SpriteBatch(graphics);

			// Make a 1x1 texture named pixel.  
			pixel = new Texture2D(graphics, 1, 1);
			Color[] colorData = { Color.White }; 

			// Set the texture data with our color information.  
			pixel.SetData<Color>(colorData);  
        }

		/// <summary>
		/// Adds a new GameObject to the field and returns it.
		/// </summary>
        public GameObject AddGameObject(GameObject obj)
        {
            Vector2 randomLocation = new Vector2((float)Rng.NextDouble() * 800, (float)Rng.NextDouble() * 400);
            obj.Location = randomLocation;
            GameObjects.Remove(obj);   // Always remove before add to prevent duplicates.
            GameObjects.Add(obj);

			return obj;
        }

		/// <summary>
		/// Update playing field activity.
		/// </summary>
        public override void Update(GameTime gameTime)
        {
            DateTime now = DateTime.Now;
            long elapsed = gameTime.ElapsedGameTime.Milliseconds;

            // Convert from ticks to seconds.
            float dt = elapsed / 1000f;

            // Prevent huge time differences when we pause for debugging.
            //if (dt > 0.1f)
            //    dt = 0.1f;
            foreach (GameObject obj in GameObjects)
            {
                obj.Update(dt);

                // If they leave the playing field reset them to a random location.
                if(obj.Location.X < 0
					|| obj.Location.X > fieldArea.X
                    || obj.Location.Y < 0
					|| obj.Location.Y > fieldArea.Y)
                {
					Vector2 randomLocation = new Vector2(
						(float)Rng.NextDouble() * fieldArea.X * 0.95f,
						(float)Rng.NextDouble() * fieldArea.Y * 0.95f);
                    obj.Location = randomLocation;
                }
            }
        }

		/// <summary>
		/// Draws the playing field and all of its objects.
		/// </summary>
        public override void Draw(GameTime gameTime)
        {
			spriteBatch.Begin();

			// Draw a fancy rectangle.  
			spriteBatch.Draw(pixel, new Rectangle(0, 0, (int)fieldArea.X, (int)fieldArea.Y), Color.Green);

			int i = 0;
            foreach (GameObject obj in GameObjects)
            {
				Color color = (i == 0) ? Color.Yellow : Color.White;
				spriteBatch.Draw(obj.Image, obj.Location, color);
				i++;
            }
			spriteBatch.End();
        }
    }
}
