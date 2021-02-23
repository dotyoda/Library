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
    public partial class FrmViewLendingReport : Form
    {
        public FrmViewLendingReport()
        {
            InitializeComponent();
        }

        private void FrmViewLendingReport_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'libraryDataSet.vwLending'. Você pode movê-la ou removê-la conforme necessário.
            this.vwLendingTableAdapter.Fill(this.libraryDataSet.vwLending);

            this.RtvLending.RefreshReport();
        }
    }
}
