using Skill_management.utill;
using System;
using System.Windows.Forms;

namespace Skill_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void existOnAction(object sender, MouseEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = DBConntection.DBConection.getDB().getConection();
            mySqlConnection.Close();
            Application.Exit();
        }

        private void logoutOnAction(object sender, MouseEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void registetionOnAction(object sender, EventArgs e)
        {
            bool v = CrudUtill.executeNonQuery("INSERT INTO registration VALUES (" +
            cmbRegNo.Text + "," +
            "'" + txtFName.Text + "'," +
            "'" + txtLName.Text + "'," +
            "" + dtpBirthDay.Text + "," +
            "'" + getGendar() + "'," +
            "'" + txtAddress.Text + "'," +
            "'" + txtEmail.Text + "'," +
            "" + txtMPhone.Text + "," +
            "" + txtHPhone.Text + "," +
            "'" + txtPName.Text + "'," +
            "'" + txtNic.Text + "'," +
            "" + txtCNo.Text +
            ")");

            if (v)
            {
                MessageBox.Show("Registetion Sucessfull ", "Exsit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbRegNo.Text = string.Empty;
                txtFName.Text = string.Empty;
                txtLName.Text = string.Empty;
                dtpBirthDay.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMPhone.Text = string.Empty;
                txtHPhone.Text = string.Empty;
                txtPName.Text = string.Empty;
                txtNic.Text = string.Empty;
                txtCNo.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Registetion Fail ", "Exsit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getGendar()
        {
            if (rBtnFemale.Checked)
            {
                return "female";
            }
            else if (rBtnMale.Checked)
            {
                return "male";
            }
            throw new NotImplementedException();
        }


        private void updateOnAction(object sender, MouseEventArgs e)
        {
            bool v = CrudUtill.executeNonQuery("UPDATE registration SET firstName   ='" + txtFName.Text + "',lastName    ='" + txtLName.Text + "',dateOfBirth  =" + dtpBirthDay.Text + ",gender       ='" + getGendar() + "',address      ='" + txtAddress.Text + "', email        ='" + txtEmail.Text + "',mobilePhone  =" + txtMPhone.Text + ",homePhone    =" + txtHPhone.Text + ", parentName   ='" + txtPName.Text + "', nic          ='" + txtNic.Text + "',contactNo    =" + txtCNo.Text + " where  regNo=" + cmbRegNo.Text + ";");

            if (v)
            {
                MessageBox.Show("Registetion Sucessfull ", "Exsit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbRegNo.Text = string.Empty;
                txtFName.Text = string.Empty;
                txtLName.Text = string.Empty;
                dtpBirthDay.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtMPhone.Text = string.Empty;
                txtHPhone.Text = string.Empty;
                txtPName.Text = string.Empty;
                txtNic.Text = string.Empty;
                txtCNo.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Update Fail ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearOnAction(object sender, EventArgs e)
        {
            cmbRegNo.Text = string.Empty;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            dtpBirthDay.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMPhone.Text = string.Empty;
            txtHPhone.Text = string.Empty;
            txtPName.Text = string.Empty;
            txtNic.Text = string.Empty;
            txtCNo.Text = string.Empty;



        }




        private void deleteOnAction(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do Your Want to remove ", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bool v = CrudUtill.executeNonQuery("DELETE FROM registration WHERE regNo=" + cmbRegNo.Text + ";");
                if (v)
                {
                    MessageBox.Show("Delete Sucessfull ", "Exsit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmbRegNo.Text = string.Empty;
                    txtFName.Text = string.Empty;
                    txtLName.Text = string.Empty;
                    dtpBirthDay.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtMPhone.Text = string.Empty;
                    txtHPhone.Text = string.Empty;
                    txtPName.Text = string.Empty;
                    txtNic.Text = string.Empty;
                    txtCNo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Delete Fail ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
