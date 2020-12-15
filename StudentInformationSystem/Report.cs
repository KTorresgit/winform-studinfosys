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
using CrystalDecisions.CrystalReports.Engine;
/// <summary>
/// Coded by       : Kim Dave Torres
/// Activity Title : Student Information System
/// Subject        : DBMS
/// </summary>
namespace StudentInformationSystem
{
    public partial class Report : Form
    {
        ReportDocument rd = new ReportDocument();

        //DB CONNECTION STRING --START
        string connection_string = "Data Source=DESKTOP-B7LVHLT;Initial Catalog=SIS;Integrated Security=True";
        //--END

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // ESTABLISHED CONNECTION --START
            SqlConnection sqlcnn;
            sqlcnn = new SqlConnection(connection_string);
            sqlcnn.Open();
            //--END

            // PATH CRYSTAL REPORT --START
            rd.Load(@"C:\Users\perfe\OneDrive\Desktop\StudentInformationSystem\StudentInformationSystem\SISCrystalReport.rpt");
            //--END

            // DISPLAY REPORT --START
            SqlCommand sqlcmd = new SqlCommand("sp_crystal_report", sqlcnn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            rd.SetDataSource(dt);
            CrystalReport.ReportSource = rd;
            //--END
        }
    }
}
