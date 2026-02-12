
namespace MDV_Addmission_System
{
    partial class Frm_Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Submit.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Submit.Location = new System.Drawing.Point(450, 560);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(166, 57);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.AutoSize = true;
            this.lbl_Login_Form.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Mongolian Baiti", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.Location = new System.Drawing.Point(355, 25);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(357, 71);
            this.lbl_Login_Form.TabIndex = 1;
            this.lbl_Login_Form.Text = "Login From";
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_User_Name.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.Location = new System.Drawing.Point(185, 218);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(209, 49);
            this.lbl_User_Name.TabIndex = 2;
            this.lbl_User_Name.Text = "UserName";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_Password.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(185, 391);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(195, 49);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(640, 218);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(401, 40);
            this.tb_UserName.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(640, 391);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(401, 40);
            this.tb_Password.TabIndex = 2;
            // 
            // Frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 736);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User_Name);
            this.Controls.Add(this.lbl_Login_Form);
            this.Controls.Add(this.btn_Submit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
    }
}

