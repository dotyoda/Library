using Library.Models;
using Library.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            timer = new Timer();
        }

        private readonly Timer timer;

        private void VerifyConnection()
        {
            try
            {
                Connection conn = new Connection();
                conn.Database.Connection.Open();
                conn.Database.Connection.Close();
            }
            catch (SqlException)
            {
                timer.Stop();
                MessageBox.Show("Verifique sua conexão com o Banco de Dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadSplashScreen()
        {
            timer.Enabled = true;
            timer.Interval = 50;
            this.PgbLoad.Maximum = 100;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (PgbLoad.Value != 100)
            {
                if (PgbLoad.Value == 30)
                    this.VerifyConnection();
                PgbLoad.Value++;
            }
            else
            {
                timer.Stop();
                this.Hide();
                var login = new FrmLogin();
                login.ShowDialog();

                if (login.Login)
                    new FrmHome().ShowDialog();
                
                this.Close();
            }
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            this.LoadSplashScreen();
        }
    }
}
