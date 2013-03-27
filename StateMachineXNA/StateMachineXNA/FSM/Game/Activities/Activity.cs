using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace StateMachineXNA.Activities
{
    public abstract class Activity
    {
		/// GameObject that performs the activity and
		/// what the activity is performed on.
        public Pets.Pet Actor { get; set; }
        public GameObject Target { get; set; }

        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity(Pets.Pet actor, GameObject target)
        {
            Actor = actor;
            Target = target;
        }

        /// <summary>
        /// Update this activity state
        /// </summary>
        /// <param name="seconds">elapsed time</param>
        /// <returns>true if the activity is complete</returns>
        public abstract bool OnUpdate( float seconds );
        
        /// <summary>
        /// Update this activity state
        /// </summary>
        /// <param name="seconds">elapsed time</param>
        public void Update(float seconds)
        {
            if(OnUpdate(seconds))
                Actor.Activity = new Idle(Actor, null);
        }

        /// <summary>
        /// Utility function to locate the best next activity for the actor.
        /// </summary>
        /// <returns></returns>
        public static Activity FindBestActivity(Pets.Pet actor)
        {
            // Look for a toy to play with...
            if (actor.Owner != null
                && actor.Owner.GameObjects != null)
            {
				// Only find toys (not other puppies for example)
                List<Toys.Toy> candidates = new List<Toys.Toy>();
                foreach (GameObject obj in actor.Owner.GameObjects)
                {
                    Toys.Toy t = obj as Toys.Toy;
                    if (t != null)
                    {
                        candidates.Add(t);
                    }
                }

				// Go through the best candidate to do the activity with.
                if (candidates.Count > 0)
                {
                    float bestScore = float.MinValue;
                    Toys.Toy bestToy = null;

                    foreach (Toys.Toy t in candidates)
                    {
						// Weigh the score for the most interesting toy.
						float myscore = t.Interest(actor);
                        if(myscore > bestScore)
                        {
                            bestScore = myscore;
							bestToy = t;
                        }
                    }
                    return bestToy.DefaultActivity(actor, bestToy);
                }
            }

            return new Idle(actor, null);
        }

        public override string ToString()
        {
            string classname = base.ToString();

            int index = classname.LastIndexOf('.');
            string shortname = classname.Substring(index + 1);
            return shortname;
        }
    }
}
