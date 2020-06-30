using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4opeenrij.Objects
{
    public class Move
    {
        private int id;
        private Player player;
        private Game game;
        private int x;
        private int y;

        public Move(Player player, Game game, int x, int y)
        {
            this.player = player;
            this.Game = game;
            this.X = x;
            this.Y = y;
        }

        public int Id { get => id; set => id = value; }
        public Player Player { get => player; set => player = value; }
        public Game Game { get => game; set => game = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void CreateToDB()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0NL1URL;Initial Catalog='B2D4 Casus';Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO dbo.moves (x, y, game_id, player_id) VALUES (@x, @y, @game_id, @player_id); SELECT SCOPE_IDENTITY();";


                SqlParameter xParam = new SqlParameter("@x", SqlDbType.Int, 0);
                xParam.Value = this.X;

                SqlParameter yParam = new SqlParameter("@y", SqlDbType.Int, 0);
                yParam.Value = this.Y;

                SqlParameter gameIdParam = new SqlParameter("@game_id", SqlDbType.Int, 0);
                gameIdParam.Value = this.Game.Id;

                SqlParameter userIdParam = new SqlParameter("@player_id", SqlDbType.Int, 0);
                userIdParam.Value = this.Player.Id;

                command.Parameters.Add(xParam);
                command.Parameters.Add(yParam);
                command.Parameters.Add(gameIdParam);
                command.Parameters.Add(userIdParam);

                command.Prepare();
                this.Id = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
            }
        }
    }
}
