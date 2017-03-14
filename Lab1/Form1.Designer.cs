namespace Lab2
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
            this.labal1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CosBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SinBox = new System.Windows.Forms.PictureBox();
            this.conBox = new System.Windows.Forms.PictureBox();
            this.corBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confftBox = new System.Windows.Forms.PictureBox();
            this.corfftBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CosBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confftBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corfftBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labal1
            // 
            this.labal1.Location = new System.Drawing.Point(0, 0);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(100, 23);
            this.labal1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function";
            // 
            // CosBox
            // 
            this.CosBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CosBox.Location = new System.Drawing.Point(44, 47);
            this.CosBox.Name = "CosBox";
            this.CosBox.Size = new System.Drawing.Size(200, 150);
            this.CosBox.TabIndex = 2;
            this.CosBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SinBox
            // 
            this.SinBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SinBox.Location = new System.Drawing.Point(44, 211);
            this.SinBox.Name = "SinBox";
            this.SinBox.Size = new System.Drawing.Size(200, 150);
            this.SinBox.TabIndex = 2;
            this.SinBox.TabStop = false;
            // 
            // conBox
            // 
            this.conBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.conBox.Location = new System.Drawing.Point(445, 47);
            this.conBox.Name = "conBox";
            this.conBox.Size = new System.Drawing.Size(200, 150);
            this.conBox.TabIndex = 2;
            this.conBox.TabStop = false;
            // 
            // corBox
            // 
            this.corBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.corBox.Location = new System.Drawing.Point(445, 211);
            this.corBox.Name = "corBox";
            this.corBox.Size = new System.Drawing.Size(200, 150);
            this.corBox.TabIndex = 2;
            this.corBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(442, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "without fft";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(667, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "with fft";
            // 
            // confftBox
            // 
            this.confftBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.confftBox.Location = new System.Drawing.Point(670, 47);
            this.confftBox.Name = "confftBox";
            this.confftBox.Size = new System.Drawing.Size(200, 150);
            this.confftBox.TabIndex = 2;
            this.confftBox.TabStop = false;
            // 
            // corfftBox
            // 
            this.corfftBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.corfftBox.Location = new System.Drawing.Point(670, 211);
            this.corfftBox.Name = "corfftBox";
            this.corfftBox.Size = new System.Drawing.Size(200, 150);
            this.corfftBox.TabIndex = 2;
            this.corfftBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(369, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "convolution";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(369, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "correlation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.corfftBox);
            this.Controls.Add(this.corBox);
            this.Controls.Add(this.SinBox);
            this.Controls.Add(this.confftBox);
            this.Controls.Add(this.conBox);
            this.Controls.Add(this.CosBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labal1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CosBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confftBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corfftBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CosBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox SinBox;
        private System.Windows.Forms.PictureBox conBox;
        private System.Windows.Forms.PictureBox corBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox confftBox;
        private System.Windows.Forms.PictureBox corfftBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

