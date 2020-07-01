using _4opeenrij.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4opeenrij
{
    public partial class InGameScreen : Form
    {
        // General info
        private Switch[] switches;

        // Game info
        private Game game;

        public InGameScreen(Game game)
        {
            InitializeComponent();

            this.game = game;

            // Get all the switches from Domoticz.
            this.switches = Domoticz.Domoticz.GetSwitches();

            // Turn off all switches to be able to start the game.
            foreach (Switch @switch in this.switches)
            {
                Domoticz.Domoticz.UseSwitch(@switch, SwitchActionEnum.Off);
            }

            // Start a Thread to be able to activate the Switches.


            // Start a Thread to be able to retrieve the actions and display them on the screen.
            Thread checkMovesThread = new Thread(CheckIfMoveWasMade);
            checkMovesThread.Start();

            // Start a Thread to show the current status of the playing field.
            Thread showCurrentStatusOfPlayingFieldThread = new Thread(ShowCurrentStatusOfPlayingField);
            showCurrentStatusOfPlayingFieldThread.Start();

            // Make the game be playable
            game.CanMakeMoves = true;
        }

        private void CheckIfMoveWasMade()
        {
            while (game.Winner == null)
            {
                foreach(Switch @switch in Domoticz.Domoticz.GetSwitches())
                {
                    if (@switch.Status == "On")
                    {
                        Domoticz.Domoticz.UseSwitch(@switch, SwitchActionEnum.Off);

                        String[] wordsInName = @switch.Name.Split(' ');

                        Player player = (game.Moves.Count() % 2 == 0) ? game.PlayerOne : game.PlayerTwo;
                        int x = int.Parse(wordsInName[0]);
                        int y = -1;
                        for (int i = 6; i >= 1; i--)
                        {
                            if (game.CanMakeMove(x, i))
                            {
                                y = i;
                                break;
                            }
                        }

                        if (y == -1) break;

                        game.MakeMove(player, x, y);
                    }
                }

                Thread.Sleep(1000);
            }
        }
    
        private void ShowCurrentStatusOfPlayingField()
        {
            while (game.Winner == null)
            {
                // TODO FRONT END -> kijk naar game.Moves wordt geupdate

                Thread.Sleep(1000);
            }
        }
    }
}
