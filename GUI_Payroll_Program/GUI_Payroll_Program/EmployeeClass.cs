using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Payroll_Program
{
    public class EmployeeClass
    { 
        private string FName, LName;
        private double PayRate, GrossPay, OvertimePay, Retirement, FICA, NetPay, Insurance;
        private int EmpNum, Hours;

        public int SetEmpNum
        {
            get
            {
                return EmpNum;
            }
            set
            {
                EmpNum = value;
            }
        }

        public string SetFName
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }

        public string SetLName
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }

        public string FullName()
        {
            string FulName;
            FulName = FName + " " + LName;
            return FulName;
        }

        public double SetPayRate
        {
            get
            {
                return PayRate;
            }
            set
            {
                PayRate = value;
            }
        }

        public int SetHours
        {
            get
            {
                return Hours;
            }
            set
            {
                Hours = value;
            }
        }

        public double CalcGross()
        {
            double fullGross;

            fullGross = Hours * PayRate;

            return fullGross;
        }

        public double SetGrossPay
        {
            get
            {
                return GrossPay;
            }
            set
            {
                GrossPay = value;
            }
        }

        public double CalcOTPay(int OTHours)
        {
            double OTPay;

            OTPay = OTHours * (PayRate * 1.5);

            return OTPay;
        }

        public double SetOTPay
        {
            get
            {
                return OvertimePay;
            }
            set
            {
                OvertimePay = value;
            }
        }

        public double SetInsure
        {
            get
            {
                return Insurance;
            }
            set
            {
                Insurance = value;
            }
        }

        public double CalcRetire()
        {
            double RetireAmt;

            RetireAmt = (GrossPay - Insurance) * 0.06;

            return RetireAmt;
        }

        public double SetRetire
        {
            get
            {
                return Retirement;
            }
            set
            {
                Retirement = value;
            }
        }

        public double CalcFICA()
        {
            double FICAAmt;

            FICAAmt = (GrossPay - Insurance - Retirement) * 0.23;

            return FICAAmt;
        }

        public double SetFICA
        {
            get
            {
                return FICA;
            }
            set
            {
                FICA = value;
            }
        }

        public double CalcNetPay()
        {
            double netPay;

            netPay = (GrossPay - Insurance - Retirement - FICA);

            return netPay;
        }

        public double SetNetPay
        {
            get
            {
                return NetPay;
            }
            set
            {
                NetPay = value;
            }
        }
    }
}
