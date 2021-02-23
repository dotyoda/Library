using Library.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Library.Presenters;
using System.Collections.Generic;

namespace Library.Views
{
    public partial class FrmCheckinBook : Form
    {
        public FrmCheckinBook(Lending lending)
        {
            InitializeComponent();
            this.presenter = new CheckinBookPresenter(this, lending);
        }

        private readonly CheckinBookPresenter presenter;

        public string Fine { set { this.LblFine.Text = value;  } }

        public void FillFields(Lending lending)
        {
            this.LblReader.Text = lending.Reader.Name;
            this.LblBook.Text = lending.Book.Title;
            this.LblCheckout.Text = lending.Checkout.ToString("dd/MM/yyyy");
            this.LblReturn.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ChbDamage_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChbDamage.Checked)
                this.presenter.AddFine(FineType.DAMAGE);
            else
                this.presenter.RemoveFine(FineType.DAMAGE);
        }

        private void ChbLost_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChbLost.Checked)
                this.presenter.AddFine(FineType.LOST);
            else
                this.presenter.RemoveFine(FineType.LOST);
        }

        public void UpdateValues(Transaction transaction)
        {
            this.LblFine.Text = $"R$ {transaction.Fine:N2}";
            this.LblPrice.Text = $"R$ {transaction.Price:N2}";
            this.LblTotal.Text = $"R$ {transaction.Fine + transaction.Price:N2}";
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.presenter.Save();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Successo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
