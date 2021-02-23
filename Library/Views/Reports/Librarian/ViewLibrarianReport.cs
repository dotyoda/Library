using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views.Reports
{
    public partial class FrmViewLibrarianReport : Form
    {
        public FrmViewLibrarianReport()
        {
            InitializeComponent();
        }

        private void ViewLibrarianReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'libraryDataSet.librarians'. Você pode movê-la ou removê-la conforme necessário.
            this.librariansTableAdapter.Fill(this.libraryDataSet.librarians);

            this.RtvLibrarian.RefreshReport();
        }
    }
}
