using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace autoverhuur
{
    class database
    {
        public MySqlConnection conn;

        public database()
        {
            string connection = "server=localhost; database=autoverhuur;user=root; password=;";
            conn = new MySqlConnection(connection);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable createTable(string selectCommand)
        {
            database db = new database();
            MySqlDataAdapter data = new MySqlDataAdapter(selectCommand, conn);
            DataSet DS = new DataSet();
            data.Fill(DS);

            return DS.Tables[0];
        }

        public void insertData(string insertCommand)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = insertCommand;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public MySqlDataReader read(string sqlCommand)
        {
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sqlCommand;
            MySqlDataReader readQuery = null;
            try
            {
                readQuery = cmd.ExecuteReader();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return readQuery;

        }
 
    }
}
