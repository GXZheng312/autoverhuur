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
    public partial class reserveren : Form
    {
        public reserveren()
        {
            InitializeComponent();
            database db = new database();
            dataGridView1.DataSource = db.createTable("SELECT * FROM reservering");
        }
    }
}
