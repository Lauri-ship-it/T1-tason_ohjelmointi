namespace Tehtävä7
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
            this.LainaTB = new System.Windows.Forms.TextBox();
            this.NesteetTB = new System.Windows.Forms.TextBox();
            this.VakuutuksetTB = new System.Windows.Forms.TextBox();
            this.MuutTB = new System.Windows.Forms.TextBox();
            this.PesutTB = new System.Windows.Forms.TextBox();
            this.HuollotTB = new System.Windows.Forms.TextBox();
            this.RenkaatTB = new System.Windows.Forms.TextBox();
            this.PolttonesteTB = new System.Windows.Forms.TextBox();
            this.KilometritCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LainaTB
            // 
            this.LainaTB.Location = new System.Drawing.Point(198, 119);
            this.LainaTB.Name = "LainaTB";
            this.LainaTB.Size = new System.Drawing.Size(103, 20);
            this.LainaTB.TabIndex = 0;
            // 
            // NesteetTB
            // 
            this.NesteetTB.Location = new System.Drawing.Point(198, 164);
            this.NesteetTB.Name = "NesteetTB";
            this.NesteetTB.Size = new System.Drawing.Size(103, 20);
            this.NesteetTB.TabIndex = 1;
            // 
            // VakuutuksetTB
            // 
            this.VakuutuksetTB.Location = new System.Drawing.Point(198, 209);
            this.VakuutuksetTB.Name = "VakuutuksetTB";
            this.VakuutuksetTB.Size = new System.Drawing.Size(103, 20);
            this.VakuutuksetTB.TabIndex = 2;
            // 
            // MuutTB
            // 
            this.MuutTB.Location = new System.Drawing.Point(198, 256);
            this.MuutTB.Name = "MuutTB";
            this.MuutTB.Size = new System.Drawing.Size(103, 20);
            this.MuutTB.TabIndex = 3;
            // 
            // PesutTB
            // 
            this.PesutTB.Location = new System.Drawing.Point(486, 119);
            this.PesutTB.Name = "PesutTB";
            this.PesutTB.Size = new System.Drawing.Size(103, 20);
            this.PesutTB.TabIndex = 4;
            this.PesutTB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // HuollotTB
            // 
            this.HuollotTB.Location = new System.Drawing.Point(486, 164);
            this.HuollotTB.Name = "HuollotTB";
            this.HuollotTB.Size = new System.Drawing.Size(103, 20);
            this.HuollotTB.TabIndex = 5;
            // 
            // RenkaatTB
            // 
            this.RenkaatTB.Location = new System.Drawing.Point(486, 209);
            this.RenkaatTB.Name = "RenkaatTB";
            this.RenkaatTB.Size = new System.Drawing.Size(103, 20);
            this.RenkaatTB.TabIndex = 6;
            // 
            // PolttonesteTB
            // 
            this.PolttonesteTB.Location = new System.Drawing.Point(198, 302);
            this.PolttonesteTB.Name = "PolttonesteTB";
            this.PolttonesteTB.Size = new System.Drawing.Size(103, 20);
            this.PolttonesteTB.TabIndex = 7;
            // 
            // KilometritCB
            // 
            this.KilometritCB.FormattingEnabled = true;
            this.KilometritCB.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000"});
            this.KilometritCB.Location = new System.Drawing.Point(486, 256);
            this.KilometritCB.Name = "KilometritCB";
            this.KilometritCB.Size = new System.Drawing.Size(103, 21);
            this.KilometritCB.TabIndex = 8;
            this.KilometritCB.SelectedIndexChanged += new System.EventHandler(this.KilometritCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lainan lyhennys korkoineen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vakuutusmaksut:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Polttoneste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pesut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Huollot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Renkaat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kilometrit/vuosi:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(288, 54);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(150, 13);
            this.VastausLB.TabIndex = 18;
            this.VastausLB.Text = "Valite laatikoihin kustannukset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KilometritCB);
            this.Controls.Add(this.PolttonesteTB);
            this.Controls.Add(this.RenkaatTB);
            this.Controls.Add(this.HuollotTB);
            this.Controls.Add(this.PesutTB);
            this.Controls.Add(this.MuutTB);
            this.Controls.Add(this.VakuutuksetTB);
            this.Controls.Add(this.NesteetTB);
            this.Controls.Add(this.LainaTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LainaTB;
        private System.Windows.Forms.TextBox NesteetTB;
        private System.Windows.Forms.TextBox VakuutuksetTB;
        private System.Windows.Forms.TextBox MuutTB;
        private System.Windows.Forms.TextBox PesutTB;
        private System.Windows.Forms.TextBox HuollotTB;
        private System.Windows.Forms.TextBox RenkaatTB;
        private System.Windows.Forms.TextBox PolttonesteTB;
        private System.Windows.Forms.ComboBox KilometritCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label VastausLB;
    }
}

