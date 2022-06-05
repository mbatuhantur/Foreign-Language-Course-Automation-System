
namespace FLCP.UI.UserControls
{
    partial class UC_CourseRequestsOfStudent
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
            this.groupBox_courseRequest = new System.Windows.Forms.GroupBox();
            this.richTextBox_descripton = new System.Windows.Forms.RichTextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_courseRequests = new System.Windows.Forms.DataGridView();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox_courseRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courseRequests)).BeginInit();
            this.groupBox_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_courseRequest
            // 
            this.groupBox_courseRequest.Controls.Add(this.richTextBox_descripton);
            this.groupBox_courseRequest.Controls.Add(this.textBox_title);
            this.groupBox_courseRequest.Controls.Add(this.textBox_id);
            this.groupBox_courseRequest.Controls.Add(this.label3);
            this.groupBox_courseRequest.Controls.Add(this.label2);
            this.groupBox_courseRequest.Controls.Add(this.label1);
            this.groupBox_courseRequest.Location = new System.Drawing.Point(27, 34);
            this.groupBox_courseRequest.Name = "groupBox_courseRequest";
            this.groupBox_courseRequest.Size = new System.Drawing.Size(416, 407);
            this.groupBox_courseRequest.TabIndex = 0;
            this.groupBox_courseRequest.TabStop = false;
            this.groupBox_courseRequest.Text = "COURSE REQUEST";
            // 
            // richTextBox_descripton
            // 
            this.richTextBox_descripton.Location = new System.Drawing.Point(117, 134);
            this.richTextBox_descripton.Name = "richTextBox_descripton";
            this.richTextBox_descripton.Size = new System.Drawing.Size(256, 233);
            this.richTextBox_descripton.TabIndex = 5;
            this.richTextBox_descripton.Text = "";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(117, 88);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(256, 23);
            this.textBox_title.TabIndex = 4;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(117, 48);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(256, 23);
            this.textBox_id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView_courseRequests
            // 
            this.dataGridView_courseRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courseRequests.Location = new System.Drawing.Point(449, 44);
            this.dataGridView_courseRequests.Name = "dataGridView_courseRequests";
            this.dataGridView_courseRequests.RowTemplate.Height = 25;
            this.dataGridView_courseRequests.Size = new System.Drawing.Size(607, 397);
            this.dataGridView_courseRequests.TabIndex = 1;
            this.dataGridView_courseRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_courseRequests_CellClick);
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.button_clear);
            this.groupBox_operations.Controls.Add(this.button_delete);
            this.groupBox_operations.Controls.Add(this.button_save);
            this.groupBox_operations.Location = new System.Drawing.Point(27, 502);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(363, 100);
            this.groupBox_operations.TabIndex = 2;
            this.groupBox_operations.TabStop = false;
            this.groupBox_operations.Text = "OPERATIONS";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(137, 32);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(96, 38);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(22, 32);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(96, 38);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(253, 32);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(86, 38);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // UC_CourseRequestsOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.dataGridView_courseRequests);
            this.Controls.Add(this.groupBox_courseRequest);
            this.Name = "UC_CourseRequestsOfStudent";
            this.Size = new System.Drawing.Size(1059, 647);
            this.Load += new System.EventHandler(this.UC_CourseRequestsOfStudent_Load);
            this.groupBox_courseRequest.ResumeLayout(false);
            this.groupBox_courseRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courseRequests)).EndInit();
            this.groupBox_operations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_courseRequest;
        private System.Windows.Forms.RichTextBox richTextBox_descripton;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_courseRequests;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clear;
    }
}
