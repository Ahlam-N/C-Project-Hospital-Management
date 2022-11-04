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
    public partial class Reception : Form
    {

        public void loadform(object form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            //f.Dock = DockStyle.Right;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();

        }
        public Reception()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Appointment_btn_Click(object sender, EventArgs e)
        {
            loadform(new Appointmentcs());
        }

        private void AddPatient_btn_Click(object sender, EventArgs e)
        {
            loadform(new add_pat());
        }

        private void patient_info_btn_Click(object sender, EventArgs e)
        {
            loadform(new patient_info());
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
