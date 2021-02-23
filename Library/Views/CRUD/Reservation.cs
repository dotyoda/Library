﻿using Library.DAOs;
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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
            this.presenter = new ReservationPresenter(this);
        }

        private readonly ReservationPresenter presenter;

        private Reader _reader;
        private Book _book;

        public Reader Reader
        {
            set
            {
                this._reader = value;
                this.TxtReader.Text = value.Name;
            }
        }

        public Book Book 
        { 
            set
            {
                this._book = value;
                this.TxtBook.Text = value.Title;
            } 
        }

        private void Save()
        {
            this.presenter.Save(
                reader: this._reader,
                book: this._book,
                checkoutIn: this.DtpCheckoutIn.Value
            );
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.ClearFields();
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

        public void SetId(int id)
        {
            this.TxtId.Text = id.ToString();
        }

        public void FillFields(Reservation reservation)
        {
            this.TxtId.Text = reservation.Id.ToString();
            this.TxtReader.Text = reservation.Reader.Name.ToString();
            this.TxtBook.Text = reservation.Book.Title.ToString();
            this.DtpCheckoutIn.Value = reservation.CheckoutIn;
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

        private void FrmMakeReservation_KeyDown(object sender, KeyEventArgs e)
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

        private void SelectReader()
        {
            presenter.SearchReader();
            this.TxtBook.Focus();
        }

        private void SelectBook()
        {
            presenter.SearchBook();
            this.DtpCheckoutIn.Focus();
        }

        private void TxtBook_Enter(object sender, EventArgs e)
        {
            this.SelectBook();
        }

        private void SearchReader_event(object sender, EventArgs e)
        {
            this.SelectReader();
        }

        private void TxtReader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Back && e.KeyCode != Keys.Tab && e.KeyCode != Keys.Escape)
            {
                this.TxtReader.Text = string.Empty;
                this.SelectReader();
            }
        }
    }
}
