using Library.Errors;
using Library.Models;
using Library.Views;
using System;

namespace Library.Presenters
{
    class ReaderPresenter
    {

        public ReaderPresenter(FrmReader form)
        {
            this.form = form;
        }

        private readonly FrmReader form;

        public void Save(
            int id, 
            string name, 
            string rg, 
            string phone, 
            string email
        )
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(rg))
            {
                form.ShowError("Os campos Nome e RG são obrigatórios");
                return;
            }

            Reader reader = new Reader
            {
                Id = id,
                Name = name,
                RG = rg,
                Phone = phone,
                Email = email
            };

            try {
                reader.Save();
                form.SetId(reader.Id);
                form.ShowSuccess("Leitor cadastrado com sucesso!");
            } catch (Error error) {
                form.ShowError(error.ToString());
            } catch (Exception) {
                form.ShowError("Não foi possível cadastrar o Leitor (a).");
            }
        }

        public void Search() 
        {
            FrmSearchReader search = new FrmSearchReader();
            search.ShowDialog();

            Reader reader = search.Reader;

            if (reader == null)
                form.ShowError("Registro não encontrado.");
            else
                form.FillFields(reader);
        }

        public void Delete(int id)
        {
            try
            {
                Reader.FindById(id).Delete();
                form.ClearFields();
            }
            catch (Exception error)
            {
                form.ShowError(error.ToString());
                form.ShowError("Não foi possível deletar o registro.");
            }
        }
    }
}
