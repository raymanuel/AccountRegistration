namespace AccountRegistration
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevents non-numeric input
            }
        }

        private void tbContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevents non-numeric input
            }
        }



        private void tbStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevents non-numeric input
            }
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Prevents non-letter input
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Prevents non-letter input
            }
        }

        private void tbMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Prevents non-letter input
            }
        }



        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing letters, digits, space, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Prevents invalid input
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Assigning values to the static properties of StudentInfoClass
            StudentInfoClass.FirstName = tbFirstName.Text;
            StudentInfoClass.LastName = tbLastName.Text;
            StudentInfoClass.MiddleName = tbMiddleName.Text;
            StudentInfoClass.Address = tbAddress.Text;
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.Age = Convert.ToInt64(tbAge.Text);
            StudentInfoClass.ContactNumber = Convert.ToInt64(tbContactNumber.Text);
            StudentInfoClass.StudentNumber = Convert.ToInt64(tbStudentNumber.Text);

           frmConfirm confirmForm = new frmConfirm();

            DialogResult result = confirmForm.ShowDialog();
            if (result == DialogResult.OK)
            {

                // Proceed with the registration process
                MessageBox.Show("Registration successful!");

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).Clear();

                    if (ctrl is ComboBox)
                        ((ComboBox)ctrl).SelectedIndex = -1;
                }

                this.Close(); // Close the registration form
            }
            else
            {
                // User cancelled the confirmation, do not proceed
                MessageBox.Show("Registration cancelled.");
            }

        }




    }//end of class
}//end of namespace
