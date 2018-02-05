using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using T_WIN_EpiBubble_2017.Classes;

namespace T_WIN_EpiBubble_2017
{
    public partial class Settings : Form
    {
        #region Variables
        private Config carrow;
        #endregion

        #region public Settings()
        /// <summary>
        /// This function initialize the component of the window.
        /// </summary>
        public Settings()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion

        #region private void Settings_Load(object sender, EventArgs e)
        /// <summary>
        /// This function is used at the windows' loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Load(object sender, EventArgs e)
        {
            carrow = new Config("ArrowColor.txt");
            arrowColorCmbx.SelectedIndex = arrowColorCmbx.FindString(carrow.ReadFile());
        }
        #endregion

        #region private void boxOk_Click(object sender, EventArgs e)
        /// <summary>
        /// This function is used by the ok button to save the color and close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxOk_Click(object sender, EventArgs e)
        {
            DialogResult result;
            String color;

            switch (arrowColorCmbx.SelectedIndex)
            {
                case 0:
                    color = "Astral";
                    carrow.WriteFile("Astral");
                    break;
                default:
                    color = arrowColorCmbx.SelectedItem.ToString();
                    carrow.WriteFile(color);
                    break;
            }

            result = saveColorMsgBox(color);

            if (result == DialogResult.OK)
            {
                Close();
            }
        }
        #endregion

        #region private void boxExit_Click(object sender, EventArgs e)
        /// <summary>
        /// This function is used by the exit button to close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region private DialogResult saveColorMsgBox(string color)
        /// <summary>
        /// This function show a messageBox when the user want to save the color of Arrow.
        /// </summary>
        /// <param name="color"></param>
        /// <returns>It returns the result of the buttons.</returns>
        private DialogResult saveColorMsgBox(string color)
        {
            return MessageBox.Show("You choose " + color,
                "Chosen color",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk);
        }
        #endregion
    }
}
