using Library.Models;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    public enum SearchBy
    {
        ID,
        READER,
        BOOK
    }

    class ReturnBookPresenter
    {
        public ReturnBookPresenter(FrmReturnBook form)
        {
            this.form = form;
            this._lendings = new List<Lending>();
        }

        private readonly FrmReturnBook form;

        private List<Lending> _lendings;

        public void SelectAll()
        {
            List<Lending> lendings = Lending.FindAll();
            form.FillTable(lendings);
            _lendings = lendings;
        }

        public void Search(string search, SearchBy searchBy)
        {
            if (!string.IsNullOrEmpty(search))
            {
                _lendings.Clear();

                if (searchBy == SearchBy.ID)
                {
                    bool success = int.TryParse(search, out int id);

                    List<Lending> lendings = new List<Lending>();
                    if (success)
                    {
                        var lending = Lending.FindById(id);
                        if (lending != null)
                            lendings.Add(lending);
                    }
                    form.FillTable(lendings);
                    this._lendings = lendings;
                }
                else if (searchBy == SearchBy.READER)
                {
                    var lendings = Lending.FindWithReader(search);
                    form.FillTable(lendings);
                    _lendings = lendings;
                }
                else if (searchBy == SearchBy.BOOK)
                {
                    var lendings = Lending.FindWithBook(search);
                    form.FillTable(lendings);
                    _lendings = lendings;
                }
            }
            else
                this.SelectAll();
        }

        public void ReturnBook(int lendingId)
        {
            var lending = _lendings.Where(l => l.Id == lendingId).First();
            new FrmCheckinBook(lending).ShowDialog();
            this.SelectAll();
        }
    }
}
