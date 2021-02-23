using Library.DAOs;
using Library.Models;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
   class BookPresenter
    {
        public BookPresenter(FrmBook form)
        {
            this.form = form;
        }

        private readonly FrmBook form;

        public void Save(
            string isbn,
            string title,
            string author,
            string format,
            int numPages,
            decimal price,
            string publisher,
            int quantity
        )
        {
            if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                form.ShowError("Os campos ISBN, Título e Autor são obrigatórios");
                return;
            }

            try
            {
                Book book = new Book
                {
                    Id = isbn,
                    Title = title,
                    Author = author,
                    Format = format,
                    NumPages = numPages,
                    Price = price,
                    Publisher = publisher,
                    Quantity = quantity,
                };

                book.Save();
                form.ShowSuccess("Livro cadastrado com sucesso!");
            }
            catch (Exception error)
            {
                form.ShowError(error.ToString());
                form.ShowError("Não foi possível cadastrar o Livro.");
            }
        }

        public void Search()
        {
            FrmSearchBook search = new FrmSearchBook();
            search.ShowDialog();

            Book book = search.Book;

            if (book == null)
                form.ShowError("Registro não encontrado.");
            else
                form.FillFields(book);
        }

        public void Delete(string id)
        {
            try { 
                Book.FindById(id).Delete();
                form.ClearFields();
            } catch {
                form.ShowError("Não foi possível deletar o registro.");
            }   
        }
    }
}
