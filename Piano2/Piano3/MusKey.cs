using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*this is what i added to the class*/
using System.Windows.Forms;
using System.Drawing;


namespace Piano3
{
    class MusKey : Button
    {
        public int notePitch;
        /*
         Location   ~ it is inherited i.e. see the constructor bellow.
         Size       ~ it is inherited i.e. see the constructor bellow.
        */

        /*Constructor of MusKey*/
        public MusKey(int iPitch, int x, int y)
        {
            notePitch = iPitch;
            Location = new Point(x, y);
            Size = new Size(40, 160);
            FlatStyle = FlatStyle.Flat;
        }

    }
}
