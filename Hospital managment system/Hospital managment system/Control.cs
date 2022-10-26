using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_managment_system
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void AddPatient_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void Control_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
            panel2.Visible = false;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Model md= new Model();
            md.Name = Name_txt.Text;
            md.Contact_Number = Name_txt.Text;
            md.Address = Address_txt.Text;
          //  md.Age = Age_txt.Text;
          md.save();
        }

        private void Add_Diagnosis_btn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            
        }

       
    }
}
