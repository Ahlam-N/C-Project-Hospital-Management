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
    public partial class patient_info : Form
    {
        private SqlService sqlService = new SqlService();
        public patient_info()
        {
            InitializeComponent();
        }

        private void patient_info_Load(object sender, EventArgs e)
        {

            string query = $"EXEC [sp_GetAllPatients]";

            SqlDataReader data = sqlService.executeReader(query);
            Model emp;

            if (data.HasRows)
            {
                emp = new Model();
                Model.Models.Clear();
                while (data.Read())
                {
                    emp.Name = (string)data["Patient_Fullname"];
                    emp.pid = ((int)data["pid"]).ToString();
                    emp.Contact_Number = (string)data["Phone_number"];
                    emp.Address = (string)data["Address"];
                    emp.Dob = (string)data["Date_of_birth"];
                    emp.Gender = (string)data["Gender"];
                    emp.Blood_group = (string)data["Blood_group"];
                    emp.Major_disease = (string)data["Major_disease"];
                    Model.Models.Add(emp);
                    emp = new Model();
                }
                dataGridView1.DataSource = Model.Models;
            }
        }
    }
}
