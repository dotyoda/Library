using Library.DAOs;
using Library.Models;
using Library.Presenters;
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
    public partial class FrmLending : Form
    {
        public FrmLending()
        {
            InitializeComponent();
            this.presenter = new LendingPresenter(this);
        }

        private readonly LendingPresenter presenter;

        public Reader Reader { set => this.TxtReader.Text = value.Name; }

        public Book Book { set => this.TxtBook.Text = value.Title; }

        private void Save()
        {
            this.presenter.Save();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.presenter.Search();
            this.LblMessage.Visible = false;
        }

        public void SetId(int id)
        {
            this.TxtId.Text = id.ToString();
        }

        public void ShowError(string message)
        {
            this.LblMessage.Text = message;
            this.LblMessage.ForeColor = Color.Red;
            this.LblMessage.Visible = true;
        }

        public void ShowSuccess(string message)
        {
            this.LblMessage.Text = message;
            this.LblMessage.ForeColor = Color.DarkGreen;
            this.LblMessage.Visible = true;
        }

        public void FillFields(Reservation reservation)
        {
            this.TxtId.Text = reservation.Id.ToString();
            this.TxtReader.Text = reservation.Reader.Name;
            this.TxtBook.Text = reservation.Book.Title;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        public void ClearFields()
        {
            ClearTextBoxes(this.Controls);
            this.LblMessage.Visible = false;
        }

        private void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
                if (ctrl is TextBoxBase) ctrl.Text = String.Empty;
                else ClearTextBoxes(ctrl.Controls);
        }

        private void FrmLending_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.Save();
                    break;
            }
        }
    }
}
