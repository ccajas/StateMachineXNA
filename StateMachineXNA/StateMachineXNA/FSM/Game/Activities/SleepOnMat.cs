using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineXNA.Activities
{
    class SleepOnMat : Activity
    {
        RunToObject mRto;

		float energy = 5f;
		float fun = 2f;

        /// <summary>
        /// Initializes a new instance of the SleepOnMat class.
        /// </summary>
        public SleepOnMat(Pets.Pet actor, GameObject target)
            : base(actor, target)
        {
            mRto = new RunToObject(actor, target);
        }

		/// <summary>
		/// 
		/// </summary>
        public override bool OnUpdate(float seconds)
        {
            // Route to the sleeping mat
            if(mRto.OnUpdate(seconds))
            {
                // Now that we are on the mat, just sit here and increase our motives.
                Actor.Motives.Energy += energy;
                Actor.Motives.Fun += fun;

				// Full of energy. Find something else to do.
                if (Actor.Motives.Energy > 50f)
                    return true;
            }

            return false;
        }
    }
}
