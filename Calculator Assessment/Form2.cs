using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Calculator_Assessment
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // login system code
            // declaration of variables 
            

            var textbox1 = textBox1; // declares textbox1 
            var textbox2 = textBox2; // declares textbox2 
            Form form2 = new Form2(); // declares already existing form 
            Form form3 = new Form3(); // declares already existing form 
            Form form5 = new Form5();  // declares already existing form 
            Form Errorform = new Form4(); // declares already existing form 

            // process code for the login system 

            if (textbox1.Text == "Admin" && textbox2.Text == "Password") // checks if textbox1.text = Admin && tetbox2.Text == Password then fires code
            {
                
                form5.Show(); // shows the loading screen
                this.Hide(); // hides the login screen 

                Stopwatch stopwatch = new Stopwatch(); // activates the new stopwatch   
                await Task.Delay(3000); // New Thread.Sleep() alternative, unlike thread.sleep, this one 
                // makes it so that the task is played first (acting like a delay) before the next task. 

                // Thread.Sleep(15000); --> Thread.sleep is the first wait function I dsicovered, yet the
                // problem I faced with it is that it disables the line of code before it 

                form5.Hide(); // Loading screen close
                form3.Show(); //shows the calculator program 
            }
            else // else system 
            {
                Errorform.Show(); // Fires if login and password is wrong 
                
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear button system 

            var textbox1 = textBox1; // declares textBox1 
            var textbox2 = textBox2; // declares textBox2 

            textbox1.Text = ""; // clears textbox1.Text if pressed 
            textbox2.Text = ""; // clears textbox2.Text if pressed 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
