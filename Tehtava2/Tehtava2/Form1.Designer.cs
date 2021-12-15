
namespace Tehtava2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.otsikkoLB = new System.Windows.Forms.Label();
            this.tulostusLB = new System.Windows.Forms.Label();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.tulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.otsikkoLB.Location = new System.Drawing.Point(12, 45);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(435, 51);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "anna tulostettava teksti:";
            // 
            // tulostusLB
            // 
            this.tulostusLB.AutoSize = true;
            this.tulostusLB.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tulostusLB.Location = new System.Drawing.Point(12, 96);
            this.tulostusLB.Name = "tulostusLB";
            this.tulostusLB.Size = new System.Drawing.Size(111, 51);
            this.tulostusLB.TabIndex = 1;
            this.tulostusLB.Text = "xxxx";
            this.tulostusLB.Visible = false;
            // 
            // viestiTB
            // 
            this.viestiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viestiTB.Location = new System.Drawing.Point(452, 46);
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(309, 50);
            this.viestiTB.TabIndex = 2;
            // 
            // tulostaBT
            // 
            this.tulostaBT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tulostaBT.Location = new System.Drawing.Point(232, 231);
            this.tulostaBT.Name = "tulostaBT";
            this.tulostaBT.Size = new System.Drawing.Size(215, 72);
            this.tulostaBT.TabIndex = 3;
            this.tulostaBT.Text = "tulosta";
            this.tulostaBT.UseVisualStyleBackColor = true;
            this.tulostaBT.Click += new System.EventHandler(this.tulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tulostaBT);
            this.Controls.Add(this.viestiTB);
            this.Controls.Add(this.tulostusLB);
            this.Controls.Add(this.otsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Harjoitus 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLB;
        private System.Windows.Forms.Label tulostusLB;
        private System.Windows.Forms.TextBox viestiTB;
        private System.Windows.Forms.Button tulostaBT;
    }
}

