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
    public partial class Frm_Student_List : Form
    {
        public Frm_Student_List()
        {
            InitializeComponent();
        }
        private void lbl_Add_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_Student_Details Obj = new Frm_Add_Student_Details();
            Obj.Show();
            this.Hide();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login_Form Obj = new Frm_Login_Form();
            Obj.Show();
            this.Hide();
        }

        private void Frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter.Fill(this.dataSet1.Student_List);

        }

       
    }
}
