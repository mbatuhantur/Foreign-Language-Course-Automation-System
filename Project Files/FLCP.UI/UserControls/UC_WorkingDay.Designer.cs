
namespace FLCP.UI.UserControls
{
    partial class UC_WorkingDay
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
            this.groupBox_workingDay = new System.Windows.Forms.GroupBox();
            this.textBox_dayName = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_workingDay = new System.Windows.Forms.DataGridView();
            this.groupBox_operations = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_workingDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workingDay)).BeginInit();
            this.groupBox_operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_workingDay
            // 
            this.groupBox_workingDay.Controls.Add(this.textBox_dayName);
            this.groupBox_workingDay.Controls.Add(this.textBox_Id);
            this.groupBox_workingDay.Controls.Add(this.label2);
            this.groupBox_workingDay.Controls.Add(this.label1);
            this.groupBox_workingDay.Location = new System.Drawing.Point(186, 136);
            this.groupBox_workingDay.Name = "groupBox_workingDay";
            this.groupBox_workingDay.Size = new System.Drawing.Size(381, 191);
            this.groupBox_workingDay.TabIndex = 0;
            this.groupBox_workingDay.TabStop = false;
            this.groupBox_workingDay.Text = "WORKING DAY";
            // 
            // textBox_dayName
            // 
            this.textBox_dayName.Location = new System.Drawing.Point(136, 107);
            this.textBox_dayName.Name = "textBox_dayName";
            this.textBox_dayName.Size = new System.Drawing.Size(183, 23);
            this.textBox_dayName.TabIndex = 3;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(136, 54);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(183, 23);
            this.textBox_Id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DAY NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView_workingDay
            // 
            this.dataGridView_workingDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_workingDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_workingDay.Location = new System.Drawing.Point(772, 136);
            this.dataGridView_workingDay.Name = "dataGridView_workingDay";
            this.dataGridView_workingDay.RowTemplate.Height = 25;
            this.dataGridView_workingDay.Size = new System.Drawing.Size(335, 294);
            this.dataGridView_workingDay.TabIndex = 1;
            this.dataGridView_workingDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_workingDay_CellClick);
            // 
            // groupBox_operations
            // 
            this.groupBox_operations.Controls.Add(this.button_clear);
            this.groupBox_operations.Controls.Add(this.button_update);
            this.groupBox_operations.Controls.Add(this.button_delete);
            this.groupBox_operations.Controls.Add(this.button_Save);
            this.groupBox_operations.Location = new System.Drawing.Point(154, 378);
            this.groupBox_operations.Name = "groupBox_operations";
            this.groupBox_operations.Size = new System.Drawing.Size(540, 100);
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
            // UC_WorkingDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_operations);
            this.Controls.Add(this.dataGridView_workingDay);
            this.Controls.Add(this.groupBox_workingDay);
            this.Name = "UC_WorkingDay";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_WorkingDay_Load);
            this.groupBox_workingDay.ResumeLayout(false);
            this.groupBox_workingDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workingDay)).EndInit();
            this.groupBox_operations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_workingDay;
        private System.Windows.Forms.TextBox textBox_dayName;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_workingDay;
        private System.Windows.Forms.GroupBox groupBox_operations;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Save;
    }
}
