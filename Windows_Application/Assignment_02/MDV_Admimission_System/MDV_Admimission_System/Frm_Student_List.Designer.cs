
namespace MDV_Admimission_System
{
    partial class Frm_Student_List
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
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.pnl_Student_List = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Student_List = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            this.pnl_Student_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Add_Student.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student.Location = new System.Drawing.Point(422, 678);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(261, 53);
            this.btn_Add_Student.TabIndex = 1;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Location = new System.Drawing.Point(1, 133);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1101, 512);
            this.dgv_Student_List.TabIndex = 1;
            // 
            // pnl_Student_List
            // 
            this.pnl_Student_List.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnl_Student_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Student_List.Controls.Add(this.btn_Logout);
            this.pnl_Student_List.Controls.Add(this.lbl_Student_List);
            this.pnl_Student_List.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pnl_Student_List.Location = new System.Drawing.Point(1, 0);
            this.pnl_Student_List.Name = "pnl_Student_List";
            this.pnl_Student_List.Size = new System.Drawing.Size(1101, 109);
            this.pnl_Student_List.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Logout.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Location = new System.Drawing.Point(996, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(95, 36);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.AutoSize = true;
            this.lbl_Student_List.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Student_List.Font = new System.Drawing.Font("Mongolian Baiti", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_List.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Student_List.Location = new System.Drawing.Point(351, 12);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(348, 71);
            this.lbl_Student_List.TabIndex = 0;
            this.lbl_Student_List.Text = "student List";
            this.lbl_Student_List.Click += new System.EventHandler(this.lbl_Student_List_Click);
            // 
            // Frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 754);
            this.Controls.Add(this.pnl_Student_List);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.btn_Add_Student);
            this.Name = "Frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            this.pnl_Student_List.ResumeLayout(false);
            this.pnl_Student_List.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Panel pnl_Student_List;
        private System.Windows.Forms.Label lbl_Student_List;
        private System.Windows.Forms.Button btn_Logout;
    }
}