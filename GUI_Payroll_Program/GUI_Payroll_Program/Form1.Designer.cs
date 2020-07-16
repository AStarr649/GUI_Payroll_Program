namespace GUI_Payroll_Program
{
    partial class Frm_Entry
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
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.chkRetire = new System.Windows.Forms.CheckBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee #";
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Location = new System.Drawing.Point(135, 10);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(75, 30);
            this.txtEmpNum.TabIndex = 1;
            this.txtEmpNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(135, 60);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(150, 30);
            this.txtFName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(423, 60);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(200, 30);
            this.txtLName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pay Rate:";
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(135, 110);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(75, 30);
            this.txtPayRate.TabIndex = 7;
            this.txtPayRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayRate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hours:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(292, 110);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(50, 30);
            this.txtHours.TabIndex = 9;
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // chkRetire
            // 
            this.chkRetire.AutoSize = true;
            this.chkRetire.Location = new System.Drawing.Point(423, 96);
            this.chkRetire.Name = "chkRetire";
            this.chkRetire.Size = new System.Drawing.Size(202, 29);
            this.chkRetire.TabIndex = 10;
            this.chkRetire.Text = "Pay into Retirement";
            this.chkRetire.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Location = new System.Drawing.Point(20, 180);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 35);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.AutoSize = true;
            this.btnAddEmp.Location = new System.Drawing.Point(250, 180);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(150, 35);
            this.btnAddEmp.TabIndex = 12;
            this.btnAddEmp.Text = "&Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(546, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 49);
            this.label6.TabIndex = 14;
            this.label6.Text = "*Checking box will deduct 6% for retirement.";
            // 
            // Frm_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 232);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.chkRetire);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Entry";
            this.Text = "Payroll Entry";
            this.Load += new System.EventHandler(this.Frm_Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.CheckBox chkRetire;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
    }
}

