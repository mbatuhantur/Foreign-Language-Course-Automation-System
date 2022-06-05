
namespace FLCP.UI.UserControls
{
    partial class UC_Region_City_Branch
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
            this.groupBox_City = new System.Windows.Forms.GroupBox();
            this.comboBox_RegionIdFK = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_CityName = new System.Windows.Forms.TextBox();
            this.textBox_CityId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Region = new System.Windows.Forms.GroupBox();
            this.textBox_RegionName = new System.Windows.Forms.TextBox();
            this.textBox_RegionID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Branch = new System.Windows.Forms.GroupBox();
            this.comboBox_CityIdFK = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox_Address = new System.Windows.Forms.RichTextBox();
            this.textBox_branchPhone = new System.Windows.Forms.TextBox();
            this.textBox_branchName = new System.Windows.Forms.TextBox();
            this.textBox_BranchId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.radioButton_Branch = new System.Windows.Forms.RadioButton();
            this.radioButton_City = new System.Windows.Forms.RadioButton();
            this.radioButton_Region = new System.Windows.Forms.RadioButton();
            this.dataGridView_Region = new System.Windows.Forms.DataGridView();
            this.dataGridView_city = new System.Windows.Forms.DataGridView();
            this.dataGridView_branch = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox_City.SuspendLayout();
            this.groupBox_Region.SuspendLayout();
            this.groupBox_Branch.SuspendLayout();
            this.groupBox_Operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_branch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_City
            // 
            this.groupBox_City.Controls.Add(this.comboBox_RegionIdFK);
            this.groupBox_City.Controls.Add(this.label3);
            this.groupBox_City.Controls.Add(this.textBox_CityName);
            this.groupBox_City.Controls.Add(this.textBox_CityId);
            this.groupBox_City.Controls.Add(this.label2);
            this.groupBox_City.Controls.Add(this.label1);
            this.groupBox_City.Location = new System.Drawing.Point(498, 57);
            this.groupBox_City.Name = "groupBox_City";
            this.groupBox_City.Size = new System.Drawing.Size(333, 164);
            this.groupBox_City.TabIndex = 0;
            this.groupBox_City.TabStop = false;
            this.groupBox_City.Text = "CITY";
            // 
            // comboBox_RegionIdFK
            // 
            this.comboBox_RegionIdFK.DisplayMember = "RegionName";
            this.comboBox_RegionIdFK.FormattingEnabled = true;
            this.comboBox_RegionIdFK.Location = new System.Drawing.Point(134, 108);
            this.comboBox_RegionIdFK.Name = "comboBox_RegionIdFK";
            this.comboBox_RegionIdFK.Size = new System.Drawing.Size(150, 23);
            this.comboBox_RegionIdFK.TabIndex = 5;
            this.comboBox_RegionIdFK.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Region";
            // 
            // textBox_CityName
            // 
            this.textBox_CityName.Location = new System.Drawing.Point(134, 66);
            this.textBox_CityName.Name = "textBox_CityName";
            this.textBox_CityName.Size = new System.Drawing.Size(150, 23);
            this.textBox_CityName.TabIndex = 3;
            // 
            // textBox_CityId
            // 
            this.textBox_CityId.Location = new System.Drawing.Point(134, 27);
            this.textBox_CityId.Name = "textBox_CityId";
            this.textBox_CityId.ReadOnly = true;
            this.textBox_CityId.Size = new System.Drawing.Size(150, 23);
            this.textBox_CityId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // groupBox_Region
            // 
            this.groupBox_Region.Controls.Add(this.textBox_RegionName);
            this.groupBox_Region.Controls.Add(this.textBox_RegionID);
            this.groupBox_Region.Controls.Add(this.label5);
            this.groupBox_Region.Controls.Add(this.label4);
            this.groupBox_Region.Location = new System.Drawing.Point(48, 61);
            this.groupBox_Region.Name = "groupBox_Region";
            this.groupBox_Region.Size = new System.Drawing.Size(340, 160);
            this.groupBox_Region.TabIndex = 1;
            this.groupBox_Region.TabStop = false;
            this.groupBox_Region.Text = "REGION";
            // 
            // textBox_RegionName
            // 
            this.textBox_RegionName.Location = new System.Drawing.Point(135, 82);
            this.textBox_RegionName.Name = "textBox_RegionName";
            this.textBox_RegionName.Size = new System.Drawing.Size(150, 23);
            this.textBox_RegionName.TabIndex = 3;
            // 
            // textBox_RegionID
            // 
            this.textBox_RegionID.Location = new System.Drawing.Point(135, 45);
            this.textBox_RegionID.Name = "textBox_RegionID";
            this.textBox_RegionID.ReadOnly = true;
            this.textBox_RegionID.Size = new System.Drawing.Size(150, 23);
            this.textBox_RegionID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Region Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // groupBox_Branch
            // 
            this.groupBox_Branch.Controls.Add(this.comboBox_CityIdFK);
            this.groupBox_Branch.Controls.Add(this.label10);
            this.groupBox_Branch.Controls.Add(this.richTextBox_Address);
            this.groupBox_Branch.Controls.Add(this.textBox_branchPhone);
            this.groupBox_Branch.Controls.Add(this.textBox_branchName);
            this.groupBox_Branch.Controls.Add(this.textBox_BranchId);
            this.groupBox_Branch.Controls.Add(this.label9);
            this.groupBox_Branch.Controls.Add(this.label8);
            this.groupBox_Branch.Controls.Add(this.label7);
            this.groupBox_Branch.Controls.Add(this.label6);
            this.groupBox_Branch.Location = new System.Drawing.Point(890, 61);
            this.groupBox_Branch.Name = "groupBox_Branch";
            this.groupBox_Branch.Size = new System.Drawing.Size(476, 393);
            this.groupBox_Branch.TabIndex = 2;
            this.groupBox_Branch.TabStop = false;
            this.groupBox_Branch.Text = "BRANCH";
            // 
            // comboBox_CityIdFK
            // 
            this.comboBox_CityIdFK.DisplayMember = "CirtyName";
            this.comboBox_CityIdFK.FormattingEnabled = true;
            this.comboBox_CityIdFK.Location = new System.Drawing.Point(198, 351);
            this.comboBox_CityIdFK.Name = "comboBox_CityIdFK";
            this.comboBox_CityIdFK.Size = new System.Drawing.Size(201, 23);
            this.comboBox_CityIdFK.TabIndex = 9;
            this.comboBox_CityIdFK.ValueMember = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "CITY";
            // 
            // richTextBox_Address
            // 
            this.richTextBox_Address.Location = new System.Drawing.Point(198, 165);
            this.richTextBox_Address.Name = "richTextBox_Address";
            this.richTextBox_Address.Size = new System.Drawing.Size(201, 159);
            this.richTextBox_Address.TabIndex = 7;
            this.richTextBox_Address.Text = "";
            // 
            // textBox_branchPhone
            // 
            this.textBox_branchPhone.Location = new System.Drawing.Point(198, 123);
            this.textBox_branchPhone.MaxLength = 11;
            this.textBox_branchPhone.Name = "textBox_branchPhone";
            this.textBox_branchPhone.Size = new System.Drawing.Size(201, 23);
            this.textBox_branchPhone.TabIndex = 6;
            // 
            // textBox_branchName
            // 
            this.textBox_branchName.Location = new System.Drawing.Point(198, 79);
            this.textBox_branchName.Name = "textBox_branchName";
            this.textBox_branchName.Size = new System.Drawing.Size(201, 23);
            this.textBox_branchName.TabIndex = 5;
            // 
            // textBox_BranchId
            // 
            this.textBox_BranchId.Enabled = false;
            this.textBox_BranchId.Location = new System.Drawing.Point(198, 42);
            this.textBox_BranchId.Name = "textBox_BranchId";
            this.textBox_BranchId.Size = new System.Drawing.Size(201, 23);
            this.textBox_BranchId.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "BRANCH ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "BRANCH PHONE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "BRANCH NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.button_Clear);
            this.groupBox_Operations.Controls.Add(this.button_Update);
            this.groupBox_Operations.Controls.Add(this.button_delete);
            this.groupBox_Operations.Controls.Add(this.button_Save);
            this.groupBox_Operations.Controls.Add(this.radioButton_Branch);
            this.groupBox_Operations.Controls.Add(this.radioButton_City);
            this.groupBox_Operations.Controls.Add(this.radioButton_Region);
            this.groupBox_Operations.Location = new System.Drawing.Point(164, 252);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(608, 106);
            this.groupBox_Operations.TabIndex = 3;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "OPERATIONS";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(468, 55);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(117, 32);
            this.button_Clear.TabIndex = 6;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(313, 55);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(129, 32);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "UPDATE";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(164, 55);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(121, 32);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(19, 55);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(111, 32);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // radioButton_Branch
            // 
            this.radioButton_Branch.AutoSize = true;
            this.radioButton_Branch.Location = new System.Drawing.Point(375, 19);
            this.radioButton_Branch.Name = "radioButton_Branch";
            this.radioButton_Branch.Size = new System.Drawing.Size(73, 19);
            this.radioButton_Branch.TabIndex = 2;
            this.radioButton_Branch.TabStop = true;
            this.radioButton_Branch.Text = "BRANCH";
            this.radioButton_Branch.UseVisualStyleBackColor = true;
            // 
            // radioButton_City
            // 
            this.radioButton_City.AutoSize = true;
            this.radioButton_City.Location = new System.Drawing.Point(268, 19);
            this.radioButton_City.Name = "radioButton_City";
            this.radioButton_City.Size = new System.Drawing.Size(49, 19);
            this.radioButton_City.TabIndex = 1;
            this.radioButton_City.TabStop = true;
            this.radioButton_City.Text = "CITY";
            this.radioButton_City.UseVisualStyleBackColor = true;
            // 
            // radioButton_Region
            // 
            this.radioButton_Region.AutoSize = true;
            this.radioButton_Region.Location = new System.Drawing.Point(144, 19);
            this.radioButton_Region.Name = "radioButton_Region";
            this.radioButton_Region.Size = new System.Drawing.Size(67, 19);
            this.radioButton_Region.TabIndex = 0;
            this.radioButton_Region.TabStop = true;
            this.radioButton_Region.Text = "REGION";
            this.radioButton_Region.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Region
            // 
            this.dataGridView_Region.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Region.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Region.Location = new System.Drawing.Point(15, 483);
            this.dataGridView_Region.Name = "dataGridView_Region";
            this.dataGridView_Region.RowTemplate.Height = 25;
            this.dataGridView_Region.Size = new System.Drawing.Size(360, 222);
            this.dataGridView_Region.TabIndex = 4;
            this.dataGridView_Region.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Region_CellClick);
            // 
            // dataGridView_city
            // 
            this.dataGridView_city.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_city.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_city.Location = new System.Drawing.Point(381, 483);
            this.dataGridView_city.Name = "dataGridView_city";
            this.dataGridView_city.RowTemplate.Height = 25;
            this.dataGridView_city.Size = new System.Drawing.Size(443, 222);
            this.dataGridView_city.TabIndex = 5;
            this.dataGridView_city.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_city_CellClick);
            // 
            // dataGridView_branch
            // 
            this.dataGridView_branch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_branch.Location = new System.Drawing.Point(830, 483);
            this.dataGridView_branch.Name = "dataGridView_branch";
            this.dataGridView_branch.RowTemplate.Height = 25;
            this.dataGridView_branch.Size = new System.Drawing.Size(571, 222);
            this.dataGridView_branch.TabIndex = 6;
            this.dataGridView_branch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_branch_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 714);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "REGIONS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(579, 714);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "CITIES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1088, 714);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "BRANCHES";
            // 
            // UC_Region_City_Branch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView_branch);
            this.Controls.Add(this.dataGridView_city);
            this.Controls.Add(this.dataGridView_Region);
            this.Controls.Add(this.groupBox_Operations);
            this.Controls.Add(this.groupBox_Branch);
            this.Controls.Add(this.groupBox_Region);
            this.Controls.Add(this.groupBox_City);
            this.Name = "UC_Region_City_Branch";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_Region_City_Branch_Load);
            this.groupBox_City.ResumeLayout(false);
            this.groupBox_City.PerformLayout();
            this.groupBox_Region.ResumeLayout(false);
            this.groupBox_Region.PerformLayout();
            this.groupBox_Branch.ResumeLayout(false);
            this.groupBox_Branch.PerformLayout();
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_Operations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_branch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_City;
        private System.Windows.Forms.TextBox textBox_CityName;
        private System.Windows.Forms.TextBox textBox_CityId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_Region;
        private System.Windows.Forms.TextBox textBox_RegionID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_RegionName;
        private System.Windows.Forms.GroupBox groupBox_Branch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_branchName;
        private System.Windows.Forms.TextBox textBox_BranchId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox_Address;
        private System.Windows.Forms.TextBox textBox_branchPhone;
        private System.Windows.Forms.ComboBox comboBox_CityIdFK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.RadioButton radioButton_Branch;
        private System.Windows.Forms.RadioButton radioButton_City;
        private System.Windows.Forms.RadioButton radioButton_Region;
        private System.Windows.Forms.DataGridView dataGridView_Region;
        private System.Windows.Forms.DataGridView dataGridView_city;
        private System.Windows.Forms.DataGridView dataGridView_branch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_RegionIdFK;
    }
}
