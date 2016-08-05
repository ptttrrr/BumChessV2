﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace BumChessV2.Forms
{
    public partial class initForm : Form
    {
        private Language lang = Language.eng;
        private Opponent player2;

        Jukebox music = new Jukebox();

        public initForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            music.MusicMaestro(1);
            cBoxOpponent.Items.Insert(0, "PvP");
            cBoxOpponent.Items.Insert(1, "AI");
            cBoxOpponent.SelectedIndex = 0;
        }


        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }


        private void btnEnglish_Click(object sender, EventArgs e)
        {
            if (lang == Language.swe)
            {
                lang = Language.eng;

                btnStartGame.Text = "P L A Y";
                btnQuitGame.Text = "Q U I T";
                chckBoxNormal.Text = "Normal mode";
                chckBoxHardmode.Text = "SUPERDUPERHARDMODE";
            }
        }

        private void btnSwedish_Click(object sender, EventArgs e)
        {
            if (lang == Language.eng)
            {
                lang = Language.swe;

                btnStartGame.Text = "S P E L A";
                btnQuitGame.Text = "A V S L U T A";
                chckBoxNormal.Text = "Normalt spelläge";
                chckBoxHardmode.Text = "Jättesvårt spelläge";
            }
        }


        private void chckBoxNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxNormal.Checked)
                chckBoxHardmode.Checked = false;
        }

        private void chckBoxHardmode_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxHardmode.Checked)
                chckBoxNormal.Checked = false;
        }

        private void cBoxOpponent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxOpponent.SelectedIndex == 0)
                player2 = Opponent.Human;
            else
                player2 = Opponent.AI;
        }

        //start game with chosen settings
        private void btnStartGame_Click(object sender, EventArgs e)
        {         
            if (!chckBoxHardmode.Checked && !chckBoxNormal.Checked)
            {
                if (lang == Language.swe)
                    this.lblErrorMsg.Text = "Välj ett spelarläge, är du snäll";
                else
                    this.lblErrorMsg.Text = "Pick a game mode, please";
            }
            else
            {
                if (chckBoxNormal.Checked)
                {
                    music.KillMusic();
                    this.Hide();
                    GameForm1 gameForm = new GameForm1(lang, player2);              
                    gameForm.Show();
                }
                else
                {
                    music.KillMusic();
                    this.Hide();
                    GameForm2 gameForm = new GameForm2(lang, player2);
                    gameForm.Show();
                }
            }
        }


    }
}