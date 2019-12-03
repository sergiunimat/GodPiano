using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano3
{
    public partial class MusicStaff : Panel
    {
        /*  ...when constructed in the main window it display itself as a rectangle of a fixed
            size with 5 lines of music staff. The lines are fixed-relative to the upper left corner
            of the panel*/
        #region Data Fields
         List<MusicNote> MusicNoteObejectsCollection = new List<MusicNote>();//to store music notes
        Button play = new Button();
        Button save = new Button();
        Button load = new Button();
        int tempo; // this reflects overall speed in ms (allegro/addagio,etc.)


        #endregion

        #region Operations
        private void PlayLB()
        {
            ///playing of the individual music note displayed on the music staff manually
            ///by pointing and clicking mouse LB.
        }

        private void PlayAll()
        {
            ///playing all the music notes continuously when clicking on the Play button.
            ///i.e. plays the whole melody by traversing the collection of music notes
        }
        private void AdjustTempo()
        {
            ///adjust the overal tempo field (grave,largo,lento,adagio,andante,moderato,allegro,presto)
        }

        #endregion

    }
}
