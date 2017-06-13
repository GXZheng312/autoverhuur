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
    public partial class autoverhuurForm : Form
    {
        public autoverhuurForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = autoverhuurDataSet.klant;
 
        }
    }
}
