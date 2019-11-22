using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
/*  (above line) enables to play different sound(s)*/
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano2
{
    /*  note, this is the Form1*/
    public partial class PianoForm : Form
    {

        #region

        /*variables & arrays*/
        string beforeWave;
        string soundSpath = @"C:\Users\desir\source\repos\Piano2\Piano2\bin\Debug\Notes-Sound files\";
        int count = 0;
        private SoundPlayer sp;
        private Timer timer1;
        int xLoc = 100;
        int yLoc = 200;
        
        int[] whitePitch = {1,3,5,6,8,10,12,13,15,17,18,20,22,24};
        //int[] whitePitch = {10,30,50,60,80,100,120,130,150,170,180,200,220,240};
        int[] blackPitch = {20,4,7,9,11,14,16,19,21,23};
        //int[] xPos= {100,300,700,900,1100,1500,1700,2100,2300,2500};
        int[] xPos= {10,30,70,90,110,150,170,210,230,250};
        private Panel panel1= new Panel();
        private Panel panel2= new Panel();
        

        #endregion
        /*  this is the constructor of the "Form1"/PianoForm*/
        public PianoForm()
        {
            InitializeComponent();    
        }

        private void DrawPianoButtons()
        {
            Muskey mk;
            BlackMuskey bmk;
            /*  draw the white buttons*/
            for (int k = 0; k < 7; k++)
            {
                int pitch = whitePitch[k];
                int xPos = k * 20;
                mk = new Muskey(pitch,xPos,50);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                mk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(mk);
            }
            int Offs = 20;
            for (int k = 0; k < 5; k++)
            {
                int pitch = blackPitch[k];
                /*  note here we are using xPoss unlike in notes (xPos)*/
                int xPoss = xPos[k];
                bmk = new BlackMuskey(pitch,xPoss,50);
                /*  note here we use bmk unlike in the notes*/
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(bmk);
                //this.panel1.Controls[this.panel1.Controls.Count-1].BringToFront();
                this.Controls[this.panel1.Controls.Count-1].BringToFront();
            }
        }




        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (Muskey mk in this.panel1.Controls)
            {
                if (sender==mk)
                {
                    if (e.Button==MouseButtons.Left)
                    {
                        timer1.Enabled = false;
                        sp.Stop();
                        string bNoteShape = null;
                        int duration = 0;
                        switch (count)
                        {
                            case int n when (n>=16):
                                bNoteShape = "SemiBrave";
                                duration = 18;
                                break;
                            case int n when (n >= 18 && n<=5):
                                bNoteShape = "DotMinim";
                                duration = (11+15)/2;
                                break;
                                //note there are more cases, they need to be written down.

                            default:
                                break;
                        }
                        //MusicNote mn = new MusicNote(mk.notePitch,duration,bNoteShape);
                        //mn.Location = new Point(xLoc,yLoc);
                        //this.panel2.Controls.Add(mn);
                        //xLoc = xLoc + 15;

                    }
                }
            }
            
            //throw new NotImplementedException();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1 = new Timer();
            sp = new SoundPlayer();

            foreach (Muskey mk in this.panel1.Controls)
            {
                if (sender == mk) // if this is true for a specific key that is pressed on the musik keyboard
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        timer1.Enabled = true;
                        count = 0;
                        timer1.Start();
                        if (mk.notePitch==1)
                        {
                            beforeWave = "a";
                        }
                        sp.SoundLocation =soundSpath + beforeWave + mk.notePitch.ToString() + ".wav";
                        sp.Play();
                    }
                }
            }
            //sp = new SoundPlayer(@"C:\Users\desir\source\repos\Piano2\Piano2\Notes-Sound files\a#0.wav");
            //sp.Play();
            //throw new NotImplementedException();
        }

        private void PianoForm_Load(object sender, EventArgs e)
        {
            //adding panel1 ~ the buttons
            this.panel1.Location = new Point(xLoc,yLoc);
            //this.panel1.BackColor = Color.Azure;
            this.panel1.Size = new Size(600,200);
            this.Controls.Add(panel1);
            //adding the panel2 ~ the music lines.
            this.panel2.Location = new Point(xLoc, 30);
            this.panel2.BackColor = Color.Azure;
            this.panel2.Size = new Size(600, 200);
            this.Controls.Add(panel2);


            Muskey mk;
            BlackMuskey bmk;
            /*  draw the white buttons*/

            for (int k = 0; k < whitePitch.Length; k++)
            {
                int pitch = whitePitch[k];
                int xPos = k * 40;//xPosition?
                mk = new Muskey(pitch, xPos, 10);
                //mk.Name = "button" + k;
                mk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                //mk.MouseDown += new EventHandler();
                mk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(mk);
                
            }
            int Offs = 20;
            for (int k = 0; k < blackPitch.Length; k++)
            {
                int pitch = blackPitch[k];
                /*  note here we are using xPoss unlike in notes (xPos)*/
                int xP = xPos[k]*2;
                bmk = new BlackMuskey(pitch, xP, 10);
                /*  note here we use bmk unlike in the notes*/
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseDown);
                bmk.MouseDown += new MouseEventHandler(this.button1_MouseUp);
                this.panel1.Controls.Add(bmk);
                this.panel1.Controls[this.panel1.Controls.Count-1].BringToFront();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count++;
        }
    }
}
