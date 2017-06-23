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
            database db = new database();
            dataGridView1.DataSource = db.createTable("SELECT * FROM factuur");
        }

        

        private void Autooverzichtbtn_Click(object sender, EventArgs e)
        {
            autoverhuurForm form = new autoverhuurForm();
            form.ShowDialog();
           
        }

        private void EindeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KlantenoverzicchtBtn_Click(object sender, EventArgs e)
        {
            klanteen_overzicht form = new klanteen_overzicht();
            form.ShowDialog();
           
        }

        private void ReserverenBtn_Click(object sender, EventArgs e)
        {
            reserveren form = new reserveren ();
            form.ShowDialog();
            
        }
    }
}
