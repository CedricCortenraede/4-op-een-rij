using System;
using System.Collections.Generic;
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
        private int row;
        private int column;

        public Move(Player player, int row, int column)
        {
            this.player = player;
            this.column = column;
            this.row = row;
        }

        public int Id { get => id; set => id = value; }
        internal Player Player { get => player; set => player = value; }
        public int Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }

        public void SaveToDB()
        {

        }
    }
}
