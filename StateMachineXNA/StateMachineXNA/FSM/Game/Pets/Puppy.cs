using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA.Pets
{
    class Puppy : Pet
    {
		float maxSpeed = 100f;

        /// <summary>
        /// Initializes a new instance of the Puppy class.
        /// </summary>
        public Puppy(PlayingField owner, ContentManager content)
            : base(owner)
        {
            Image = content.Load<Texture2D>("Images/puppy");
        }

		/// <summary>
		/// Gets the maximum speed.
		/// </summary>
        public override float MaxSpeed()
        {
            return maxSpeed;  
        }
    }
}
