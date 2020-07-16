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
    public partial class Emp_List_Form : Form
    {
        public static EmployeeClass[] Employees = new EmployeeClass[20];
        public StreamReader intake = new StreamReader("Payroll.txt");        

        public int Count = 0, EmpTotal = 0;

        public Emp_List_Form()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            intake.Close();            
            Application.Exit();
        }

        public void AddEmployees(string fname, string lname, string empNum, string payRate, string hrsWorked, bool hasInsure)
        {
            Employees[EmpTotal] = new EmployeeClass();
            Employees[EmpTotal].SetFName = fname;
            Employees[EmpTotal].SetLName = lname;
            Employees[EmpTotal].SetEmpNum = Convert.ToInt32(empNum);
            Employees[EmpTotal].SetPayRate = Convert.ToDouble(payRate);
            Employees[EmpTotal].SetHours = Convert.ToInt32(hrsWorked);
            Employees[EmpTotal].SetGrossPay = Employees[EmpTotal].CalcGross();
            if (Employees[EmpTotal].SetHours > 40)
            {
                Employees[EmpTotal].SetOTPay = Employees[EmpTotal].CalcOTPay(Employees[EmpTotal].SetHours - 40);
            }
            else
            {
                Employees[EmpTotal].SetOTPay = 0.0;
            }
            if(hasInsure == true)
            {
                Employees[EmpTotal].SetInsure = 75.00;
            }
            else
            {
                Employees[EmpTotal].SetInsure = 0.00;
            }
            Employees[EmpTotal].SetRetire = Employees[EmpTotal].CalcRetire();
            Employees[EmpTotal].SetFICA = Employees[EmpTotal].CalcFICA();
            Employees[EmpTotal].SetNetPay = Employees[EmpTotal].CalcNetPay();
            EmpTotal++;
        }

        public void LoadEmployees()
        {
            string inValue;

            while((inValue = intake.ReadLine()) != null)
            {
                Employees[EmpTotal] = new EmployeeClass();
                Employees[EmpTotal].SetEmpNum = Convert.ToInt32(inValue);                  
                Employees[EmpTotal].SetFName = intake.ReadLine();
                Employees[EmpTotal].SetLName = intake.ReadLine();                    
                Employees[EmpTotal].SetHours = Convert.ToInt32(intake.ReadLine());                   
                Employees[EmpTotal].SetPayRate = Convert.ToDouble(intake.ReadLine());
                Employees[EmpTotal].SetGrossPay = Convert.ToDouble(intake.ReadLine());
                Employees[EmpTotal].SetOTPay = Convert.ToDouble(intake.ReadLine());
                Employees[EmpTotal].SetInsure = Convert.ToDouble(intake.ReadLine());
                Employees[EmpTotal].SetRetire = Convert.ToDouble(intake.ReadLine());
                Employees[EmpTotal].SetFICA = Convert.ToDouble(intake.ReadLine());
                Employees[EmpTotal].SetNetPay = Convert.ToDouble(intake.ReadLine());
                EmpTotal++;              
            }
            intake.Close();
        }

        public void DisplayEmployee()
        {
            lblEmpNum.Text = Employees[EmpTotal - 1].SetEmpNum.ToString();
            lblEmpName.Text = Employees[EmpTotal - 1].FullName();
            lblHrsWorked.Text = Employees[EmpTotal - 1].SetHours.ToString();
            lblPayRate.Text = Employees[EmpTotal - 1].SetPayRate.ToString("C2");
            lblGrossPay.Text = Employees[EmpTotal - 1].SetGrossPay.ToString("C2");
            lblOTPay.Text = Employees[EmpTotal - 1].SetOTPay.ToString("C2");
            lblinSure.Text = Employees[EmpTotal - 1].SetInsure.ToString("C2");
            lblRetirement.Text = Employees[EmpTotal - 1].SetRetire.ToString("C2");
            lblFICA.Text = Employees[EmpTotal - 1].SetFICA.ToString("C2");
            lblNetPay.Text = Employees[EmpTotal - 1].SetNetPay.ToString("C2");
        }

        public void DisplayEmployee(int empNum)
        {
            lblEmpNum.Text = Employees[empNum].SetEmpNum.ToString();
            lblEmpName.Text = Employees[empNum].FullName();
            lblHrsWorked.Text = Employees[empNum].SetHours.ToString();
            lblPayRate.Text = Employees[empNum].SetPayRate.ToString("C2");
            lblGrossPay.Text = Employees[empNum].SetGrossPay.ToString("C2");
            lblOTPay.Text = Employees[empNum].SetOTPay.ToString("C2");
            lblinSure.Text = Employees[empNum].SetInsure.ToString("C2");
            lblRetirement.Text = Employees[empNum].SetRetire.ToString("C2");
            lblFICA.Text = Employees[empNum].SetFICA.ToString("C2");
            lblNetPay.Text = Employees[empNum].SetNetPay.ToString("C2");
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if(Count != 0)
            {
                Count--;
                DisplayEmployee(Count);
            }
            else
            {
                Console.Beep();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(Count < Employees.Length)
            {
                if(Employees[Count + 1] != null)
                {
                    Count++;
                    DisplayEmployee(Count);
                }
                else
                {
                    Console.Beep();
                }
            }
            else
            {
                Console.Beep();
            }
        }

        private void Emp_List_Form_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormClass.mf.clearFields();
            FormClass.mf.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream outfile = new FileStream("Payroll.txt", FileMode.Create, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(outfile);
            for(Count = 0; Count < EmpTotal; Count++)
            {
                fileWriter.WriteLine(Employees[Count].SetEmpNum.ToString());
                fileWriter.WriteLine(Employees[Count].SetFName);
                fileWriter.WriteLine(Employees[Count].SetLName);
                fileWriter.WriteLine(Employees[Count].SetHours.ToString());
                fileWriter.WriteLine(Employees[Count].SetPayRate.ToString());
                fileWriter.WriteLine(Employees[Count].SetGrossPay.ToString());
                fileWriter.WriteLine(Employees[Count].SetOTPay.ToString());
                fileWriter.WriteLine(Employees[Count].SetInsure.ToString());
                fileWriter.WriteLine(Employees[Count].SetRetire.ToString());
                fileWriter.WriteLine(Employees[Count].SetFICA.ToString());
                fileWriter.WriteLine(Employees[Count].SetNetPay.ToString());
            }
            fileWriter.Close();
        }
    }
}
