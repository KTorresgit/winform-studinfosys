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
using System.IO;
using System.Drawing.Imaging;
/// <summary>
/// Coded by       : Kim Dave Torres
/// Activity Title : Student Information System
/// Subject        : DBMS
/// </summary>
namespace StudentInformationSystem
{
    public partial class SIS : Form
    {
        
        public SIS()
        {
            InitializeComponent();
        }

        //DB CONNECTION STRING --START
        string conn_string = "Data Source=DESKTOP-B7LVHLT;Initial Catalog=SIS;Integrated Security=True";
        //--END

        string img_location = "";

        //LOGIN BTN --START
        private void loginbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
        }
        //--END


        //BROWSE IMAGE --START
        private void buttonbrowseimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                img_location = file.FileName.ToString();
                pictureboximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
                pictureboximage.ImageLocation = img_location;
            }
        }
        //--END


        //BTN INSERT DATA --START
        private async void button1_Click(object sender, EventArgs e)
        {
            if (pictureboximage.Image == null)
            {
                labelimagevalidate.Visible = true;
                await Task.Delay(1000);
                labelimagevalidate.Visible = false;
            }
            else if(textboxtrackorstrand.Text == "")  //studentinfo form validation --start
            {
                labeltrcorstrndvalidate.Visible = true;
                await Task.Delay(1000);
                labeltrcorstrndvalidate.Visible = false;

                textboxtrackorstrand.Select();
            }
            else if(textboxlrn.Text == "") 
            {
                labellrnvalidate.Visible = true;
                await Task.Delay(1000);
                labellrnvalidate.Visible = false;

                textboxlrn.Select();
            }
            else if (textboxfname.Text == "")
            {
                labelstudfnamevalidate.Visible = true;
                await Task.Delay(1000);
                labelstudfnamevalidate.Visible = false;

                textboxfname.Select();
            }
            else if (textboxmiddlename.Text == "")
            {
                labelstudmnamevalidate.Visible = true;
                await Task.Delay(1000);
                labelstudmnamevalidate.Visible = false;

                textboxmiddlename.Select();
            }
            else if (textboxlname.Text == "")
            {
                labelstudlnamevalidate.Visible = true;
                await Task.Delay(1000);
                labelstudlnamevalidate.Visible = false;

                textboxlname.Select();
            }
            else if (comboBoxextraname.Text == "")
            {
                labelstudextranamevalidate.Visible = true;
                await Task.Delay(1000);
                labelstudextranamevalidate.Visible = false;

                comboBoxextraname.Select();
            }
            else if (comboBoxSex.Text == "")
            {
                labelstudsexvalidate.Visible = true;
                await Task.Delay(1000);
                labelstudsexvalidate.Visible = false;

                comboBoxSex.Select();
            }
            else if (textboxage.Text == "")
            {
                labelstudagevalidate.Visible = true;
                await Task.Delay(1000);
                labelstudagevalidate.Visible = false;

                textboxage.Select();
            }
            else if (dateTimePickerdob.Text == string.Empty)
            {
                labelstuddobvalidate.Visible = true;
                await Task.Delay(1000);
                labelstuddobvalidate.Visible = false;

                dateTimePickerdob.Select();
            }
            else if (textBoxcitizenship.Text == "")
            {
                labelstudcitizenshipvalidate.Visible = true;
                await Task.Delay(1000);
                labelstudcitizenshipvalidate.Visible = false;

                textBoxcitizenship.Select();
            }
            else if (comboBoxcivilstatus.Text == "")
            {
                labelstudstatusvalidate.Visible = true;
                await Task.Delay(1000);
                labelstudstatusvalidate.Visible = false;

                comboBoxcivilstatus.Select();
            }
            else if (textboxhomeaddress.Text == "")
            {
                labelstudhomeaddvalidate.Visible = true;
                await Task.Delay(1000);
                labelstudhomeaddvalidate.Visible = false;

                textboxhomeaddress.Select();
            }
            else if (textboxdistrict.Text == "")
            {
                labelstuddistrictvalidate.Visible = true;
                await Task.Delay(1000);
                labelstuddistrictvalidate.Visible = false;

                textboxdistrict.Select();
            }
            else if (textboxzipcode.Text == "")
            {
                labelstudzipcodevalidate.Visible = true;
                await Task.Delay(1000);
                labelstudzipcodevalidate.Visible = false;

                textboxzipcode.Select();
            }
            else if (textboxemail.Text == "")
            {
                labelstudmailvalidate.Visible = true;
                await Task.Delay(1000);
                labelstudmailvalidate.Visible = false;

                textboxemail.Select();
            }
            else if (textboxcontactnumber.Text == "")
            {
                labelstudcontactvalidate.Visible = true;
                await Task.Delay(1000);
                labelstudcontactvalidate.Visible = false;

                textboxcontactnumber.Select();
            } // --end
            else if (textboxmothersname.Text == "") // parent form validation --start
            {
                labelmothersnamevalidate.Visible = true;
                await Task.Delay(1000);
                labelmothersnamevalidate.Visible = false;

                textboxmothersname.Select();
            }
            else if (textboxmothersoccupation.Text == "")
            {
                labelmothersoccupvalidate.Visible = true;
                await Task.Delay(1000);
                labelmothersoccupvalidate.Visible = false;

                textboxmothersoccupation.Select();
            }
            else if (textboxmothercontactnumber.Text == "")
            {
                labelcnmothernamevalidate.Visible = true;
                await Task.Delay(1000);
                labelcnmothernamevalidate.Visible = false;

                textboxmothercontactnumber.Select();
            }
            else if (textboxfathersname.Text == "")
            {
                labelfathersnamevalidate.Visible = true;
                await Task.Delay(1000);
                labelfathersnamevalidate.Visible = false;

                textboxfathersname.Select();
            }
            else if (textboxfathersoccupation.Text == "")
            {
                labelfathersoccupvalidate.Visible = true;
                await Task.Delay(1000);
                labelfathersoccupvalidate.Visible = false;

                textboxfathersoccupation.Select();
            }
            else if (textboxfathescontactnumber.Text == "")
            {
                labelcnfathervalidate.Visible = true;
                await Task.Delay(1000);
                labelcnfathervalidate.Visible = false;

                textboxfathescontactnumber.Select();
            }
            else if (comboBoxpreferredcontact.Text == "")
            {
                labelprffdvalidate.Visible = true;
                await Task.Delay(1000);
                labelprffdvalidate.Visible = false;

                comboBoxpreferredcontact.Select();
            } //--end
            else if (textboxlastschoolattended.Text == "") // school info form validation --start
            {
                labelcnlsavalidate.Visible = true;
                await Task.Delay(1000);
                labelcnlsavalidate.Visible = false;

                textboxlastschoolattended.Select();
            }
            else if (textboxyeargraduated.Text == "")
            {
                labelygvalidate.Visible = true;
                await Task.Delay(1000);
                labelygvalidate.Visible = false;

                textboxyeargraduated.Select();
            }
            else if (textboxaddress_school.Text == "")
            {
                labelaofvalidate.Visible = true;
                await Task.Delay(1000);
                labelaofvalidate.Visible = false;

                textboxaddress_school.Select();
            } //--end
            else
            {
                button1.Enabled = false;
                SqlConnection sqlcnn;
                sqlcnn = new SqlConnection(conn_string);
                sqlcnn.Open();

                // convert image to byte array --start
                MemoryStream mem_stream = new MemoryStream();
                pictureboximage.Image.Save(mem_stream, ImageFormat.Jpeg);

                byte[] photo_arr = new byte[mem_stream.Length];

                mem_stream.Position = 0;
                mem_stream.Read(photo_arr, 0, photo_arr.Length);
                // --end

                SqlCommand sqlcmd_stud = new SqlCommand("sp_students", sqlcnn);
                SqlCommand sqlcmd_contact = new SqlCommand("sp_contact", sqlcnn);
                SqlCommand sqlcmd_parent = new SqlCommand("sp_parent", sqlcnn);
                SqlCommand sqlcmd_school = new SqlCommand("sp_school", sqlcnn);

                //students insert
                sqlcmd_stud.CommandType = CommandType.StoredProcedure;
                sqlcmd_stud.Parameters.AddWithValue("@ProfileImage", photo_arr);
                sqlcmd_stud.Parameters.AddWithValue("@TrackOrStrand", textboxtrackorstrand.Text);
                sqlcmd_stud.Parameters.AddWithValue("@LRN_Number", textboxlrn.Text);
                sqlcmd_stud.Parameters.AddWithValue("@Firstname", textboxfname.Text);
                sqlcmd_stud.Parameters.AddWithValue("@Middlename", textboxmiddlename.Text);
                sqlcmd_stud.Parameters.AddWithValue("@Lastname", textboxlname.Text);
                sqlcmd_stud.Parameters.AddWithValue("@ExtraName", comboBoxextraname.SelectedItem.ToString());
                sqlcmd_stud.Parameters.AddWithValue("@Sex", comboBoxSex.SelectedItem.ToString());
                sqlcmd_stud.Parameters.AddWithValue("@Age", int.Parse(textboxage.Text.ToString()));
                sqlcmd_stud.Parameters.AddWithValue("@DOB", dateTimePickerdob.Value.ToString("MM/dd/yyyy"));
                sqlcmd_stud.Parameters.AddWithValue("@Citizenship", textBoxcitizenship.Text);
                sqlcmd_stud.Parameters.AddWithValue("@CivilStatus", comboBoxcivilstatus.SelectedItem.ToString());
                //end

                //contact insert
                sqlcmd_contact.CommandType = CommandType.StoredProcedure;
                sqlcmd_contact.Parameters.AddWithValue("@HomeAddress", textboxhomeaddress.Text);
                sqlcmd_contact.Parameters.AddWithValue("@District", textboxdistrict.Text);
                sqlcmd_contact.Parameters.AddWithValue("@ZipCode", textboxzipcode.Text);
                sqlcmd_contact.Parameters.AddWithValue("@Email", textboxemail.Text);
                sqlcmd_contact.Parameters.AddWithValue("@ContactNumber", textboxcontactnumber.Text);
		        //end

                //parent insert
                sqlcmd_parent.CommandType = CommandType.StoredProcedure;
                sqlcmd_parent.Parameters.AddWithValue("@MotherName", textboxmothersname.Text);
                sqlcmd_parent.Parameters.AddWithValue("@MotherOccupation", textboxmothersoccupation.Text);
                sqlcmd_parent.Parameters.AddWithValue("@MotherMobileNumber", textboxmothercontactnumber.Text);
                sqlcmd_parent.Parameters.AddWithValue("@FatherName", textboxfathersname.Text);
                sqlcmd_parent.Parameters.AddWithValue("@FatherOccupation", textboxfathersoccupation.Text);
                sqlcmd_parent.Parameters.AddWithValue("@FatherMobileNumber", textboxfathescontactnumber.Text);
                sqlcmd_parent.Parameters.AddWithValue("@PreferredContact", comboBoxpreferredcontact.SelectedItem.ToString());
                //end

                //school insert
                sqlcmd_school.CommandType = CommandType.StoredProcedure;
                sqlcmd_school.Parameters.AddWithValue("@SchoolLastAttended", textboxlastschoolattended.Text);
                sqlcmd_school.Parameters.AddWithValue("@YearGraduated", textboxyeargraduated.Text);
                sqlcmd_school.Parameters.AddWithValue("@AddressOfSchool", textboxaddress_school.Text);
                //end

                int stud, contact, parent, school;
                stud = sqlcmd_stud.ExecuteNonQuery();
                contact = sqlcmd_contact.ExecuteNonQuery();
                parent = sqlcmd_parent.ExecuteNonQuery();
                school = sqlcmd_school.ExecuteNonQuery();

                if (stud > 0 && contact > 0 && parent > 0 && school > 0)
                {
                    Success s = new Success();
                    s.Show();
                    await Task.Delay(1000);
                    s.Close();
                    await Task.Delay(1000);
                    ClearInputField();
                    button1.Enabled = true;
                    //DisplayUserData();
                }
                else
                {
                    Failed f = new Failed();
                    f.Show();
                    await Task.Delay(1000);
                    f.Close();
                    //ClearInputField();
                }
                sqlcnn.Close();
            }
        }
        //--END

        //CLEAR ALL FIELDS --START
        public void ClearInputField()
        {
            pictureboximage.Image = null;
            textboxtrackorstrand.Text = "";
            textboxlrn.Text = "";
            textboxfname.Text = "";
            textboxmiddlename.Text = "";
            textboxlname.Text = "";
            comboBoxextraname.Text = "";
            comboBoxSex.Text = "";
            textboxage.Text = "";
            dateTimePickerdob.Text = string.Empty;
            textBoxcitizenship.Text = "";
            comboBoxcivilstatus.Text = "";
            textboxhomeaddress.Text = "";
            textboxdistrict.Text = "";
            textboxzipcode.Text = "";
            textboxemail.Text = "";
            textboxcontactnumber.Text = "";
            textboxmothersname.Text = "";
            textboxmothersoccupation.Text = "";
            textboxmothercontactnumber.Text = "";
            textboxfathersname.Text = "";
            textboxfathersoccupation.Text = "";
            textboxfathescontactnumber.Text = "";
            comboBoxpreferredcontact.Text = "";
            textboxlastschoolattended.Text = "";
            textboxyeargraduated.Text = "";
            textboxaddress_school.Text = "";
        }
        //--END












        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureboximage_Click(object sender, EventArgs e)
        {

        }
        private void textboxaddress_school_TextChanged(object sender, EventArgs e)
        {
        }
        private void labeladdress_school_Click(object sender, EventArgs e)
        {
        }
        private void textboxyeargraduated_TextChanged(object sender, EventArgs e)
        {
        }
        private void textboxlastschoolattended_TextChanged(object sender, EventArgs e)
        {
        }
        private void labelyeargraduated_Click(object sender, EventArgs e)
        {
        }
        private void labellastschoolattended_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void labelstuddob_Click(object sender, EventArgs e)
        {
        }

        private void SIS_Load(object sender, EventArgs e)
        {

        }
    }
}
