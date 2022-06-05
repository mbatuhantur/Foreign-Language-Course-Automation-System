
namespace FLCP.UI.UserControls
{
    partial class UC_CourseRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_courseRegistration = new System.Windows.Forms.GroupBox();
            this.comboBox_Statu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_StudentId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_CourseId = new System.Windows.Forms.ComboBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView_courseRegistration = new System.Windows.Forms.DataGridView();
            this.button_report = new System.Windows.Forms.Button();
            this.groupBox_courseRegistration.SuspendLayout();
            this.groupBox_operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courseRegistration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COURSE REGISTRATION";
            // 
            // groupBox_courseRegistration
            // 
            this.groupBox_courseRegistration.Controls.Add(this.comboBox_Statu);
            this.groupBox_courseRegistration.Controls.Add(this.label5);
            this.groupBox_courseRegistration.Controls.Add(this.comboBox_StudentId);
            this.groupBox_courseRegistration.Controls.Add(this.label4);
            this.groupBox_courseRegistration.Controls.Add(this.label3);
            this.groupBox_courseRegistration.Controls.Add(this.comboBox_CourseId);
            this.groupBox_courseRegistration.Controls.Add(this.textBox_ID);
            this.groupBox_courseRegistration.Controls.Add(this.label2);
            this.groupBox_courseRegistration.Location = new System.Drawing.Point(102, 146);
            this.groupBox_courseRegistration.Name = "groupBox_courseRegistration";
            this.groupBox_courseRegistration.Size = new System.Drawing.Size(508, 245);
            this.groupBox_courseRegistration.TabIndex = 1;
            this.groupBox_courseRegistration.TabStop = false;
            this.groupBox_courseRegistration.Text = "Course Registration";
            // 
            // comboBox_Statu
            // 
            this.comboBox_Statu.FormattingEnabled = true;
            this.comboBox_Statu.Items.AddRange(new object[] {
            "LEFT",
            "CONTINUOS"});
            this.comboBox_Statu.Location = new System.Drawing.Point(147, 174);
            this.comboBox_Statu.Name = "comboBox_Statu";
            this.comboBox_Statu.Size = new System.Drawing.Size(170, 23);
            this.comboBox_Statu.TabIndex = 7;
            this.comboBox_Statu.Text = "Select Statu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Statu";
            // 
            // comboBox_StudentId
            // 
            this.comboBox_StudentId.DisplayMember = "Name";
            this.comboBox_StudentId.FormattingEnabled = true;
            this.comboBox_StudentId.Location = new System.Drawing.Point(147, 136);
            this.comboBox_StudentId.Name = "comboBox_StudentId";
            this.comboBox_StudentId.Size = new System.Drawing.Size(170, 23);
            this.comboBox_StudentId.TabIndex = 5;
            this.comboBox_StudentId.ValueMember = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course";
            // 
            // comboBox_CourseId
            // 
            this.comboBox_CourseId.DisplayMember = "CourseCode";
            this.comboBox_CourseId.FormattingEnabled = true;
            this.comboBox_CourseId.Location = new System.Drawing.Point(147, 94);
            this.comboBox_CourseId.Name = "comboBox_CourseId";
            this.comboBox_CourseId.Size = new System.Drawing.Size(170, 23);
            this.comboBox_CourseId.TabIndex = 2;
            this.comboBox_CourseId.ValueMember = "Id";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(147, 58);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(170, 23);
            this.textBox_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.button_report);
            this.groupBox_operations.Controls.Add(this.button_clear);
            this.groupBox_operations.Controls.Add(this.button_update);
            this.groupBox_operations.Controls.Add(this.button_delete);
            this.groupBox_operations.Controls.Add(this.button_Save);
            this.groupBox_operations.Location = new System.Drawing.Point(687, 146);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(693, 100);
            this.groupBox_operations.TabIndex = 2;
            this.groupBox_operations.TabStop = false;
            this.groupBox_operations.Text = "OPERATIONS";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(421, 35);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(99, 44);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(296, 35);
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
            // dataGridView_courseRegistration
            // 
            this.dataGridView_courseRegistration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_courseRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courseRegistration.Location = new System.Drawing.Point(102, 442);
            this.dataGridView_courseRegistration.Name = "dataGridView_courseRegistration";
            this.dataGridView_courseRegistration.RowTemplate.Height = 25;
            this.dataGridView_courseRegistration.Size = new System.Drawing.Size(508, 241);
            this.dataGridView_courseRegistration.TabIndex = 3;
            this.dataGridView_courseRegistration.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_courseRegistration_CellClick);
            // 
            // button_report
            // 
            this.button_report.Location = new System.Drawing.Point(551, 35);
            this.button_report.Name = "button_report";
            this.button_report.Size = new System.Drawing.Size(103, 44);
            this.button_report.TabIndex = 4;
            this.button_report.Text = "CREATE REPORT";
            this.button_report.UseVisualStyleBackColor = true;
            this.button_report.Click += new System.EventHandler(this.button_report_Click);
            // 
            // UC_CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_courseRegistration);
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.groupBox_courseRegistration);
            this.Controls.Add(this.label1);
            this.Name = "UC_CourseRegistration";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_CourseRegistration_Load);
            this.groupBox_courseRegistration.ResumeLayout(false);
            this.groupBox_courseRegistration.PerformLayout();
            this.groupBox_operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courseRegistration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_courseRegistration;
        private System.Windows.Forms.ComboBox comboBox_Statu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_StudentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_CourseId;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView dataGridView_courseRegistration;
        private System.Windows.Forms.Button button_report;
    }
}
