using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BumChessV2.Forms
{
    public partial class GameForm1 : Form
    {

        private System.Windows.Forms.Button[] cells;
        private bool roundOngoing = true;
        private Team currentPlayer = Team.X;
        private Opponent playerType;
       // DateTime startTime;

        Jukebox music = new Jukebox();
        GameMechanics game = new GameMechanics();
        Highscore highScore = new Highscore();


        public GameForm1(Language lang, Opponent player2)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            playerType = player2; 
            music.MusicMaestro(2);

            NewGameInit();
        }
        

        private void GameForm1_Load(object sender, EventArgs e)
        {
            HideShowControls(false);
            cells = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            for (int i = 0; i < 9; i++)
                this.cells[i].Click += new System.EventHandler(this.ClickHandler);
        }


        //event handler for button clicks
        private void ClickHandler(object sender, System.EventArgs e)
        {
            Button clickedCell = (Button)sender;

            //keep going until there is a winner
            while (roundOngoing)
            {
                if (clickedCell.Text != "")
                    return;

                if (currentPlayer == Team.X)
                    clickedCell.Text = "X";
                else
                    clickedCell.Text = "O";

                game.Moves++;

                ChangePlayer(playerType);

                //checking for winner
                if (game.CheckForWinner(cells))
                {
                    roundOngoing = false;
                }
            }
            //yay.      
            GetStats();               
        }


        private void GetStats()
        {
            HideShowControls(true);

            

            ChangePlayer(playerType);
            lblCongrats.Text = "you're a hero, " + currentPlayer.ToString() + ". Game was over in " + game.Moves + " moves and " + TimePlayed(startTime).ToString() + " seconds";
            btnReplay.Visible = true;
        }


        private void ChangePlayer(Opponent opp)
        {
            if (currentPlayer == Team.X)
                currentPlayer = Team.O;
            else
                currentPlayer = Team.X;

            if (opp == Opponent.AI)
            {
                ComputerMove();
            }
        }


        public int TimePlayed(DateTime startTime)
        {
        
            DateTime EndTime = DateTime.Now;
            TimeSpan span = EndTime - startTime;
            
            int time =Convert.ToInt32(span.TotalSeconds);

            return time;
        }


        private void NewGameInit()
        {
            startTime = DateTime.Now;
        }



        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            highScore.CalculateScoreAndStore(game.Moves, TimePlayed, txtEnterName.Text);
        }
        

        private void btnReplay_Click(object sender, EventArgs e)
        {

        }


        private void ComputerMove()
        {

        }

        //hide/show controls
        public void HideShowControls(bool showhide)
        {
            btnReplay.Visible = showhide;
            panelSplash.Visible = showhide;
            lblenterName.Visible = showhide;
            txtEnterName.Visible = showhide;
            btnSaveScore.Visible = showhide;
        }


    }
}
