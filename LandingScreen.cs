using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4opeenrij
{
    public partial class LandingScreen : Form
    {
        public LandingScreen()
        {
            InitializeComponent();
        }

        private void buttonGoInToGame_Click(object sender, EventArgs e)
        {
            if (1 == 2)
            {
                //TODO: Check if a game has already started, if it has open that game.
                /*InGameScreen inGameScreen = new InGameScreen(GAME);
                inGameScreen.Show();*/
            }
            else
            {
                StartGameScreen startGameScreen = new StartGameScreen();
                startGameScreen.Show();
            }
        }
    }
}
