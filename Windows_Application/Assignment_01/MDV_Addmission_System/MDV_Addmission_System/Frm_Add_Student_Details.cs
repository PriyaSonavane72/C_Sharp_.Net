using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDV_Addmission_System
{
    public partial class Frm_Add_Student_Details : Form
    {
        public Frm_Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7PFJ7TM;Integrated Security=True");

        void Con_Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
        void Con_Close()
        {
            con.Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            ///dtp_Date_Of_Birth.Text = "25-03-2005";
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_Date_Of_Birth.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = con;
                Cmd.CommandText = "Insert Into Student_List Values(@Rno,@Nm,@DOB,@MNo,@Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully........");
            }
            else
            {
                MessageBox.Show("Incomplete Data");
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||(e.KeyChar == (Char)Keys.Back)))
            {
                e.Handled = true;
            }
                   
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar ==(Char)Keys.Back) ||(e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            } 
        }
        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            Frm_Student_List Obj = new Frm_Student_List();
            Obj.Show();
            this.Show();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login_Form Obj = new Frm_Login_Form();
            Obj.Show();
            this.Hide();
        }
    }
}
