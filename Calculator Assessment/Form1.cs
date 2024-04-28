using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Music Library 

namespace Calculator_Assessment
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundplayer1; // Declares new variable 
        public Form1()
        {
            InitializeComponent();
            _soundplayer1 = new SoundPlayer("CALCU-LATOR.wav"); // Searches for Sound file 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // opens program if clicked yes

            this.Hide(); // If User proceeds to continue, this form is set to hide
            Form form2 = new Form2(); // declares form 2 
            form2.Show(); // Form 2 show
            _soundplayer1.Stop(); // Music stops 
      
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Music player - Plays music on Form Load 
            _soundplayer1.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // closes program if clicked no
            this.Close(); // Form Closes 
            _soundplayer1.Stop(); // Music Stops 
     
        }
    }
}
