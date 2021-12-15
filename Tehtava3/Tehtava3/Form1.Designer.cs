
namespace Tehtava3
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
            this.lukuyksiTB = new System.Windows.Forms.TextBox();
            this.lukukaksiTB = new System.Windows.Forms.TextBox();
            this.laskutoimitusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.laskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lukuyksiTB
            // 
            this.lukuyksiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lukuyksiTB.Location = new System.Drawing.Point(47, 41);
            this.lukuyksiTB.Name = "lukuyksiTB";
            this.lukuyksiTB.Size = new System.Drawing.Size(117, 50);
            this.lukuyksiTB.TabIndex = 0;
            // 
            // lukukaksiTB
            // 
            this.lukukaksiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lukukaksiTB.Location = new System.Drawing.Point(270, 41);
            this.lukukaksiTB.Name = "lukukaksiTB";
            this.lukukaksiTB.Size = new System.Drawing.Size(150, 50);
            this.lukukaksiTB.TabIndex = 1;
            // 
            // laskutoimitusCB
            // 
            this.laskutoimitusCB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskutoimitusCB.FormattingEnabled = true;
            this.laskutoimitusCB.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.laskutoimitusCB.Location = new System.Drawing.Point(170, 41);
            this.laskutoimitusCB.Name = "laskutoimitusCB";
            this.laskutoimitusCB.Size = new System.Drawing.Size(94, 53);
            this.laskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(426, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(474, 46);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(39, 45);
            this.vastausLB.TabIndex = 4;
            this.vastausLB.Text = "X";
            this.vastausLB.Visible = false;
            // 
            // laskeBT
            // 
            this.laskeBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laskeBT.Location = new System.Drawing.Point(99, 142);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(165, 140);
            this.laskeBT.TabIndex = 5;
            this.laskeBT.Text = "Laske";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskutoimitusCB);
            this.Controls.Add(this.lukukaksiTB);
            this.Controls.Add(this.lukuyksiTB);
            this.Name = "Form1";
            this.Text = "nelilaskin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lukuyksiTB;
        private System.Windows.Forms.TextBox lukukaksiTB;
        private System.Windows.Forms.ComboBox laskutoimitusCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.Button laskeBT;
    }
}

