namespace JuulM_Lopen
{
    partial class FrmBewerken
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
            this.lblKiesDeelnemer = new System.Windows.Forms.Label();
            this.cmbKiesDeelnemer = new System.Windows.Forms.ComboBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.grbBetaald = new System.Windows.Forms.GroupBox();
            this.rbNietBetaald = new System.Windows.Forms.RadioButton();
            this.rbBetaald = new System.Windows.Forms.RadioButton();
            this.cmbAfstand = new System.Windows.Forms.ComboBox();
            this.twtNaam = new System.Windows.Forms.TextBox();
            this.lblAfstand = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.grbBetaald.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKiesDeelnemer
            // 
            this.lblKiesDeelnemer.AutoSize = true;
            this.lblKiesDeelnemer.Location = new System.Drawing.Point(57, 55);
            this.lblKiesDeelnemer.Name = "lblKiesDeelnemer";
            this.lblKiesDeelnemer.Size = new System.Drawing.Size(243, 29);
            this.lblKiesDeelnemer.TabIndex = 0;
            this.lblKiesDeelnemer.Text = "Kies een deelnemer: ";
            // 
            // cmbKiesDeelnemer
            // 
            this.cmbKiesDeelnemer.FormattingEnabled = true;
            this.cmbKiesDeelnemer.Location = new System.Drawing.Point(329, 52);
            this.cmbKiesDeelnemer.Name = "cmbKiesDeelnemer";
            this.cmbKiesDeelnemer.Size = new System.Drawing.Size(198, 37);
            this.cmbKiesDeelnemer.TabIndex = 1;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(388, 335);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(139, 41);
            this.btnAnnuleren.TabIndex = 13;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(62, 335);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(139, 41);
            this.btnAanpassen.TabIndex = 12;
            this.btnAanpassen.Text = "Aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            // 
            // grbBetaald
            // 
            this.grbBetaald.Controls.Add(this.rbNietBetaald);
            this.grbBetaald.Controls.Add(this.rbBetaald);
            this.grbBetaald.Location = new System.Drawing.Point(62, 224);
            this.grbBetaald.Name = "grbBetaald";
            this.grbBetaald.Size = new System.Drawing.Size(465, 100);
            this.grbBetaald.TabIndex = 11;
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
            // cmbAfstand
            // 
            this.cmbAfstand.FormattingEnabled = true;
            this.cmbAfstand.Items.AddRange(new object[] {
            "  5km",
            "10km",
            "20km"});
            this.cmbAfstand.Location = new System.Drawing.Point(329, 159);
            this.cmbAfstand.Name = "cmbAfstand";
            this.cmbAfstand.Size = new System.Drawing.Size(198, 37);
            this.cmbAfstand.TabIndex = 10;
            // 
            // twtNaam
            // 
            this.twtNaam.Location = new System.Drawing.Point(329, 102);
            this.twtNaam.Name = "twtNaam";
            this.twtNaam.Size = new System.Drawing.Size(198, 34);
            this.twtNaam.TabIndex = 9;
            // 
            // lblAfstand
            // 
            this.lblAfstand.AutoSize = true;
            this.lblAfstand.Location = new System.Drawing.Point(57, 167);
            this.lblAfstand.Name = "lblAfstand";
            this.lblAfstand.Size = new System.Drawing.Size(104, 29);
            this.lblAfstand.TabIndex = 8;
            this.lblAfstand.Text = "Afstand: ";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(57, 107);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(83, 29);
            this.lblNaam.TabIndex = 7;
            this.lblNaam.Text = "Naam:";
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(225, 335);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(157, 41);
            this.btnVerwijderen.TabIndex = 14;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            // 
            // FrmBewerken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.grbBetaald);
            this.Controls.Add(this.cmbAfstand);
            this.Controls.Add(this.twtNaam);
            this.Controls.Add(this.lblAfstand);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cmbKiesDeelnemer);
            this.Controls.Add(this.lblKiesDeelnemer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmBewerken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<";
            this.grbBetaald.ResumeLayout(false);
            this.grbBetaald.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiesDeelnemer;
        private System.Windows.Forms.ComboBox cmbKiesDeelnemer;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.GroupBox grbBetaald;
        private System.Windows.Forms.RadioButton rbNietBetaald;
        private System.Windows.Forms.RadioButton rbBetaald;
        private System.Windows.Forms.ComboBox cmbAfstand;
        private System.Windows.Forms.TextBox twtNaam;
        private System.Windows.Forms.Label lblAfstand;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnVerwijderen;
    }
}