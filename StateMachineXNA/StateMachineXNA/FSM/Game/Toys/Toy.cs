using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA.Toys
{
    public abstract class Toy : GameObject
    {
        /// <summary>
        /// Initializes a new instance of the Toy class.
        /// </summary>
        public Toy(PlayingField owner)
            : base(owner)
        {   }

		/// <summary>
		/// Default activity for this Toy.
		/// </summary>
        public abstract Activities.Activity DefaultActivity(Pets.Pet actor, GameObject target);

		/// <summary>
		/// How interesting a Toy is, used for making the pet choose one to play with.
		/// </summary>
        public abstract float Interest(Pets.Pet pet);

		/// <summary>
		/// Basic update function for the Toy.
		/// </summary>
		public override void Update(float seconds)
        {
            // Note that most toys do nothing of themselves. They are driven by their activities.
        }

    }
}
