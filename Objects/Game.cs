using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4opeenrij.Objects
{
    public class Game
    {
        private int id;
        private DateTime gameStarted;
        private DateTime gameEnded;
        private List<Move> moves;
        private bool canMakeMoves = true;

        // Players
        private Player playerOne;
        private Player playerTwo;
        private Player winner;

        public Game(DateTime gameStarted, Player playerOne, Player playerTwo)
        {
            this.GameStarted = gameStarted;
            this.moves = new List<Move>();

            this.PlayerOne = playerOne;
            this.PlayerTwo = playerTwo;
        }

        public int Id { get => id; set => id = value; }
        public DateTime GameStarted { get => gameStarted; set => gameStarted = value; }
        public DateTime GameEnded { get => gameEnded; set => gameEnded = value; }
        public List<Move> Moves { get => moves; set => moves = value; }
        public Player PlayerOne { get => playerOne; set => playerOne = value; }
        public Player PlayerTwo { get => playerTwo; set => playerTwo = value; }
        public Player Winner { get => winner; set => winner = value; }
        public bool CanMakeMoves { get => canMakeMoves; set => canMakeMoves = value; }

        public bool CanMakeMove(int x, int y)
        {
            if (!this.CanMakeMoves) return false;

            foreach (Move move in this.Moves)
            {
                if (move.X == x && move.Y == y)
                {
                    return false;
                }
            }

            return true;
        }

        public Move GetMove(int x, int y)
        {
            foreach (Move move in this.Moves)
            {
                if (move.X == x && move.Y == y)
                {
                    return move;
                }
            }

            return null;
        }

        public void MakeMove(Player player, int x, int y)
        {
            // Check if there already is a move set at the specified location.
            if (!this.CanMakeMove(x, y))
            {
                return;
            }

            // Make the move
            Move move = new Move(player, this, x, y);
            Moves.Add(move);

            // Save the move to Database
            move.CreateToDB();

            MessageBox.Show("Move made by " + player.Name + " to location (" + x + ", " + y + ")");

            // Make the players not able to make another move for another second, this makes sure the next move will be able to be registered.
            this.CanMakeMoves = false;

            // While the player is not able to make another move check if the game has been won.
            if (this.CheckIfGameWon(player, x, y)) return;

            Thread.Sleep(1000);

            this.CanMakeMoves = true;
        }

        public bool CheckIfGameWon(Player player, int x, int y)
        {
            bool gameWon = this.CheckIfGameWonHorizontally(player, x, y);

            if (gameWon)
            {
                this.GameWon(player);

                return true;
            }

            // Check vertical
            gameWon = this.CheckIfGameWonVertically(player, x, y);

            if (gameWon)
            {
                this.GameWon(player);

                return true;
            }

            // Check diagonal
            gameWon = this.CheckIfGameWonDiagonally(player, x, y);

            if (gameWon)
            {
                this.GameWon(player);

                return true;
            }

            return false;
        }

        private bool CheckIfGameWonHorizontally(Player player, int x, int y)
        {
            List<Move> InARow = new List<Move>();

            // Check to the left.
            for (int i = x; i >= 1; i--)
            {
                Move move = this.GetMove(i, y);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            // Check to the right.
            for (int i = x; i <= 7; i++)
            {
                Move move = this.GetMove(i, y);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            if (InARow.Count >= 4)
            {
                return true;
            }

            return false;
        }

        private bool CheckIfGameWonVertically(Player player, int x, int y)
        {
            List<Move> InARow = new List<Move>();

            // Check to the top.
            for (int i = y; i >= 1; i--)
            {
                Move move = this.GetMove(x, i);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            // Check to the bottom.
            for (int i = y; i <= 6; i++)
            {
                Move move = this.GetMove(x, i);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            if (InARow.Count >= 4)
            {
                return true;
            }

            return false;
        }

        private bool CheckIfGameWonDiagonally(Player player, int x, int y)
        {
            /* 
             1  2  3  4  5  6  7
             8  9 10 11 12 13 14
            15 16 17 18 19 20 21
            22 23 24 25 26 27 28
            29 30 31 32 33 34 35
            36 37 38 39 40 41 42
            */

            List<Move> InARow = new List<Move>();

            // Check to the top left.
            for (int i = 0; i < 4; i++)
            {
                Move move = this.GetMove(x - i, y - i);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            // Check to the bottom right.
            for (int i = 0; i < 4; i++)
            {
                Move move = this.GetMove(x + i, y + i);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            if (InARow.Count >= 4)
            {
                return true;
            }
                        
            InARow.Clear();

            // Check to the top right.
            for (int i = 0; i < 4; i++)
            {
                Move move = this.GetMove(x + i, y - i);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            // Check to the bottom left.
            for (int i = 0; i < 4; i++)
            {
                Move move = this.GetMove(x - i, y + i);

                if (move != null && move.Player == player && !InARow.Contains(move))
                {
                    InARow.Add(move);

                    continue;
                }

                break;
            }

            if (InARow.Count >= 4)
            {
                return true;
            }

            return false;
        }

        public void GameWon(Player player)
        {
            this.gameEnded = DateTime.Now;
            this.winner = player;

            MessageBox.Show("Het spel is gewonnen door " + player.Name + "!");

            this.UpdateToDB();
        }

        public void CreateToDB()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0NL1URL;Initial Catalog='B2D4 Casus';Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO dbo.games (game_started, player_1, player_2) VALUES (@game_started, @player_1, @player_2); SELECT SCOPE_IDENTITY();";

                SqlParameter gameStartedParam = new SqlParameter("@game_started", SqlDbType.DateTime, 0);
                gameStartedParam.Value = this.GameStarted;

                SqlParameter playerOneParam = new SqlParameter("@player_1", SqlDbType.Int, 0);
                playerOneParam.Value = PlayerOne.Id;

                SqlParameter playerTwoParam = new SqlParameter("@player_2", SqlDbType.Int, 0);
                playerTwoParam.Value = PlayerTwo.Id;

                command.Parameters.Add(gameStartedParam);
                command.Parameters.Add(playerOneParam);
                command.Parameters.Add(playerTwoParam);

                command.Prepare();
                this.Id = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
            }
        }

        public void UpdateToDB()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0NL1URL;Initial Catalog='B2D4 Casus';Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "UPDATE dbo.games SET game_ended = @game_ended, player_winner = @player_winner WHERE id = @id;";

                SqlParameter gameEndedParam = new SqlParameter("@game_ended", SqlDbType.DateTime, 0);
                gameEndedParam.Value = this.GameEnded;

                SqlParameter playerWinnerParam = new SqlParameter("@player_winner", SqlDbType.Int, 0);
                playerWinnerParam.Value = Winner.Id;

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, 0);
                idParam.Value = this.Id;

                command.Parameters.Add(gameEndedParam);
                command.Parameters.Add(playerWinnerParam);
                command.Parameters.Add(idParam);

                command.Prepare();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
