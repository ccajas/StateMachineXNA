using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA.Pets
{
    public abstract class Pet : GameObject
    {
        public MotiveBase Motives { get; set; }

		/// <summary>
		/// Current activity this pet is doing.
		/// </summary>
        public Activities.Activity Activity { get; set; }

        /// <summary>
        /// Initializes a new instance of the Pet class.
        /// </summary>
        public Pet(PlayingField owner)
            : base(owner)
        {
            Activity = new Activities.Idle(this, null);

			// Sets random amount of energy for each pet.
			Motives = new MotiveBase() { Energy = 30, Fun = 70 };
        }

        /// <summary>
        /// Allow a pet to do something custom on their update
        /// </summary>
        /// <param name="seconds"></param>
        protected virtual void OnUpdate(float seconds) { return; }

		/// <summary>
		/// Keep doing the activity for this Pet.
		/// </summary>
        public override void Update(float seconds)
        {
            if (Activity == null)
                Activity = new Activities.Idle(this, null);

            Activity.Update(seconds);
        }

		/// <summary>
		/// Moves this pet to a target of interest.
		/// </summary>
        public override void PushToward(Vector2 destination, float seconds)
        {
            base.PushToward(destination, seconds);

			// Just bump it the correct direction.
            float xDiff = destination.X - Location.X;
            float yDiff = destination.Y - Location.Y;

            float magnitude = (float)Math.Sqrt(xDiff * xDiff) + (float)Math.Sqrt(yDiff * yDiff);

            if (magnitude > (MaxSpeed() * seconds))
            {
                float scale = (MaxSpeed() * seconds) / magnitude;
                xDiff *= scale;
                yDiff *= scale;
            }
            Location = new Vector2(xDiff + Location.X, yDiff + Location.Y);
        }
    }
}
