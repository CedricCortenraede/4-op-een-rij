﻿using _4opeenrij.Objects;
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
        private List<Switch> switchesUsed = new List<Switch>();

        // Game info
        private Game game;
        private bool isPlaying = false;

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
            this.isPlaying = true;
        }

        private void CheckIfMoveWasMade()
        {
            while (isPlaying)
            {
                foreach(Switch @switch in Domoticz.Domoticz.GetSwitches())
                {
                    if (@switch.Status == "On")
                    {
                        bool switchAlreadyRegistered = false;

                        foreach (Switch @switchUsed in this.switchesUsed)
                        {
                            if (@switch.Idx == @switchUsed.Idx)
                            {
                                switchAlreadyRegistered = true;
                                break;
                            }
                        }

                        if (switchAlreadyRegistered) continue;

                        this.switchesUsed.Add(@switch);

                        String[] wordsInName = @switch.Name.Replace("(", "").Replace(")", "").Replace(",", "").Split(' ');

                        Player player = (game.Moves.Count() % 2 == 0) ? game.PlayerOne : game.PlayerTwo;
                        int row = int.Parse(wordsInName[1]);
                        int column = int.Parse(wordsInName[2]);

                        game.MakeMove(player, row, column);
                    }
                }

                MessageBox.Show(switchesUsed.Count() + "");

                Thread.Sleep(1000);
            }
        }
    
        private void ShowCurrentStatusOfPlayingField()
        {
            while (isPlaying)
            {
                // TODO FRONT END -> kijk naar game.Moves wordt geupdate

                Thread.Sleep(1000);
            }
        }
    }
}
