using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StateMachineXNA
{
    public abstract class GameObject
    {
        public PlayingField Owner { get; set; }

        /// <summary>
        /// Initializes a new instance of the GameObject class.
        /// </summary>
        public GameObject(PlayingField owner)
        {
            Owner = owner;
        }

        /// <summary>
        /// Update the object
        /// </summary>
        /// <param name="seconds">seconds since last update.</param>
        /// <remarks>seconds is the easiest scale for the individual settings</remarks>
        public abstract void Update(float seconds);

        /// <summary>
        /// Location on the playing field to draw the actor
        /// </summary>
        public Vector2 Location { get; set; }

        /// <summary>
        /// What to draw on the playing field
        /// </summary>
        public virtual Texture2D Image { protected set; get; }

        /// <summary>
        /// Push the game object toward a location. Default behavior is to not move.
        /// </summary>
        /// <param name="destination">Location to push toward</param>
        /// <param name="seconds">Seconds that have passed in this movement</param>
        public virtual void PushToward(Vector2 destination, float seconds) { return; }

        /// <summary>
        /// Get the maximum speed of this game object. Default behavior is not to move.
        /// </summary>
        /// <returns></returns>
        public virtual float MaxSpeed() { return 0; }

        /// <summary>
        /// Simplified name for the object to display in the property browser
        /// </summary>
        /// <returns>Shorter name</returns>
        public override string ToString()
        {
            string classname = base.ToString();

            int index = classname.LastIndexOf('.');
            string shortname = classname.Substring(index+1);
            return shortname;
        }

    }
}
