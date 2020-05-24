namespace RockPaperScissors
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCentSecont = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(177, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 83);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(355, 30);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(146, 83);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(747, 400);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(70, 51);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "00";
          
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(822, 400);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 51);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = ":";
            // 
            // lblCentSecont
            // 
            this.lblCentSecont.AutoSize = true;
            this.lblCentSecont.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentSecont.Location = new System.Drawing.Point(863, 400);
            this.lblCentSecont.Name = "lblCentSecont";
            this.lblCentSecont.Size = new System.Drawing.Size(70, 51);
            this.lblCentSecont.TabIndex = 4;
            this.lblCentSecont.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(122, 330);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(113, 46);
            this.lblComputer.TabIndex = 5;
            this.lblComputer.Text = "Rock";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(276, 439);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(133, 46);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(456, 330);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(113, 46);
            this.lblPlayer.TabIndex = 7;
            this.lblPlayer.Text = "Rock";
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(785, 138);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(123, 57);
            this.btnRock.TabIndex = 8;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(785, 288);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(123, 56);
            this.btnScissors.TabIndex = 10;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(785, 215);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(123, 53);
            this.btnPaper.TabIndex = 11;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // picComputer
            // 
            this.picComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picComputer.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.picComputer.Location = new System.Drawing.Point(104, 157);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(154, 148);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComputer.TabIndex = 12;
            this.picComputer.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.picPlayer.Location = new System.Drawing.Point(426, 157);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(157, 148);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 13;
            this.picPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 517);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblCentSecont);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblCentSecont;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}

