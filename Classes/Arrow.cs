using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace T_WIN_EpiBubble_2017.Classes
{
    class Arrow
    {
        #region Variables
        public Color color { get; set; }
        public float elapsed { get; set; }
        public float spinning { get; set; }
        public float speed { get; set; }
        public Vector2 place { get; set; }
        public Texture2D texture { get; set; }
        #endregion

        #region public Arrow(Vector2 place, string color)
        /// <summary>
        /// This is the constructor of the Arrow.
        /// </summary>
        /// <param name="place"></param>
        /// <param name="color"></param>
        public Arrow(Vector2 place, string color)
        {
            this.color = SetColor(color);
            elapsed = 0f;
            spinning = 0f;
            speed = 2;
            this.place = place;
        }
        #endregion

        #region
        private Color SetColor(string color)
        {
            switch (color)
            {
                case "Rose":
                    return new Color(246, 74, 138);
                case "Olive":
                    return new Color(128, 128, 0);
                case "Gray":
                    return Color.Gray;
                case "Maroon":
                    return Color.Maroon;
                case "Gold":
                    return Color.Gold;
                default:
                    return new Color(50, 125, 160); // Astral
            }
        }
        #endregion
    }
}
