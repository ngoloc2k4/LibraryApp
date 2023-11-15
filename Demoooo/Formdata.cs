using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Draft1
{

    public partial class Formdata : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        int choosenId;
        public Formdata()
        {
            InitializeComponent();
        }


        private void createConnection()
        {
            try
            {
                String str = "Server=Lobi\\SQLEXPRESS;Database=OnlineLibraryManagement;Integrated Security = true";
                // tao ket noi 
                conn = new SqlConnection(str);
                // khoi tao command
                cmd = new SqlCommand();
                // set Connection cho command
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da say ra loi" + ex.Message);
            }
        }

       
        
    }
}
