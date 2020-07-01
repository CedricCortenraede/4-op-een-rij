using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4opeenrij
{
    public partial class RegisterUserScreen : Form
    {
        public RegisterUserScreen()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Je moet een gebruikersnaam invullen!");

                return;
            }

            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0NL1URL;Initial Catalog='B2D4 Casus';Integrated Security=True"))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(null, connection);
                command.CommandText = "INSERT INTO dbo.players (name) VALUES (@name);";

                SqlParameter usernameParam = new SqlParameter("@name", SqlDbType.VarChar, 255);
                usernameParam.Value = textBoxUsername.Text;

                command.Parameters.Add(usernameParam);

                command.Prepare();
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Het account is aangemaakt!");
            }

            this.Close();
        }
    }
}
