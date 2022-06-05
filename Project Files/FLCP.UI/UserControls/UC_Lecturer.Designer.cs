
namespace FLCP.UI.UserControls
{
    partial class UC_Lecturer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Lecturer = new System.Windows.Forms.GroupBox();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.dateTimePicker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Branch = new System.Windows.Forms.ComboBox();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.textBox_LecturerId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_LecturerWorkingDay = new System.Windows.Forms.GroupBox();
            this.button_saveLecturerWorkingDay = new System.Windows.Forms.Button();
            this.comboBox_WorkingDay = new System.Windows.Forms.ComboBox();
            this.comboBox_LecturerId = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_lecturer = new System.Windows.Forms.DataGridView();
            this.dataGridView_mentor_workingDay = new System.Windows.Forms.DataGridView();
            this.button_cretaePDF = new System.Windows.Forms.Button();
            this.groupBox_Lecturer.SuspendLayout();
            this.groupBox_Operations.SuspendLayout();
            this.groupBox_LecturerWorkingDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mentor_workingDay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Lecturer
            // 
            this.groupBox_Lecturer.Controls.Add(this.richTextBox_address);
            this.groupBox_Lecturer.Controls.Add(this.textBox_Phone);
            this.groupBox_Lecturer.Controls.Add(this.dateTimePicker_BirthDate);
            this.groupBox_Lecturer.Controls.Add(this.comboBox_Gender);
            this.groupBox_Lecturer.Controls.Add(this.textBox_Surname);
            this.groupBox_Lecturer.Controls.Add(this.textBox_Name);
            this.groupBox_Lecturer.Controls.Add(this.comboBox_Branch);
            this.groupBox_Lecturer.Controls.Add(this.comboBox_Language);
            this.groupBox_Lecturer.Controls.Add(this.textBox_LecturerId);
            this.groupBox_Lecturer.Controls.Add(this.label9);
            this.groupBox_Lecturer.Controls.Add(this.label8);
            this.groupBox_Lecturer.Controls.Add(this.label7);
            this.groupBox_Lecturer.Controls.Add(this.label6);
            this.groupBox_Lecturer.Controls.Add(this.label5);
            this.groupBox_Lecturer.Controls.Add(this.label4);
            this.groupBox_Lecturer.Controls.Add(this.label3);
            this.groupBox_Lecturer.Controls.Add(this.label2);
            this.groupBox_Lecturer.Controls.Add(this.label1);
            this.groupBox_Lecturer.Location = new System.Drawing.Point(20, 22);
            this.groupBox_Lecturer.Name = "groupBox_Lecturer";
            this.groupBox_Lecturer.Size = new System.Drawing.Size(463, 492);
            this.groupBox_Lecturer.TabIndex = 0;
            this.groupBox_Lecturer.TabStop = false;
            this.groupBox_Lecturer.Text = "LECTURER";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(219, 349);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(212, 124);
            this.richTextBox_address.TabIndex = 17;
            this.richTextBox_address.Text = "";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(219, 303);
            this.textBox_Phone.MaxLength = 11;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(212, 23);
            this.textBox_Phone.TabIndex = 16;
            // 
            // dateTimePicker_BirthDate
            // 
            this.dateTimePicker_BirthDate.Location = new System.Drawing.Point(219, 264);
            this.dateTimePicker_BirthDate.Name = "dateTimePicker_BirthDate";
            this.dateTimePicker_BirthDate.Size = new System.Drawing.Size(212, 23);
            this.dateTimePicker_BirthDate.TabIndex = 15;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Doesn\'t want to specify"});
            this.comboBox_Gender.Location = new System.Drawing.Point(219, 225);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(212, 23);
            this.comboBox_Gender.TabIndex = 14;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(219, 188);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(212, 23);
            this.textBox_Surname.TabIndex = 13;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(219, 145);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(212, 23);
            this.textBox_Name.TabIndex = 12;
            // 
            // comboBox_Branch
            // 
            this.comboBox_Branch.DisplayMember = "BranchName";
            this.comboBox_Branch.FormattingEnabled = true;
            this.comboBox_Branch.Location = new System.Drawing.Point(219, 106);
            this.comboBox_Branch.Name = "comboBox_Branch";
            this.comboBox_Branch.Size = new System.Drawing.Size(212, 23);
            this.comboBox_Branch.TabIndex = 11;
            this.comboBox_Branch.ValueMember = "Id";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.DisplayMember = "Name";
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Location = new System.Drawing.Point(219, 71);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(212, 23);
            this.comboBox_Language.TabIndex = 10;
            this.comboBox_Language.ValueMember = "Id";
            // 
            // textBox_LecturerId
            // 
            this.textBox_LecturerId.Location = new System.Drawing.Point(219, 39);
            this.textBox_LecturerId.Name = "textBox_LecturerId";
            this.textBox_LecturerId.ReadOnly = true;
            this.textBox_LecturerId.Size = new System.Drawing.Size(212, 23);
            this.textBox_LecturerId.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "PHONE NUMBER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "BIRTH DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "GENDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "SURNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "BRANCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LANGUAGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.button_Clear);
            this.groupBox_Operations.Controls.Add(this.button_Update);
            this.groupBox_Operations.Controls.Add(this.button_Delete);
            this.groupBox_Operations.Controls.Add(this.button_Save);
            this.groupBox_Operations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Operations.Location = new System.Drawing.Point(25, 529);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(458, 100);
            this.groupBox_Operations.TabIndex = 3;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "OPERATIONS";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(330, 40);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(107, 37);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(220, 40);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(104, 37);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "UPDATE";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(113, 40);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(101, 37);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(6, 40);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(101, 37);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox_LecturerWorkingDay
            // 
            this.groupBox_LecturerWorkingDay.Controls.Add(this.button_saveLecturerWorkingDay);
            this.groupBox_LecturerWorkingDay.Controls.Add(this.comboBox_WorkingDay);
            this.groupBox_LecturerWorkingDay.Controls.Add(this.comboBox_LecturerId);
            this.groupBox_LecturerWorkingDay.Controls.Add(this.label11);
            this.groupBox_LecturerWorkingDay.Controls.Add(this.label10);
            this.groupBox_LecturerWorkingDay.Location = new System.Drawing.Point(538, 22);
            this.groupBox_LecturerWorkingDay.Name = "groupBox_LecturerWorkingDay";
            this.groupBox_LecturerWorkingDay.Size = new System.Drawing.Size(412, 292);
            this.groupBox_LecturerWorkingDay.TabIndex = 4;
            this.groupBox_LecturerWorkingDay.TabStop = false;
            this.groupBox_LecturerWorkingDay.Text = "LECTURER WORKING DAYS";
            // 
            // button_saveLecturerWorkingDay
            // 
            this.button_saveLecturerWorkingDay.Location = new System.Drawing.Point(176, 194);
            this.button_saveLecturerWorkingDay.Name = "button_saveLecturerWorkingDay";
            this.button_saveLecturerWorkingDay.Size = new System.Drawing.Size(113, 42);
            this.button_saveLecturerWorkingDay.TabIndex = 4;
            this.button_saveLecturerWorkingDay.Text = "SAVE";
            this.button_saveLecturerWorkingDay.UseVisualStyleBackColor = true;
            this.button_saveLecturerWorkingDay.Click += new System.EventHandler(this.button_saveLecturerWorkingDay_Click);
            // 
            // comboBox_WorkingDay
            // 
            this.comboBox_WorkingDay.DisplayMember = "DayName";
            this.comboBox_WorkingDay.FormattingEnabled = true;
            this.comboBox_WorkingDay.Location = new System.Drawing.Point(136, 131);
            this.comboBox_WorkingDay.Name = "comboBox_WorkingDay";
            this.comboBox_WorkingDay.Size = new System.Drawing.Size(201, 23);
            this.comboBox_WorkingDay.TabIndex = 3;
            this.comboBox_WorkingDay.ValueMember = "Id";
            // 
            // comboBox_LecturerId
            // 
            this.comboBox_LecturerId.DisplayMember = "Name";
            this.comboBox_LecturerId.FormattingEnabled = true;
            this.comboBox_LecturerId.Location = new System.Drawing.Point(136, 65);
            this.comboBox_LecturerId.Name = "comboBox_LecturerId";
            this.comboBox_LecturerId.Size = new System.Drawing.Size(201, 23);
            this.comboBox_LecturerId.TabIndex = 2;
            this.comboBox_LecturerId.ValueMember = "Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Working Day";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Lecturer";
            // 
            // dataGridView_lecturer
            // 
            this.dataGridView_lecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lecturer.Location = new System.Drawing.Point(499, 362);
            this.dataGridView_lecturer.Name = "dataGridView_lecturer";
            this.dataGridView_lecturer.RowTemplate.Height = 25;
            this.dataGridView_lecturer.Size = new System.Drawing.Size(875, 327);
            this.dataGridView_lecturer.TabIndex = 5;
            this.dataGridView_lecturer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lecturer_CellClick);
            // 
            // dataGridView_mentor_workingDay
            // 
            this.dataGridView_mentor_workingDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mentor_workingDay.Location = new System.Drawing.Point(956, 31);
            this.dataGridView_mentor_workingDay.Name = "dataGridView_mentor_workingDay";
            this.dataGridView_mentor_workingDay.RowTemplate.Height = 25;
            this.dataGridView_mentor_workingDay.Size = new System.Drawing.Size(445, 283);
            this.dataGridView_mentor_workingDay.TabIndex = 6;
            // 
            // button_cretaePDF
            // 
            this.button_cretaePDF.Location = new System.Drawing.Point(887, 695);
            this.button_cretaePDF.Name = "button_cretaePDF";
            this.button_cretaePDF.Size = new System.Drawing.Size(116, 39);
            this.button_cretaePDF.TabIndex = 7;
            this.button_cretaePDF.Text = "CREATE REPORT";
            this.button_cretaePDF.UseVisualStyleBackColor = true;
            this.button_cretaePDF.Click += new System.EventHandler(this.button_cretaePDF_Click);
            // 
            // UC_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_cretaePDF);
            this.Controls.Add(this.dataGridView_mentor_workingDay);
            this.Controls.Add(this.dataGridView_lecturer);
            this.Controls.Add(this.groupBox_LecturerWorkingDay);
            this.Controls.Add(this.groupBox_Operations);
            this.Controls.Add(this.groupBox_Lecturer);
            this.Name = "UC_Lecturer";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_Lecturer_Load);
            this.groupBox_Lecturer.ResumeLayout(false);
            this.groupBox_Lecturer.PerformLayout();
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_LecturerWorkingDay.ResumeLayout(false);
            this.groupBox_LecturerWorkingDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mentor_workingDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Lecturer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BirthDate;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Branch;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.TextBox textBox_LecturerId;
        private System.Windows.Forms.RichTextBox richTextBox_address;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.GroupBox groupBox_LecturerWorkingDay;
        private System.Windows.Forms.DataGridView dataGridView_lecturer;
        private System.Windows.Forms.DataGridView dataGridView_mentor_workingDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_WorkingDay;
        private System.Windows.Forms.ComboBox comboBox_LecturerId;
        private System.Windows.Forms.Button button_saveLecturerWorkingDay;
        private System.Windows.Forms.Button button_cretaePDF;
    }
}
