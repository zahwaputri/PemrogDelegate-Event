using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasCalculator
// NAMA : ZAHWA PUTRI CHAIRUNNISA
// NIM : 21.11.4084
// KELAS : 21 IF 04
{
    public partial class formCalculatorApp : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public formCalculatorApp()
        {
            InitializeComponent();
        }

        private void FrmEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Clear();
            listOfCalculator.Add(cal);
            IstHasil.Items.Add(cal.Hasil);
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            
            FormEntryData frmEntry = new FormEntryData();
            frmEntry.onCreate += FrmEntry_OnCreate;
            frmEntry.ShowDialog();
        }

        private void IstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
