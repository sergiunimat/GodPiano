using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Piano2
{
    class MusicNote : PictureBox
    {
        public string path = @"C:\Users\desir\source\repos\Piano2\Piano2\bin\Debug\Notes-Images";
        public int pitch;
        public string noteShape;
        public int noteDuration;
        public MusicNote(int iPitch, int iDuration, string iNoteShape):base()
        {
            pitch = iPitch;
            noteShape = iNoteShape;
            noteDuration = iDuration;

            Location = new Point(100,50);
            Size = new Size(40,40);
            Bitmap bmp = new Bitmap(noteShape+".bmp");
            Image = bmp;
            BackColor = Color.Transparent;
        }
    }
}
