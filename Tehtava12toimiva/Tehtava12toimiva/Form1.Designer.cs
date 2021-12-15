
namespace Tehtava12toimiva
{
    partial class vastauslomakeFORM
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
            this.kysymysLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vastausDRB = new System.Windows.Forms.RadioButton();
            this.vastausCRB = new System.Windows.Forms.RadioButton();
            this.vastausBRB = new System.Windows.Forms.RadioButton();
            this.VastausARB = new System.Windows.Forms.RadioButton();
            this.dummyRB = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Location = new System.Drawing.Point(12, 65);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(354, 45);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Vastaus 1. kysymykseen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vastausDRB);
            this.groupBox1.Controls.Add(this.vastausCRB);
            this.groupBox1.Controls.Add(this.vastausBRB);
            this.groupBox1.Controls.Add(this.VastausARB);
            this.groupBox1.Controls.Add(this.dummyRB);
            this.groupBox1.Location = new System.Drawing.Point(372, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "vastaus";
            // 
            // vastausDRB
            // 
            this.vastausDRB.AutoSize = true;
            this.vastausDRB.Location = new System.Drawing.Point(6, 214);
            this.vastausDRB.Name = "vastausDRB";
            this.vastausDRB.Size = new System.Drawing.Size(67, 49);
            this.vastausDRB.TabIndex = 4;
            this.vastausDRB.TabStop = true;
            this.vastausDRB.Text = "D";
            this.vastausDRB.UseVisualStyleBackColor = true;
            // 
            // vastausCRB
            // 
            this.vastausCRB.AutoSize = true;
            this.vastausCRB.Location = new System.Drawing.Point(6, 159);
            this.vastausCRB.Name = "vastausCRB";
            this.vastausCRB.Size = new System.Drawing.Size(65, 49);
            this.vastausCRB.TabIndex = 3;
            this.vastausCRB.TabStop = true;
            this.vastausCRB.Text = "C";
            this.vastausCRB.UseVisualStyleBackColor = true;
            // 
            // vastausBRB
            // 
            this.vastausBRB.AutoSize = true;
            this.vastausBRB.Location = new System.Drawing.Point(6, 104);
            this.vastausBRB.Name = "vastausBRB";
            this.vastausBRB.Size = new System.Drawing.Size(63, 49);
            this.vastausBRB.TabIndex = 2;
            this.vastausBRB.TabStop = true;
            this.vastausBRB.Text = "B";
            this.vastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            this.VastausARB.AutoSize = true;
            this.VastausARB.Location = new System.Drawing.Point(5, 51);
            this.VastausARB.Name = "VastausARB";
            this.VastausARB.Size = new System.Drawing.Size(66, 49);
            this.VastausARB.TabIndex = 1;
            this.VastausARB.TabStop = true;
            this.VastausARB.Text = "A";
            this.VastausARB.UseVisualStyleBackColor = true;
            // 
            // dummyRB
            // 
            this.dummyRB.AutoCheck = false;
            this.dummyRB.AutoSize = true;
            this.dummyRB.Location = new System.Drawing.Point(6, 49);
            this.dummyRB.Name = "dummyRB";
            this.dummyRB.Size = new System.Drawing.Size(61, 49);
            this.dummyRB.TabIndex = 0;
            this.dummyRB.TabStop = true;
            this.dummyRB.Text = "E";
            this.dummyRB.UseVisualStyleBackColor = true;
            this.dummyRB.Visible = false;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(12, 398);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(127, 45);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // vastauslomakeFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 810);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kysymysLB);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "vastauslomakeFORM";
            this.Text = "Vastauslomake";
            this.Load += new System.EventHandler(this.vastauslomakeFORM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kysymysLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton vastausDRB;
        private System.Windows.Forms.RadioButton vastausCRB;
        private System.Windows.Forms.RadioButton vastausBRB;
        private System.Windows.Forms.RadioButton VastausARB;
        private System.Windows.Forms.RadioButton dummyRB;
        private System.Windows.Forms.Label vastausLB;
    }
}

