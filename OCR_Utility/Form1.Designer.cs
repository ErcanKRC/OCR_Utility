namespace OCR_Utility
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
            this.GKB_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Recog_Button = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.FH_ProjBox = new System.Windows.Forms.TextBox();
            this.FV_ProjBox = new System.Windows.Forms.TextBox();
            this.CH_ProjBox = new System.Windows.Forms.TextBox();
            this.CV_ProjBox = new System.Windows.Forms.TextBox();
            this.HDiff_Box = new System.Windows.Forms.TextBox();
            this.VDiff_Box = new System.Windows.Forms.TextBox();
            this.EcuBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CharH_ProjBox = new System.Windows.Forms.Label();
            this.CharV_ProjBox = new System.Windows.Forms.Label();
            this.HDiffBox = new System.Windows.Forms.Label();
            this.VDiffBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GKB_button
            // 
            this.GKB_button.Location = new System.Drawing.Point(42, 93);
            this.GKB_button.Name = "GKB_button";
            this.GKB_button.Size = new System.Drawing.Size(231, 58);
            this.GKB_button.TabIndex = 0;
            this.GKB_button.Text = "Generate Knowledge Base";
            this.GKB_button.UseVisualStyleBackColor = true;
            this.GKB_button.Click += new System.EventHandler(this.GKB_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OCR_Utility.Properties.Resources.letter_f;
            this.pictureBox1.Location = new System.Drawing.Point(605, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(605, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Recog_Button
            // 
            this.Recog_Button.Location = new System.Drawing.Point(42, 238);
            this.Recog_Button.Name = "Recog_Button";
            this.Recog_Button.Size = new System.Drawing.Size(119, 49);
            this.Recog_Button.TabIndex = 3;
            this.Recog_Button.Text = "Recognition";
            this.Recog_Button.UseVisualStyleBackColor = true;
            this.Recog_Button.Click += new System.EventHandler(this.Recog_Button_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(308, 251);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(240, 20);
            this.PathBox.TabIndex = 4;
            this.PathBox.Text = "C:\\Users\\karac\\Downloads\\char1.bmp";
            // 
            // FH_ProjBox
            // 
            this.FH_ProjBox.Location = new System.Drawing.Point(42, 341);
            this.FH_ProjBox.Name = "FH_ProjBox";
            this.FH_ProjBox.Size = new System.Drawing.Size(100, 20);
            this.FH_ProjBox.TabIndex = 5;
            // 
            // FV_ProjBox
            // 
            this.FV_ProjBox.Location = new System.Drawing.Point(42, 397);
            this.FV_ProjBox.Name = "FV_ProjBox";
            this.FV_ProjBox.Size = new System.Drawing.Size(100, 20);
            this.FV_ProjBox.TabIndex = 6;
            // 
            // CH_ProjBox
            // 
            this.CH_ProjBox.Location = new System.Drawing.Point(173, 341);
            this.CH_ProjBox.Name = "CH_ProjBox";
            this.CH_ProjBox.Size = new System.Drawing.Size(100, 20);
            this.CH_ProjBox.TabIndex = 7;
            // 
            // CV_ProjBox
            // 
            this.CV_ProjBox.Location = new System.Drawing.Point(173, 397);
            this.CV_ProjBox.Name = "CV_ProjBox";
            this.CV_ProjBox.Size = new System.Drawing.Size(100, 20);
            this.CV_ProjBox.TabIndex = 8;
            // 
            // HDiff_Box
            // 
            this.HDiff_Box.Location = new System.Drawing.Point(346, 341);
            this.HDiff_Box.Name = "HDiff_Box";
            this.HDiff_Box.Size = new System.Drawing.Size(100, 20);
            this.HDiff_Box.TabIndex = 9;
            // 
            // VDiff_Box
            // 
            this.VDiff_Box.Location = new System.Drawing.Point(346, 397);
            this.VDiff_Box.Name = "VDiff_Box";
            this.VDiff_Box.Size = new System.Drawing.Size(100, 20);
            this.VDiff_Box.TabIndex = 10;
            // 
            // EcuBox
            // 
            this.EcuBox.Location = new System.Drawing.Point(492, 367);
            this.EcuBox.Name = "EcuBox";
            this.EcuBox.Size = new System.Drawing.Size(100, 20);
            this.EcuBox.TabIndex = 11;
            this.EcuBox.TextChanged += new System.EventHandler(this.EcuBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "F H_Proj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "F V_Proj";
            // 
            // CharH_ProjBox
            // 
            this.CharH_ProjBox.AutoSize = true;
            this.CharH_ProjBox.Location = new System.Drawing.Point(170, 325);
            this.CharH_ProjBox.Name = "CharH_ProjBox";
            this.CharH_ProjBox.Size = new System.Drawing.Size(64, 13);
            this.CharH_ProjBox.TabIndex = 15;
            this.CharH_ProjBox.Text = "Char H_Proj";
            // 
            // CharV_ProjBox
            // 
            this.CharV_ProjBox.AutoSize = true;
            this.CharV_ProjBox.Location = new System.Drawing.Point(170, 381);
            this.CharV_ProjBox.Name = "CharV_ProjBox";
            this.CharV_ProjBox.Size = new System.Drawing.Size(63, 13);
            this.CharV_ProjBox.TabIndex = 16;
            this.CharV_ProjBox.Text = "Char V_Proj";
            // 
            // HDiffBox
            // 
            this.HDiffBox.AutoSize = true;
            this.HDiffBox.Location = new System.Drawing.Point(343, 325);
            this.HDiffBox.Name = "HDiffBox";
            this.HDiffBox.Size = new System.Drawing.Size(37, 13);
            this.HDiffBox.TabIndex = 17;
            this.HDiffBox.Text = "H Diff.";
            // 
            // VDiffBox
            // 
            this.VDiffBox.AutoSize = true;
            this.VDiffBox.Location = new System.Drawing.Point(343, 381);
            this.VDiffBox.Name = "VDiffBox";
            this.VDiffBox.Size = new System.Drawing.Size(36, 13);
            this.VDiffBox.TabIndex = 18;
            this.VDiffBox.Text = "V Diff.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Eculeadean Distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 539);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VDiffBox);
            this.Controls.Add(this.HDiffBox);
            this.Controls.Add(this.CharV_ProjBox);
            this.Controls.Add(this.CharH_ProjBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EcuBox);
            this.Controls.Add(this.VDiff_Box);
            this.Controls.Add(this.HDiff_Box);
            this.Controls.Add(this.CV_ProjBox);
            this.Controls.Add(this.CH_ProjBox);
            this.Controls.Add(this.FV_ProjBox);
            this.Controls.Add(this.FH_ProjBox);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.Recog_Button);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GKB_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GKB_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Recog_Button;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox FH_ProjBox;
        private System.Windows.Forms.TextBox FV_ProjBox;
        private System.Windows.Forms.TextBox CH_ProjBox;
        private System.Windows.Forms.TextBox CV_ProjBox;
        private System.Windows.Forms.TextBox HDiff_Box;
        private System.Windows.Forms.TextBox VDiff_Box;
        private System.Windows.Forms.TextBox EcuBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CharH_ProjBox;
        private System.Windows.Forms.Label CharV_ProjBox;
        private System.Windows.Forms.Label HDiffBox;
        private System.Windows.Forms.Label VDiffBox;
        private System.Windows.Forms.Label label8;
    }
}

