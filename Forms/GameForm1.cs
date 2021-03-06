﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Globalization;
using System.Threading;

namespace BumChessV2.Forms
{
    public partial class GameForm1 : Form
    {

        private System.Windows.Forms.Button[] cells;
        private bool roundOngoing = true;
        private Team currentPlayer = Team.X;
        private Opponent playerType;
        private Language lang;
        private int seconds;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private DateTime time;
        private Opponent winner;

        Jukebox music = new Jukebox();
        GameMechanics game = new GameMechanics();
        Highscore highScore = new Highscore();
        ComputerPlayer cpu = new ComputerPlayer();


        public GameForm1(Language lang, Opponent player2)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            playerType = player2;
            music.MusicMaestro(2);
            this.lang = lang;

            if (lang == Language.swe)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
            }
        }
        

        private void GameForm1_Load(object sender, EventArgs e)
        {

            HideShowControls(false);
            //creating array of buttons
            cells = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            //setting font and style
            for (int i = 0; i < 9; i++)
            {
                this.cells[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 32F,
                                          System.Drawing.FontStyle.Italic &
                                          System.Drawing.FontStyle.Bold,
                                          System.Drawing.GraphicsUnit.Point,
                                          ((System.Byte)(0)));
            }

            //adding eventhandlers for cells
            for (int i = 0; i < 9; i++)
                this.cells[i].Click += new System.EventHandler(this.ClickHandler);

            //initalizing new game
            NewGameInit();
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
                {
                    clickedCell.Text = "O";
                }

                game.Moves++;

                //checking for winner
                if (game.CheckForWinner(cells, 8))
                {
                    roundOngoing = false;
                    game.LockUnlockCells(cells, false);
                    break;
                }
                else          
                    CheckIfAIplayerAndChangePlayer(playerType);
                

                //check for a draw
                if (game.Moves == 9)
                {
                    lblCongrats.Visible = true;

                    if (lang == Language.swe)
                        lblCongrats.Text = "Oavgjort. Försök igen.";
                    else
                        lblCongrats.Text = "Draw. Try again.";

                    roundOngoing = false;
                }
            }    
            GetStats();               
        }


        private void GetStats()
        {
            //if draw, skip stats. also checks if AI won and skipping some stuff
            if (game.Moves == 9 || winner == Opponent.AI)
            {
                btnReplay.Visible = true;
                PopulateHighScoreList();
            }

            else
            {
                HideShowControls(true);
                PopulateHighScoreList();
                timer.Stop();

                string roundTime = time.AddSeconds(seconds).ToString("HH:mm:ss");

                if (lang == Language.swe)
                    lblCongrats.Text = "Spelet var över på " + game.Moves + " drag och " + roundTime + " sekunder";
                else
                    lblCongrats.Text = "Game was over in " + game.Moves + " moves and " + roundTime + " seconds";

                btnReplay.Visible = true;
            }
                   
        }

        //simple method for switching player.
        public void SwitchPlayers(Team cp)
        {
            switch (cp)
            {
                case Team.X:
                    currentPlayer = Team.O;
                    break;
                case Team.O:
                    currentPlayer = Team.X;
                    break;
                default:
                    break;
            }
        }

        //switching players and checks if AI is playing and calculating AI moves.
        private void CheckIfAIplayerAndChangePlayer(Opponent opp)
        {
            SwitchPlayers(currentPlayer);

            if (opp == Opponent.AI && currentPlayer == Team.O)
            {
                int cpuMove = cpu.RandomAIMove(cells, 9);

                cells[cpuMove].Text = "O";

                //checking if AI wins
                if (game.CheckForWinner(cells, 8))
                {
                    roundOngoing = false;
                    HideShowControls(true);
                    winner = Opponent.AI;
                }
                    
                else
                currentPlayer = Team.X;
            }
        }

        //counting seconds
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
        }

        //reseting and restarting game session variables
        private void NewGameInit()
        {
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            seconds = 0;
            game.Moves = 0;
            roundOngoing = true;
            game.LockUnlockCells(cells, true);
            HideShowControls(false);
            lblCongrats.Visible = false;
            currentPlayer = Team.X;
            winner = Opponent.None;
            
        }

        //populating highscore list
        private void PopulateHighScoreList()
        {
            List<string> Top5List = new List<string>(highScore.ShowHighScore());

            lblHS1.Text = Top5List[4];
            lblHS2.Text = Top5List[3];
            lblHS3.Text = Top5List[2];
            lblHS4.Text = Top5List[1];
            lblHS5.Text = Top5List[0];
        }

        //save and show updated highscore list
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            highScore.CalculateScoreAndStore(game.Moves, seconds, txtEnterName.Text);
            PopulateHighScoreList();

            //hiding controls after entering highscore name
            txtEnterName.Text = "";
            lblenterName.Visible = false;
            txtEnterName.Visible = false;
            btnSaveScore.Visible = false;
        }        


        //reset board and restart game
        private void btnReplay_Click(object sender, EventArgs e)
        {
            foreach (Button cell in cells)
            {
                cell.Text = "";
                cell.BackColor = Color.LightBlue;
            }
            NewGameInit();         
        }


        //hide/show controls
        public void HideShowControls(bool showhide)
        {
            btnReplay.Visible = showhide;
            lblCongrats.Visible = showhide;
            lblHighScore.Visible = showhide;
            lblHS1.Visible = showhide;
            lblHS2.Visible = showhide;
            lblHS3.Visible = showhide;
            lblHS4.Visible = showhide;
            lblHS5.Visible = showhide;
            lblenterName.Visible = showhide;
            txtEnterName.Visible = showhide;
            btnSaveScore.Visible = showhide;

            //kicks in if the AI opponent wins
            if (playerType == Opponent.AI && currentPlayer == Team.O)
            {
                lblenterName.Visible = false;
                txtEnterName.Visible = false;
                btnSaveScore.Visible = false;
                lblCongrats.Visible = true;
                if (lang == Language.eng)
                    lblCongrats.Text = "You lost against the mighty CPU.";
                else
                    lblCongrats.Text = "Du förlorade mot datorn.";
            }
        }

        //back to main game menu
        private void btnBackToInitForm_Click(object sender, EventArgs e)
        {
            music.KillMusic();
            this.Hide();
            initForm menuForm = new initForm();
            menuForm.Show();
        }
    }
}
