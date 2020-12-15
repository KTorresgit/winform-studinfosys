using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/// <summary>
/// Coded by       : Kim Dave Torres
/// Activity Title : Student Information System
/// Subject        : DBMS
/// </summary>
namespace StudentInformationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //SQL CONNECTION STRING --START
        string connection_string = "Data Source=DESKTOP-B7LVHLT;Initial Catalog=SIS;Integrated Security=True";
        //--END

        //LOGIN BUTTON --START
        private async void buttonlogin_Click(object sender, EventArgs e)
        {
            // validation --start
            if(textboxusername.Text == "")
            {
                labelusernamevalidate.Visible = true;
                await Task.Delay(2000);
                labelusernamevalidate.Visible = false;

                textboxusername.Select(); // select text box that empty
            }else if(textboxpassword.Text == "")
            {
                labelpasswordvalidate.Visible = true;
                await Task.Delay(2000);
                labelpasswordvalidate.Visible = false;

                textboxpassword.Select();
            }// valdation --end
            else
            {
                SqlConnection sqlcnn;
                sqlcnn = new SqlConnection(connection_string);
                sqlcnn.Open();

                SqlCommand sqlcmd = new SqlCommand("sp_login", sqlcnn);
                SqlParameter param1 = new SqlParameter("@Username", textboxusername.Text);
                SqlParameter param2 = new SqlParameter("@Password", textboxpassword.Text);

                sqlcmd.CommandType = CommandType.StoredProcedure;

                sqlcmd.Parameters.Add(param1);
                sqlcmd.Parameters.Add(param2);

                SqlDataReader sqlreader = sqlcmd.ExecuteReader();
                if (sqlreader.Read())
                {
                    buttonlogin.Enabled = false;
                    textboxusername.Enabled = false;
                    textboxpassword.Enabled = false; 
                    labelloginsuccess.Visible = true;

                    // after 2 secs close login form
                    await Task.Delay(2000);
                    this.Close();

                    AdminForm adminfrm = new AdminForm();
                    adminfrm.Show();
                }
                else
                {
                    labelloginfailed.Visible = true;
                    await Task.Delay(3000);
                    labelloginfailed.Visible = false;
                    textboxusername.Select();
                }
                sqlcnn.Close();
            }
        }
        //--END
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
