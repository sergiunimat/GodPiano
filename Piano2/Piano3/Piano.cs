using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano3
{
    public partial class Piano : Form
    {

        #region Data Fields
        private Panel basePanel = new Panel();
        int[] whitePitch = { 1, 3, 5, 6, 8, 10, 12, 13, 15, 17, 18, 20, 22, 24 };
        int[] blackPitch = { 20, 4, 7, 9, 11, 14, 16, 19, 21, 23 };
        int[] xPos = { 10, 30, 70, 90, 110, 150, 170, 210, 230, 250 };
        int count = 0;
        /*---------------------*/
        private SoundPlayer sp;
        private Timer timer1;
        #endregion


        public Piano()
        {
            InitializeComponent();
        }

        private void Piano_Load(object sender, EventArgs e)
        {
            /*construction of MusicStaff and Music Keyboard objects */
         
            basePanel.Location = new Point(100,10);
            basePanel.Size = new Size(600,400);
            basePanel.BackColor = Color.Transparent;
            this.Controls.Add(basePanel);

            MusKey mk;
            BlackMusKey bmk;
            for (int k = 0; k < whitePitch.Length; k++)
            {
                int pitch = whitePitch[k];
                int xPos = k * 40;
                mk = new MusKey(pitch, xPos+20, 220);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.basePanel.Controls.Add(mk);

            }
            
            for (int k = 0; k < blackPitch.Length; k++)
            {
                int pitch = blackPitch[k];
                /*  note here we are using xPoss unlike in notes (xPos)*/
                int xP = xPos[k] * 2;
                bmk = new BlackMusKey(pitch, xP+20, 220);
                /*  note here we use bmk unlike in the notes*/
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.basePanel.Controls.Add(bmk);
                this.basePanel.Controls[this.basePanel.Controls.Count - 1].BringToFront();

            }

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {/* create a new MusicNote object*/
            MusicNote currentNote = new MusicNote();
            throw new NotImplementedException();
        }
    }
}
