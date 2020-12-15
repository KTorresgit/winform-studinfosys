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
using System.Globalization;
/// <summary>
/// Coded by       : Kim Dave Torres
/// Activity Title : Student Information System
/// Subject        : DBMS
/// </summary>
namespace StudentInformationSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            StudentSummary();
            Student();
            Contact();
            Parents();
            School();
        }


        //DB CONNECTION STRING --START
        string connection_string = "Data Source=DESKTOP-B7LVHLT;Initial Catalog=SIS;Integrated Security=True";
        //--END


        string img_location = "";
        int userid;


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


        //DISPLAY STUDENT SUMMARY DATA --START
        public void StudentSummary()
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("sp_join", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            dataGridViewsisdata.DataSource = dt;

            for (int i = 0; i < dataGridViewsisdata.Columns.Count; i++)
            {
                if (dataGridViewsisdata.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridViewsisdata.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
            for (int i = dataGridViewsisdata.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = dataGridViewsisdata.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    dataGridViewsisdata.Rows.RemoveAt(i);
                }
            }
            sqlcnn.Close();
        }
        //--END

        //DISPLAY STUDENT DATA --START
        public void Student()
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("sp_display_student", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            dataGridViewstudtable.DataSource = dt;

            for (int i = 0; i < dataGridViewstudtable.Columns.Count; i++)
            {
                if (dataGridViewstudtable.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridViewstudtable.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
            sqlcnn.Close();
        }
        //--END


        //DISPLAY CONTACT DATA --START
        public void Contact()
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("sp_display_contact", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            dataGridViewcontacttable.DataSource = dt;

            sqlcnn.Close();
        }
        //--END


        //DISPLAY PARENT DATA --START
        public void Parents()
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("sp_display_parent", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            dataGridViewparenttable.DataSource = dt;

            sqlcnn.Close();
        }
        //--END


        //DISPLAY SCHOOL DATA --START
        public void School()
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("sp_display_school", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            dataGridViewschool.DataSource = dt;

            sqlcnn.Close();
        }
        //--END


        //DATA GRID CLICK --START
        private void dataGridViewsisdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = int.Parse(dataGridViewsisdata.CurrentRow.Cells[0].Value.ToString());

            byte[] photo_arr = (byte[])dataGridViewsisdata.CurrentRow.Cells[1].Value;
            MemoryStream mem_stream = new MemoryStream(photo_arr);
            pictureboximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureboximage.Image = Image.FromStream(mem_stream);

            textboxtrackorstrand.Text = dataGridViewsisdata.CurrentRow.Cells[2].Value.ToString();
            textboxlrn.Text = dataGridViewsisdata.CurrentRow.Cells[3].Value.ToString();
            textboxfname.Text = dataGridViewsisdata.CurrentRow.Cells[4].Value.ToString();
            textboxmiddlename.Text = dataGridViewsisdata.CurrentRow.Cells[5].Value.ToString();
            textboxlname.Text = dataGridViewsisdata.CurrentRow.Cells[6].Value.ToString();
            comboBoxextraname.Text = dataGridViewsisdata.CurrentRow.Cells[7].Value.ToString();
            comboBoxSex.Text = dataGridViewsisdata.CurrentRow.Cells[8].Value.ToString();
            textboxage.Text = dataGridViewsisdata.CurrentRow.Cells[9].Value.ToString();
            string grid_dob = dataGridViewsisdata.CurrentRow.Cells[10].Value.ToString();
            string dob_conversion = DateTime.ParseExact(grid_dob, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString();
            dateTimePickerdob.Text = dob_conversion;
            textBoxcitizenship.Text = dataGridViewsisdata.CurrentRow.Cells[11].Value.ToString();
            comboBoxcivilstatus.Text = dataGridViewsisdata.CurrentRow.Cells[12].Value.ToString();


            textboxhomeaddress.Text = dataGridViewsisdata.CurrentRow.Cells[14].Value.ToString();
            textboxdistrict.Text = dataGridViewsisdata.CurrentRow.Cells[15].Value.ToString();
            textboxzipcode.Text = dataGridViewsisdata.CurrentRow.Cells[16].Value.ToString();
            textboxemail.Text = dataGridViewsisdata.CurrentRow.Cells[17].Value.ToString();
            textboxcontactnumber.Text = dataGridViewsisdata.CurrentRow.Cells[18].Value.ToString();


            textboxmothersname.Text = dataGridViewsisdata.CurrentRow.Cells[20].Value.ToString();
            textboxmothersoccupation.Text = dataGridViewsisdata.CurrentRow.Cells[21].Value.ToString();
            textboxmothercontactnumber.Text = dataGridViewsisdata.CurrentRow.Cells[22].Value.ToString();
            textboxfathersname.Text = dataGridViewsisdata.CurrentRow.Cells[23].Value.ToString();
            textboxfathersoccupation.Text = dataGridViewsisdata.CurrentRow.Cells[24].Value.ToString();
            textboxfathescontactnumber.Text = dataGridViewsisdata.CurrentRow.Cells[25].Value.ToString();
            comboBoxpreferredcontact.Text = dataGridViewsisdata.CurrentRow.Cells[26].Value.ToString();


            textboxlastschoolattended.Text = dataGridViewsisdata.CurrentRow.Cells[28].Value.ToString();
            textboxyeargraduated.Text = dataGridViewsisdata.CurrentRow.Cells[29].Value.ToString();
            textboxaddress_school.Text = dataGridViewsisdata.CurrentRow.Cells[30].Value.ToString();
        }
        //--END


        //SAVE NEW RECORD --START
        private async void button1_Click(object sender, EventArgs e)
        {
            if (pictureboximage.Image == null)
            {
                labelimagevalidate.Visible = true;
                await Task.Delay(1000);
                labelimagevalidate.Visible = false;
            }
            else if (textboxtrackorstrand.Text == "")  //studentinfo form validation --start
            {
                labeltrcorstrndvalidate.Visible = true;
                await Task.Delay(1000);
                labeltrcorstrndvalidate.Visible = false;

                textboxtrackorstrand.Select();
            }
            else if (textboxlrn.Text == "")
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
                SqlConnection sqlcnn;
                sqlcnn = new SqlConnection(connection_string);
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
                    StudentSummary();
                    Student();
                    Contact();
                    Parents();
                    School();
                    await Task.Delay(1000);
                    s.Close();
                    ClearInputField();
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


        //UPDATE DATA --START
        private async void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            //convert image to binary
            MemoryStream mem_stream = new MemoryStream();
            pictureboximage.Image.Save(mem_stream, ImageFormat.Jpeg);

            byte[] photo_arr = new byte[mem_stream.Length];

            mem_stream.Position = 0;
            mem_stream.Read(photo_arr, 0, photo_arr.Length);
            //end

            SqlCommand sqlcmd_stud = new SqlCommand("sp_student_update", sqlcnn);
            SqlCommand sqlcmd_contact = new SqlCommand("sp_contact_update", sqlcnn);
            SqlCommand sqlcmd_parent = new SqlCommand("sp_parent_update", sqlcnn);
            SqlCommand sqlcmd_school = new SqlCommand("sp_school_update", sqlcnn);


            // student
            sqlcmd_stud.CommandType = CommandType.StoredProcedure;
            sqlcmd_stud.Parameters.AddWithValue("@Stud_ID", userid);
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
            // end

            //contact insert
            sqlcmd_contact.CommandType = CommandType.StoredProcedure;
            sqlcmd_contact.Parameters.AddWithValue("@Contact_ID", userid);
            sqlcmd_contact.Parameters.AddWithValue("@HomeAddress", textboxhomeaddress.Text);
            sqlcmd_contact.Parameters.AddWithValue("@District", textboxdistrict.Text);
            sqlcmd_contact.Parameters.AddWithValue("@ZipCode", textboxzipcode.Text);
            sqlcmd_contact.Parameters.AddWithValue("@Email", textboxemail.Text);
            sqlcmd_contact.Parameters.AddWithValue("@ContactNumber", textboxcontactnumber.Text);
            //end

            //parent 
            sqlcmd_parent.CommandType = CommandType.StoredProcedure;
            sqlcmd_parent.Parameters.AddWithValue("@Parent_ID", userid);
            sqlcmd_parent.Parameters.AddWithValue("@MotherName", textboxmothersname.Text);
            sqlcmd_parent.Parameters.AddWithValue("@MotherOccupation", textboxmothersoccupation.Text);
            sqlcmd_parent.Parameters.AddWithValue("@MotherMobileNumber", textboxmothercontactnumber.Text);
            sqlcmd_parent.Parameters.AddWithValue("@FatherName", textboxfathersname.Text);
            sqlcmd_parent.Parameters.AddWithValue("@FatherOccupation", textboxfathersoccupation.Text);
            sqlcmd_parent.Parameters.AddWithValue("@FatherMobileNumber", textboxfathescontactnumber.Text);
            sqlcmd_parent.Parameters.AddWithValue("@PreferredContact", comboBoxpreferredcontact.SelectedItem.ToString());
            //end

            //school 
            sqlcmd_school.CommandType = CommandType.StoredProcedure;
            sqlcmd_school.Parameters.AddWithValue("@School_ID", userid);
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
                StudentSummary();
                Student();
                Contact();
                Parents();
                School();
                await Task.Delay(1000);
                s.Close();
                ClearInputField();
            }
            else
            {
                Failed f = new Failed();
                f.Show();
                await Task.Delay(1000);
                f.Close();
            }
            sqlcnn.Close();
        }
        //--END


        //DELETE DATA --START
        private async void buttondelete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            SqlCommand sqlcmd_stud = new SqlCommand("sp_student_delete", sqlcnn);
            SqlCommand sqlcmd_contact = new SqlCommand("sp_contact_delete", sqlcnn);
            SqlCommand sqlcmd_parent = new SqlCommand("sp_parent_delete", sqlcnn);
            SqlCommand sqlcmd_school = new SqlCommand("sp_school_delete", sqlcnn);

            // student
            sqlcmd_stud.CommandType = CommandType.StoredProcedure;
            sqlcmd_stud.Parameters.AddWithValue("@Stud_ID", userid);
            // end

            //contact insert
            sqlcmd_contact.CommandType = CommandType.StoredProcedure;
            sqlcmd_contact.Parameters.AddWithValue("@Contact_ID", userid);
            //end

            //parent 
            sqlcmd_parent.CommandType = CommandType.StoredProcedure;
            sqlcmd_parent.Parameters.AddWithValue("@Parent_ID", userid);
            //end

            //school 
            sqlcmd_school.CommandType = CommandType.StoredProcedure;
            sqlcmd_school.Parameters.AddWithValue("@School_ID", userid);
            //end

            int stud, contact, parent, school;
            stud = sqlcmd_stud.ExecuteNonQuery();
            contact = sqlcmd_contact.ExecuteNonQuery();
            parent = sqlcmd_parent.ExecuteNonQuery();
            school = sqlcmd_school.ExecuteNonQuery();
            if (stud > 0 && contact > 0 && parent > 0 && school > 0)
            {
                Deleted s = new Deleted();
                s.Show();
                StudentSummary();
                Student();
                Contact();
                Parents();
                School();
                await Task.Delay(1000);
                s.Close();
                ClearInputField();
            }
            else
            {
                FailedDeleted f = new FailedDeleted();
                f.Show();
                await Task.Delay(1000);
                f.Close();
            }
            sqlcnn.Close();
        }
        //--END

        // SEARCH --START
        private void textboxsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();

            DataTable dt = new DataTable();
            SqlCommand sqlcmd = new SqlCommand("sp_search", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@keywords", textboxsearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            sda.Fill(dt);
            dataGridViewsisdata.DataSource = dt;
            if (dataGridViewsisdata.Rows.Count < 1)
            {
                MessageBox.Show("No such data found!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlcnn.Close();
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

        // PRINT BTN --START
        private async void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            reportload rl = new reportload();
            Report r = new Report();

            rl.Show();
           
            await Task.Delay(3000);
            rl.Close();
            r.Show();
            button2.Enabled = true;
        }
        // --END

        // LOGOUT BTN --START
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // --END




        private void dataGridViewstudtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
