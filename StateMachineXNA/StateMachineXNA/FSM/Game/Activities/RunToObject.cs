using System;
using Microsoft.Xna.Framework;

namespace StateMachineXNA.Activities
{
    class RunToObject : Activity
    {
		float energy = -2f;

        /// <summary>
        /// Initializes a new instance of the RunToObject class.
        /// </summary>
        public RunToObject(Pets.Pet actor, GameObject target)
            : base(actor, target)
        {        
			energy *= (actor.MaxSpeed() / 100);
        }

		/// <summary>
		/// Check if we're close enough to the target object.
		/// </summary>
        public override bool OnUpdate(float seconds)
        {
			// If out of energy, don't move
			//if (Actor.Motives.Energy < 0f)
			//	return false;

            // Are we there yet?
            Vector2 offset = Target.Location - Actor.Location;
            float distanceSquared = offset.X * offset.X + offset.Y * offset.Y;
            float closeEnough = 8f;
            float closeEnoughSquared = closeEnough * closeEnough;

			// Close enough to the object
            if (distanceSquared < closeEnoughSquared)
                return true;

			// Not close enough, keep moving
            Actor.PushToward(Target.Location, seconds);
			Actor.Motives.Energy += energy * seconds;

            return false;
        }
    }
}
