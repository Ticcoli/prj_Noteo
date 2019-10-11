namespace prj_Noteo
{
    partial class Profs
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
            this.cbMatiere = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMatiere
            // 
            this.cbMatiere.FormattingEnabled = true;
            this.cbMatiere.Location = new System.Drawing.Point(293, 130);
            this.cbMatiere.Name = "cbMatiere";
            this.cbMatiere.Size = new System.Drawing.Size(252, 24);
            this.cbMatiere.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matière :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(293, 184);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(252, 22);
            this.tbNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saisissez le nom de votre professeur :";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(221, 258);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(323, 60);
            this.btValider.TabIndex = 5;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            // 
            // Profs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMatiere);
            this.Name = "Profs";
            this.Text = "Profs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMatiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btValider;
    }
}