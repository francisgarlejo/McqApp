/*Assignment1_FrancisGarlejo.sln
 * Assignment 1 - MCQ Game
 * 
 * Revision History:
 *      Francis Gerald Garlejo 
 *      2022.09.24: Created,
 *      2022.09.27: Revised,
 *      2022.09.28: Revised,
 *      2022.10.01: Finalized
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using System.Runtime.ExceptionServices;

namespace Assignment1_FrancisGarlejo
{
    public partial class FormMCQ : Form
    {
        int questionNumber = 0;
        int correctAnswer;
        int score = 0;
        int buttonTag;
        private int coutdownTimer = 60;
        string questionHint;
        Random randomNumber = new Random();
        public FormMCQ()
        {
            InitializeComponent();
            askQuestion(getRandomNum());
            lblPoints.Text = "Points: " + score.ToString();
            colorLabel();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        // Generate the random number for the questions

        Random random = new Random();
        static List<int> randomList = new List<int>();

        private int getRandomNum()
        {
            if (randomList.Count == 7)
            {
                return 7;
            }
            int num = random.Next(7);
            while (randomList.Contains(num))
            {
                num = random.Next(7);
            }

            randomList.Add(num);

            return num;
        }

        // Display the player name entered in the Login form
        public void enterName(string name)
        {
            lblPlayerName.Text = "Player Name: " + name;
        }

        // Color the label for each level
        public void colorLabel()
        {
            lblLevel1.BackColor = Color.Transparent;
            lblLevel2.BackColor = Color.Transparent;
            lblLevel3.BackColor = Color.Transparent;
            lblLevel4.BackColor = Color.Transparent;
            lblLevel5.BackColor = Color.Transparent;
            lblLevel6.BackColor = Color.Transparent;
            lblLevel7.BackColor = Color.Transparent;

            switch (questionNumber)
            {
                case 0:
                    lblLevel1.BackColor = Color.Red;
                    break;

                case 1:
                    lblLevel2.BackColor = Color.Red;
                    break;

                case 2:
                    lblLevel3.BackColor = Color.Red;
                    break;

                case 3:
                    lblLevel4.BackColor = Color.Red;
                    break;

                case 4:
                    lblLevel5.BackColor = Color.Red;
                    break;

                case 5:
                    lblLevel6.BackColor = Color.Red;
                    break;

                case 6:
                    lblLevel7.BackColor = Color.Red;
                    break;
            }
        }

        // Function that will run upon moving to the next level
        private void nextLevel()
        {
            timer.Stop();
            coutdownTimer = 60;
            timer.Interval = 1000;
            timer.Start();
            questionNumber++;
            askQuestion(getRandomNum());
            colorLabel();


            btnOpt1.BackColor = Color.White;
            btnOpt2.BackColor = Color.White;
            btnOpt3.BackColor = Color.White;
            btnOpt4.BackColor = Color.White;

            btnOpt1.Enabled = true;
            btnOpt2.Enabled = true;
            btnOpt3.Enabled = true;
            btnOpt4.Enabled = true;

            if (questionNumber == 7)
            {
                timer.Stop();
            }
        }

        // Dialog box pop-up after finishing all the levels

        public void dialogBox()
        {
            DialogResult result = MessageBox.Show("Quiz Ended!!!" + "\n" + "\n" + "Your total points: " + score + "\n" + "\n" + "Do you want to play again?", "Player Option", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                randomList = new List<int>();
                LoginForm playerOption = new LoginForm();
                playerOption.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        // Dialog box pop-up after choosing the wrong answer

        public void incorrectDialogBox()
        {
            DialogResult result = MessageBox.Show("Better Try Next Time!!!" + "\n" + "\n" + "Your total points: " + score + "\n" + "\n" + "Do you want to play again?", "Player Option", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                randomList = new List<int>();
                LoginForm playerOption = new LoginForm();
                playerOption.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        // Function for the fifty-fifty button.
        public void disableTwoOption()
        {
            try
            {
                int disableBtnCount = 0;

                foreach (var button in this.Controls.OfType<Button>())
                {

                    if (button.Tag != null && button.Tag.ToString() != correctAnswer.ToString())
                    {

                        button.Enabled = false;
                        button.BackColor = Color.LightGray;
                        disableBtnCount++;
                    }
                    if (disableBtnCount > 1)
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        // Button event to check and verify player's choice

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            try
            {
                var senderObject = (Button)sender;

                buttonTag = Convert.ToInt32(senderObject.Tag);

                // Correct Answer
                if (buttonTag == correctAnswer)
                {
                    switch (questionNumber)
                    {
                        case 0:
                            Console.WriteLine("score: 100");
                            score = score + 100;
                            break;
                        case 1:
                            Console.WriteLine("score: 1000");
                            score = score + 1000;
                            break;
                        case 2:
                            Console.WriteLine("score: 10000");
                            score = score + 10000;
                            break;
                        case 3:
                            Console.WriteLine("score: 100000");
                            score = score + 100000;
                            break;
                        case 4:
                            Console.WriteLine("score: 1000000");
                            score = score + 1000000;
                            break;
                        case 5:
                            Console.WriteLine("score: 10000000");
                            score = score + 10000000;
                            break;
                        case 6:
                            Console.WriteLine("score: 100000000");
                            score = score + 100000000;
                            break;
                    }

                    lblPoints.Text = "Points: " + score.ToString();

                    nextLevel();

                    MessageBox.Show("Congratulations!!!");

                    if (questionNumber > 6)
                    {
                        Console.WriteLine("Game ended!" + questionNumber);

                        dialogBox();
                    }
                }
                else
                {
                    // Incorrect Answer
                    disableAllButton();
                    timer.Stop();

                    foreach (var button in this.Controls.OfType<Button>())
                    {
                        if (button.Tag != null && int.Parse(button.Tag.ToString()) == correctAnswer)
                        {
                            button.BackColor = Color.CornflowerBlue;
                            button.Enabled = false;

                        }

                    }
                    incorrectDialogBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        
        // List of questions for the MCQ game
        public void askQuestion(int questionNum)
        {
            try
            {
                switch (questionNum)
                {
                    case 0:
                        lblQuestion.Text = " What is the sum of 55 + 44?";


                        btnOpt1.Text = "88";
                        btnOpt2.Text = "98";
                        btnOpt3.Text = "99";
                        btnOpt4.Text = "89";

                        correctAnswer = 3;

                        questionHint = "98 + 1";

                        break;

                    case 1:
                        lblQuestion.Text = "What is the product of 33 and 3?";
                        btnOpt1.Text = "99 ";
                        btnOpt2.Text = "88";
                        btnOpt3.Text = "98";
                        btnOpt4.Text = "89";

                        correctAnswer = 1;

                        questionHint = "100 - 1";

                        break;

                    case 2:
                        lblQuestion.Text = "What is the quotient of 81 and 9?";

                        btnOpt1.Text = "8";
                        btnOpt2.Text = "7";
                        btnOpt3.Text = "6";
                        btnOpt4.Text = "9";

                        correctAnswer = 4;

                        questionHint = "3 + 3 + 3";

                        break;

                    case 3:
                        lblQuestion.Text = "What is the difference of 132 and 87?";

                        btnOpt1.Text = "44";
                        btnOpt2.Text = "45";
                        btnOpt3.Text = "46";
                        btnOpt4.Text = "47";

                        correctAnswer = 2;

                        questionHint = "46 - 1";

                        break;

                    case 4:
                        lblQuestion.Text = "Who is the inventor of Basketball?";

                        btnOpt1.Text = "James Naismith";
                        btnOpt2.Text = "Jake Naismith";
                        btnOpt3.Text = "John Naismith";
                        btnOpt4.Text = "Jonathan Naismith";

                        correctAnswer = 1;

                        questionHint = "Jam__ Naismith";

                        break;

                    case 5:
                        lblQuestion.Text = "Who invented the light bulb?";

                        btnOpt1.Text = "Albert Einstein";
                        btnOpt2.Text = "Joseph Swan";
                        btnOpt3.Text = "Hiram Maxim";
                        btnOpt4.Text = "Thomas Edison";

                        correctAnswer = 4;

                        questionHint = "Tho___ Ed____";

                        break;

                    case 6:
                        lblQuestion.Text = "What is the biggest planet in our solar system?";

                        btnOpt1.Text = "Mars";
                        btnOpt2.Text = "Jupiter";
                        btnOpt3.Text = "Saturn";
                        btnOpt4.Text = "Uranus";

                        correctAnswer = 2;

                        questionHint = "J______";

                        break;
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        // Event for the timer
        private void timer_Tick(object sender, EventArgs e)
        {
            coutdownTimer--;
            lblCountdownTimer.Text = "00:" + coutdownTimer.ToString();

            if (coutdownTimer == 0)
            {
                timer.Stop();
                lblCountdownTimer.Text = coutdownTimer.ToString();
                btnOpt1.Enabled = false;
                btnOpt2.Enabled = false;
                btnOpt3.Enabled = false;
                btnOpt4.Enabled = false;
                btnFiftyFifty.Enabled = false;
                btnHint.Enabled = false;
                dialogBox();
            }

        }

        // Event for the Hint
        private void btnHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(questionHint);

            btnHint.Enabled = false;
            btnHint.BackColor = Color.LightGray;
        }

        // Event for the Fifty-fifty
        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
            disableTwoOption();

            btnFiftyFifty.Enabled = false;
            btnFiftyFifty.BackColor = Color.LightGray;
        }

        // Disable all the buttons in the MCQ Form
        private void disableAllButton()
        {
            btnFiftyFifty.Enabled = false;
            btnHint.Enabled = false;
            btnOpt1.Enabled = false;
            btnOpt2.Enabled = false;
            btnOpt3.Enabled = false;
            btnOpt4.Enabled = false;
        }
    }
}
