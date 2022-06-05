
namespace FLCP.UI.UserControls
{
    partial class UC_PaymentOperation
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
            this.groupBox_PaymentOperation = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_NumberOfInstallments = new System.Windows.Forms.TextBox();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.comboBox_student = new System.Windows.Forms.ComboBox();
            this.comboBox_PaymentStatu = new System.Windows.Forms.ComboBox();
            this.comboBox_paymentType = new System.Windows.Forms.ComboBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView_payments = new System.Windows.Forms.DataGridView();
            this.button_createReport = new System.Windows.Forms.Button();
            this.groupBox_PaymentOperation.SuspendLayout();
            this.groupBox_operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_PaymentOperation
            // 
            this.groupBox_PaymentOperation.Controls.Add(this.label9);
            this.groupBox_PaymentOperation.Controls.Add(this.textBox_NumberOfInstallments);
            this.groupBox_PaymentOperation.Controls.Add(this.comboBox_course);
            this.groupBox_PaymentOperation.Controls.Add(this.comboBox_student);
            this.groupBox_PaymentOperation.Controls.Add(this.comboBox_PaymentStatu);
            this.groupBox_PaymentOperation.Controls.Add(this.comboBox_paymentType);
            this.groupBox_PaymentOperation.Controls.Add(this.richTextBox_description);
            this.groupBox_PaymentOperation.Controls.Add(this.textBox_title);
            this.groupBox_PaymentOperation.Controls.Add(this.textBox_Id);
            this.groupBox_PaymentOperation.Controls.Add(this.label8);
            this.groupBox_PaymentOperation.Controls.Add(this.label7);
            this.groupBox_PaymentOperation.Controls.Add(this.label6);
            this.groupBox_PaymentOperation.Controls.Add(this.label5);
            this.groupBox_PaymentOperation.Controls.Add(this.label4);
            this.groupBox_PaymentOperation.Controls.Add(this.label3);
            this.groupBox_PaymentOperation.Controls.Add(this.label2);
            this.groupBox_PaymentOperation.Controls.Add(this.label1);
            this.groupBox_PaymentOperation.Location = new System.Drawing.Point(24, 29);
            this.groupBox_PaymentOperation.Name = "groupBox_PaymentOperation";
            this.groupBox_PaymentOperation.Size = new System.Drawing.Size(545, 524);
            this.groupBox_PaymentOperation.TabIndex = 0;
            this.groupBox_PaymentOperation.TabStop = false;
            this.groupBox_PaymentOperation.Text = "PAYMENT OPERATIONS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(22, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(246, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "If payment type is advanced payment , set - 1";
            // 
            // textBox_NumberOfInstallments
            // 
            this.textBox_NumberOfInstallments.Location = new System.Drawing.Point(214, 419);
            this.textBox_NumberOfInstallments.Name = "textBox_NumberOfInstallments";
            this.textBox_NumberOfInstallments.Size = new System.Drawing.Size(263, 23);
            this.textBox_NumberOfInstallments.TabIndex = 15;
            // 
            // comboBox_course
            // 
            this.comboBox_course.DisplayMember = "CourseCode";
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(214, 381);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(263, 23);
            this.comboBox_course.TabIndex = 14;
            this.comboBox_course.ValueMember = "Id";
            // 
            // comboBox_student
            // 
            this.comboBox_student.DisplayMember = "Name";
            this.comboBox_student.FormattingEnabled = true;
            this.comboBox_student.Location = new System.Drawing.Point(214, 344);
            this.comboBox_student.Name = "comboBox_student";
            this.comboBox_student.Size = new System.Drawing.Size(263, 23);
            this.comboBox_student.TabIndex = 13;
            this.comboBox_student.ValueMember = "Id";
            // 
            // comboBox_PaymentStatu
            // 
            this.comboBox_PaymentStatu.FormattingEnabled = true;
            this.comboBox_PaymentStatu.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.comboBox_PaymentStatu.Location = new System.Drawing.Point(214, 303);
            this.comboBox_PaymentStatu.Name = "comboBox_PaymentStatu";
            this.comboBox_PaymentStatu.Size = new System.Drawing.Size(263, 23);
            this.comboBox_PaymentStatu.TabIndex = 12;
            this.comboBox_PaymentStatu.Text = "Select Payment Statu";
            // 
            // comboBox_paymentType
            // 
            this.comboBox_paymentType.FormattingEnabled = true;
            this.comboBox_paymentType.Items.AddRange(new object[] {
            "Cash Payment",
            "Installment Payment"});
            this.comboBox_paymentType.Location = new System.Drawing.Point(214, 258);
            this.comboBox_paymentType.Name = "comboBox_paymentType";
            this.comboBox_paymentType.Size = new System.Drawing.Size(263, 23);
            this.comboBox_paymentType.TabIndex = 11;
            this.comboBox_paymentType.Text = "Select Payment Type";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(214, 123);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(263, 96);
            this.richTextBox_description.TabIndex = 10;
            this.richTextBox_description.Text = "";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(214, 78);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(263, 23);
            this.textBox_title.TabIndex = 9;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(214, 41);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(263, 23);
            this.textBox_Id.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Number Of Installments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Course";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Payment Statu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payment Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.button_clear);
            this.groupBox_operations.Controls.Add(this.button_update);
            this.groupBox_operations.Controls.Add(this.button_delete);
            this.groupBox_operations.Controls.Add(this.button_Save);
            this.groupBox_operations.Location = new System.Drawing.Point(24, 577);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(545, 100);
            this.groupBox_operations.TabIndex = 3;
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
            // dataGridView_payments
            // 
            this.dataGridView_payments.AllowUserToAddRows = false;
            this.dataGridView_payments.AllowUserToDeleteRows = false;
            this.dataGridView_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payments.Location = new System.Drawing.Point(575, 38);
            this.dataGridView_payments.Name = "dataGridView_payments";
            this.dataGridView_payments.ReadOnly = true;
            this.dataGridView_payments.RowTemplate.Height = 25;
            this.dataGridView_payments.Size = new System.Drawing.Size(826, 358);
            this.dataGridView_payments.TabIndex = 4;
            this.dataGridView_payments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_payments_CellClick);
            // 
            // button_createReport
            // 
            this.button_createReport.Location = new System.Drawing.Point(1260, 402);
            this.button_createReport.Name = "button_createReport";
            this.button_createReport.Size = new System.Drawing.Size(141, 43);
            this.button_createReport.TabIndex = 5;
            this.button_createReport.Text = "CREATE REPORT";
            this.button_createReport.UseVisualStyleBackColor = true;
            this.button_createReport.Click += new System.EventHandler(this.button_createReport_Click);
            // 
            // UC_PaymentOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_createReport);
            this.Controls.Add(this.dataGridView_payments);
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.groupBox_PaymentOperation);
            this.Name = "UC_PaymentOperation";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_PaymentOperation_Load);
            this.groupBox_PaymentOperation.ResumeLayout(false);
            this.groupBox_PaymentOperation.PerformLayout();
            this.groupBox_operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_PaymentOperation;
        private System.Windows.Forms.TextBox textBox_NumberOfInstallments;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.ComboBox comboBox_student;
        private System.Windows.Forms.ComboBox comboBox_PaymentStatu;
        private System.Windows.Forms.ComboBox comboBox_paymentType;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView dataGridView_payments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_createReport;
    }
}
