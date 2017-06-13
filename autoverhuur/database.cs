using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
    class database
    {
        public string test()
        {
            autoverhuurDataSet.autoDataTable test = new autoverhuurDataSet.autoDataTable();
            
            return test.Columns.Count.ToString();
        }
    }
}
