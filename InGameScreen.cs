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
        private Board board;

        public InGameScreen(Game game)
        {
            InitializeComponent();

            this.game = game;
            this.board = new Board();

            // Show the right name under current move maker section.
            this.SafelyWriteTextToLabel(labelMoveUsername, game.PlayerOne.Name);

            // Get all the switches from Domoticz.
            this.switches = Domoticz.Domoticz.GetSwitches();

            // Turn off all switches to be able to start the game.
            foreach (Switch @switch in this.switches)
            {
                Domoticz.Domoticz.UseSwitch(@switch, SwitchActionEnum.Off);
            }

            // Start a Thread to be able to retrieve the actions and display them on the screen.
            Thread checkMovesThread = new Thread(CheckIfMoveWasMade);
            checkMovesThread.Start();

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

                        this.SafelyWriteTextToLabel(labelMoveUsername, (game.Moves.Count() % 2 == 0) ? game.PlayerTwo.Name : game.PlayerOne.Name);

                        game.MakeMove(player, x, y);

                        using (Graphics f = this.panel1.CreateGraphics())
                        {
                            if (game.Moves.Count % 2 == 0)
                            {
                                board.drawGamePiece(Color.Red, x, y, f);
                            }
                            else
                            {
                                board.drawGamePiece(Color.Yellow, x, y, f);
                            }
                        }
                    }
                }

                Thread.Sleep(1000);
            }
        }
    
        /*private void ShowCurrentStatusOfPlayingField()
        {
            while (game.Winner == null)
            {
                // TODO FRONT END -> kijk naar game.Moves wordt geupdate

                Thread.Sleep(1000);
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            board.drawBoard(e);
        }

        private void SafelyWriteTextToLabel(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        label.Text = text;
                    }
                ));
            }
            else
            {
                label.Text = text;
            }
        }
    }
}
