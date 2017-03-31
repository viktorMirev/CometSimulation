namespace CometDustAndIceDistribution_Simulation
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
            this.TextBoxSpeed = new System.Windows.Forms.TextBox();
            this.TextBoxAccValue = new System.Windows.Forms.TextBox();
            this.TextBoxDeltaT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.TextBoxStep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBlur = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extraCheckBox = new System.Windows.Forms.CheckBox();
            this.extraLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accMulTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_AVGdist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxSpeed
            // 
            this.TextBoxSpeed.BackColor = System.Drawing.SystemColors.MenuText;
            this.TextBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSpeed.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxSpeed.Location = new System.Drawing.Point(6, 32);
            this.TextBoxSpeed.Name = "TextBoxSpeed";
            this.TextBoxSpeed.Size = new System.Drawing.Size(135, 26);
            this.TextBoxSpeed.TabIndex = 0;
            this.TextBoxSpeed.Text = "560";
            this.TextBoxSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxSpeed_KeyDown);
            // 
            // TextBoxAccValue
            // 
            this.TextBoxAccValue.BackColor = System.Drawing.SystemColors.MenuText;
            this.TextBoxAccValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxAccValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAccValue.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxAccValue.Location = new System.Drawing.Point(527, 5);
            this.TextBoxAccValue.Name = "TextBoxAccValue";
            this.TextBoxAccValue.Size = new System.Drawing.Size(67, 26);
            this.TextBoxAccValue.TabIndex = 3;
            this.TextBoxAccValue.Text = "2";
            this.TextBoxAccValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAccValue_KeyDown);
            // 
            // TextBoxDeltaT
            // 
            this.TextBoxDeltaT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBoxDeltaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDeltaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxDeltaT.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxDeltaT.Location = new System.Drawing.Point(250, 4);
            this.TextBoxDeltaT.Name = "TextBoxDeltaT";
            this.TextBoxDeltaT.Size = new System.Drawing.Size(65, 26);
            this.TextBoxDeltaT.TabIndex = 1;
            this.TextBoxDeltaT.Text = "1";
            this.TextBoxDeltaT.TextChanged += new System.EventHandler(this.TextBoxDeltaT_TextChanged);
            this.TextBoxDeltaT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxDeltaT_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Initial Speed [m/s]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 566);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(957, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "SIMULATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTime.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxTime.Location = new System.Drawing.Point(250, 32);
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(65, 26);
            this.TextBoxTime.TabIndex = 2;
            this.TextBoxTime.Text = "32";
            this.TextBoxTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxTime_KeyDown);
            // 
            // TextBoxStep
            // 
            this.TextBoxStep.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextBoxStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxStep.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxStep.Location = new System.Drawing.Point(527, 33);
            this.TextBoxStep.Name = "TextBoxStep";
            this.TextBoxStep.Size = new System.Drawing.Size(67, 26);
            this.TextBoxStep.TabIndex = 4;
            this.TextBoxStep.Text = "10";
            this.TextBoxStep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxStep_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(162, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "dT   [days]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(332, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(420, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Particle Radius [10E-6 m]                         AVG Distance [AU]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(153, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Time [days]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(332, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Particle Step [degrees]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(784, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Blur";
            // 
            // checkBlur
            // 
            this.checkBlur.AutoSize = true;
            this.checkBlur.BackColor = System.Drawing.Color.Black;
            this.checkBlur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBlur.FlatAppearance.BorderSize = 10;
            this.checkBlur.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBlur.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBlur.Location = new System.Drawing.Point(771, 12);
            this.checkBlur.Name = "checkBlur";
            this.checkBlur.Size = new System.Drawing.Size(15, 14);
            this.checkBlur.TabIndex = 5;
            this.checkBlur.UseVisualStyleBackColor = false;
            this.checkBlur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBlur_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(1002, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "© Viktor Mirev";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // extraCheckBox
            // 
            this.extraCheckBox.AutoSize = true;
            this.extraCheckBox.BackColor = System.Drawing.Color.Black;
            this.extraCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.extraCheckBox.FlatAppearance.BorderSize = 10;
            this.extraCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.extraCheckBox.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extraCheckBox.Location = new System.Drawing.Point(771, 38);
            this.extraCheckBox.Name = "extraCheckBox";
            this.extraCheckBox.Size = new System.Drawing.Size(15, 14);
            this.extraCheckBox.TabIndex = 5;
            this.extraCheckBox.UseVisualStyleBackColor = false;
            // 
            // extraLabel
            // 
            this.extraLabel.AutoSize = true;
            this.extraLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extraLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.extraLabel.Location = new System.Drawing.Point(785, 36);
            this.extraLabel.Name = "extraLabel";
            this.extraLabel.Size = new System.Drawing.Size(60, 20);
            this.extraLabel.TabIndex = 21;
            this.extraLabel.Text = "Ion Tail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(844, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Acc multiplier";
            // 
            // accMulTb
            // 
            this.accMulTb.BackColor = System.Drawing.SystemColors.InfoText;
            this.accMulTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accMulTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accMulTb.ForeColor = System.Drawing.Color.DarkGray;
            this.accMulTb.Location = new System.Drawing.Point(848, 33);
            this.accMulTb.Name = "accMulTb";
            this.accMulTb.Size = new System.Drawing.Size(101, 26);
            this.accMulTb.TabIndex = 6;
            this.accMulTb.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(-1, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Version 4.3";
            // 
            // TextBox_AVGdist
            // 
            this.TextBox_AVGdist.BackColor = System.Drawing.SystemColors.MenuText;
            this.TextBox_AVGdist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_AVGdist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_AVGdist.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBox_AVGdist.Location = new System.Drawing.Point(614, 33);
            this.TextBox_AVGdist.Name = "TextBox_AVGdist";
            this.TextBox_AVGdist.Size = new System.Drawing.Size(132, 26);
            this.TextBox_AVGdist.TabIndex = 5;
            this.TextBox_AVGdist.Text = "2,5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1110, 657);
            this.Controls.Add(this.TextBox_AVGdist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accMulTb);
            this.Controls.Add(this.extraCheckBox);
            this.Controls.Add(this.extraLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBlur);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxStep);
            this.Controls.Add(this.TextBoxTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxDeltaT);
            this.Controls.Add(this.TextBoxAccValue);
            this.Controls.Add(this.TextBoxSpeed);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CometDustAndIceDistribution_Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSpeed;
        private System.Windows.Forms.TextBox TextBoxAccValue;
        private System.Windows.Forms.TextBox TextBoxDeltaT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxTime;
        private System.Windows.Forms.TextBox TextBoxStep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBlur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox extraCheckBox;
        private System.Windows.Forms.Label extraLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accMulTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_AVGdist;
    }
}

