
namespace MDV_Addmission_System
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Add_Student = new System.Windows.Forms.Button();
            this.lbl_Student_list = new System.Windows.Forms.Label();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MDV_Addmission_System.DataSet1();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.student_ListTableAdapter = new MDV_Addmission_System.DataSet1TableAdapters.Student_ListTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Add_Student
            // 
            this.lbl_Add_Student.BackColor = System.Drawing.Color.FloralWhite;
            this.lbl_Add_Student.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Student.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Add_Student.Location = new System.Drawing.Point(460, 674);
            this.lbl_Add_Student.Name = "lbl_Add_Student";
            this.lbl_Add_Student.Size = new System.Drawing.Size(166, 50);
            this.lbl_Add_Student.TabIndex = 0;
            this.lbl_Add_Student.Text = "Add Student";
            this.lbl_Add_Student.UseVisualStyleBackColor = false;
            this.lbl_Add_Student.Click += new System.EventHandler(this.lbl_Add_Student_Click);
            // 
            // lbl_Student_list
            // 
            this.lbl_Student_list.AutoSize = true;
            this.lbl_Student_list.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Student_list.Font = new System.Drawing.Font("Mongolian Baiti", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_list.Location = new System.Drawing.Point(391, 9);
            this.lbl_Student_list.Name = "lbl_Student_list";
            this.lbl_Student_list.Size = new System.Drawing.Size(314, 63);
            this.lbl_Student_list.TabIndex = 1;
            this.lbl_Student_list.Text = "Student List";
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.idDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentListBindingSource;
            this.dgv_Student_List.Location = new System.Drawing.Point(3, 92);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1120, 559);
            this.dgv_Student_List.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Roll No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date Of Birth";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mob No";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Course";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataMember = "Student List";
            this.studentListBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Logout.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Location = new System.Drawing.Point(993, -1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(130, 44);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // student_ListTableAdapter
            // 
            this.student_ListTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob No";
            this.mobNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 736);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.lbl_Student_list);
            this.Controls.Add(this.lbl_Add_Student);
            this.Name = "Frm_Student_List";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.Frm_Student_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lbl_Add_Student;
        private System.Windows.Forms.Label lbl_Student_list;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Button btn_Logout;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentListBindingSource;
        private DataSet1TableAdapters.Student_ListTableAdapter student_ListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}