using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BumChessV2
{
    class Jukebox
    {
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        //dunkadunka
        public void MusicMaestro(int choice)
        {
            switch (choice)
            {
                case 1:
                    wplayer.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "dubstep.mp3");
                    break;
                case 2:
                    wplayer.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "punchandpie.mp3");
                    break;
                default:
                      break;
            }
            wplayer.controls.play();
        }



        public void KillMusic()
        {
            wplayer.close();
        }
    }
}
