using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
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

            cBoxLang.Items.Insert(0, "English");
            cBoxLang.Items.Insert(1, "Svenska");
            cBoxLang.SelectedIndex = 0;

            cBoxBoardSize.Items.Insert(0, "3x3 board");
            cBoxBoardSize.Items.Insert(1, "6x6 board");
            cBoxBoardSize.SelectedIndex = 0;

            cBoxMode.Items.Insert(0, "Simple");
            cBoxMode.Items.Insert(1, "Harder");
            cBoxMode.SelectedIndex = 0;
        }


        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
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

            if (cBoxLang.SelectedIndex == 1)
                lang = Language.swe;
            else
                lang = Language.eng;


                if (cBoxBoardSize.SelectedIndex == 0)
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
        

        private void cBoxLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxLang.SelectedIndex == 1)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sv-SE");
                ComponentResourceManager resources = new ComponentResourceManager(typeof(initForm));
                resources.ApplyResources(this, "$this");
                applyResources(resources, this.Controls);
            }

            if (cBoxLang.SelectedIndex == 0)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                ComponentResourceManager resources = new ComponentResourceManager(typeof(initForm));
                resources.ApplyResources(this, "$this");
                applyResources(resources, this.Controls);
            }
        }


        private void applyResources(ComponentResourceManager resources, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                resources.ApplyResources(ctl, ctl.Name);
                applyResources(resources, ctl.Controls);
            }
        }




        private void cBoxBoardSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ChangeLanguage(CultureInfo culture)
        {
            Application.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture.Name);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(culture.Name);
        }
    }
}
