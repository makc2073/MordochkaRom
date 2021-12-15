using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MordochkaRom
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string countlabel2;
        string countlabel1;
        string connectionString = "Data Source=10.10.1.24;Initial Catalog=UP_Romash;User ID=pro-41;Password=Pro_41student";
        void View(string sql) // Метод вывода запроса в таблицу клиента
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewClients.DataSource = ds.Tables[0];
                connection.Close();
            }      
        
            string sqlExpression = "SELECT COUNT(*) FROM Client";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int count = (int)command.ExecuteScalar();
                countlabel2 = count.ToString();
                connection.Close();
            }
        }

        private void FormClients_Load(object sender, EventArgs e)
        {        
          View("SELECT * FROM Client");
        }
        
        int str = 0;
        string list;
        int viewtop;
        string toplist;
        int top = 10;
        int rows;
        
        void sheets(int countstr, int str)
        {
            viewtop = countstr * str;
            toplist = Convert.ToString(viewtop);
            list = Convert.ToString(countstr);
            View("SELECT * FROM Client ORDER BY ID OFFSET " + toplist + " ROWS FETCH NEXT " + list + " ROWS ONLY;");
            labelcount.Text = countlabel1 + "/" + countlabel2;
        }
        void labelrows()
        {
            rows = dataGridViewClients.Rows.Count - 1;
            countlabel1 = rows.ToString();
            labelcount.Text = countlabel1 + "/" + countlabel2;
            if (Convert.ToInt32(countlabel1) == Convert.ToInt32(countlabel2))
            {
                btnForward.Enabled = false;
            }
            else
            { btnForward.Enabled = true; }
            btnBack.Enabled = true;
        }
        private void top10_Click(object sender, EventArgs e)
        {
            top = 10;
            str = 0;
            sheets(top, str);
            labelrows();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
           
            if (str > 0)
            {
                str = str - 1;
                sheets(top, str);
                rows = Convert.ToInt32(countlabel1) - dataGridViewClients.Rows.Count + 1;
                countlabel1 = rows.ToString();
                labelcount.Text = countlabel1 + "/" + countlabel2;
                
            }
            else
            {
                str = 0;                
                btnBack.Enabled = false;
               
            }
            if (Convert.ToInt32(countlabel1) == Convert.ToInt32(countlabel2))
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
            }

        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            str = str + 1;            
            sheets(top, str);
            btnBack.Enabled = true;
            rows = rows + dataGridViewClients.Rows.Count - 1;            
            countlabel1 = rows.ToString();
            labelcount.Text = countlabel1 + "/" + countlabel2;
            if (Convert.ToInt32(countlabel1) == Convert.ToInt32(countlabel2))
            { btnForward.Enabled = false; }

        }

        private void top50_Click(object sender, EventArgs e)
        {
            btnForward.Enabled = true;
            top = 50;
            str = 0;
            sheets(top, str);
            labelrows();
        }
            private void top100_Click(object sender, EventArgs e)
        {
            btnForward.Enabled = true;
            top = 100;
            str = 0;
            sheets(top, str);
            labelrows();
        }
        private void topAll_Click(object sender, EventArgs e)
        {
          
            View("SELECT * FROM Client");
            labelrows();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
