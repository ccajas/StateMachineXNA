using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StateMachineXNA
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game1 : Microsoft.Xna.Framework.Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		SpriteFont font;

		/// Key input
		KeyboardState lastKeyboardState;

		/// Game logic elements
		PlayingField playingField;
		List<Pets.Puppy> puppies;

		/// Keeps track of a selected puppy
		Pets.Puppy selectedPuppy;

		public Game1()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			puppies = new List<Pets.Puppy>();
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			playingField = new PlayingField(this, GraphicsDevice);
			Components.Add(playingField);

			// Create a new SpriteBatch, which can be used to draw textures.
			spriteBatch = new SpriteBatch(GraphicsDevice);
			font = Content.Load<SpriteFont>("Arial");

			for (int i = 0; i < 3; i++)
				puppies.Add(playingField.AddGameObject(new Pets.Puppy(playingField, Content)) 
					as Pets.Puppy);

			for (int i = 0; i < 5; i++)
				playingField.AddGameObject(new Toys.Ball(playingField, Content));

			for (int i = 0; i < 2; i++)
				playingField.AddGameObject(new Toys.SleepingMat(playingField, Content));

			selectedPuppy = puppies[0];
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			// Allows the game to exit
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
				this.Exit();

			int current = puppies.IndexOf(selectedPuppy);

			// Select among objects for its information.
			if (Keyboard.GetState().IsKeyDown(Keys.Up) && !lastKeyboardState.IsKeyDown(Keys.Up))
			{
				if (current < puppies.Count - 1)
					selectedPuppy = puppies[current + 1];
			}

			if (Keyboard.GetState().IsKeyDown(Keys.Down) && !lastKeyboardState.IsKeyDown(Keys.Down))
			{
				if (current > 0)
					selectedPuppy = puppies[current - 1];
			}

			lastKeyboardState = Keyboard.GetState();

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			base.Draw(gameTime);

			// This displays info for the selected puppy.
			spriteBatch.Begin();
			spriteBatch.DrawString(font, "Puppy " + puppies.IndexOf(selectedPuppy), Vector2.Zero, Color.Cyan);
			spriteBatch.DrawString(font, selectedPuppy.Activity.ToString(), new Vector2(0, 12f), Color.White);
			spriteBatch.DrawString(font, "Energy: " + selectedPuppy.Motives.Energy.ToString(), new Vector2(0, 24f), Color.White);
			spriteBatch.DrawString(font, "Fun:    " + selectedPuppy.Motives.Fun.ToString(), new Vector2(0, 36f), Color.White);

			if (selectedPuppy.Activity.Target != null)
				spriteBatch.DrawString(font, "Target: " + selectedPuppy.Activity.Target.ToString(), new Vector2(0, 48f), Color.White);
			spriteBatch.End();
		}
	}
}
