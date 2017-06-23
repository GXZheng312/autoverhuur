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
    public partial class klanteen_overzicht : Form
    {
        public klanteen_overzicht()
        {
            InitializeComponent();
            database db = new database();
            dataGridView1.DataSource = db.createTable("SELECT * FROM klant");

        }

        private void klantToevoegenBtn_Click(object sender, EventArgs e)
        {
            klant_toevoegen form = new klant_toevoegen();
            form.ShowDialog();
        }
    }
}
