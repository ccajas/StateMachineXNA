using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA.Toys
{
    class Ball : Toy
    {
        /// <summary>
        /// Initializes a new instance of the Ball class.
        /// </summary>
        public Ball(PlayingField owner, ContentManager content)
            : base(owner)
        {
			Image = content.Load<Texture2D>("Images/Ball");
        }

		/// <summary>
		/// Chase the object as default.
		/// </summary>
        public override Activities.Activity DefaultActivity(Pets.Pet actor, GameObject target)
        {
            return new Activities.ChaseBall(actor, target);
        }

		/// <summary>
		/// Determine how interesting this Ball is to a Pet.
		/// </summary>
        public override float Interest(StateMachineXNA.Pets.Pet pet)
        {
			// The most interesting object will be the closest one
			float toyDistance = Vector2.Distance(this.Location, pet.Location); 

            return 100 - (toyDistance / 4f);// pet.Motives.Fun;
        }
    }
}
