using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingService
{
    public partial class Rezervisi : Form
    { 
        string naziv;
        public Rezervisi()
        {
            InitializeComponent();
           
        }
        public Rezervisi(string naziv)
        {
            InitializeComponent();
            this.naziv = naziv;
            this.Text = "M" + naziv + " " + "parking ";
        }
        public string Mesto
        {
            get
            { return naziv; }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtVrijeme.Enabled = false;
            txtVrijeme.Text = DateTime.Now.ToString();
        }

        private void txtRegistracija_TextChanged(object sender, EventArgs e)
        {
            if(txtVrijeme.Text!="" && txtRegistracija.Text!="" && txtBrDokumenta.Text!="")
            {
                btnRezervisi.Enabled = true;
            }
        }

        private void txtBrDokumenta_TextChanged(object sender, EventArgs e)
        {
            if (txtVrijeme.Text != "" && txtRegistracija.Text != "" && txtBrDokumenta.Text != "")
            {
                btnRezervisi.Enabled = true;
            }
        }

        private void txtVrijeme_TextChanged(object sender, EventArgs e)
        {
            if (txtVrijeme.Text != "" && txtRegistracija.Text != "" && txtBrDokumenta.Text != "")
            {
                btnRezervisi.Enabled = true;
            }
        }
       
        private void btnRezervisi_Click(object sender, EventArgs e)
        {
                  
            this.DialogResult = DialogResult.OK;
          
            
        }
        public override string ToString()
        {
            return "M" + Mesto + "Dolazak" + txtVrijeme.Text + "\n" + "Registarksa oznaka:" + txtRegistracija.Text + "\n" + "Tip:" + comboBox1.Text + "\n";
        }
    }
}
