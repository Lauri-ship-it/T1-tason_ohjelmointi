namespace Palautejarjestelma
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
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-MAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALASANA";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(273, 197);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(256, 20);
            this.emailTB.TabIndex = 2;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(273, 258);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(256, 20);
            this.passwordTB.TabIndex = 3;
            // 
            // loginBT
            // 
            this.loginBT.Location = new System.Drawing.Point(235, 316);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(294, 89);
            this.loginBT.TabIndex = 4;
            this.loginBT.Text = "KIRJAUDU";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Palautejarjestelma.Properties.Resources.keudalogo;
            this.pictureBox1.Location = new System.Drawing.Point(182, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 152);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // registerBT
            // 
            this.registerBT.Location = new System.Drawing.Point(59, 328);
            this.registerBT.Name = "registerBT";
            this.registerBT.Size = new System.Drawing.Size(99, 65);
            this.registerBT.TabIndex = 6;
            this.registerBT.Text = "REKISTERÖIDY";
            this.registerBT.UseVisualStyleBackColor = true;
            this.registerBT.Click += new System.EventHandler(this.registerBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registerBT;
    }
}

