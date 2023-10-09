using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void clearOnAction(object sender, EventArgs e)
        {
            userName.Text = null;
            password.Text = null;
        }

        private void loginOnAction(object sender, EventArgs e)
        {
                MySql.Data.MySqlClient.MySqlDataReader reader = utill.CrudUtill.endExecuteReader("SELECT * FROM user");

                while (reader.Read())
                {
                    if (reader.GetString("userName")== userName.Text && reader.GetString("password")==password.Text)
                    {
                        Form1 studentRegistation = new Form1();
                        studentRegistation.Show();
                        this.Hide();

                    }
                else
                {
                    MessageBox.Show("Login Fail ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
        }

        private void closeOnAction(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = DBConntection.DBConection.getDB().getConection();
            mySqlConnection.Close();

           Application.Exit();
        }
    }
}
