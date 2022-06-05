
namespace FLCP.UI.UserControls
{
    partial class UC_Language
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
            this.groupBox_Language = new System.Windows.Forms.GroupBox();
            this.textBox_LanguageName = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Language = new System.Windows.Forms.DataGridView();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_Language.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Language)).BeginInit();
            this.groupBox_Operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Language
            // 
            this.groupBox_Language.Controls.Add(this.textBox_LanguageName);
            this.groupBox_Language.Controls.Add(this.textBox_ID);
            this.groupBox_Language.Controls.Add(this.label2);
            this.groupBox_Language.Controls.Add(this.label1);
            this.groupBox_Language.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Language.Location = new System.Drawing.Point(135, 159);
            this.groupBox_Language.Name = "groupBox_Language";
            this.groupBox_Language.Size = new System.Drawing.Size(470, 214);
            this.groupBox_Language.TabIndex = 0;
            this.groupBox_Language.TabStop = false;
            this.groupBox_Language.Text = "RECORD INFORMATION";
            // 
            // textBox_LanguageName
            // 
            this.textBox_LanguageName.Location = new System.Drawing.Point(173, 130);
            this.textBox_LanguageName.Name = "textBox_LanguageName";
            this.textBox_LanguageName.Size = new System.Drawing.Size(171, 23);
            this.textBox_LanguageName.TabIndex = 3;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(173, 78);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(171, 23);
            this.textBox_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "LANGUAGE NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dataGridView_Language
            // 
            this.dataGridView_Language.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Language.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Language.Location = new System.Drawing.Point(719, 159);
            this.dataGridView_Language.Name = "dataGridView_Language";
            this.dataGridView_Language.RowTemplate.Height = 25;
            this.dataGridView_Language.Size = new System.Drawing.Size(544, 260);
            this.dataGridView_Language.TabIndex = 1;
            this.dataGridView_Language.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Language_CellClick);
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.button_Clear);
            this.groupBox_Operations.Controls.Add(this.button_Update);
            this.groupBox_Operations.Controls.Add(this.button_Delete);
            this.groupBox_Operations.Controls.Add(this.button_Save);
            this.groupBox_Operations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Operations.Location = new System.Drawing.Point(719, 446);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(544, 100);
            this.groupBox_Operations.TabIndex = 2;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "OPERATIONS";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(420, 40);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(107, 37);
            this.button_Clear.TabIndex = 3;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(294, 40);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(104, 37);
            this.button_Update.TabIndex = 2;
            this.button_Update.Text = "UPDATE";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(163, 40);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(101, 37);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(18, 40);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(101, 37);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // UC_Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Operations);
            this.Controls.Add(this.dataGridView_Language);
            this.Controls.Add(this.groupBox_Language);
            this.Name = "UC_Language";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_Language_Load);
            this.groupBox_Language.ResumeLayout(false);
            this.groupBox_Language.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Language)).EndInit();
            this.groupBox_Operations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Language;
        private System.Windows.Forms.TextBox textBox_LanguageName;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Language;
        private System.Windows.Forms.GroupBox groupBox_Operations;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
    }
}
