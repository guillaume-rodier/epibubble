using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace T_WIN_EpiBubble_2017.Classes
{
    public class Bubble
    {
        #region Variables
        public Vector2 place;
        public Vector2 axe;
        public Color color { get; private set; }
        public Vector2 boxPlace { get; set; }
        public Boolean move = false;
        #endregion

        #region Constructor
        public Bubble(Vector2 place, Color color)
        {
            this.place = place;
            axe = Vector2.Zero;
            this.color = color;
        }
        #endregion

        #region Shift
        public void Shift()
        {
            if (move)
            {
                place += axe;
            }
        }
        #endregion

        public void newPlace()
        {
            int fy = (int)(place.Y - Game1.limitTop +
                (Game1.sizeBubble / 2)) / Game1.sizeBubble;
            int fx = (int)((place.X - Game1.limitLeft +
                (Game1.sizeBubble / 2) - ((fy % 2) *
               (Game1.sizeBubble / 2))) / Game1.sizeBubble);

            boxPlace = new Vector2(fx, fy);
        }
    }
}
