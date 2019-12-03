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
        public string path = @"C:\Users\desir\Documents\forkbasic\GodPiano\Piano2\Piano2\bin\Debug\Notes-Images\";
        public int pitch;
        public string noteShape;
        public int noteDuration;
        public enum accidental
        {
            flat,
            sharp,
            sole
        }


        public bool isDragging = false; // this field show the begining & ending of dragging.
        /*  Constructor of the MusicNote*/
        public MusicNote(int iPitch, int iDuration, string iNoteShape):base()
        {
            pitch = iPitch;
            noteShape = iNoteShape;
            noteDuration = iDuration;

            Location = new Point(100,50);
            Size = new Size(25,40);
            /*  geting the img of music note*/
            Bitmap bmp = new Bitmap(path+ noteShape + ".bmp",true);
            Image = bmp;
            BackColor = Color.Transparent;

            /*  Event registrations, the functions passed as parameters are defined bellow. */
            this.MouseDown += new MouseEventHandler(StartDrag);
            this.MouseUp += new MouseEventHandler(StopDrag);
            this.MouseMove += new MouseEventHandler(NoteDrag);
        }

        //i am not sure i couldl explain what this function does. is from notes.
        private void InitilaizeComponent()
        {
            this.BackColor = SystemColors.Control;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
        }

        #region Even Start,Stop and Note
        private void StartDrag(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                isDragging = true;
                pitch = e.Y; //this is the current Y coordinate of mouse
                this.Location = new Point(this.Location.X,pitch);
            }
        }
        private void StopDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                pitch = e.Y; //this is the current Y coordinate of mouse
                
            }
        }
        private void NoteDrag(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                /*  Top property is the distance in pixels betwwen the top edge of the component
                    and the top endge of its container.*/
                this.Top = this.Top + (e.Y-this.pitch); //this to move in vertical direction
            }
        }
        #endregion

        /*this method is used to redrwaw automatically.*/
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


    }
}
