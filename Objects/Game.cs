using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4opeenrij.Objects
{
    public class Game
    {
        private int id;
        private DateTime gameStarted;
        private DateTime gameEnded;
        private List<Move> moves;
        private bool canMakeMove = true;

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

        public bool CanMakeMove(int row, int column)
        {
            if (!this.canMakeMove) return false;

            foreach (Move move in this.Moves)
            {
                if (move.Column == column && move.Row == row)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }

            return false;
        }

        public void MakeMove(Player player, int row, int column)
        {
            // Check if there already is a move set at the specified location.
            if (!this.CanMakeMove(row, column))
            {
                return;
            }

            // Make the move
            Move move = new Move(player, column, row);
            Moves.Add(move);

            // Set Make move to false for 1 second so the field can update and players won't be able to spam moves.
            this.canMakeMove = false;

            Thread.Sleep(1000);

            this.canMakeMove = true;

            // Save the move to Database
            move.SaveToDB();
        }

        public void CreateToDB()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0NL1URL;Initial Catalog='B2D4 Casus';Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO dbo.games (game_started, user_1, user_2) VALUES (@game_started, @user_1, @user_2); SELECT SCOPE_IDENTITY();";


                SqlParameter gameStartedParam = new SqlParameter("@game_started", SqlDbType.DateTime, 0);
                gameStartedParam.Value = this.GameStarted;

                SqlParameter userOneParam = new SqlParameter("@user_1", SqlDbType.Int, 0);
                userOneParam.Value = PlayerOne.Id;

                SqlParameter userTwoParam = new SqlParameter("@user_2", SqlDbType.Int, 0);
                userTwoParam.Value = PlayerTwo.Id;

                command.Parameters.Add(gameStartedParam);
                command.Parameters.Add(userOneParam);
                command.Parameters.Add(userTwoParam);

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
                command.CommandText = "UPDATE dbo.games SET game_ended = @game_ended, user_winner = @user_winner WHERE id = @id;";

                SqlParameter gameEndedParam = new SqlParameter("@game_ended", SqlDbType.DateTime, 0);
                gameEndedParam.Value = this.GameEnded;

                SqlParameter userWinnerParam = new SqlParameter("@user_winner", SqlDbType.Int, 0);
                userWinnerParam.Value = Winner.Id;

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int, 0);
                idParam.Value = this.Id;

                command.Parameters.Add(gameEndedParam);
                command.Parameters.Add(userWinnerParam);
                command.Parameters.Add(idParam);

                command.Prepare();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
