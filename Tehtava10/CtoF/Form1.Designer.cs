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
            this.label1 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.CelciusRBT = new System.Windows.Forms.RadioButton();
            this.FahrenheitRBT = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna asteet:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(123, 286);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(45, 13);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(251, 129);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(100, 20);
            this.AsteetTB.TabIndex = 2;
            // 
            // CelciusRBT
            // 
            this.CelciusRBT.AutoSize = true;
            this.CelciusRBT.Location = new System.Drawing.Point(454, 126);
            this.CelciusRBT.Name = "CelciusRBT";
            this.CelciusRBT.Size = new System.Drawing.Size(59, 17);
            this.CelciusRBT.TabIndex = 3;
            this.CelciusRBT.TabStop = true;
            this.CelciusRBT.Text = "Celcius";
            this.CelciusRBT.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRBT
            // 
            this.FahrenheitRBT.AutoSize = true;
            this.FahrenheitRBT.Location = new System.Drawing.Point(454, 149);
            this.FahrenheitRBT.Name = "FahrenheitRBT";
            this.FahrenheitRBT.Size = new System.Drawing.Size(75, 17);
            this.FahrenheitRBT.TabIndex = 4;
            this.FahrenheitRBT.TabStop = true;
            this.FahrenheitRBT.Text = "Fahrenheit";
            this.FahrenheitRBT.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Miten muunnat?";
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(640, 130);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(75, 23);
            this.MuunnaBT.TabIndex = 6;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FahrenheitRBT);
            this.Controls.Add(this.CelciusRBT);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox AsteetTB;
        private System.Windows.Forms.RadioButton CelciusRBT;
        private System.Windows.Forms.RadioButton FahrenheitRBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MuunnaBT;
    }
}

