using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryChess
{
    public abstract class ChessPiece
    {
        public ChessPiece(string color, char column, int row)
        {
            Color = color;
            Column = column;
            Row = row;
        }

        public string Color { get; set; }
        public char Column { get; set; }
        public int Row { get; set; }

        public virtual void MakeMove(char newColumn, int newRow)
        {
            if (IsMovePossible(newColumn, newRow))
            {
                Column = newColumn;
                Row = newRow;
            }
            else
            {
                Console.WriteLine("Недопустимый ход");
            }
        }

        protected abstract bool IsMovePossible(char newColumn, int newRow);
    }
}
