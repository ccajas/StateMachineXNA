using System;
using Microsoft.Xna.Framework;

namespace StateMachineXNA.Activities
{
    class ChaseBall : Activity
    {
        RunToObject mRto;

		float fun = 3f;

        /// <summary>
        /// Initializes a new instance of the ChaseBall class.
        /// </summary>
        public ChaseBall(Pets.Pet actor, GameObject target)
            : base(actor, target)
        {
            mRto = new RunToObject(actor, target);
        }

        public override bool OnUpdate(float seconds)
        {
            // When they kick the ball, move it to a new location and continue our activity.
            if(mRto.OnUpdate(seconds))
            {
                float kickDistance = 100f;

                // Get a random number with +/- kick distance
                float newX = Target.Location.X + (((float)Target.Owner.Rng.NextDouble()*(2*kickDistance))-kickDistance);
                float newY = Target.Location.Y + (((float)Target.Owner.Rng.NextDouble()*(2*kickDistance))-kickDistance);
                Vector2 randomLocation = new Vector2(newX,newY);

                Target.Location = randomLocation;
                Actor.Motives.Fun += fun;

				// Maxed out on fun or out of energy, look for another activity.
				if (Actor.Motives.Fun > 100f || Actor.Motives.Energy < 0f)
                    return true;
            }

            return false;
        }
    }
}
