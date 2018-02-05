using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_WIN_EpiBubble_2017
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            using (var game = new Game1())
                game.Run();
        }

        private void btn_level_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            Settings sg = new Settings();
            sg.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
