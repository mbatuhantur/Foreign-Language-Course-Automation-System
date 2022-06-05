
namespace FLCP.UI.UserControls
{
    partial class UC_Classroom_Course
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
            this.groupBox_Classroom = new System.Windows.Forms.GroupBox();
            this.comboBox_BranchId = new System.Windows.Forms.ComboBox();
            this.textBox_ClassroomName = new System.Windows.Forms.TextBox();
            this.textBox_ClassroomId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Course = new System.Windows.Forms.GroupBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.comboBox_Classroom = new System.Windows.Forms.ComboBox();
            this.comboBox_Langauge = new System.Windows.Forms.ComboBox();
            this.comboBox_Lecturer = new System.Windows.Forms.ComboBox();
            this.textBox_CourseCredit = new System.Windows.Forms.TextBox();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.radioButton_course = new System.Windows.Forms.RadioButton();
            this.radioButton_classroom = new System.Windows.Forms.RadioButton();
            this.dataGridView_classroom = new System.Windows.Forms.DataGridView();
            this.dataGridView_course = new System.Windows.Forms.DataGridView();
            this.button_createReportCourse = new System.Windows.Forms.Button();
            this.groupBox_Classroom.SuspendLayout();
            this.groupBox_Course.SuspendLayout();
            this.groupBox_Operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Classroom
            // 
            this.groupBox_Classroom.Controls.Add(this.comboBox_BranchId);
            this.groupBox_Classroom.Controls.Add(this.textBox_ClassroomName);
            this.groupBox_Classroom.Controls.Add(this.textBox_ClassroomId);
            this.groupBox_Classroom.Controls.Add(this.label3);
            this.groupBox_Classroom.Controls.Add(this.label2);
            this.groupBox_Classroom.Controls.Add(this.label1);
            this.groupBox_Classroom.Location = new System.Drawing.Point(42, 28);
            this.groupBox_Classroom.Name = "groupBox_Classroom";
            this.groupBox_Classroom.Size = new System.Drawing.Size(372, 136);
            this.groupBox_Classroom.TabIndex = 0;
            this.groupBox_Classroom.TabStop = false;
            this.groupBox_Classroom.Text = "CLASSROOM";
            // 
            // comboBox_BranchId
            // 
            this.comboBox_BranchId.DisplayMember = "BranchName";
            this.comboBox_BranchId.FormattingEnabled = true;
            this.comboBox_BranchId.Location = new System.Drawing.Point(170, 87);
            this.comboBox_BranchId.Name = "comboBox_BranchId";
            this.comboBox_BranchId.Size = new System.Drawing.Size(150, 23);
            this.comboBox_BranchId.TabIndex = 5;
            this.comboBox_BranchId.ValueMember = "Id";
            // 
            // textBox_ClassroomName
            // 
            this.textBox_ClassroomName.Location = new System.Drawing.Point(170, 58);
            this.textBox_ClassroomName.Name = "textBox_ClassroomName";
            this.textBox_ClassroomName.Size = new System.Drawing.Size(150, 23);
            this.textBox_ClassroomName.TabIndex = 4;
            // 
            // textBox_ClassroomId
            // 
            this.textBox_ClassroomId.Location = new System.Drawing.Point(170, 29);
            this.textBox_ClassroomId.Name = "textBox_ClassroomId";
            this.textBox_ClassroomId.ReadOnly = true;
            this.textBox_ClassroomId.Size = new System.Drawing.Size(150, 23);
            this.textBox_ClassroomId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Classroom Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox_Course
            // 
            this.groupBox_Course.Controls.Add(this.textBox_price);
            this.groupBox_Course.Controls.Add(this.comboBox_Classroom);
            this.groupBox_Course.Controls.Add(this.comboBox_Langauge);
            this.groupBox_Course.Controls.Add(this.comboBox_Lecturer);
            this.groupBox_Course.Controls.Add(this.textBox_CourseCredit);
            this.groupBox_Course.Controls.Add(this.textBox_CourseCode);
            this.groupBox_Course.Controls.Add(this.textBox_CourseID);
            this.groupBox_Course.Controls.Add(this.label10);
            this.groupBox_Course.Controls.Add(this.label9);
            this.groupBox_Course.Controls.Add(this.label8);
            this.groupBox_Course.Controls.Add(this.label7);
            this.groupBox_Course.Controls.Add(this.label6);
            this.groupBox_Course.Controls.Add(this.label5);
            this.groupBox_Course.Controls.Add(this.label4);
            this.groupBox_Course.Location = new System.Drawing.Point(976, 28);
            this.groupBox_Course.Name = "groupBox_Course";
            this.groupBox_Course.Size = new System.Drawing.Size(363, 315);
            this.groupBox_Course.TabIndex = 1;
            this.groupBox_Course.TabStop = false;
            this.groupBox_Course.Text = "COURSE";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(159, 278);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(140, 23);
            this.textBox_price.TabIndex = 13;
            // 
            // comboBox_Classroom
            // 
            this.comboBox_Classroom.DisplayMember = "ClassroomName";
            this.comboBox_Classroom.FormattingEnabled = true;
            this.comboBox_Classroom.Location = new System.Drawing.Point(159, 238);
            this.comboBox_Classroom.Name = "comboBox_Classroom";
            this.comboBox_Classroom.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Classroom.TabIndex = 12;
            this.comboBox_Classroom.ValueMember = "Id";
            // 
            // comboBox_Langauge
            // 
            this.comboBox_Langauge.DisplayMember = "Name";
            this.comboBox_Langauge.FormattingEnabled = true;
            this.comboBox_Langauge.Location = new System.Drawing.Point(159, 195);
            this.comboBox_Langauge.Name = "comboBox_Langauge";
            this.comboBox_Langauge.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Langauge.TabIndex = 11;
            this.comboBox_Langauge.ValueMember = "Id";
            // 
            // comboBox_Lecturer
            // 
            this.comboBox_Lecturer.DisplayMember = "Name";
            this.comboBox_Lecturer.FormattingEnabled = true;
            this.comboBox_Lecturer.Location = new System.Drawing.Point(159, 154);
            this.comboBox_Lecturer.Name = "comboBox_Lecturer";
            this.comboBox_Lecturer.Size = new System.Drawing.Size(140, 23);
            this.comboBox_Lecturer.TabIndex = 10;
            this.comboBox_Lecturer.ValueMember = "Id";
            // 
            // textBox_CourseCredit
            // 
            this.textBox_CourseCredit.Location = new System.Drawing.Point(159, 116);
            this.textBox_CourseCredit.Name = "textBox_CourseCredit";
            this.textBox_CourseCredit.Size = new System.Drawing.Size(140, 23);
            this.textBox_CourseCredit.TabIndex = 9;
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.Location = new System.Drawing.Point(159, 76);
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(140, 23);
            this.textBox_CourseCode.TabIndex = 8;
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Location = new System.Drawing.Point(159, 41);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.ReadOnly = true;
            this.textBox_CourseID.Size = new System.Drawing.Size(140, 23);
            this.textBox_CourseID.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Classroom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Language";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Lecturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Course Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.button_clear);
            this.groupBox_Operations.Controls.Add(this.button_update);
            this.groupBox_Operations.Controls.Add(this.button_delete);
            this.groupBox_Operations.Controls.Add(this.button_save);
            this.groupBox_Operations.Controls.Add(this.radioButton_course);
            this.groupBox_Operations.Controls.Add(this.radioButton_classroom);
            this.groupBox_Operations.Location = new System.Drawing.Point(456, 28);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(480, 136);
            this.groupBox_Operations.TabIndex = 2;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "OPERATIONS";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(372, 76);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(91, 36);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(256, 76);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(94, 36);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(142, 76);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(96, 36);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(19, 76);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(103, 36);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // radioButton_course
            // 
            this.radioButton_course.AutoSize = true;
            this.radioButton_course.Location = new System.Drawing.Point(272, 37);
            this.radioButton_course.Name = "radioButton_course";
            this.radioButton_course.Size = new System.Drawing.Size(69, 19);
            this.radioButton_course.TabIndex = 1;
            this.radioButton_course.TabStop = true;
            this.radioButton_course.Text = "COURSE";
            this.radioButton_course.UseVisualStyleBackColor = true;
            // 
            // radioButton_classroom
            // 
            this.radioButton_classroom.AutoSize = true;
            this.radioButton_classroom.Location = new System.Drawing.Point(73, 36);
            this.radioButton_classroom.Name = "radioButton_classroom";
            this.radioButton_classroom.Size = new System.Drawing.Size(95, 19);
            this.radioButton_classroom.TabIndex = 0;
            this.radioButton_classroom.TabStop = true;
            this.radioButton_classroom.Text = "CLASSROOM";
            this.radioButton_classroom.UseVisualStyleBackColor = true;
            // 
            // dataGridView_classroom
            // 
            this.dataGridView_classroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_classroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_classroom.Location = new System.Drawing.Point(42, 414);
            this.dataGridView_classroom.Name = "dataGridView_classroom";
            this.dataGridView_classroom.RowTemplate.Height = 25;
            this.dataGridView_classroom.Size = new System.Drawing.Size(474, 275);
            this.dataGridView_classroom.TabIndex = 3;
            this.dataGridView_classroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_classroom_CellClick);
            // 
            // dataGridView_course
            // 
            this.dataGridView_course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_course.Location = new System.Drawing.Point(579, 414);
            this.dataGridView_course.Name = "dataGridView_course";
            this.dataGridView_course.RowTemplate.Height = 25;
            this.dataGridView_course.Size = new System.Drawing.Size(760, 275);
            this.dataGridView_course.TabIndex = 4;
            this.dataGridView_course.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_course_CellClick);
            // 
            // button_createReportCourse
            // 
            this.button_createReportCourse.Location = new System.Drawing.Point(579, 696);
            this.button_createReportCourse.Name = "button_createReportCourse";
            this.button_createReportCourse.Size = new System.Drawing.Size(191, 29);
            this.button_createReportCourse.TabIndex = 5;
            this.button_createReportCourse.Text = "CREATE REPORT FOR COURSES";
            this.button_createReportCourse.UseVisualStyleBackColor = true;
            this.button_createReportCourse.Click += new System.EventHandler(this.button_createReportCourse_Click);
            // 
            // UC_Classroom_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_createReportCourse);
            this.Controls.Add(this.dataGridView_course);
            this.Controls.Add(this.dataGridView_classroom);
            this.Controls.Add(this.groupBox_Operations);
            this.Controls.Add(this.groupBox_Course);
            this.Controls.Add(this.groupBox_Classroom);
            this.Name = "UC_Classroom_Course";
            this.Size = new System.Drawing.Size(1404, 781);
            this.Load += new System.EventHandler(this.UC_Classroom_Course_Load);
            this.groupBox_Classroom.ResumeLayout(false);
            this.groupBox_Classroom.PerformLayout();
            this.groupBox_Course.ResumeLayout(false);
            this.groupBox_Course.PerformLayout();
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_Operations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_classroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Classroom;
        private System.Windows.Forms.ComboBox comboBox_BranchId;
        private System.Windows.Forms.TextBox textBox_ClassroomName;
        private System.Windows.Forms.TextBox textBox_ClassroomId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Course;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.ComboBox comboBox_Classroom;
        private System.Windows.Forms.ComboBox comboBox_Langauge;
        private System.Windows.Forms.ComboBox comboBox_Lecturer;
        private System.Windows.Forms.TextBox textBox_CourseCredit;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.RadioButton radioButton_course;
        private System.Windows.Forms.RadioButton radioButton_classroom;
        private System.Windows.Forms.DataGridView dataGridView_classroom;
        private System.Windows.Forms.DataGridView dataGridView_course;
        private System.Windows.Forms.Button button_createReportCourse;
    }
}
