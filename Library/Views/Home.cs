using Library.Views.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void MnAddReader_Click(object sender, EventArgs e)
        {
            new FrmReader().ShowDialog();
        }

        private void MnAddLibrarian_Click(object sender, EventArgs e)
        {
            new FrmLibrarian().ShowDialog();
        }

        private void MnAddBook_Click(object sender, EventArgs e)
        {
            new FrmBook().ShowDialog();
        }

        private void MnMakeReservation_Click(object sender, EventArgs e)
        {
            new FrmReservation().ShowDialog();
        }

        private void MnMakeLending_Click(object sender, EventArgs e)
        {
            new FrmLending().ShowDialog();
        }

        private void FrmHome_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void MnReturnBook_Click(object sender, EventArgs e)
        {
            new FrmReturnBook().ShowDialog();
        }

        private void MnBookReport_Click(object sender, EventArgs e)
        {
            new FrmViewBookReport().ShowDialog();
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmViewReadersReport().ShowDialog();
        }

        private void MnLibrarian_Click(object sender, EventArgs e)
        {
            new FrmViewLibrarianReport().ShowDialog();
        }

        private void MnReservations_Click(object sender, EventArgs e)
        {
            new FrmViewReservationsReport().ShowDialog();
        }

        private void MnLendingReport_Click(object sender, EventArgs e)
        {
            new FrmViewLendingReport().ShowDialog();
        }
    }
}
