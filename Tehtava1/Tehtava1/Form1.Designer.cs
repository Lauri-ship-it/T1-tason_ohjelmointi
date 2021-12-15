
namespace Tehtava1
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
            this.vaihdaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // otsikkoLB
            // 
            this.otsikkoLB.AutoSize = true;
            this.otsikkoLB.Location = new System.Drawing.Point(55, 40);
            this.otsikkoLB.Name = "otsikkoLB";
            this.otsikkoLB.Size = new System.Drawing.Size(73, 25);
            this.otsikkoLB.TabIndex = 0;
            this.otsikkoLB.Text = "Otsikko";
            // 
            // vaihdaBT
            // 
            this.vaihdaBT.Location = new System.Drawing.Point(60, 90);
            this.vaihdaBT.Name = "vaihdaBT";
            this.vaihdaBT.Size = new System.Drawing.Size(176, 105);
            this.vaihdaBT.TabIndex = 1;
            this.vaihdaBT.Text = "Vaihda teksti";
            this.vaihdaBT.UseVisualStyleBackColor = true;
            this.vaihdaBT.Click += new System.EventHandler(this.vaihdaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vaihdaBT);
            this.Controls.Add(this.otsikkoLB);
            this.Name = "Form1";
            this.Text = "Harjoitus 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLB;
        private System.Windows.Forms.Button vaihdaBT;
    }
}

