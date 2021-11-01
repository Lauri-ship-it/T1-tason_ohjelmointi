namespace Tehtävä_5
{
    partial class Lukujenjarjestys
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
            this.UusilukuTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku (-999 lopetus)";
            // 
            // UusilukuTB
            // 
            this.UusilukuTB.Location = new System.Drawing.Point(301, 119);
            this.UusilukuTB.Name = "UusilukuTB";
            this.UusilukuTB.Size = new System.Drawing.Size(100, 20);
            this.UusilukuTB.TabIndex = 1;
            this.UusilukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UusilukuTB_KeyPress);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(149, 295);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(35, 13);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "label2";
            this.VastausLB.Visible = false;
            // 
            // Lukujenjarjestys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.UusilukuTB);
            this.Controls.Add(this.label1);
            this.Name = "Lukujenjarjestys";
            this.Text = "Lukujen järjestys";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UusilukuTB;
        private System.Windows.Forms.Label VastausLB;
    }
}

