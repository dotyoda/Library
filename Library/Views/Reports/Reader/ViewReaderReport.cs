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
    public partial class FrmViewReadersReport : Form
    {
        public FrmViewReadersReport()
        {
            InitializeComponent();
        }

        private void FrmViewReadersReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'libraryDataSet.readers'. Você pode movê-la ou removê-la conforme necessário.
            this.readersTableAdapter.Fill(this.libraryDataSet.readers);

            this.RpwReader.RefreshReport();
        }
    }
}
