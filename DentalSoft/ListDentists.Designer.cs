﻿namespace DentalSoft
{
    partial class frmListDentists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListDentists));
            this.lblTitulli = new System.Windows.Forms.Label();
            this.txtKerkoEmriMbiemri = new System.Windows.Forms.TextBox();
            this.lblKerkoEmriMbiemri = new System.Windows.Forms.Label();
            this.dgvListaEDentisteve = new System.Windows.Forms.DataGridView();
            this.lblHorizontalDivider = new System.Windows.Forms.Label();
            this.btnEdito = new System.Windows.Forms.Button();
            this.btnFshij = new System.Windows.Forms.Button();
            this.btnMbylle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEDentisteve)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulli
            // 
            this.lblTitulli.AutoSize = true;
            this.lblTitulli.Location = new System.Drawing.Point(12, 16);
            this.lblTitulli.Name = "lblTitulli";
            this.lblTitulli.Size = new System.Drawing.Size(164, 13);
            this.lblTitulli.TabIndex = 0;
            this.lblTitulli.Text = "Kerkoni dentistet ne baze te emrit";
            // 
            // txtKerkoEmriMbiemri
            // 
            this.txtKerkoEmriMbiemri.Location = new System.Drawing.Point(108, 57);
            this.txtKerkoEmriMbiemri.Name = "txtKerkoEmriMbiemri";
            this.txtKerkoEmriMbiemri.Size = new System.Drawing.Size(165, 20);
            this.txtKerkoEmriMbiemri.TabIndex = 1;
            // 
            // lblKerkoEmriMbiemri
            // 
            this.lblKerkoEmriMbiemri.AutoSize = true;
            this.lblKerkoEmriMbiemri.Location = new System.Drawing.Point(12, 60);
            this.lblKerkoEmriMbiemri.Name = "lblKerkoEmriMbiemri";
            this.lblKerkoEmriMbiemri.Size = new System.Drawing.Size(90, 13);
            this.lblKerkoEmriMbiemri.TabIndex = 2;
            this.lblKerkoEmriMbiemri.Text = "Emri dhe Mbiemri:";
            // 
            // dgvListaEDentisteve
            // 
            this.dgvListaEDentisteve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEDentisteve.Location = new System.Drawing.Point(15, 89);
            this.dgvListaEDentisteve.Name = "dgvListaEDentisteve";
            this.dgvListaEDentisteve.Size = new System.Drawing.Size(390, 239);
            this.dgvListaEDentisteve.TabIndex = 3;
            // 
            // lblHorizontalDivider
            // 
            this.lblHorizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHorizontalDivider.Location = new System.Drawing.Point(15, 40);
            this.lblHorizontalDivider.Name = "lblHorizontalDivider";
            this.lblHorizontalDivider.Size = new System.Drawing.Size(390, 2);
            this.lblHorizontalDivider.TabIndex = 26;
            // 
            // btnEdito
            // 
            this.btnEdito.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEdito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdito.Location = new System.Drawing.Point(330, 338);
            this.btnEdito.Name = "btnEdito";
            this.btnEdito.Size = new System.Drawing.Size(75, 23);
            this.btnEdito.TabIndex = 27;
            this.btnEdito.Text = "Edito";
            this.btnEdito.UseVisualStyleBackColor = true;
            // 
            // btnFshij
            // 
            this.btnFshij.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFshij.Location = new System.Drawing.Point(249, 337);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(75, 23);
            this.btnFshij.TabIndex = 28;
            this.btnFshij.Text = "Fshij";
            this.btnFshij.UseVisualStyleBackColor = true;
            // 
            // btnMbylle
            // 
            this.btnMbylle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMbylle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMbylle.Location = new System.Drawing.Point(15, 337);
            this.btnMbylle.Name = "btnMbylle";
            this.btnMbylle.Size = new System.Drawing.Size(75, 23);
            this.btnMbylle.TabIndex = 29;
            this.btnMbylle.Text = "Mbylle";
            this.btnMbylle.UseVisualStyleBackColor = true;
            // 
            // frmListDentists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMbylle;
            this.ClientSize = new System.Drawing.Size(421, 375);
            this.Controls.Add(this.btnMbylle);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.btnEdito);
            this.Controls.Add(this.lblHorizontalDivider);
            this.Controls.Add(this.dgvListaEDentisteve);
            this.Controls.Add(this.lblKerkoEmriMbiemri);
            this.Controls.Add(this.txtKerkoEmriMbiemri);
            this.Controls.Add(this.lblTitulli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListDentists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listo dentistet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEDentisteve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulli;
        private System.Windows.Forms.TextBox txtKerkoEmriMbiemri;
        private System.Windows.Forms.Label lblKerkoEmriMbiemri;
        private System.Windows.Forms.DataGridView dgvListaEDentisteve;
        private System.Windows.Forms.Label lblHorizontalDivider;
        private System.Windows.Forms.Button btnEdito;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.Button btnMbylle;
    }
}