
namespace Tehtava18
{
    partial class AvainhenkilotFORM
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
            this.oppilaitosCB = new System.Windows.Forms.ComboBox();
            this.vastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.postinumeroLB = new System.Windows.Forms.Label();
            this.postitoimipaikkaLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.sahkopostiLB = new System.Windows.Forms.Label();
            this.osastoLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // oppilaitosCB
            // 
            this.oppilaitosCB.FormattingEnabled = true;
            this.oppilaitosCB.Location = new System.Drawing.Point(35, 196);
            this.oppilaitosCB.Name = "oppilaitosCB";
            this.oppilaitosCB.Size = new System.Drawing.Size(242, 40);
            this.oppilaitosCB.TabIndex = 2;
            this.oppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitosCB_SelectedIndexChanged);
            // 
            // vastuuhenkiloCB
            // 
            this.vastuuhenkiloCB.FormattingEnabled = true;
            this.vastuuhenkiloCB.Location = new System.Drawing.Point(418, 200);
            this.vastuuhenkiloCB.Name = "vastuuhenkiloCB";
            this.vastuuhenkiloCB.Size = new System.Drawing.Size(295, 40);
            this.vastuuhenkiloCB.TabIndex = 4;
            this.vastuuhenkiloCB.TextChanged += new System.EventHandler(this.vastuuhenkiloCB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Location = new System.Drawing.Point(37, 262);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(98, 32);
            this.osoiteLB.TabIndex = 5;
            this.osoiteLB.Text = "Osoite";
            // 
            // postinumeroLB
            // 
            this.postinumeroLB.AutoSize = true;
            this.postinumeroLB.Location = new System.Drawing.Point(42, 320);
            this.postinumeroLB.Name = "postinumeroLB";
            this.postinumeroLB.Size = new System.Drawing.Size(175, 32);
            this.postinumeroLB.TabIndex = 6;
            this.postinumeroLB.Text = "Postinumero";
            // 
            // postitoimipaikkaLB
            // 
            this.postitoimipaikkaLB.AutoSize = true;
            this.postitoimipaikkaLB.Location = new System.Drawing.Point(42, 378);
            this.postitoimipaikkaLB.Name = "postitoimipaikkaLB";
            this.postitoimipaikkaLB.Size = new System.Drawing.Size(223, 32);
            this.postitoimipaikkaLB.TabIndex = 7;
            this.postitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Location = new System.Drawing.Point(42, 436);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(112, 32);
            this.puhelinLB.TabIndex = 8;
            this.puhelinLB.Text = "Puhelin";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(420, 436);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(112, 32);
            this.puhLB.TabIndex = 12;
            this.puhLB.Text = "Puhelin";
            // 
            // sahkopostiLB
            // 
            this.sahkopostiLB.AutoSize = true;
            this.sahkopostiLB.Location = new System.Drawing.Point(420, 378);
            this.sahkopostiLB.Name = "sahkopostiLB";
            this.sahkopostiLB.Size = new System.Drawing.Size(157, 32);
            this.sahkopostiLB.TabIndex = 11;
            this.sahkopostiLB.Text = "Sähköposti";
            // 
            // osastoLB
            // 
            this.osastoLB.AutoSize = true;
            this.osastoLB.Location = new System.Drawing.Point(420, 320);
            this.osastoLB.Name = "osastoLB";
            this.osastoLB.Size = new System.Drawing.Size(105, 32);
            this.osastoLB.TabIndex = 10;
            this.osastoLB.Text = "Osasto";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(415, 262);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(85, 32);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = "Titteli";
            // 
            // AvainhenkilotFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 522);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.sahkopostiLB);
            this.Controls.Add(this.osastoLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.postitoimipaikkaLB);
            this.Controls.Add(this.postinumeroLB);
            this.Controls.Add(this.osoiteLB);
            this.Controls.Add(this.vastuuhenkiloCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AvainhenkilotFORM";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.AvainhenkilotFORM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox oppilaitosCB;
        private System.Windows.Forms.ComboBox vastuuhenkiloCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label osoiteLB;
        private System.Windows.Forms.Label postinumeroLB;
        private System.Windows.Forms.Label postitoimipaikkaLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.Label sahkopostiLB;
        private System.Windows.Forms.Label osastoLB;
        private System.Windows.Forms.Label titteliLB;
    }
}

