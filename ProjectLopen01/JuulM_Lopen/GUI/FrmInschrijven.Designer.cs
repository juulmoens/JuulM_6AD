namespace JuulM_Lopen
{
    partial class FrmInschrijven
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblAfstand = new System.Windows.Forms.Label();
            this.twtNaam = new System.Windows.Forms.TextBox();
            this.cmbAfstand = new System.Windows.Forms.ComboBox();
            this.grbBetaald = new System.Windows.Forms.GroupBox();
            this.rbNietBetaald = new System.Windows.Forms.RadioButton();
            this.rbBetaald = new System.Windows.Forms.RadioButton();
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.grbBetaald.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(83, 29);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam:";
            // 
            // lblAfstand
            // 
            this.lblAfstand.AutoSize = true;
            this.lblAfstand.Location = new System.Drawing.Point(12, 71);
            this.lblAfstand.Name = "lblAfstand";
            this.lblAfstand.Size = new System.Drawing.Size(104, 29);
            this.lblAfstand.TabIndex = 1;
            this.lblAfstand.Text = "Afstand: ";
            // 
            // twtNaam
            // 
            this.twtNaam.Location = new System.Drawing.Point(109, 6);
            this.twtNaam.Name = "twtNaam";
            this.twtNaam.Size = new System.Drawing.Size(198, 34);
            this.twtNaam.TabIndex = 2;
            // 
            // cmbAfstand
            // 
            this.cmbAfstand.FormattingEnabled = true;
            this.cmbAfstand.Items.AddRange(new object[] {
            "  5km",
            "10km",
            "20km"});
            this.cmbAfstand.Location = new System.Drawing.Point(109, 68);
            this.cmbAfstand.Name = "cmbAfstand";
            this.cmbAfstand.Size = new System.Drawing.Size(198, 37);
            this.cmbAfstand.TabIndex = 3;
            // 
            // grbBetaald
            // 
            this.grbBetaald.Controls.Add(this.rbNietBetaald);
            this.grbBetaald.Controls.Add(this.rbBetaald);
            this.grbBetaald.Location = new System.Drawing.Point(17, 128);
            this.grbBetaald.Name = "grbBetaald";
            this.grbBetaald.Size = new System.Drawing.Size(290, 100);
            this.grbBetaald.TabIndex = 4;
            this.grbBetaald.TabStop = false;
            this.grbBetaald.Text = "Heeft u betaald?";
            // 
            // rbNietBetaald
            // 
            this.rbNietBetaald.AutoSize = true;
            this.rbNietBetaald.Location = new System.Drawing.Point(6, 72);
            this.rbNietBetaald.Name = "rbNietBetaald";
            this.rbNietBetaald.Size = new System.Drawing.Size(80, 33);
            this.rbNietBetaald.TabIndex = 1;
            this.rbNietBetaald.TabStop = true;
            this.rbNietBetaald.Text = "Nee";
            this.rbNietBetaald.UseVisualStyleBackColor = true;
            // 
            // rbBetaald
            // 
            this.rbBetaald.AutoSize = true;
            this.rbBetaald.Location = new System.Drawing.Point(6, 33);
            this.rbBetaald.Name = "rbBetaald";
            this.rbBetaald.Size = new System.Drawing.Size(59, 33);
            this.rbBetaald.TabIndex = 0;
            this.rbBetaald.TabStop = true;
            this.rbBetaald.Text = "Ja";
            this.rbBetaald.UseVisualStyleBackColor = true;
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(17, 239);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(139, 41);
            this.btnInschrijven.TabIndex = 5;
            this.btnInschrijven.Text = "Inschrijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(168, 239);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(139, 41);
            this.btnAnnuleren.TabIndex = 6;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // FrmInschrijven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnInschrijven);
            this.Controls.Add(this.grbBetaald);
            this.Controls.Add(this.cmbAfstand);
            this.Controls.Add(this.twtNaam);
            this.Controls.Add(this.lblAfstand);
            this.Controls.Add(this.lblNaam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmInschrijven";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inschrijven";
            this.grbBetaald.ResumeLayout(false);
            this.grbBetaald.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblAfstand;
        private System.Windows.Forms.TextBox twtNaam;
        private System.Windows.Forms.ComboBox cmbAfstand;
        private System.Windows.Forms.GroupBox grbBetaald;
        private System.Windows.Forms.RadioButton rbNietBetaald;
        private System.Windows.Forms.RadioButton rbBetaald;
        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.Button btnAnnuleren;
    }
}