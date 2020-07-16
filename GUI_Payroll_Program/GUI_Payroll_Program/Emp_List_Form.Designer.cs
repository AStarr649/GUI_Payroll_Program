namespace GUI_Payroll_Program
{
    partial class Emp_List_Form
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHrsWorked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOTPay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblinSure = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRetirement = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFICA = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Location = new System.Drawing.Point(13, 431);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(458, 431);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrev.Location = new System.Drawing.Point(175, 431);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(87, 35);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "&Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.SystemColors.Control;
            this.btnNext.Location = new System.Drawing.Point(285, 431);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(375, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee #";
            // 
            // lblEmpNum
            // 
            this.lblEmpNum.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpNum.Location = new System.Drawing.Point(509, 15);
            this.lblEmpNum.Name = "lblEmpNum";
            this.lblEmpNum.Size = new System.Drawing.Size(36, 25);
            this.lblEmpNum.TabIndex = 7;
            this.lblEmpNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name:";
            // 
            // lblEmpName
            // 
            this.lblEmpName.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpName.Location = new System.Drawing.Point(285, 55);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(260, 26);
            this.lblEmpName.TabIndex = 9;
            this.lblEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hours Worked:";
            // 
            // lblHrsWorked
            // 
            this.lblHrsWorked.BackColor = System.Drawing.SystemColors.Control;
            this.lblHrsWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHrsWorked.Location = new System.Drawing.Point(458, 95);
            this.lblHrsWorked.Name = "lblHrsWorked";
            this.lblHrsWorked.Size = new System.Drawing.Size(87, 25);
            this.lblHrsWorked.TabIndex = 11;
            this.lblHrsWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pay Rate:";
            // 
            // lblPayRate
            // 
            this.lblPayRate.BackColor = System.Drawing.SystemColors.Control;
            this.lblPayRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayRate.Location = new System.Drawing.Point(458, 135);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(87, 25);
            this.lblPayRate.TabIndex = 13;
            this.lblPayRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gross Pay:";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BackColor = System.Drawing.SystemColors.Control;
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrossPay.Location = new System.Drawing.Point(458, 175);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(87, 25);
            this.lblGrossPay.TabIndex = 15;
            this.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "OT Pay:";
            // 
            // lblOTPay
            // 
            this.lblOTPay.BackColor = System.Drawing.SystemColors.Control;
            this.lblOTPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOTPay.Location = new System.Drawing.Point(458, 215);
            this.lblOTPay.Name = "lblOTPay";
            this.lblOTPay.Size = new System.Drawing.Size(87, 25);
            this.lblOTPay.TabIndex = 17;
            this.lblOTPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Insurance:";
            // 
            // lblinSure
            // 
            this.lblinSure.BackColor = System.Drawing.SystemColors.Control;
            this.lblinSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblinSure.Location = new System.Drawing.Point(458, 255);
            this.lblinSure.Name = "lblinSure";
            this.lblinSure.Size = new System.Drawing.Size(87, 25);
            this.lblinSure.TabIndex = 19;
            this.lblinSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Retirement:";
            // 
            // lblRetirement
            // 
            this.lblRetirement.BackColor = System.Drawing.SystemColors.Control;
            this.lblRetirement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRetirement.Location = new System.Drawing.Point(458, 295);
            this.lblRetirement.Name = "lblRetirement";
            this.lblRetirement.Size = new System.Drawing.Size(87, 25);
            this.lblRetirement.TabIndex = 21;
            this.lblRetirement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "FICA:";
            // 
            // lblFICA
            // 
            this.lblFICA.BackColor = System.Drawing.SystemColors.Control;
            this.lblFICA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFICA.Location = new System.Drawing.Point(458, 335);
            this.lblFICA.Name = "lblFICA";
            this.lblFICA.Size = new System.Drawing.Size(87, 25);
            this.lblFICA.TabIndex = 23;
            this.lblFICA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Net Pay:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.BackColor = System.Drawing.SystemColors.Control;
            this.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetPay.Location = new System.Drawing.Point(458, 375);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(87, 25);
            this.lblNetPay.TabIndex = 25;
            this.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Emp_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(560, 480);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblFICA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRetirement);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblinSure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblOTPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHrsWorked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEmpNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Emp_List_Form";
            this.Text = "Emp_List_Form";
            this.Load += new System.EventHandler(this.Emp_List_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHrsWorked;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOTPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblinSure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRetirement;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFICA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNetPay;
    }
}