namespace WindowsFormsApplication9
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
            this.x = new System.Windows.Forms.Timer(this.components);
            this.exit = new System.Windows.Forms.PictureBox();
            this.boo1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.boo = new System.Windows.Forms.PictureBox();
            this.borderR = new System.Windows.Forms.PictureBox();
            this.borderD = new System.Windows.Forms.PictureBox();
            this.borderU = new System.Windows.Forms.PictureBox();
            this.borderL = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::WindowsFormsApplication9.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Location = new System.Drawing.Point(216, 57);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 50);
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            // 
            // boo1
            // 
            this.boo1.BackgroundImage = global::WindowsFormsApplication9.Properties.Resources.ghost;
            this.boo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boo1.Location = new System.Drawing.Point(181, 154);
            this.boo1.Name = "boo1";
            this.boo1.Size = new System.Drawing.Size(100, 50);
            this.boo1.TabIndex = 1;
            this.boo1.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore.Location = new System.Drawing.Point(508, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(39, 15);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score";
            // 
            // boo
            // 
            this.boo.BackgroundImage = global::WindowsFormsApplication9.Properties.Resources.ghost;
            this.boo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boo.Location = new System.Drawing.Point(127, 56);
            this.boo.Name = "boo";
            this.boo.Size = new System.Drawing.Size(100, 50);
            this.boo.TabIndex = 3;
            this.boo.TabStop = false;
            // 
            // borderR
            // 
            this.borderR.Location = new System.Drawing.Point(522, 56);
            this.borderR.Name = "borderR";
            this.borderR.Size = new System.Drawing.Size(100, 50);
            this.borderR.TabIndex = 4;
            this.borderR.TabStop = false;
            // 
            // borderD
            // 
            this.borderD.Location = new System.Drawing.Point(424, 166);
            this.borderD.Name = "borderD";
            this.borderD.Size = new System.Drawing.Size(100, 50);
            this.borderD.TabIndex = 5;
            this.borderD.TabStop = false;
            // 
            // borderU
            // 
            this.borderU.Location = new System.Drawing.Point(215, 13);
            this.borderU.Name = "borderU";
            this.borderU.Size = new System.Drawing.Size(100, 50);
            this.borderU.TabIndex = 6;
            this.borderU.TabStop = false;
            // 
            // borderL
            // 
            this.borderL.Location = new System.Drawing.Point(338, 153);
            this.borderL.Name = "borderL";
            this.borderL.Size = new System.Drawing.Size(100, 50);
            this.borderL.TabIndex = 7;
            this.borderL.TabStop = false;
            // 
            // pacman
            // 
            this.pacman.BackgroundImage = global::WindowsFormsApplication9.Properties.Resources.Pacman;
            this.pacman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pacman.Location = new System.Drawing.Point(45, 45);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(30, 30);
            this.pacman.TabIndex = 8;
            this.pacman.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(779, 393);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.borderL);
            this.Controls.Add(this.borderU);
            this.Controls.Add(this.borderD);
            this.Controls.Add(this.borderR);
            this.Controls.Add(this.boo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.boo1);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Timer x;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox boo1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox boo;
        private System.Windows.Forms.PictureBox borderR;
        private System.Windows.Forms.PictureBox borderD;
        private System.Windows.Forms.PictureBox borderU;
        private System.Windows.Forms.PictureBox borderL;
        private System.Windows.Forms.PictureBox pacman;
    }
}

