using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using WMPLib;
using System.Media;


namespace Calculator_Assessment
{
    public partial class Form3 : Form
    {
        //Declares music player public
        private SoundPlayer _soundPlayer; 

  
        public Form3()
        {

            InitializeComponent();
            _soundPlayer = new SoundPlayer("touka_game.wav");
            //ourworld.wav
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // code for equals button 
            //declaration of variables 
            int num1 = int.Parse(textBox1.Text); // reads userinput and translates it into number
            int num2 = int.Parse(textBox2.Text); // reads second userinput and translates it into number
            var add = radioButton1; // declares radiobutton1 
            var sub = radioButton2; // declares radiobutton2 
            var mult = radioButton3; // declares radiobutton3 
            var div = radioButton4; // declares radiobutton4 
            var mode = radioButton5; // declares radiobutton5 
            var resultText = label3; // declares label3 

            //start of the code
            if (radioButton1.Checked) // if function, checks if radiobutton1 is checked
            {
                int resultAdd = num1 + num2; // creates a new integer and adds num1 and 2 if radiobutton1 checked
                resultText.Text = "The sum equals to: " + resultAdd.ToString(); // prints result via label3 
            }
            if (radioButton2.Checked) // if function, checks if radiobutton2 is checked
            {
                int resultSub = num1 - num2; // creates a new integer and subs num1 and 2 if radiobutton2 checked
                resultText.Text = "The difference equals to: " + resultSub.ToString(); // prints result via label3

            }
            if (radioButton3.Checked) // if function, checks if radiobutton3 is checked 
            {
                int resultMult = num1 * num2; // creates a new integer and multiplies num1 and 2 if radiobutton3 checked
                resultText.Text = "The multiple equates to " + resultMult.ToString(); // prints result via label3
            }
            if (radioButton4.Checked) // if function, checks if radiobutton4 is checked
            {
                int resultDiv = num1 / num2; // creates a new integer and divides num1 and 2 if radiobutton4 checked
                resultText.Text = "The quotient equates to " + resultDiv.ToString(); // prints result via label4
            }
            if (radioButton5.Checked) // if function, checks if radiobutton5 is checked
            {
                int resultMode = num1 % num2; // creates a new integer and finds the remainder between num1 and 2 if radiobutton5 checked
                resultText.Text = "The modulus equates to " + resultMode.ToString(); // prints result via label4
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // code for the clear button 

            textBox1.Text = ""; // if button is clicked, textBox1.Text will return to blank ("")
            textBox2.Text = ""; // if button is clicked, textBox2.Text will return to blank ("")
            label3.Text = ""; // if button is clicked, results label will return to blank ("")

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            // => Submit Button Code <= 

            var picture1Default = pictureBox1;
            picture1Default.Show();

            // =============== Question Generator (Old Code) ================

            // Declaring different numbers/questions
            // First num and Second num
            //var FirstNumber = label5;
            //var SecondNumber = label6;
            // Third num and Fourth num 
            //var ThirdNumber = label11;
            //var FourthNumber = label10;
            // Five num and Sixth num
            // var FiveNumber = label14;
            //var SixthNumber = label13;
            // Seventh num and Eight num 
            // var SeventhNumber = label17;
            //var EightNumber = label16;



            // Declaring different Operators 
            //var OperText1 = label7;
            //var OperText2 = label9;
            //var OperText3 = label12;
            //var OperText4 = label15;

            // Random Number Generator
            // Random randomNum1 = new Random();
            // addition numbers genrator
            // int Num1 = randomNum1.Next(4, 50);
            //int Num2 = randomNum1.Next(60, 120);
            // subtraction numbers generator
            // int Num3 = randomNum1.Next(70, 120);
            //int Num4 = randomNum1.Next(10, 50);
            // multiplication numbers generator
            // int Num5 = randomNum1.Next(4, 20);
            //int Num6 = randomNum1.Next(20, 50);
            // division numbers generator
            //int Num7 = randomNum1.Next(60, 120);
            // int Num8 = randomNum1.Next(4, 50);

            // Operator Array 
            //string[] Oper = { "+", "-", "*", "/" };

            // Addition Question
            // OperText1.Text = Oper[0];
            //FirstNumber.Text = Num1.ToString();
            // SecondNumber.Text = Num2.ToString();
            // Subtraction Question
            //OperText2.Text = Oper[1];
            //ThirdNumber.Text = Num3.ToString();
            //FourthNumber.Text = Num4.ToString();
            // Multiplication Question
            // OperText3.Text = Oper[2];
            // FiveNumber.Text = Num5.ToString();
            //SixthNumber.Text = Num6.ToString();
            // Division Question
            // OperText4.Text = Oper[3];
            //SeventhNumber.Text = Num7.ToString();
            //EightNumber.Text = Num8.ToString();

            // =============== Answer Checker Code =================

            // Declaring different numbers/questions
            // First num and Second num
            var FirstNum = int.Parse(label5.Text);
            var SecondNum = int.Parse(label6.Text);
            // Third num and Fourth num 
            var ThirdNum = int.Parse(label11.Text);
            var FourthNum = int.Parse(label10.Text);
            // Five num and Sixth num
            var FiveNum = int.Parse(label14.Text);
            var SixthNum = int.Parse(label13.Text);
            // Seventh num and Eight num 
            var SeventhNum = int.Parse(label17.Text);
            var EightNum = int.Parse(label16.Text);

            // Declaring Scoreboard
            var Score = label8;
            int ScoreNum = Convert.ToInt16(label8.Text);
            // int DefaultValue = ScoreNum = 0; 

           
            // Declaring different Operators 
            var OperTextCon1 = Convert.ToString(label7.Text);
            var OperTextCon2 = Convert.ToString(label9.Text);
            var OperTextCon3 = Convert.ToString(label12.Text);
            var OperTextCon4 = Convert.ToString(label15.Text); 


            // Declaring Different Result Boxes 
            var AnswerBox1 = textBox3;
            var AnswerBox2 = textBox4;
            var AnswerBox3 = textBox5;
            var AnswerBox4 = textBox6; 

            // If statements 
            if (OperTextCon1 == "+") // Checks if the equation is addition 
            {
                int AnsKey1 = FirstNum + SecondNum; // Adds num
                int Answer1 = int.Parse(AnswerBox1.Text); // Converts to Int
                var print1 = AnsKey1.ToString();// Converts Result to String
                if (AnsKey1 == Answer1) // Checks if Generated Question Answer = to user input answer
                    
                {
                    // Score Board Updater
                    int ScoreNum1 = Convert.ToInt16(label8.Text); // Converts to int
                    int NewScore1 = ScoreNum1 + 1; // Updates the ScoreBoard
                    // var printScore1 = NewScore1.ToString(); old code, not mandatory
                    Score.Text = Convert.ToString(NewScore1); // Displays the score via converting += 1 int to string

                }
                else 
                {
                    // If Wrong
                    Console.WriteLine("Its wrong"); // coders checking
                    int ScoreNum2 = Convert.ToInt16(label8.Text); // int Conversion
                    int SubScore1 = ScoreNum2 - 1; // Minus one in scoreboard if user input is wrong
                    // var printSub1 = SubScore1.ToString(); old code, not mandated
                    Score.Text = Convert.ToString(SubScore1); // Displays it
                    // This process of code is repeated until every answer type is checked. 
                    // [+, -, *, / - 4 Questions for each operator type]
                    
                }
               

            }

            if (OperTextCon2 == "-") // sub
            {
                int AnsKey2 = ThirdNum - FourthNum;
                int Answer2 = int.Parse(AnswerBox2.Text); 
                var print2 = AnsKey2.ToString();

                if (AnsKey2 == Answer2) 
                {
                    Console.WriteLine("Its correct");
                    int ScoreNum3  = Convert.ToInt16(label8.Text);
                    int NewScore2 = ScoreNum3 + 1;
                    var printScore2 = NewScore2.ToString();
                    Score.Text = Convert.ToString(NewScore2);
                }
              
                else 
                {
                    Console.WriteLine("Its wrong");
                    int ScoreNum4 = Convert.ToInt16(label8.Text);
                    int SubScore2 = ScoreNum4 - 1;
                    var printSub2 = SubScore2.ToString();
                    Score.Text = Convert.ToString(SubScore2);
                }
               
            }

            if (OperTextCon3 == "*") // multiply 
            {
                int AnsKey3 = FiveNum * SixthNum;
                int Answer3 = int.Parse(AnswerBox3.Text);
                var print3 = AnsKey3.ToString(); 

                if (AnsKey3 == Answer3) 
                {

                    Console.WriteLine("Its correct");
                    int ScoreNum5 = Convert.ToInt16(label8.Text);
                    int NewScore3 = ScoreNum5 + 1;
                    var printScore3 = NewScore3.ToString();
                    Score.Text = Convert.ToString(NewScore3);
                }
                
                else 
                {

                    Console.WriteLine("Its wrong");
                    int ScoreNum6 = Convert.ToInt16(label8.Text);
                    int SubScore3 = ScoreNum6 - 1;
                    var printSub3 = SubScore3.ToString();
                    Score.Text = Convert.ToString(SubScore3);

                   
                }

            }

            if (OperTextCon4 == "/") // divide 
            {
                int AnsKey4 = SeventhNum / EightNum;
                int Answer4 = int.Parse(AnswerBox4.Text);
                var print4 = AnsKey4.ToString(); 

                if (AnsKey4 == Answer4) 
                {
                    Console.WriteLine("Its correct");
                    int ScoreNum7 = Convert.ToInt16(label8.Text);
                    int NewScore4 = ScoreNum7 + 1;
                    var printScore4 = NewScore4.ToString();
                    Score.Text = Convert.ToString(NewScore4);
                }

                else 
                {
                    Console.WriteLine("Its wrong");
                    int ScoreNum8 = Convert.ToInt16(label8.Text);
                    int SubScore4 = ScoreNum8 - 1;
                    var printSub4 = SubScore4.ToString();
                    Score.Text = Convert.ToString(SubScore4);
                    
                }

                // [Old code that sadly didn't work]

                //if (ScoreNum < 0)
                //{
                    //int NewScoreValue = 0;
                    //string DefaultValue = NewScoreValue.ToString();
                    //Score.Text = DefaultValue;
               // }

            }

            // => Touka Images and Dialogue Code <=

            // [Button Code Variables] 
            Button genButton = button4;  
            // Answer Keys
            int Ans1 = FirstNum + SecondNum;
            int Ans2 = ThirdNum - FourthNum;
            int Ans3 = FiveNum * SixthNum;
            int Ans4 = SeventhNum / EightNum;
            // User Answer
            int UserAns1 = int.Parse(AnswerBox1.Text);
            int UserAns2 = int.Parse(AnswerBox2.Text);
            int UserAns3 = int.Parse(AnswerBox3.Text);
            int UserAns4 = int.Parse(AnswerBox4.Text);
            // Touka Images
            var picture2Angry = pictureBox2;
            var picture3Happy= pictureBox3;
            // Dialogue Variables
            var DialogueBox = label18;
            string DefaultResponse = "It's alright we can keep trying!";
            string HappyResponse = "Thank you.. for getting it all right";
            string AngryResponse = "UNFORGIVEABLEE!!!"; 


            // Scripting Part 
            if (Ans1 == UserAns1 && Ans2 == UserAns2 && Ans3 == UserAns3 && Ans4 == UserAns4)
            {
                //Fires code if all answers are correct
                picture1Default.Hide(); picture2Angry.Hide();  picture3Happy.Show();
                DialogueBox.Text = HappyResponse;  
            }

            else if  (Ans1 == UserAns1 && Ans2 == UserAns2 || Ans3 == UserAns3 && Ans4 == UserAns4) 
            {
                // Fires code if 2 answers are correct 
                picture1Default.Show(); picture2Angry.Hide(); picture3Happy.Hide();
                DialogueBox.Text = DefaultResponse; 
            }

            else 
            {
                // Fires Code if none of the answers are correct 
                picture2Angry.Show(); picture1Default.Hide(); picture3Happy.Hide();
                DialogueBox.Text = AngryResponse; 
            }

            //=> Question Generator Recoded <=

            // 1st and 2nd 
            var QNum1 = label5;
            var QNum2 = label6;
            // 3rd and 4th
            var QNum3 = label11;
            var QNum4 = label10;
            // 5th and 6th
            var QNum5 = label14;
            var QNum6 = label13;
            // 7th and 8th 
            var QNum7 = label17;
            var QNum8 = label16;

            Random newRand = new Random();
            //add
            int GenNum1 = newRand.Next(4, 50);
            int GenNum2 = newRand.Next(60, 120);
            //sub
            int GenNum3 = newRand.Next(70, 120);
            int GenNum4 = newRand.Next(10, 50);
            // mult
            int GenNum5 = newRand.Next(4, 20);
            int GenNum6 = newRand.Next(20, 50);
            // div
            int GenNum7 = newRand.Next(60, 120);
            int GenNum8 = newRand.Next(1, 10);

            //random addition
            QNum1.Text = GenNum1.ToString();
            QNum2.Text = GenNum2.ToString();

            // random subtraction 
            QNum3.Text = GenNum3.ToString();
            QNum4.Text = GenNum4.ToString();

            // random mult 
            QNum5.Text = GenNum5.ToString();
            QNum6.Text = GenNum6.ToString();

            // random div 
            QNum7.Text = GenNum7.ToString();
            QNum8.Text = GenNum8.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // plays the music
            _soundPlayer.PlayLooping(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Generate button 
            // Declaring different numbers/questions

            // First num and Second num
            var FirstNum = label5;
            var SecondNum = label6;
            // Third num and Fourth num 
            var ThirdNum = label11;
            var FourthNum = label10;
            // Five num and Sixth num
            var FiveNum = label14;
            var SixthNum = label13;
            // Seventh num and Eight num 
            var SeventhNum = label17;
            var EightNum = label16; 


            // Declaring different Operators 
            var OperText1 = label7;
            var OperText2 = label9;
            var OperText3 = label12;
            var OperText4 = label15; 

            // Random Number Generator
            Random randomNum1 = new Random();
            // addition numbers genrator
            int Num1 = randomNum1.Next(4, 50);
            int Num2 = randomNum1.Next(60, 120);
            // subtraction numbers generator
            int Num3 = randomNum1.Next(70, 120);
            int Num4 = randomNum1.Next(10, 50);
            // multiplication numbers generator
            int Num5 = randomNum1.Next(4, 20);
            int Num6 = randomNum1.Next(20, 50);
            // division numbers generator
            int Num7 = randomNum1.Next(60,120);
            int Num8 = randomNum1.Next(1, 10);

            // Operator Array 
            string[] Oper = { "+", "-", "*", "/" };

            // Addition Question
            OperText1.Text = Oper[0];
            FirstNum.Text = Num1.ToString();
            SecondNum.Text = Num2.ToString();
            // Subtraction Question
            OperText2.Text = Oper[1];
            ThirdNum.Text = Num3.ToString();
            FourthNum.Text = Num4.ToString();
            // Multiplication Question
            OperText3.Text = Oper[2];
            FiveNum.Text = Num5.ToString();
            SixthNum.Text = Num6.ToString();
            // Division Question
            OperText4.Text = Oper[3];
            SeventhNum.Text = Num7.ToString();
            EightNum.Text = Num8.ToString();

            // Touka's Default Script 
            var picture1Default = pictureBox1;
            var picture2Angry = pictureBox2;
            var picture3Happy = pictureBox3;

            picture1Default.Show();
            picture2Angry.Hide();
            picture3Happy.Hide();

            // Hides start button code: 

            var Button4 = button4; // Declares Button4
            Button4.Hide(); // Hides Button4 

            // Appearance and Disapearrance code code: 
            // Summary: Once the start button is clicked, the game begins.
            // Declaring Variables: 
            var SubButton = button3; 
            var ClearButton = button5;
            var ArrowGif = pictureBox4;  

            if (SubButton.Visible == false && ClearButton.Visible == false) // Checks if Submit and Clear Button are set to false 
            {
                SubButton.Visible = true; ClearButton.Visible = true; // Once button clicked, it makes it visible
                ArrowGif.Hide(); // Hides arrow GIF 
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // picture box
            var picture1Default = pictureBox1;
            picture1Default.Show();
           
            // textbox clear code 
            var textbox1 = textBox3;
            var textbox2 = textBox4;
            var textbox3 = textBox5;
            var textbox4 = textBox6;
            string cleartxt = "";

            textbox1.Text = cleartxt;
            textbox2.Text = cleartxt;
            textbox3.Text = cleartxt;
            textbox4.Text = cleartxt;

           


        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
