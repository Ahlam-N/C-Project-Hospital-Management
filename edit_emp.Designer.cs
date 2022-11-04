namespace Hospital_managment_system
{
    partial class edit_emp
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
            this.label1 = new System.Windows.Forms.Label();
            this.empid_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empname_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // empid_txt
            // 
            this.empid_txt.Location = new System.Drawing.Point(144, 48);
            this.empid_txt.Name = "empid_txt";
            this.empid_txt.Size = new System.Drawing.Size(90, 20);
            this.empid_txt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 356);
            this.dataGridView1.TabIndex = 2;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(175, 349);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(52, 349);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 4;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Login password";
            // 
            // empname_txt
            // 
            this.empname_txt.Location = new System.Drawing.Point(144, 116);
            this.empname_txt.Name = "empname_txt";
            this.empname_txt.Size = new System.Drawing.Size(90, 20);
            this.empname_txt.TabIndex = 27;
            this.empname_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.pass_txt);
            this.panel1.Controls.Add(this.empname_txt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Update_btn);
            this.panel1.Controls.Add(this.Delete_btn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.empid_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 410);
            this.panel1.TabIndex = 0;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(144, 155);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(90, 20);
            this.pass_txt.TabIndex = 28;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(114, 259);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 29;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // edit_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_emp";
            this.Text = "edit_emp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empid_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empname_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button search;
    }
}