namespace Tehtävä11Noppa
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
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NopanheittoBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::Tehtävä11Noppa.Properties.Resources.dice01;
            this.noppa01PB.Location = new System.Drawing.Point(157, 141);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(112, 137);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 0;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::Tehtävä11Noppa.Properties.Resources.dice01;
            this.noppa02PB.Location = new System.Drawing.Point(275, 141);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(110, 137);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 1;
            this.noppa02PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nopan heitto";
            // 
            // NopanheittoBT
            // 
            this.NopanheittoBT.Location = new System.Drawing.Point(157, 302);
            this.NopanheittoBT.Name = "NopanheittoBT";
            this.NopanheittoBT.Size = new System.Drawing.Size(228, 68);
            this.NopanheittoBT.TabIndex = 4;
            this.NopanheittoBT.Text = "Heitä nopat";
            this.NopanheittoBT.UseVisualStyleBackColor = true;
            this.NopanheittoBT.Click += new System.EventHandler(this.NopanheittoBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NopanheittoBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox noppa01PB;
        private System.Windows.Forms.PictureBox noppa02PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NopanheittoBT;
    }
}

