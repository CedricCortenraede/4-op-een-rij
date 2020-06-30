using _4opeenrij.Objects;
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
    public partial class StartGameScreen : Form
    {
        public StartGameScreen()
        {
            InitializeComponent();
        }

        private void GameStartScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playerTwoOptions.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter1.Fill(this.playerTwoOptions.players);
            // TODO: This line of code loads data into the 'playerOneOptions.players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.playerOneOptions.players);

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            // Check if selected Players are not empty.
            if (comboBoxPlayerOne.SelectedIndex == -1 || comboBoxPlayerTwo.SelectedIndex == -1)
            {
                MessageBox.Show("Je moet een speler selecteren voordat je door kan gaan met het spelen van het spel!", "Oeps, er ging iets fout!");

                return;
            }

            // Check if Player One and Two are not the same person.
            int playerOneID = (int) comboBoxPlayerOne.SelectedValue;
            int playerTwoID = (int) comboBoxPlayerTwo.SelectedValue;
            if (playerOneID == playerTwoID)
            {
                MessageBox.Show("Je kan niet dezelfde speler selecteren, selecteer 2 verschillende spelers om door te gaan.", "Oeps, er ging iets fout!");

                return;
            }

            // Start the game
            Player playerOne = new Player(playerOneID, (string) ((DataRowView) comboBoxPlayerOne.Items[comboBoxPlayerOne.SelectedIndex])["name"]);
            Player playerTwo = new Player(playerTwoID, (string) ((DataRowView) comboBoxPlayerTwo.Items[comboBoxPlayerTwo.SelectedIndex])["name"]);

            Game game = new Game(DateTime.Now, playerOne, playerTwo);
            game.CreateToDB();

            // TODO: Open game menu!
            InGameScreen inGameScreen = new InGameScreen(game);
            inGameScreen.Show();
        }
    }
}
