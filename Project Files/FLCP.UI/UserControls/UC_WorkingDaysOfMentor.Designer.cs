
namespace FLCP.UI.UserControls
{
    partial class UC_WorkingDaysOfMentor
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
            this.dataGridView_workingday = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workingday)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_workingday
            // 
            this.dataGridView_workingday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_workingday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_workingday.Location = new System.Drawing.Point(120, 70);
            this.dataGridView_workingday.Name = "dataGridView_workingday";
            this.dataGridView_workingday.RowTemplate.Height = 25;
            this.dataGridView_workingday.Size = new System.Drawing.Size(666, 252);
            this.dataGridView_workingday.TabIndex = 0;
            // 
            // UC_WorkingDaysOfMentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_workingday);
            this.Name = "UC_WorkingDaysOfMentor";
            this.Size = new System.Drawing.Size(966, 614);
            this.Load += new System.EventHandler(this.UC_WorkingDaysOfMentor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_workingday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_workingday;
    }
}
