using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineXNA.Activities
{
    class Idle : Activity
    {
        float mTimeInIdle = 0;
		float minimumIdleTime = 5f;

		float energy = 2f;
		float fun = -1.5f;

        public Idle(Pets.Pet actor, GameObject target)
            : base(actor, target)
        { }

		/// <summary>
		/// Update Idle activity
		/// </summary> 
        public override bool OnUpdate(float seconds)
        {
            mTimeInIdle += seconds;

			// Set how long at least objects should be idle.
			if (mTimeInIdle >= minimumIdleTime)
                Actor.Activity = FindBestActivity(Actor);

            // Sitting there idle isn't much fun and slowly recharges energy.
			// This encourages us to pick up other activiites.
            Actor.Motives.Fun += fun * seconds;
            Actor.Motives.Energy += energy * seconds;

            // Always return false because idle is never finished.  It auto-replaces if it can find something.
            return false;
        }
    }
}
