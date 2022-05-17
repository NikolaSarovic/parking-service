using ParkingService.Properties;
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
    public partial class ParkingService : Form
    {
        Boolen []niz=new Boolen[15];
     
        
        public ParkingService()
        {
            InitializeComponent();
            lblvrijeme.Text = DateTime.Now.ToString();
           
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblvrijeme.Text = DateTime.Now.ToString();
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ParkingService_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach(Control ctrl in tableLayoutPanel1.Controls)
            {
                Button btn = (Button)ctrl;
                if(btn.Text==e.KeyChar.ToString())
                {
                  btn.PerformClick();
                }
            }
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                Button btn = (Button)ctrl;
                if (btn.Text == e.KeyChar.ToString())
                {
                    btn.PerformClick();
                }
            }
            
        }

        private void eksportAktivnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Tekst file(*.txt)|*.txt";
            if(svd.ShowDialog()==DialogResult.OK)
            {
                rtbUpisujemo.SaveFile(svd.FileName, RichTextBoxStreamType.PlainText);

            }
        }

      

        private void rezervisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezervisi rz = new Rezervisi(btn_selktovani.Text);
            DialogResult d = rz.ShowDialog();
            if(d==DialogResult.OK)
            {
                rtbUpisujemo.Text += rz.ToString();
                
            }
            
            btn_selktovani.BackColor = Color.Red;
            Settings.Default.brMjesta = Settings.Default.brMjesta-1;
            lblRezevisi.Text = (Settings.Default.brMjesta).ToString();
            
            
            
            this.Show();
            
                    
                
          
            
        }
        public Button btn_selktovani = null;
       
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                Button btn=(Button)sender;
                btn_selktovani=btn;
                
            }
                

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (btn_selktovani.BackColor == Color.Red)
            {
                rezervisiToolStripMenuItem.Enabled = false;
                naplatiToolStripMenuItem.Enabled = true;
            }
            else
            {
                rezervisiToolStripMenuItem.Enabled = true;
                naplatiToolStripMenuItem.Enabled = false;
            }
        }

        private void naplatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_selktovani.BackColor = Color.Lime;
            rtbUpisujemo.Text += "M" + btn_selktovani.Text + "Odlazak" + DateTime.Now.ToString();
            Settings.Default.brMjesta++;
            lblRezevisi.Text = Settings.Default.brMjesta.ToString();
        }

       

      

        

       
    }
}
