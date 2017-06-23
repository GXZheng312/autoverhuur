using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoverhuur
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        

        private void Autooverzichtbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            autoverhuurForm form = new autoverhuurForm();
            form.ShowDialog();
           
        }

        private void EindeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KlantenoverzicchtBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            klanteen_overzicht form = new klanteen_overzicht();
            form.ShowDialog();
           
        }

        private void KlantToevoegenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            klant_toevoegen form = new klant_toevoegen();
            form.ShowDialog();
           
        }

        private void AutotoevoegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            auto_toevoegen form = new auto_toevoegen();
            form.ShowDialog();
       
        }

        private void ReserverenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            reserveren form = new reserveren ();
            form.ShowDialog();
            
        }
    }
}
