using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BumChessV2
{
    class GameMechanics
    {
        public int Moves { get; set; }
        public string LatestWinner { get; set; }
        private int[,] winCombos = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
        private int[,] winCombos6x6 = new int[,] { { 0, 1, 2 }, { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 },
                                                   { 6, 7, 8 }, { 7, 8, 9 }, { 8, 9, 10 }, { 9, 10, 11 },
                                                    { 12, 13, 14 }, { 13, 14, 15 }, { 14, 15, 16 }, { 15, 16, 17 },
                                                    { 18, 19, 20 }, { 19, 20, 21 }, {20, 21, 22 }, {21, 22, 23 },
                                                     {24, 25, 26 }, {25, 26, 27 }, {26, 27, 28 }, {27, 28, 29 },
                                                    {30, 31, 32 }, {31, 32, 33 }, {32, 33, 35 }, {33, 34, 35 },
                                                    {0, 6, 12 }, {6, 12, 18 }, {12, 18, 24 }, {18, 24, 30 },
                                                    {1, 7, 13 }, {7, 13, 19 }, {13, 19, 25 }, {19, 25, 31 },
                                                    {2, 8, 14 }, {8, 14, 20 }, {14, 20, 26 }, {20, 26, 32 },
                                                    {3, 9, 15 }, {9, 15, 21 }, {15, 21, 27 }, {21, 27, 33 },
                                                    {4, 10, 16 }, {10, 16, 22 }, {16, 22, 28 }, {22, 28, 34 },
                                                    {5, 11, 17 }, {11, 17, 23 }, { 17, 23, 29}, {23, 29, 35 },
                                                    {0, 7, 14 }, {7, 14, 21 }, {14, 21, 28 }, {21, 28, 35 },
                                                    { 1, 8, 15}, {8, 15, 22 }, {15, 22, 29 }, {2, 9, 16 }, {9, 16, 23 }, {3, 10, 17 },
                                                    {6, 13, 20 }, {13, 20, 27 }, {20, 27, 34 }, {12, 19, 26 }, {19, 26, 33 }, {18, 25, 32 },
                                                    { 5, 10, 15}, {10, 15, 20 }, {15, 20, 25 }, {20, 25, 30 },
                                                     };





        public bool CheckForWinner(Button[] cells)
        {
            for (int i = 0; i < 8; i++)
            {
                int a = winCombos[i, 0], b = winCombos[i, 1], c = winCombos[i, 2];       
                                                                                    
                Button b1 = cells[a], b2 = cells[b], b3 = cells[c];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "") 
                    continue;                                           

                if (b1.Text == b2.Text && b2.Text == b3.Text)           
                {                                                      
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.Aqua;

                    return true; 
                }
            }
            return false;
        }


        //locking or unlocking cells
        public void LockUnlockCells(Button[] cells, bool lockUnlock)
        {
            foreach (Button cell in cells)
            {
                cell.Enabled = lockUnlock;
            }
        }





    }
}
