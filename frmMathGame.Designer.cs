namespace Math_Game
{
    partial class frmMathGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRightAnswer = new System.Windows.Forms.Label();
            this.lblPlayerAnswer = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblShowOperater = new System.Windows.Forms.Label();
            this.lll = new System.Windows.Forms.Label();
            this.pbNextQuestion = new System.Windows.Forms.PictureBox();
            this.pbReset = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pReset = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Round:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblLevel.Location = new System.Drawing.Point(121, 46);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 21);
            this.lblLevel.TabIndex = 4;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRound.Location = new System.Drawing.Point(121, 12);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(0, 21);
            this.lblRound.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTime.Location = new System.Drawing.Point(121, 114);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 21);
            this.lblTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(586, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Right Answer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(586, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player Answer:";
            // 
            // lblRightAnswer
            // 
            this.lblRightAnswer.AutoSize = true;
            this.lblRightAnswer.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswer.ForeColor = System.Drawing.Color.Red;
            this.lblRightAnswer.Location = new System.Drawing.Point(732, 28);
            this.lblRightAnswer.Name = "lblRightAnswer";
            this.lblRightAnswer.Size = new System.Drawing.Size(0, 39);
            this.lblRightAnswer.TabIndex = 9;
            // 
            // lblPlayerAnswer
            // 
            this.lblPlayerAnswer.AutoSize = true;
            this.lblPlayerAnswer.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAnswer.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayerAnswer.Location = new System.Drawing.Point(732, 76);
            this.lblPlayerAnswer.Name = "lblPlayerAnswer";
            this.lblPlayerAnswer.Size = new System.Drawing.Size(0, 39);
            this.lblPlayerAnswer.TabIndex = 10;
            // 
            // lblNumber1
            // 
            this.lblNumber1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.ForeColor = System.Drawing.Color.Blue;
            this.lblNumber1.Location = new System.Drawing.Point(302, 173);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(89, 50);
            this.lblNumber1.TabIndex = 11;
            this.lblNumber1.Tag = "";
            this.lblNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber2
            // 
            this.lblNumber2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.ForeColor = System.Drawing.Color.Blue;
            this.lblNumber2.Location = new System.Drawing.Point(418, 173);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(83, 50);
            this.lblNumber2.TabIndex = 12;
            this.lblNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.Red;
            this.lblOperator.Location = new System.Drawing.Point(377, 162);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(54, 61);
            this.lblOperator.TabIndex = 0;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCheckAnswer.Location = new System.Drawing.Point(287, 269);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(224, 36);
            this.btnCheckAnswer.TabIndex = 15;
            this.btnCheckAnswer.Text = "CHECK ANSWER";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.DarkGray;
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAnswer.Location = new System.Drawing.Point(287, 226);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(224, 37);
            this.txtAnswer.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblShowOperater
            // 
            this.lblShowOperater.AutoSize = true;
            this.lblShowOperater.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOperater.ForeColor = System.Drawing.Color.Firebrick;
            this.lblShowOperater.Location = new System.Drawing.Point(121, 80);
            this.lblShowOperater.Name = "lblShowOperater";
            this.lblShowOperater.Size = new System.Drawing.Size(0, 21);
            this.lblShowOperater.TabIndex = 26;
            // 
            // lll
            // 
            this.lll.AutoSize = true;
            this.lll.BackColor = System.Drawing.Color.Gray;
            this.lll.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lll.ForeColor = System.Drawing.Color.White;
            this.lll.Location = new System.Drawing.Point(12, 81);
            this.lll.Name = "lll";
            this.lll.Size = new System.Drawing.Size(95, 18);
            this.lll.TabIndex = 25;
            this.lll.Text = "Operator:";
            // 
            // pbNextQuestion
            // 
            this.pbNextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNextQuestion.Image = global::Math_Game.Properties.Resources.Next;
            this.pbNextQuestion.Location = new System.Drawing.Point(505, 342);
            this.pbNextQuestion.Name = "pbNextQuestion";
            this.pbNextQuestion.Size = new System.Drawing.Size(86, 87);
            this.pbNextQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNextQuestion.TabIndex = 28;
            this.pbNextQuestion.TabStop = false;
            this.pbNextQuestion.Click += new System.EventHandler(this.pbNextQuestion_Click);
            // 
            // pbReset
            // 
            this.pbReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReset.Image = global::Math_Game.Properties.Resources.Result;
            this.pbReset.Location = new System.Drawing.Point(660, 342);
            this.pbReset.Name = "pbReset";
            this.pbReset.Size = new System.Drawing.Size(86, 87);
            this.pbReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReset.TabIndex = 27;
            this.pbReset.TabStop = false;
            this.pbReset.Click += new System.EventHandler(this.pbReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Math_Game.Properties.Resources.Operators;
            this.pictureBox1.Location = new System.Drawing.Point(301, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::Math_Game.Properties.Resources.question_mark;
            this.pb1.Location = new System.Drawing.Point(40, 180);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(166, 132);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 17;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::Math_Game.Properties.Resources.question_mark;
            this.pb2.Location = new System.Drawing.Point(576, 180);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(166, 132);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 16;
            this.pb2.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStart.Image = global::Math_Game.Properties.Resources.Start;
            this.pbStart.Location = new System.Drawing.Point(350, 342);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(86, 87);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStart.TabIndex = 29;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // pReset
            // 
            this.pReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pReset.Image = global::Math_Game.Properties.Resources.Reset;
            this.pReset.Location = new System.Drawing.Point(195, 342);
            this.pReset.Name = "pReset";
            this.pReset.Size = new System.Drawing.Size(86, 87);
            this.pReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pReset.TabIndex = 30;
            this.pReset.TabStop = false;
            this.pReset.Click += new System.EventHandler(this.pReset_Click);
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::Math_Game.Properties.Resources.Back;
            this.pbBack.Location = new System.Drawing.Point(40, 342);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(86, 87);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 31;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // frmMathGame
            // 
            this.AcceptButton = this.btnCheckAnswer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pReset);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.pbNextQuestion);
            this.Controls.Add(this.pbReset);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblShowOperater);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lll);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.lblPlayerAnswer);
            this.Controls.Add(this.lblRightAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMathGame";
            this.Text = "Math Game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRightAnswer;
        private System.Windows.Forms.Label lblPlayerAnswer;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblShowOperater;
        private System.Windows.Forms.Label lll;
        private System.Windows.Forms.PictureBox pbReset;
        private System.Windows.Forms.PictureBox pbNextQuestion;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pReset;
        private System.Windows.Forms.PictureBox pbBack;
    }
}