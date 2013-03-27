using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA.Toys
{
    class SleepingMat : Toy
    {
        /// <summary>
        /// Initializes a new instance of the SleepingMat class.
        /// </summary>
        public SleepingMat(PlayingField owner, ContentManager content)
            : base(owner)
        {
			Image = content.Load<Texture2D>("Images/SleepingMat");            
        }

        public override StateMachineXNA.Activities.Activity DefaultActivity(Pets.Pet actor, GameObject target)
        {
            return new Activities.SleepOnMat(actor, this);
        }

		/// <summary>
		/// The less energy the Pet has, the more interesting this object would be.
		/// </summary>
        public override float Interest(StateMachineXNA.Pets.Pet pet)
        {
            return 100 - pet.Motives.Energy;
        }
    }
}
