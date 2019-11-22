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
    class BlackMuskey : Muskey
    {
        /*  Constructor of BlackMusKey class*/
        public BlackMuskey(int iPitch,int x,int y): base(iPitch, x, y)//base is like super in java.
        {
            Location = new Point(x,y);
            /*  change the color for the small button of piano*/
            this.BackColor = Color.Black;
            /*  change the size for the small button of piano*/
            this.Size = new Size(40,120);
        }
            

        
    }
}
