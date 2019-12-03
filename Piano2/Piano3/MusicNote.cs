using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano3
{
    class MusicNote
    {
        #region DataFields
        int pitch;
        int shape;
        int duration;
        enum accidental{flat,sharp,sole}
        #endregion

        #region Constructor
        public MusicNote(int iPitch, int iShape, int iDuration)
        {
            pitch = iPitch;
            shape = iShape;
            duration = iDuration;
            /*enum=iEnum?*/
        }
        #endregion

        #region Mouse Events
        /*  ...when the mouse pointer is positioned on a particular music note image*/
        /*click event*/
        private void Click(object sender,MouseEventArgs e)
        {
            /*...plays a single note of the selected music note with its duration and pitch*/
        }

        private void RightPress(object sender, MouseEventArgs e)
        {
            /*...used for editing the selected note.
                the duration of the RM pressing determines the shape of music note.
                When released the duration value is set accorndingly*/
        }

        private void Drag(object sender, MouseEventArgs e)
        {
            /*...moves the existing note vertically only and adjust its pitch accordingly*/
        }


        #endregion


    }
}
