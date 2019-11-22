using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*this is what i added to the class*/
using System.Windows.Forms;
using System.Drawing;

namespace Piano2
{
    public class Muskey : Button
    {
        public int notePitch;
        /*
         Location   ~ it is inherited i.e. see the constructor bellow.
         Size       ~ it is inherited i.e. see the constructor bellow.
        */

        /*Constructor of MusKey*/
        public Muskey(int iPitch,int x, int y)
        {
            notePitch = iPitch;
            Location = new Point(x,y);
            Size = new Size(40,160);
        }
    }
}
