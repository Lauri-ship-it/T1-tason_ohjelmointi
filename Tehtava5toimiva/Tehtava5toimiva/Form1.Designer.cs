
namespace Tehtava5toimiva
{
    partial class lukujenjarjestysFORM
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
            this.label1 = new System.Windows.Forms.Label();
            this.uusilukuTB = new System.Windows.Forms.TextBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna luku (-999 lopetus):";
            // 
            // uusilukuTB
            // 
            this.uusilukuTB.Location = new System.Drawing.Point(238, 17);
            this.uusilukuTB.Name = "uusilukuTB";
            this.uusilukuTB.Size = new System.Drawing.Size(241, 31);
            this.uusilukuTB.TabIndex = 1;
            this.uusilukuTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uusilukuTB_KeyPress);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(21, 104);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(59, 25);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "label2";
            this.vastausLB.Visible = false;
            // 
            // lukujenjarjestysFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.uusilukuTB);
            this.Controls.Add(this.label1);
            this.Name = "lukujenjarjestysFORM";
            this.Text = "Lukujen järjestys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uusilukuTB;
        private System.Windows.Forms.Label vastausLB;
    }
}

