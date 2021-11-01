namespace Salasana
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.VirheLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.VirheLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaBT);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(698, 411);
            this.SalasanaPanel.TabIndex = 0;
            this.SalasanaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SalasanaPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(354, 94);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(251, 31);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(354, 145);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(251, 31);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.TarkistaBT.Location = new System.Drawing.Point(123, 197);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(98, 40);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // VirheLB
            // 
            this.VirheLB.AutoSize = true;
            this.VirheLB.Location = new System.Drawing.Point(266, 290);
            this.VirheLB.Name = "VirheLB";
            this.VirheLB.Size = new System.Drawing.Size(62, 25);
            this.VirheLB.TabIndex = 5;
            this.VirheLB.Text = "Virhe";
            this.VirheLB.Visible = false;
            this.VirheLB.Click += new System.EventHandler(this.VirheLB_Click);
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label3);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(698, 411);
            this.SalasanaOikeinPanel.TabIndex = 6;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 80);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa sivulleni!";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 411);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Controls.Add(this.SalasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.Label VirheLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SalasanaOikeinPanel;
        private System.Windows.Forms.Label label3;
    }
}

