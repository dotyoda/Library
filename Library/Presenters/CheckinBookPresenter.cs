using Library.Models;
using Library.Settings;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    class CheckinBookPresenter
    {
        public CheckinBookPresenter(FrmCheckinBook form, Lending lending)
        {
            this._transaction = new Transaction
            {
                LendingId = lending.Id,
                CreatedAt = DateTime.Now
            };

            this._lending = lending;
            this.form = form;

            form.FillFields(lending);
            this.CalculatePrice();
        }

        private readonly Lending _lending;
        private readonly Transaction _transaction;
        private readonly FrmCheckinBook form;

        private void CalculatePrice()
        {
            int days = (int) (DateTime.Now.Date - this._lending.Checkout.Date).TotalDays;
            this._transaction.Price = this._lending.Book.Price * days == 0 ? 1 : days;
            form.UpdateValues(this._transaction);
        }

        public void RemoveFine(FineType type)
        {
            switch (type)
            {
                case FineType.DAMAGE:
                    this._transaction.Fine -= Constants.FINE_DEMAGE;
                    break;
                case FineType.LOST:
                    this._transaction.Fine -= Constants.FINE_LOST;
                    break;
                case FineType.DELAYED:
                    this._transaction.Fine -= Constants.FINE_DELAYED * (decimal) (Constants.MAX_DAYS_LENDING - (DateTime.Now.Date - this._lending.Checkout.Date).TotalDays);
                    break;
            }

            form.UpdateValues(this._transaction);
        }

        public void AddFine(FineType type)
        {
            switch (type)
            {
                case FineType.DAMAGE:
                    this._transaction.Fine += Constants.FINE_DEMAGE;
                    break;
                case FineType.LOST:
                    this._transaction.Fine += Constants.FINE_LOST;
                    break;
                case FineType.DELAYED:
                    this._transaction.Fine += Constants.FINE_DELAYED * (decimal) (Constants.MAX_DAYS_LENDING - (DateTime.Now.Date - this._lending.Checkout.Date).TotalDays);
                    break;
            }

            form.UpdateValues(this._transaction);
        }

        public void Save()
        {
            try
            {
                this._lending.Checkin = DateTime.Now;

                this._lending.Save();
                this._transaction.Save();
                form.ShowSuccess("Devolução realizada com sucesso!");
                form.Close();
            } catch (Exception)
            {
                form.ShowError("Infelizmente não foi possível efetuar a operação!");
            }
        }
    }
}
