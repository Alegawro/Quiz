namespace Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Score = new System.Windows.Forms.Label();
            this.Pytanie = new System.Windows.Forms.Label();
            this.Powitanie = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.OdpowiedzA = new System.Windows.Forms.Button();
            this.OdpowiedzB = new System.Windows.Forms.Button();
            this.OdpowiedzC = new System.Windows.Forms.Button();
            this.OdpowiedzD = new System.Windows.Forms.Button();
            this.OdpowiedzA_Tresc = new System.Windows.Forms.Label();
            this.OdpowiedzB_Tresc = new System.Windows.Forms.Label();
            this.OdpowiedzC_Tresc = new System.Windows.Forms.Label();
            this.OdpowiedzD_Tresc = new System.Windows.Forms.Label();
            this.Powitanie2 = new System.Windows.Forms.Label();
            this.Obrazek1 = new System.Windows.Forms.PictureBox();
            this.Obrazek2 = new System.Windows.Forms.PictureBox();
            this.Obrazek3 = new System.Windows.Forms.PictureBox();
            this.Obrazek4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek4)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(909, 545);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Wyjdź";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Score);
            this.groupBox1.Location = new System.Drawing.Point(822, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wynik";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Score.Location = new System.Drawing.Point(45, 20);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(73, 31);
            this.Score.TabIndex = 0;
            this.Score.Text = "0 pkt";
            // 
            // Pytanie
            // 
            this.Pytanie.AutoSize = true;
            this.Pytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pytanie.Location = new System.Drawing.Point(41, 59);
            this.Pytanie.Name = "Pytanie";
            this.Pytanie.Size = new System.Drawing.Size(119, 33);
            this.Pytanie.TabIndex = 3;
            this.Pytanie.Text = "Pytanie";
            // 
            // Powitanie
            // 
            this.Powitanie.AutoSize = true;
            this.Powitanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie.Location = new System.Drawing.Point(348, 143);
            this.Powitanie.Name = "Powitanie";
            this.Powitanie.Size = new System.Drawing.Size(245, 42);
            this.Powitanie.TabIndex = 4;
            this.Powitanie.Text = "Witaj w Quzie";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Chartreuse;
            this.Start.Location = new System.Drawing.Point(368, 294);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(196, 64);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // OdpowiedzA
            // 
            this.OdpowiedzA.BackColor = System.Drawing.Color.Silver;
            this.OdpowiedzA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdpowiedzA.Location = new System.Drawing.Point(33, 166);
            this.OdpowiedzA.Name = "OdpowiedzA";
            this.OdpowiedzA.Size = new System.Drawing.Size(141, 48);
            this.OdpowiedzA.TabIndex = 6;
            this.OdpowiedzA.Text = "Odpowiedz A";
            this.OdpowiedzA.UseVisualStyleBackColor = false;
            this.OdpowiedzA.Click += new System.EventHandler(this.OdpowiedzA_Click);
            // 
            // OdpowiedzB
            // 
            this.OdpowiedzB.BackColor = System.Drawing.Color.Silver;
            this.OdpowiedzB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzB.Location = new System.Drawing.Point(33, 257);
            this.OdpowiedzB.Name = "OdpowiedzB";
            this.OdpowiedzB.Size = new System.Drawing.Size(141, 48);
            this.OdpowiedzB.TabIndex = 7;
            this.OdpowiedzB.Text = "Odpowiedz B";
            this.OdpowiedzB.UseVisualStyleBackColor = false;
            this.OdpowiedzB.Click += new System.EventHandler(this.OdpowiedzB_Click);
            // 
            // OdpowiedzC
            // 
            this.OdpowiedzC.BackColor = System.Drawing.Color.Silver;
            this.OdpowiedzC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzC.Location = new System.Drawing.Point(33, 346);
            this.OdpowiedzC.Name = "OdpowiedzC";
            this.OdpowiedzC.Size = new System.Drawing.Size(141, 48);
            this.OdpowiedzC.TabIndex = 8;
            this.OdpowiedzC.Text = "Odpowiedz C";
            this.OdpowiedzC.UseVisualStyleBackColor = false;
            this.OdpowiedzC.Click += new System.EventHandler(this.OdpowiedzC_Click);
            // 
            // OdpowiedzD
            // 
            this.OdpowiedzD.BackColor = System.Drawing.Color.Silver;
            this.OdpowiedzD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzD.Location = new System.Drawing.Point(33, 435);
            this.OdpowiedzD.Name = "OdpowiedzD";
            this.OdpowiedzD.Size = new System.Drawing.Size(141, 48);
            this.OdpowiedzD.TabIndex = 9;
            this.OdpowiedzD.Text = "Odpowiedz D";
            this.OdpowiedzD.UseVisualStyleBackColor = false;
            this.OdpowiedzD.Click += new System.EventHandler(this.OdpowiedzD_Click);
            // 
            // OdpowiedzA_Tresc
            // 
            this.OdpowiedzA_Tresc.AutoSize = true;
            this.OdpowiedzA_Tresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzA_Tresc.Location = new System.Drawing.Point(224, 180);
            this.OdpowiedzA_Tresc.Name = "OdpowiedzA_Tresc";
            this.OdpowiedzA_Tresc.Size = new System.Drawing.Size(163, 20);
            this.OdpowiedzA_Tresc.TabIndex = 10;
            this.OdpowiedzA_Tresc.Text = "OdpowiedzA_Tresc";
            // 
            // OdpowiedzB_Tresc
            // 
            this.OdpowiedzB_Tresc.AutoSize = true;
            this.OdpowiedzB_Tresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzB_Tresc.Location = new System.Drawing.Point(224, 271);
            this.OdpowiedzB_Tresc.Name = "OdpowiedzB_Tresc";
            this.OdpowiedzB_Tresc.Size = new System.Drawing.Size(163, 20);
            this.OdpowiedzB_Tresc.TabIndex = 11;
            this.OdpowiedzB_Tresc.Text = "OdpowiedzB_Tresc";
            // 
            // OdpowiedzC_Tresc
            // 
            this.OdpowiedzC_Tresc.AutoSize = true;
            this.OdpowiedzC_Tresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzC_Tresc.Location = new System.Drawing.Point(224, 361);
            this.OdpowiedzC_Tresc.Name = "OdpowiedzC_Tresc";
            this.OdpowiedzC_Tresc.Size = new System.Drawing.Size(163, 20);
            this.OdpowiedzC_Tresc.TabIndex = 12;
            this.OdpowiedzC_Tresc.Text = "OdpowiedzC_Tresc";
            // 
            // OdpowiedzD_Tresc
            // 
            this.OdpowiedzD_Tresc.AutoSize = true;
            this.OdpowiedzD_Tresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OdpowiedzD_Tresc.Location = new System.Drawing.Point(224, 463);
            this.OdpowiedzD_Tresc.Name = "OdpowiedzD_Tresc";
            this.OdpowiedzD_Tresc.Size = new System.Drawing.Size(164, 20);
            this.OdpowiedzD_Tresc.TabIndex = 13;
            this.OdpowiedzD_Tresc.Text = "OdpowiedzD_Tresc";
            // 
            // Powitanie2
            // 
            this.Powitanie2.AutoSize = true;
            this.Powitanie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Powitanie2.Location = new System.Drawing.Point(246, 219);
            this.Powitanie2.Name = "Powitanie2";
            this.Powitanie2.Size = new System.Drawing.Size(428, 42);
            this.Powitanie2.TabIndex = 14;
            this.Powitanie2.Text = "o Politechnice Gdańskiej";
            // 
            // Obrazek1
            // 
            this.Obrazek1.Image = ((System.Drawing.Image)(resources.GetObject("Obrazek1.Image")));
            this.Obrazek1.Location = new System.Drawing.Point(208, 153);
            this.Obrazek1.Name = "Obrazek1";
            this.Obrazek1.Size = new System.Drawing.Size(134, 78);
            this.Obrazek1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obrazek1.TabIndex = 15;
            this.Obrazek1.TabStop = false;
            // 
            // Obrazek2
            // 
            this.Obrazek2.Image = ((System.Drawing.Image)(resources.GetObject("Obrazek2.Image")));
            this.Obrazek2.Location = new System.Drawing.Point(208, 245);
            this.Obrazek2.Name = "Obrazek2";
            this.Obrazek2.Size = new System.Drawing.Size(134, 75);
            this.Obrazek2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obrazek2.TabIndex = 16;
            this.Obrazek2.TabStop = false;
            this.Obrazek2.Click += new System.EventHandler(this.Obrazek2_Click);
            // 
            // Obrazek3
            // 
            this.Obrazek3.Image = ((System.Drawing.Image)(resources.GetObject("Obrazek3.Image")));
            this.Obrazek3.Location = new System.Drawing.Point(208, 336);
            this.Obrazek3.Name = "Obrazek3";
            this.Obrazek3.Size = new System.Drawing.Size(134, 75);
            this.Obrazek3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obrazek3.TabIndex = 17;
            this.Obrazek3.TabStop = false;
            this.Obrazek3.Click += new System.EventHandler(this.Obrazek3_Click);
            // 
            // Obrazek4
            // 
            this.Obrazek4.Image = ((System.Drawing.Image)(resources.GetObject("Obrazek4.Image")));
            this.Obrazek4.Location = new System.Drawing.Point(208, 434);
            this.Obrazek4.Name = "Obrazek4";
            this.Obrazek4.Size = new System.Drawing.Size(134, 75);
            this.Obrazek4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Obrazek4.TabIndex = 18;
            this.Obrazek4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 635);
            this.Controls.Add(this.Obrazek4);
            this.Controls.Add(this.Obrazek3);
            this.Controls.Add(this.Obrazek2);
            this.Controls.Add(this.Obrazek1);
            this.Controls.Add(this.Powitanie2);
            this.Controls.Add(this.OdpowiedzD_Tresc);
            this.Controls.Add(this.OdpowiedzC_Tresc);
            this.Controls.Add(this.OdpowiedzB_Tresc);
            this.Controls.Add(this.OdpowiedzA_Tresc);
            this.Controls.Add(this.OdpowiedzD);
            this.Controls.Add(this.OdpowiedzC);
            this.Controls.Add(this.OdpowiedzB);
            this.Controls.Add(this.OdpowiedzA);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Powitanie);
            this.Controls.Add(this.Pytanie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrazek4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Pytanie;
        private System.Windows.Forms.Label Powitanie;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button OdpowiedzA;
        private System.Windows.Forms.Button OdpowiedzB;
        private System.Windows.Forms.Button OdpowiedzC;
        private System.Windows.Forms.Button OdpowiedzD;
        private System.Windows.Forms.Label OdpowiedzA_Tresc;
        private System.Windows.Forms.Label OdpowiedzB_Tresc;
        private System.Windows.Forms.Label OdpowiedzC_Tresc;
        private System.Windows.Forms.Label OdpowiedzD_Tresc;
        private System.Windows.Forms.Label Powitanie2;
        private System.Windows.Forms.PictureBox Obrazek1;
        private System.Windows.Forms.PictureBox Obrazek2;
        private System.Windows.Forms.PictureBox Obrazek3;
        private System.Windows.Forms.PictureBox Obrazek4;
    }
}

