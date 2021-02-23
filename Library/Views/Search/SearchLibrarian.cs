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
    public partial class FrmSearchLibrarian : Form
    {
        public FrmSearchLibrarian()
        {
            InitializeComponent();
            FillTable(Librarian.FindAll());
        }

        private Librarian _librarian;
        public Librarian Librarian { get => _librarian; }

        private void FillTable(List<Librarian> readers)
        {
            this.DgvLibrarians.DataSource = readers;

            if (this.DgvLibrarians.Columns.Count > 0)
            {
                this.DgvLibrarians.Columns[0].HeaderText = "Código";
                this.DgvLibrarians.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                this.DgvLibrarians.Columns[0].Width = 70;

                this.DgvLibrarians.Columns[1].HeaderText = "Nome";
                this.DgvLibrarians.Columns[2].HeaderText = "Telefone";
                this.DgvLibrarians.Columns[3].HeaderText = "E-mail";

                this.DgvLibrarians.Columns[4].HeaderText = "Usuário";
                this.DgvLibrarians.Columns[4].DisplayIndex = 2;

                this.DgvLibrarians.Columns[5].Visible = false;
            }
        }

        private void SelectLibrarian()
        {
            _librarian = this.DgvLibrarians.SelectedRows[0].DataBoundItem as Librarian;
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtSearch.Text.Length > 0)
            {
                if (this.RdbId.Checked)
                {
                    List<Librarian> librarians = new List<Librarian>();

                    bool success = int.TryParse(this.TxtSearch.Text, out int id);

                    if (success)
                    {
                        librarians.Add(Librarian.FindById(id));
                        FillTable(librarians);
                    }
                }
                else if (this.RdbName.Checked)
                    FillTable(Librarian.FindWithName(this.TxtSearch.Text));
                else if (this.RdbUsername.Checked)
                    FillTable(Librarian.FindWithUsername(this.TxtSearch.Text));
            }
            else
                FillTable(Librarian.FindAll());
        }

        private void FrmSearchLibrarian_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.SelectLibrarian();
                    break;
            }
        }
    }
}
