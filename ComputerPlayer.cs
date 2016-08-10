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

        public int RandomAIMove(Button[] cells, int size)
        {
            bool invalidCell = true;
            int cellChoice = GetRandomNumber(size);

            cellChoice--;

            while(invalidCell)
            {
                       
                if (cells[cellChoice].Text == "")
                    invalidCell = false;
                else
                    cellChoice = GetRandomNumber(size);
            }
            return cellChoice;
        }


        private int GetRandomNumber(int size)
        {
            Random r = new Random();
            int randNumber = r.Next(1, size);
            return randNumber;
        }
    }
}
