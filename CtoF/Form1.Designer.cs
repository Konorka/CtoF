namespace CtoF
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
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.buttonFtoC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(245, 15);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(75, 23);
            this.buttonCtoF.TabIndex = 0;
            this.buttonCtoF.Text = "Váltás C -> F";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            this.buttonCtoF.Click += new System.EventHandler(this.buttonCtoF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Celsius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fahrenheit:";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(88, 15);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 20);
            this.textBoxC.TabIndex = 3;
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(88, 45);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(100, 20);
            this.textBoxF.TabIndex = 4;
            // 
            // buttonFtoC
            // 
            this.buttonFtoC.Location = new System.Drawing.Point(245, 45);
            this.buttonFtoC.Name = "buttonFtoC";
            this.buttonFtoC.Size = new System.Drawing.Size(75, 23);
            this.buttonFtoC.TabIndex = 5;
            this.buttonFtoC.Text = "Váltás F -> C";
            this.buttonFtoC.UseVisualStyleBackColor = true;
            this.buttonFtoC.Click += new System.EventHandler(this.buttonFtoC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 89);
            this.Controls.Add(this.buttonFtoC);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCtoF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Button buttonFtoC;
    }
}

