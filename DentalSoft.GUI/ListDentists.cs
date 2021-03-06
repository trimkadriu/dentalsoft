﻿using DentalSoft.Service;
using DentalSoft.Domain;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace DentalSoft
{
    public partial class frmListDentists : Form
    {
        private DentistService dentistService;
        private BindingSource bindingSource;

        public frmListDentists()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dentistService = new DentistService();
            Init();
        }

        private void Init()
        {
            bindingSource.DataSource = dentistService.getBindingSource();
            dgvListaEDentisteve.DataSource = bindingSource;
            dgvListaEDentisteve.Columns["Id"].Visible = false;
            dgvListaEDentisteve.Columns["Fjalekalimi"].Visible = false;
            dgvListaEDentisteve.Columns["Foto profilit"].Visible = false;
            dgvListaEDentisteve.Sort(this.dgvListaEDentisteve.Columns["Emri"], ListSortDirection.Ascending);
        }

        private void txtKerkoEmriMbiemri_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                bindingSource.Filter = "Emri like '%" + txtKerkoEmriMbiemri.Text + "%'";
            }
            catch (SyntaxErrorException)
            {
                txtKerkoEmriMbiemri.Text = string.Empty;
            }
        }

        private void btnFshij_Click(object sender, System.EventArgs e)
        {
            if (dgvListaEDentisteve.SelectedRows.Count == 1)
            {
                string id = dgvListaEDentisteve.SelectedRows[0].Cells[0].Value.ToString();
                string perdoruesi = dgvListaEDentisteve.SelectedRows[0].Cells[3].Value.ToString();
                DialogResult dr = MessageBox.Show("A jeni i sigurte qe deshironi ta fshini\ndentistin me emrin e perdorusit: [ " + perdoruesi.ToUpper() + " ]",
                                                  "Konfirmo ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Dentist dentist = new Dentist(id);
                    dentistService.removeDentist(dentist);
                    if (frmMain.loggedInDentist.Equals(dentist))
                        this.DialogResult = DialogResult.Yes;
                    else
                        this.DialogResult = DialogResult.None;
                    Init();
                }
            }
        }

        private void dgvListaEDentisteve_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListaEDentisteve.ClearSelection();
        }

        private void btnMbylle_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
