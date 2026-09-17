namespace JuulM_Lopen
{
    partial class FrmOpzoeken
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
            this.btn1Deelnemer = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnAlleDeelnemers = new System.Windows.Forms.Button();
            this.cmbKiesDeelnemer = new System.Windows.Forms.ComboBox();
            this.lblKiesDeelnemer = new System.Windows.Forms.Label();
            this.txtToon = new System.Windows.Forms.TextBox();
            this.lblToon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1Deelnemer
            // 
            this.btn1Deelnemer.Location = new System.Drawing.Point(221, 12);
            this.btn1Deelnemer.Name = "btn1Deelnemer";
            this.btn1Deelnemer.Size = new System.Drawing.Size(203, 41);
            this.btn1Deelnemer.TabIndex = 17;
            this.btn1Deelnemer.Text = "1 deelnemer";
            this.btn1Deelnemer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(17, 500);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(407, 41);
            this.btnAnnuleren.TabIndex = 16;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnAlleDeelnemers
            // 
            this.btnAlleDeelnemers.Location = new System.Drawing.Point(12, 12);
            this.btnAlleDeelnemers.Name = "btnAlleDeelnemers";
            this.btnAlleDeelnemers.Size = new System.Drawing.Size(203, 41);
            this.btnAlleDeelnemers.TabIndex = 15;
            this.btnAlleDeelnemers.Text = "Alle Deelnemers";
            this.btnAlleDeelnemers.UseVisualStyleBackColor = true;
            // 
            // cmbKiesDeelnemer
            // 
            this.cmbKiesDeelnemer.FormattingEnabled = true;
            this.cmbKiesDeelnemer.Location = new System.Drawing.Point(256, 88);
            this.cmbKiesDeelnemer.Name = "cmbKiesDeelnemer";
            this.cmbKiesDeelnemer.Size = new System.Drawing.Size(168, 37);
            this.cmbKiesDeelnemer.TabIndex = 19;
            // 
            // lblKiesDeelnemer
            // 
            this.lblKiesDeelnemer.AutoSize = true;
            this.lblKiesDeelnemer.Location = new System.Drawing.Point(7, 91);
            this.lblKiesDeelnemer.Name = "lblKiesDeelnemer";
            this.lblKiesDeelnemer.Size = new System.Drawing.Size(243, 29);
            this.lblKiesDeelnemer.TabIndex = 18;
            this.lblKiesDeelnemer.Text = "Kies een deelnemer: ";
            // 
            // txtToon
            // 
            this.txtToon.Location = new System.Drawing.Point(12, 176);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.Size = new System.Drawing.Size(412, 318);
            this.txtToon.TabIndex = 20;
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(12, 144);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(139, 29);
            this.lblToon.TabIndex = 21;
            this.lblToon.Text = "Resultaten: ";
            // 
            // FrmOpzoeken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 553);
            this.ControlBox = false;
            this.Controls.Add(this.lblToon);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.cmbKiesDeelnemer);
            this.Controls.Add(this.lblKiesDeelnemer);
            this.Controls.Add(this.btn1Deelnemer);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnAlleDeelnemers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmOpzoeken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoek een deelnemer op:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Deelnemer;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnAlleDeelnemers;
        private System.Windows.Forms.ComboBox cmbKiesDeelnemer;
        private System.Windows.Forms.Label lblKiesDeelnemer;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Label lblToon;
    }
}