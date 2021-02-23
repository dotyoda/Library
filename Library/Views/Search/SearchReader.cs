using Library.DAOs;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FrmSearchReader : Form
    {
        public FrmSearchReader()
        {
            InitializeComponent();
            FillTable(Reader.FindAll());
        }

        private Reader _reader;
        public Reader Reader { get => _reader; }

        private void FillTable(List<Reader> readers)
        {
            this.DgvReaders.DataSource = readers;

            if (this.DgvReaders.Columns.Count > 0)
            {
                this.DgvReaders.Columns[0].HeaderText = "Código";
                this.DgvReaders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this.DgvReaders.Columns[0].Width = 70;

                this.DgvReaders.Columns[1].HeaderText = "Nome";
                this.DgvReaders.Columns[2].HeaderText = "RG";
                this.DgvReaders.Columns[3].HeaderText = "Telefone";
                this.DgvReaders.Columns[4].HeaderText = "E-mail";
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            this.SelectReader();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {


            if (this.TxtSearch.Text.Length > 0)
            {
                if (this.RdbId.Checked)
                {
                    List<Reader> readers = new List<Reader>();

                    bool success = int.TryParse(this.TxtSearch.Text, out int id);

                    if (success)
                    {
                        readers.Add(Reader.FindById(id));
                        FillTable(readers);
                    }
                } else if (this.RdbId.Checked)
                    FillTable(Reader.FindByName(this.TxtSearch.Text));
            }
            else
                FillTable(Reader.FindAll());
        }

        private void SelectReader()
        {
            _reader = this.DgvReaders.SelectedRows[0].DataBoundItem as Reader;
            this.Close();
        }

        private void FrmSearchReader_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.SelectReader();
                    break;
            }
        }
    }
}
