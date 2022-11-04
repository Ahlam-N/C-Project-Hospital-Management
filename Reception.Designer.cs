namespace Hospital_managment_system
{
    partial class Reception
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPatient_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.patient_info_btn = new System.Windows.Forms.Button();
            this.Appointment_btn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.AddPatient_btn);
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Controls.Add(this.patient_info_btn);
            this.panel1.Controls.Add(this.Appointment_btn);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 451);
            this.panel1.TabIndex = 0;
            // 
            // AddPatient_btn
            // 
            this.AddPatient_btn.Location = new System.Drawing.Point(60, 148);
            this.AddPatient_btn.Name = "AddPatient_btn";
            this.AddPatient_btn.Size = new System.Drawing.Size(151, 26);
            this.AddPatient_btn.TabIndex = 18;
            this.AddPatient_btn.Text = "Add New Patient Record";
            this.AddPatient_btn.UseVisualStyleBackColor = true;
            this.AddPatient_btn.Click += new System.EventHandler(this.AddPatient_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exit_btn.Location = new System.Drawing.Point(112, 387);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "Logout";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // patient_info_btn
            // 
            this.patient_info_btn.Location = new System.Drawing.Point(60, 206);
            this.patient_info_btn.Name = "patient_info_btn";
            this.patient_info_btn.Size = new System.Drawing.Size(151, 26);
            this.patient_info_btn.TabIndex = 15;
            this.patient_info_btn.Text = "Patient Information";
            this.patient_info_btn.UseVisualStyleBackColor = true;
            this.patient_info_btn.Click += new System.EventHandler(this.patient_info_btn_Click);
            // 
            // Appointment_btn
            // 
            this.Appointment_btn.Location = new System.Drawing.Point(60, 90);
            this.Appointment_btn.Name = "Appointment_btn";
            this.Appointment_btn.Size = new System.Drawing.Size(151, 26);
            this.Appointment_btn.TabIndex = 14;
            this.Appointment_btn.Text = "Appointment";
            this.Appointment_btn.UseVisualStyleBackColor = true;
            this.Appointment_btn.Click += new System.EventHandler(this.Appointment_btn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Unicode MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(75, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 21);
            this.label19.TabIndex = 13;
            this.label19.Text = "Heathcare Center";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(265, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 451);
            this.panel2.TabIndex = 1;
            // 
            // Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reception";
            this.Text = "Reception";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Appointment_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button patient_info_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddPatient_btn;
    }
}