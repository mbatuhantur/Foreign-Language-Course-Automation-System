
namespace FLCP.UI.UserControls
{
    partial class UC_Students
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
            this.groupBox_student = new System.Windows.Forms.GroupBox();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.textBox_phoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePicker_student = new System.Windows.Forms.DateTimePicker();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_branchId = new System.Windows.Forms.ComboBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_createPdf = new System.Windows.Forms.Button();
            this.groupBox_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            this.groupBox_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_student
            // 
            this.groupBox_student.Controls.Add(this.richTextBox_address);
            this.groupBox_student.Controls.Add(this.textBox_phoneNumber);
            this.groupBox_student.Controls.Add(this.dateTimePicker_student);
            this.groupBox_student.Controls.Add(this.comboBox_gender);
            this.groupBox_student.Controls.Add(this.textBox_surname);
            this.groupBox_student.Controls.Add(this.textBox_name);
            this.groupBox_student.Controls.Add(this.comboBox_branchId);
            this.groupBox_student.Controls.Add(this.textBox_id);
            this.groupBox_student.Controls.Add(this.label8);
            this.groupBox_student.Controls.Add(this.label7);
            this.groupBox_student.Controls.Add(this.label6);
            this.groupBox_student.Controls.Add(this.label5);
            this.groupBox_student.Controls.Add(this.label4);
            this.groupBox_student.Controls.Add(this.label3);
            this.groupBox_student.Controls.Add(this.label2);
            this.groupBox_student.Controls.Add(this.label1);
            this.groupBox_student.Location = new System.Drawing.Point(52, 67);
            this.groupBox_student.Name = "groupBox_student";
            this.groupBox_student.Size = new System.Drawing.Size(478, 574);
            this.groupBox_student.TabIndex = 0;
            this.groupBox_student.TabStop = false;
            this.groupBox_student.Text = "STUDENT";
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.Location = new System.Drawing.Point(186, 333);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(206, 173);
            this.richTextBox_address.TabIndex = 15;
            this.richTextBox_address.Text = "";
            // 
            // textBox_phoneNumber
            // 
            this.textBox_phoneNumber.Location = new System.Drawing.Point(186, 283);
            this.textBox_phoneNumber.Name = "textBox_phoneNumber";
            this.textBox_phoneNumber.Size = new System.Drawing.Size(206, 23);
            this.textBox_phoneNumber.TabIndex = 14;
            // 
            // dateTimePicker_student
            // 
            this.dateTimePicker_student.Location = new System.Drawing.Point(186, 247);
            this.dateTimePicker_student.Name = "dateTimePicker_student";
            this.dateTimePicker_student.Size = new System.Drawing.Size(206, 23);
            this.dateTimePicker_student.TabIndex = 13;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_gender.Location = new System.Drawing.Point(186, 203);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(206, 23);
            this.comboBox_gender.TabIndex = 12;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(186, 162);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(206, 23);
            this.textBox_surname.TabIndex = 11;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(186, 123);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(206, 23);
            this.textBox_name.TabIndex = 10;
            // 
            // comboBox_branchId
            // 
            this.comboBox_branchId.DisplayMember = "BranchName";
            this.comboBox_branchId.FormattingEnabled = true;
            this.comboBox_branchId.Location = new System.Drawing.Point(186, 85);
            this.comboBox_branchId.Name = "comboBox_branchId";
            this.comboBox_branchId.Size = new System.Drawing.Size(206, 23);
            this.comboBox_branchId.TabIndex = 9;
            this.comboBox_branchId.ValueMember = "Id";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(186, 44);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(206, 23);
            this.textBox_id.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "ADDRESS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "PHONE NUMBER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "BIRTH DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "GENDER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "SURNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "BRANCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Location = new System.Drawing.Point(634, 67);
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.RowTemplate.Height = 25;
            this.dataGridView_students.Size = new System.Drawing.Size(736, 470);
            this.dataGridView_students.TabIndex = 1;
            this.dataGridView_students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_students_CellClick);
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.button_createPdf);
            this.groupBox_operations.Controls.Add(this.button_clear);
            this.groupBox_operations.Controls.Add(this.button_update);
            this.groupBox_operations.Controls.Add(this.button_delete);
            this.groupBox_operations.Controls.Add(this.button_Save);
            this.groupBox_operations.Location = new System.Drawing.Point(634, 567);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(736, 100);
            this.groupBox_operations.TabIndex = 3;
            this.groupBox_operations.TabStop = false;
            this.groupBox_operations.Text = "OPERATIONS";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(450, 35);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 44);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(308, 35);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(107, 44);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(170, 35);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(104, 44);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(25, 34);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(115, 45);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_createPdf
            // 
            this.button_createPdf.Location = new System.Drawing.Point(600, 35);
            this.button_createPdf.Name = "button_createPdf";
            this.button_createPdf.Size = new System.Drawing.Size(104, 44);
            this.button_createPdf.TabIndex = 4;
            this.button_createPdf.Text = "CREATE PDF";
            this.button_createPdf.UseVisualStyleBackColor = true;
            this.button_createPdf.Click += new System.EventHandler(this.button_createPdf_Click);
            // 
            // UC_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.dataGridView_students);
            this.Controls.Add(this.groupBox_student);
            this.Name = "UC_Students";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_Students_Load);
            this.groupBox_student.ResumeLayout(false);
            this.groupBox_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            this.groupBox_operations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_student;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_address;
        private System.Windows.Forms.TextBox textBox_phoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker_student;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_branchId;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_createPdf;
    }
}
