namespace BMILaskinTehtävä9
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
            this.label2 = new System.Windows.Forms.Label();
            this.PainoTB = new System.Windows.Forms.TextBox();
            this.PituusTB = new System.Windows.Forms.TextBox();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.IndeksiLB = new System.Windows.Forms.Label();
            this.PainoLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna paino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            this.PainoTB.Location = new System.Drawing.Point(153, 110);
            this.PainoTB.Name = "PainoTB";
            this.PainoTB.Size = new System.Drawing.Size(100, 20);
            this.PainoTB.TabIndex = 2;
            // 
            // PituusTB
            // 
            this.PituusTB.Location = new System.Drawing.Point(153, 162);
            this.PituusTB.Name = "PituusTB";
            this.PituusTB.Size = new System.Drawing.Size(100, 20);
            this.PituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(84, 204);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(169, 38);
            this.LaskeBT.TabIndex = 4;
            this.LaskeBT.Text = "Laske painoindeksi";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // IndeksiLB
            // 
            this.IndeksiLB.AutoSize = true;
            this.IndeksiLB.Location = new System.Drawing.Point(89, 283);
            this.IndeksiLB.Name = "IndeksiLB";
            this.IndeksiLB.Size = new System.Drawing.Size(35, 13);
            this.IndeksiLB.TabIndex = 5;
            this.IndeksiLB.Text = "XXXX";
            this.IndeksiLB.Visible = false;
            // 
            // PainoLB
            // 
            this.PainoLB.AutoSize = true;
            this.PainoLB.Location = new System.Drawing.Point(89, 312);
            this.PainoLB.Name = "PainoLB";
            this.PainoLB.Size = new System.Drawing.Size(35, 13);
            this.PainoLB.TabIndex = 6;
            this.PainoLB.Text = "XXXX";
            this.PainoLB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(Käytä pilkkuja pisteen sijaan)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PainoLB);
            this.Controls.Add(this.IndeksiLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.PituusTB);
            this.Controls.Add(this.PainoTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PainoTB;
        private System.Windows.Forms.TextBox PituusTB;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label IndeksiLB;
        private System.Windows.Forms.Label PainoLB;
        private System.Windows.Forms.Label label3;
    }
}

