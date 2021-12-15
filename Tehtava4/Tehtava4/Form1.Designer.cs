
namespace Tehtava4
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
            this.syntymaaikaDT = new System.Windows.Forms.DateTimePicker();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vuosiLB = new System.Windows.Forms.Label();
            this.kuukausiLB = new System.Windows.Forms.Label();
            this.paivaLB = new System.Windows.Forms.Label();
            this.tuntiLB = new System.Windows.Forms.Label();
            this.minuuttiLB = new System.Windows.Forms.Label();
            this.sekunttiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // syntymaaikaDT
            // 
            this.syntymaaikaDT.Location = new System.Drawing.Point(81, 64);
            this.syntymaaikaDT.Name = "syntymaaikaDT";
            this.syntymaaikaDT.Size = new System.Drawing.Size(323, 31);
            this.syntymaaikaDT.TabIndex = 0;
            // 
            // laskeBT
            // 
            this.laskeBT.Location = new System.Drawing.Point(468, 60);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(147, 43);
            this.laskeBT.TabIndex = 1;
            this.laskeBT.Text = "Laske ikä";
            this.laskeBT.UseVisualStyleBackColor = true;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vuosiLB
            // 
            this.vuosiLB.AutoSize = true;
            this.vuosiLB.Location = new System.Drawing.Point(117, 160);
            this.vuosiLB.Name = "vuosiLB";
            this.vuosiLB.Size = new System.Drawing.Size(75, 25);
            this.vuosiLB.TabIndex = 2;
            this.vuosiLB.Text = "Vuosina";
            this.vuosiLB.Visible = false;
            // 
            // kuukausiLB
            // 
            this.kuukausiLB.AutoSize = true;
            this.kuukausiLB.Location = new System.Drawing.Point(117, 195);
            this.kuukausiLB.Name = "kuukausiLB";
            this.kuukausiLB.Size = new System.Drawing.Size(101, 25);
            this.kuukausiLB.TabIndex = 3;
            this.kuukausiLB.Text = "Kuukausina";
            this.kuukausiLB.Visible = false;
            // 
            // paivaLB
            // 
            this.paivaLB.AutoSize = true;
            this.paivaLB.Location = new System.Drawing.Point(117, 231);
            this.paivaLB.Name = "paivaLB";
            this.paivaLB.Size = new System.Drawing.Size(66, 25);
            this.paivaLB.TabIndex = 4;
            this.paivaLB.Text = "Päivinä";
            this.paivaLB.Visible = false;
            // 
            // tuntiLB
            // 
            this.tuntiLB.AutoSize = true;
            this.tuntiLB.Location = new System.Drawing.Point(477, 160);
            this.tuntiLB.Name = "tuntiLB";
            this.tuntiLB.Size = new System.Drawing.Size(79, 25);
            this.tuntiLB.TabIndex = 5;
            this.tuntiLB.Text = "Tunteina";
            this.tuntiLB.Visible = false;
            // 
            // minuuttiLB
            // 
            this.minuuttiLB.AutoSize = true;
            this.minuuttiLB.Location = new System.Drawing.Point(477, 195);
            this.minuuttiLB.Name = "minuuttiLB";
            this.minuuttiLB.Size = new System.Drawing.Size(106, 25);
            this.minuuttiLB.TabIndex = 6;
            this.minuuttiLB.Text = "Minuutteina";
            this.minuuttiLB.Visible = false;
            // 
            // sekunttiLB
            // 
            this.sekunttiLB.AutoSize = true;
            this.sekunttiLB.Location = new System.Drawing.Point(477, 231);
            this.sekunttiLB.Name = "sekunttiLB";
            this.sekunttiLB.Size = new System.Drawing.Size(104, 25);
            this.sekunttiLB.TabIndex = 7;
            this.sekunttiLB.Text = "Sekuntteina";
            this.sekunttiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 338);
            this.Controls.Add(this.sekunttiLB);
            this.Controls.Add(this.minuuttiLB);
            this.Controls.Add(this.tuntiLB);
            this.Controls.Add(this.paivaLB);
            this.Controls.Add(this.kuukausiLB);
            this.Controls.Add(this.vuosiLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.syntymaaikaDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker syntymaaikaDT;
        private System.Windows.Forms.Button laskeBT;
        private System.Windows.Forms.Label vuosiLB;
        private System.Windows.Forms.Label kuukausiLB;
        private System.Windows.Forms.Label paivaLB;
        private System.Windows.Forms.Label tuntiLB;
        private System.Windows.Forms.Label minuuttiLB;
        private System.Windows.Forms.Label sekunttiLB;
    }
}

