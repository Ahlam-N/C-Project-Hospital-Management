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

namespace Hospital_managment_system
{
    public partial class edit_emp : Form
    {

        SqlService services = new SqlService();
        public edit_emp()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

            string query = $"EXEC [sp_editEmployee] '{empid_txt.Text}', '{empname_txt.Text}', " +
                $"'{pass_txt.Text}'";

            services.executeNonQuery(query);
            MessageBox.Show("Updated Successfully");
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string query = $"EXEC [sp_deleteEmployee] '{empid_txt.Text}'";

            services.executeNonQuery(query);
            MessageBox.Show("Deleted Successfully");

        }

        private void search_Click(object sender, EventArgs e)
        {
            string query = $"EXEC [sp_SearchEmployee] '{empid_txt.Text}'";

            SqlDataReader data = services.executeReader(query);
            eModel emp = new eModel();
            List<eModel> searchedList = new List<eModel>();
            if (data.Read())
            {
                emp.Name = (string)data["Employee_Fullname"];
                emp.pdid = ((int)data["EId"]).ToString();
                emp.Contact_Number = (string)data["Phone_number"];
                emp.Address = (string)data["Address"];
                emp.Dob = (string)data["Date_of_birth"];
                emp.Gender = (string)data["Gender"];
                emp.Position = (string)data["Position"];
                emp.Password = (string)data["pass"];
                searchedList.Add(emp);
            }
            dataGridView1.DataSource = searchedList;
        }
    }
}
