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
    class LibrarianPresenter
    {
        public LibrarianPresenter(FrmLibrarian form)
        {
            this.form = form;
        }

        private readonly FrmLibrarian form;

        public void Save(
            int id,
            string name,
            string phone,
            string email,
            string username,
            string password
        )
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                form.ShowError("Os campos Nome, Usuário e Senha são obrigatórios");
                return;
            }

            try
            {
                Librarian librarian = new Librarian
                {
                    Id = id,
                    Name = name,
                    Phone = phone,
                    Email = email,
                    Password = password,
                    Username = username
                };

                librarian.Save();
                form.SetId(librarian.Id);
                form.ShowSuccess("Bibliotecário (a) cadastrado com sucesso!");
            }
            catch (Exception)
            {
                form.ShowError("Não foi possível cadastrar o Bibliotecário (a).");
            }
        }

        public void Search()
        {
            FrmSearchLibrarian search = new FrmSearchLibrarian();
            search.ShowDialog();

            Librarian librarian = search.Librarian;

            if (librarian == null)
                form.ShowError("Registro não encontrado.");
            else
                form.FillFields(librarian);
        }

        public void Delete(int id)
        {
            try
            {
                Librarian.FindById(id).Delete();
                form.ClearFields();
            }
            catch
            {
                form.ShowError("Não foi possível deletar o registro.");
            }
        }
    }
}
