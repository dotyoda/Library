using Library.Models;
using Library.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presenters
{
    class LoginPresenter
    {
        public LoginPresenter(FrmLogin form)
        {
            this.form = form;
        }

        public readonly FrmLogin form;

        public void Auth(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                form.ShowError("Preencha todos os campos");
                return;
            }

            try
            {
                form.Login = Librarian.Auth(username, password);

                if (!form.Login)
                    form.ShowError("Login inválido");
                else
                    form.Close();
            } catch (Exception error)
            {
                Console.WriteLine(error);
                form.ShowError("Não foi possível realizar o login");
            }
        }
    }
}
