namespace AccountRegistration
{
    partial class frmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentNo = new Label();
            lblLastName = new Label();
            tbStudentNumber = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            lblFirstName = new Label();
            tbMiddleName = new TextBox();
            lblMiddleName = new Label();
            tbAge = new TextBox();
            lblAge = new Label();
            tbContactNumber = new TextBox();
            lblContactNumber = new Label();
            tbAddress = new TextBox();
            lblAddress = new Label();
            btnNext = new Button();
            lblProgram = new Label();
            cbProgram = new ComboBox();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.FlatStyle = FlatStyle.Flat;
            lblStudentNo.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNo.Location = new Point(31, 23);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(118, 18);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No.:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.FlatStyle = FlatStyle.Flat;
            lblLastName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(31, 105);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(107, 18);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            // 
            // tbStudentNumber
            // 
            tbStudentNumber.BackColor = Color.LightGray;
            tbStudentNumber.BorderStyle = BorderStyle.FixedSingle;
            tbStudentNumber.Location = new Point(34, 45);
            tbStudentNumber.Name = "tbStudentNumber";
            tbStudentNumber.Size = new Size(217, 23);
            tbStudentNumber.TabIndex = 1;
            tbStudentNumber.KeyPress += tbStudentNumber_KeyPress;
            // 
            // tbLastName
            // 
            tbLastName.BackColor = Color.LightGray;
            tbLastName.BorderStyle = BorderStyle.FixedSingle;
            tbLastName.Location = new Point(34, 126);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(217, 23);
            tbLastName.TabIndex = 2;
            tbLastName.KeyPress += tbLastName_KeyPress;
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = Color.LightGray;
            tbFirstName.BorderStyle = BorderStyle.FixedSingle;
            tbFirstName.Location = new Point(279, 126);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(217, 23);
            tbFirstName.TabIndex = 4;
            tbFirstName.KeyPress += tbFirstName_KeyPress;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.FlatStyle = FlatStyle.Flat;
            lblFirstName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(276, 105);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(108, 18);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // tbMiddleName
            // 
            tbMiddleName.BackColor = Color.LightGray;
            tbMiddleName.BorderStyle = BorderStyle.FixedSingle;
            tbMiddleName.Location = new Point(524, 126);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(217, 23);
            tbMiddleName.TabIndex = 6;
            tbMiddleName.KeyPress += tbMiddleName_KeyPress;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.FlatStyle = FlatStyle.Flat;
            lblMiddleName.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMiddleName.Location = new Point(521, 105);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(126, 18);
            lblMiddleName.TabIndex = 5;
            lblMiddleName.Text = "Middle Name:";
            // 
            // tbAge
            // 
            tbAge.BackColor = Color.LightGray;
            tbAge.BorderStyle = BorderStyle.FixedSingle;
            tbAge.Location = new Point(37, 203);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(217, 23);
            tbAge.TabIndex = 8;
            tbAge.KeyPress += tbAge_KeyPress;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.FlatStyle = FlatStyle.Flat;
            lblAge.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(34, 182);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(48, 18);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age:";
            // 
            // tbContactNumber
            // 
            tbContactNumber.BackColor = Color.LightGray;
            tbContactNumber.BorderStyle = BorderStyle.FixedSingle;
            tbContactNumber.Location = new Point(282, 203);
            tbContactNumber.Name = "tbContactNumber";
            tbContactNumber.Size = new Size(217, 23);
            tbContactNumber.TabIndex = 10;
            tbContactNumber.KeyPress += tbContactNumber_KeyPress;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.FlatStyle = FlatStyle.Flat;
            lblContactNumber.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactNumber.Location = new Point(279, 182);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(157, 18);
            lblContactNumber.TabIndex = 9;
            lblContactNumber.Text = "Contact Number:";
            // 
            // tbAddress
            // 
            tbAddress.BackColor = Color.LightGray;
            tbAddress.BorderStyle = BorderStyle.FixedSingle;
            tbAddress.Location = new Point(37, 269);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(704, 165);
            tbAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.FlatStyle = FlatStyle.Flat;
            lblAddress.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(34, 248);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(85, 18);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address:";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.SteelBlue;
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatStyle = FlatStyle.Popup;
            btnNext.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(319, 475);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(117, 35);
            btnNext.TabIndex = 13;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.FlatStyle = FlatStyle.Flat;
            lblProgram.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgram.Location = new Point(283, 22);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(91, 18);
            lblProgram.TabIndex = 14;
            lblProgram.Text = "Program:";
            // 
            // cbProgram
            // 
            cbProgram.BackColor = Color.Silver;
            cbProgram.Cursor = Cursors.Hand;
            cbProgram.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.ForeColor = Color.Black;
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Civil Engineering", "BS in Biology", "BS in Mathematics", "BS in Computer Science", "AB English|", "AB Sociology", "AB History", "AB Filipino" });
            cbProgram.Location = new Point(283, 43);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(458, 25);
            cbProgram.TabIndex = 15;
            cbProgram.Text = "-Select a program-";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(cbProgram);
            Controls.Add(lblProgram);
            Controls.Add(btnNext);
            Controls.Add(tbAddress);
            Controls.Add(lblAddress);
            Controls.Add(tbContactNumber);
            Controls.Add(lblContactNumber);
            Controls.Add(tbAge);
            Controls.Add(lblAge);
            Controls.Add(tbMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(tbFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(tbLastName);
            Controls.Add(tbStudentNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblStudentNo);
            Name = "frmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentNo;
        private Label lblLastName;
        private TextBox tbStudentNumber;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private Label lblFirstName;
        private TextBox tbMiddleName;
        private Label lblMiddleName;
        private TextBox tbAge;
        private Label lblAge;
        private TextBox tbContactNumber;
        private Label lblContactNumber;
        private TextBox tbAddress;
        private Label lblAddress;
        private Button btnNext;
        private Label lblProgram;
        private ComboBox cbProgram;
    }
}
