using Math_Game.Properties;
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
using static Math_Game.frmMathGame;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Math_Game
{
    public partial class frmMathGame : Form
    {

        private int Counter = 25;
        public static frmMathGame Instance;
        public stGameInfo GameInfo;


        public frmMathGame()
        {
            InitializeComponent();

            Instance = this;

            GameInfo.Rounds = Convert.ToByte(frmStartGame.instance.cbRounds.Text);
            GameInfo.Level = (enLevel)frmStartGame.instance.cbLevel.SelectedIndex;
            GameInfo.RoundNumber = 1;
            GameInfo.Operator = (enOperator)frmStartGame.instance.cbOperator.SelectedIndex;

            lblRound.Text = GameInfo.RoundNumber + "/" + GameInfo.Rounds.ToString();
            GameInfo.RoundNumber++;
            lblLevel.Text = GameInfo.Level.ToString();
            lblShowOperater.Text = GameInfo.Operator.ToString();

            pbReset.Enabled = false;
            btnCheckAnswer.Enabled = false;
            txtAnswer.Enabled = false;
            pbNextQuestion.Enabled = false;
            pReset.Enabled = false;
        }

        public enum enOperator
        {
            Addition = 0,
            Subtraction = 1,
            Multiplication = 2,
            Division = 3,
            Mix = 4 

        }
        public enum enLevel
        {
            Easy = 0,
            Medium = 1,
            Hard = 2,
            Mix = 3
        }
        public struct stGameInfo
        {
            public int Number1;
            public int Number2;
            public int RightAnswer;
            public int PlayerAnswer;
            public int CorrectAnswerTime;
            public int WrongAnswerTime;
            public byte Rounds;
            public byte RoundNumber;
            public enLevel Level;
            public byte Time;
            public enOperator Operator;
        }

        void GenarateNumbersBySelectedLevel()
        {

            Random Number1 = new Random();
            Random Number2 = new Random();
            Random Level = new Random();

            enLevel temp = GameInfo.Level;

            if (GameInfo.Level == enLevel.Mix)
            {
                GameInfo.Level = (enLevel) Level.Next(0,3);
            }


            switch (GameInfo.Level)
            {
                case enLevel.Easy:
                    GameInfo.Number1 = Number1.Next(1, 10);
                    GameInfo.Number2 = Number2.Next(11, 50);
                    break;

                case enLevel.Medium:
                    GameInfo.Number1 = Number1.Next(51, 200);
                    GameInfo.Number2 = Number2.Next(201, 400);
                    break;

                case enLevel.Hard:
                    GameInfo.Number1 = Number1.Next(401, 600);
                    GameInfo.Number2 = Number2.Next(601, 800);
                    break;

            }

            GameInfo.Level = temp;
            lblNumber1.Text = GameInfo.Number1.ToString();
            lblNumber2.Text = GameInfo.Number2.ToString();
        }

        void GetSelectedOperator()
        {
            enOperator temp = GameInfo.Operator; 

            Random Operator = new Random();

            if (GameInfo.Operator == enOperator.Mix)
            {
                GameInfo.Operator = (enOperator)Operator.Next(0, 4);
            }


            switch (GameInfo.Operator)
            {
                case enOperator.Addition:
                    lblOperator.Text = "+";
                    GameInfo.RightAnswer = GameInfo.Number1 + GameInfo.Number2;
                    break;

                case enOperator.Subtraction:
                    lblOperator.Text = "-";
                    GameInfo.RightAnswer = GameInfo.Number1 - GameInfo.Number2;
                    break;

                case enOperator.Division:
                    lblOperator.Text = "/";
                    GameInfo.RightAnswer = GameInfo.Number1 / GameInfo.Number2;
                    break;

                case enOperator.Multiplication:
                    lblOperator.Text = "*";
                    GameInfo.RightAnswer = GameInfo.Number1 * GameInfo.Number2;
                    break;

            }

            GameInfo.Operator = temp;
        }

        void UpdateAnswersLable()
        {
            lblPlayerAnswer.Text = GameInfo.PlayerAnswer.ToString();
            lblRightAnswer.Text = GameInfo.RightAnswer.ToString();
            pbNextQuestion.Enabled = true;
        }

        void CheckAnswer()
        {
            pbNextQuestion.Enabled = true;

            if (String.IsNullOrEmpty(txtAnswer.Text))
                return;

            GameInfo.PlayerAnswer = Convert.ToInt32(txtAnswer.Text);

            if (GameInfo.RightAnswer == GameInfo.PlayerAnswer)
            {
                GameInfo.CorrectAnswerTime++;
                pb1.Image = Resources.correct;
                pb2.Image = Resources.TrueBoy;
            }

            else
            {
                GameInfo.WrongAnswerTime++;
                pb1.Image = Resources.wrong;
                pb2.Image = Resources.FalseBoy;
            }

            UpdateAnswersLable();

        }

        void ResetLablesInfo()
        {
            GameInfo.RoundNumber = 1;
            lblRound.Text = GameInfo.RoundNumber + "/" + GameInfo.Rounds.ToString();
            lblRightAnswer.Text = "";
            lblPlayerAnswer.Text = "";
            txtAnswer.Clear();
            lblNumber1.Text = "";
            lblNumber2.Text = "";
            lblOperator.Text = "";
            Counter = 25;
            lblTime.Text = Counter.ToString();
        }
        void ResetLables()
        {
            txtAnswer.Clear();
            lblRightAnswer.Text = "";
            lblPlayerAnswer.Text = "";
            lblNumber1.Text = "";
            lblNumber2.Text = "";
            lblOperator.Text = "";
        }
        void ResetGameInfo()
        {
            GameInfo.CorrectAnswerTime = 0;
            GameInfo.WrongAnswerTime = 0;
            GameInfo.RoundNumber++;
        }
        void ResetImages()
        {
            pb1.Image = Resources.question_mark;
            pb2.Image = Resources.question_mark;
        }
        void ResetButtons()
        {
            btnCheckAnswer.Enabled = true;
            pbStart.Enabled = true;
            pbNextQuestion.Enabled = false;
        }
        void ResetMathGame()
        {
            ResetImages();
            ResetButtons();
            ResetLablesInfo();
            ResetGameInfo();
        }
        void ResetPage()
        {
            ResetImages();
            ResetLables();
        }

        void NextQuestion()
        {

            ResetPage();
            pbStart.Enabled = false;


            if (GameInfo.RoundNumber <= GameInfo.Rounds)
            {
                GenarateNumbersBySelectedLevel();
                GetSelectedOperator();

                lblRound.Text = GameInfo.RoundNumber + "/" + GameInfo.Rounds.ToString();
                GameInfo.RoundNumber++;
            }

            else
            {
                pbNextQuestion.Enabled = false;
                btnCheckAnswer.Enabled = false;
                txtAnswer.Enabled = false;
                pbReset.Enabled = true;
                timer1.Enabled = false;
                
            }
        }

        void StartGame()
        {
            GenarateNumbersBySelectedLevel();
            GetSelectedOperator();
            btnCheckAnswer.Enabled = true;
            txtAnswer.Enabled = true;
            pbNextQuestion.Enabled = true;
            pReset.Enabled = true;
            timer1.Enabled = true;
            pbNextQuestion.Enabled = false;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            lblTime.Text = Counter.ToString();

            if(Counter == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Time Over, Try Play Again","Game Over",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                pbStart.Enabled = false;
                pbNextQuestion.Enabled = false;
                btnCheckAnswer.Enabled = false;
                txtAnswer.Enabled = false;

            }
        }

        //private void txtAnswer_Validating_1(object sender, CancelEventArgs e)
        //{
        //    if (String.IsNullOrEmpty(txtAnswer.Text))
        //    {
        //        e.Cancel = true;
        //        txtAnswer.Focus();
        //        errorProvider1.SetError(txtAnswer, "Please Enter an Answer First");
        //    }

        //    else
        //    {
        //        e.Cancel = false;
        //        errorProvider1.SetError(txtAnswer, "");
        //    }
        //}

        private void pbNextQuestion_Click(object sender, EventArgs e)
        {
            NextQuestion();
            pbNextQuestion.Enabled = false;
        }

        private void pbReset_Click(object sender, EventArgs e)
        {
            Form frmResults = new frmResult();
            frmResults.Show();
            this.Close();
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            StartGame();
            pbStart.Enabled = false;
        }

        private void pReset_Click(object sender, EventArgs e)
        {
            ResetMathGame();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Form frmMainForm = new frmStartGame();
            frmMainForm.Show();
            this.Close();
        }
    }
}
