using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskPerformanceFInals
{
    public partial class Form1 : Form
    {
        public static int Age = 0;
        public static string FirstName = "";
        public static string LastName = "";
        public static string Address = "";
        public string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ReyDiFy\\source\\repos\\TaskPerformanceFInals\\TaskPerformanceFInals\\StudDB1.mdf;Integrated Security = True";
        public int StudentID = 0;
        public void refresh()
        {
            SqlConnection Refresher;
            Refresher = new SqlConnection(conn);
            Refresher.Open();

            SqlDataAdapter sqlDt = new SqlDataAdapter("Select * from RegistrationBoardDB", conn);
            DataTable DT = new DataTable();
            sqlDt.Fill(DT);
            StudentDataGridView.DataSource = DT;
            Refresher.Close();
        }
        public Form1()
        {

            InitializeComponent();
            refresh();
        }
        public void StudentIdBox_TextChanged()
        {

        }
        public void FirstNameBox_TextChanged()
        {

        }
        public void LastNameBox_TextChanged()
        {

        }
        public void AgeBox_TextChanged()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ReyDiFy\\source\\repos\\TaskPerformanceFInals\\TaskPerformanceFInals\\StudDB1.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            Int32.TryParse(StudentIdBox.Text, out StudentID);
            Int32.TryParse(AgeBox.Text, out Age);
            FirstName = FirstNameBox.Text;
            LastName = LastNameBox.Text;
            Address = AddressName.Text;
            SqlCommand sqlCmd = new SqlCommand("Insert into RegistrationBoardDB values (" + StudentID + ",'" + FirstName + "','" + LastName + "'," + Age + ",'" + Address + "')", cnn);
            sqlCmd.ExecuteNonQuery();
            cnn.Close();
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            SqlConnection FactoryReset;
            FactoryReset = new SqlConnection(conn);
            FactoryReset.Open();

            SqlCommand sqlCMD = new SqlCommand("DROP TABLE RegistrationBoardDB; CREATE TABLE RegistrationBoardDB (Stud_ID int, Stud_Fname varchar(50), Stud_Lname varchar(50), Stud_Age int, Stud_Address varchar(50));", FactoryReset);
            sqlCMD.ExecuteNonQuery();
            FactoryReset.Close();
            refresh();
        }
    }
}
