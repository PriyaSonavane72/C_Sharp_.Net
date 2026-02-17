using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Windows_Controls
{
    public partial class Use_Windows_Controls : Form
    {
        public Use_Windows_Controls()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)|| (e.KeyChar == (char)Keys.Back) || (e.KeyChar ==(char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey)||(e.KeyChar ==(char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //-Harry-from department -Testing-is-Male-Candidate,Prefers Shift timing-Evening-.
            string Result = "";
            bool Flag = true;

            if(tb_Employee_Name.Text!="")
            {
                Result = tb_Employee_Name.Text + "from department";

                if(cmb_Emloyee_Department.Text!="")
                {
                    Result += cmb_Emloyee_Department.Text + "is";
                     
                    if(rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + "condidate,Prefers shift timimg";
                    }
                    else if(rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + "condidate,Prefers shift timimg";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender Of Employee");
                        Flag = false;    
                    }
                    if (rb_Morning.Checked == true)
                    {
                        Result += rb_Morning.Text +".";
                    }
                    else if (rb_Evening.Checked == true)
                    {
                        Result += rb_Evening.Text + ".";
                    }
                    else if (rb_Night.Checked == true)
                    {
                        Result += rb_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Time");
                        Flag = false;
                    }
                }
                else
                {
                    MessageBox.Show("Select Employee Department");
                    Flag = false;
                }
            }
            else
            {
                MessageBox.Show("Enter Name Of Emloyee");
                Flag = false;
            }
            if(Flag == true)
            {
                tb_Output.Text = Result;
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            tb_Output.Clear();
            cmb_Emloyee_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Morning.Checked = false;
            rb_Evening.Checked = false;
            rb_Night.Checked = false;
        }
      
    }
}
