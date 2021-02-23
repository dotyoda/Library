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
    public partial class FrmViewBookReport : Form
    {
        public FrmViewBookReport()
        {
            InitializeComponent();
        }

        private void ViewBookReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'libraryDataSet.books'. Você pode movê-la ou removê-la conforme necessário.
            this.booksTableAdapter.Fill(this.libraryDataSet.books);

            this.reportViewer1.RefreshReport();
        }
    }
}
