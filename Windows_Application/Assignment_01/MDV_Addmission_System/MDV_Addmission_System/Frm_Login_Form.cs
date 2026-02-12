using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDV_Addmission_System
{
    public partial class Frm_Login_Form : Form
    {
        public Frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if((tb_UserName.Text == "ADMIN" && tb_Password.Text == "1234") || (tb_UserName.Text == "S" && tb_Password.Text == "1162"))
            {
                MessageBox.Show("Login Successful", "Welcom");

                Frm_Add_Student_Details Obj = new Frm_Add_Student_Details();
                    Obj.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed, Enter Correct Username/Password", "fail");
            }
            tb_UserName.Clear();
            tb_Password.Clear();
            tb_UserName.Focus();

        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }
    }
}
