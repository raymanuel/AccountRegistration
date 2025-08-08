using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class frmConfirm : Form
    {


        private StudentInfoClass.DelegateText DelProgram,
        DelFirstName,
        DelLastName,
        DelMiddleName,
        DelAddress;

        private StudentInfoClass.DelegateNum DelAge, DelStudentNumber, DelContactNumber;



        // This class is used to confirm the registration details before final submission.
        public frmConfirm()
        {
            InitializeComponent();
            DelProgram = StudentInfoClass.GetProgram;
            DelFirstName = StudentInfoClass.GetFirstName;
            DelLastName = StudentInfoClass.GetLastName;
            DelMiddleName = StudentInfoClass.GetMiddleName;
            DelAddress = StudentInfoClass.GetAddress;

            DelAge = StudentInfoClass.GetAge;
            DelStudentNumber = StudentInfoClass.GetStudentNumber;
            DelContactNumber = StudentInfoClass.GetContactNumber;

        }


        private void frmConfirm_Load(object sender, EventArgs e)
        {
            // Display the registration details in the confirmation form.
            lblProgram.Text = DelProgram(StudentInfoClass.Program);
            lblFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            lblLastName.Text = DelLastName(StudentInfoClass.LastName);
            lblMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            lblAddress.Text = DelAddress(StudentInfoClass.Address);

            lblAge.Text = DelAge(StudentInfoClass.Age).ToString();
            lblContact.Text = DelContactNumber(StudentInfoClass.ContactNumber).ToString();
            lblStudentNumber.Text = DelStudentNumber(StudentInfoClass.StudentNumber).ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Set the dialog result to OK when the submit button is clicked.
            this.Close(); // Close the confirmation form.
        }

        private void frmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }//end of class
}//end of namespace
