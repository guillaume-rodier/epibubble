using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_WIN_EpiBubble_2017.Classes;

namespace T_WIN_EpiBubble_2017.Classes
{
    class Levels
    {
        private Config config;
        private List<Color> colorBubble;
        private List<Bubble> listBubble;

        public Levels()
        {
            config = new Config("ColorLevels.txt");
            colorBubble = new List<Color>
            {
                Color.Black,
                Color.Silver,
                Color.Gray,
                Color.White,
                Color.Maroon,
                Color.Red,
                Color.Purple,
                Color.Fuchsia,
                Color.Green,
                Color.Lime,
                Color.Yellow,
                Color.Blue,
                Color.Cyan
            };
        }
    }
}
