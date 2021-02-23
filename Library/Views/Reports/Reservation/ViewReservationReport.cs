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
    public partial class FrmViewReservationsReport : Form
    {
        public FrmViewReservationsReport()
        {
            InitializeComponent();
        }

        private void FrmViewLendingReport_Load(object sender, EventArgs e)
        {
            this.vwReservationTableAdapter.Fill(this.libraryDataSet.vwReservation);
            this.RpvLending.RefreshReport();
        }
    }
}
