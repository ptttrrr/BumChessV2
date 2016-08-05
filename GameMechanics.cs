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
        private int[,] winCombos = new int[,]
           {
             {0,1,2},{3,4,5},{6,7,8},{0,3,6},{1,4,7},{2,5,8},{0,4,8},{2,4,6}
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



    }
}
