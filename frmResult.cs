using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
            lblRound.Text = frmStartGame.instance.cbRounds.Text;
            lblOperator.Text = frmStartGame.instance.cbOperator.Text;
            lblLevel.Text = frmStartGame.instance.cbLevel.Text;
            lblCorrectTime.Text = frmMathGame.Instance.GameInfo.CorrectAnswerTime.ToString();
            lblWrongTime.Text = frmMathGame.Instance.GameInfo.WrongAnswerTime.ToString();
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            if (frmMathGame.Instance.GameInfo.CorrectAnswerTime >
                frmMathGame.Instance.GameInfo.WrongAnswerTime)
            {
                lblIfPass.Text = "Pass (^_^)";
            }
            else
            {
                lblIfPass.Text = "Fail :-(";
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmStartGame.instance.Close();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Form frmMathGame = new frmMathGame();
            frmMathGame.Show();
            this.Close();
        }
    }
}
