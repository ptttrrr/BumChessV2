using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BumChessV2
{
    class ComputerPlayer
    {

        public int RandomAIMove(Button[] cells)
        {
            bool invalidCell = true;
            int cellChoice = GetRandomNumber();

            cellChoice--;

            while(invalidCell)
            {
                if (cells[cellChoice].Text == "")
                    invalidCell = false;
                else
                    cellChoice = GetRandomNumber();
            }
            return cellChoice;
        }


        private int GetRandomNumber()
        {
            Random r = new Random();
            int randNumber = r.Next(1, 9);
            return randNumber;
        }
    }
}
