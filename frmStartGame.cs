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
    public partial class frmStartGame : Form
    {
        public static frmStartGame instance;
        public frmStartGame()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmStartGame_Load(object sender, EventArgs e)
        {
            cbLevel.SelectedIndex = 0;
            cbOperator.SelectedIndex = 0;
            cbRounds.SelectedIndex = 2;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form frmMathGame = new frmMathGame();
            frmMathGame.Show();
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
