using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Payroll_Program
{
    public partial class Frm_Entry : Form
    {
        public Frm_Entry()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormClass.lf.intake.Close();
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (File.Exists("Payroll.txt") && FormClass.lf.intake.ReadLine() != null)
            {
                FormClass.lf.Visible = true;
                FormClass.lf.Count = 0;
                FormClass.lf.LoadEmployees();
                FormClass.lf.DisplayEmployee();
                this.Visible = false;
            }
            else if(File.Exists("Payroll.txt") && FormClass.lf.intake.ReadLine() == null)
            {
                MessageBox.Show("File contains no employees.");
            }
            else
            {
                MessageBox.Show("File not found.");
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            FormClass.lf.AddEmployees(txtFName.Text, txtLName.Text, txtEmpNum.Text, txtPayRate.Text, txtHours.Text, chkRetire.Checked);
            FormClass.lf.Visible = true;
            FormClass.lf.DisplayEmployee();
            this.Visible = false;
        }

        public void clearFields()
        {
            txtEmpNum.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtHours.Text = "";
            txtPayRate.Text = "";
            chkRetire.Checked = false;
            txtEmpNum.Focus();
        }

        private void Frm_Entry_Load(object sender, EventArgs e)
        {
            try
            {
                File.Exists("Payroll.txt");
                btnView.Enabled = true;
            }
            catch (System.IO.IOException exc)
            {
                btnView.Enabled = false;
            }
        }

        private void txtEmpNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPayRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
