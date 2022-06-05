
namespace FLCP.UI.UserControls
{
    partial class UC_CoursesOfStudent
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
            this.dataGridView_courses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_courses
            // 
            this.dataGridView_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courses.Location = new System.Drawing.Point(35, 59);
            this.dataGridView_courses.Name = "dataGridView_courses";
            this.dataGridView_courses.RowTemplate.Height = 25;
            this.dataGridView_courses.Size = new System.Drawing.Size(958, 336);
            this.dataGridView_courses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "MY COURSES";
            // 
            // UC_CoursesOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_courses);
            this.Name = "UC_CoursesOfStudent";
            this.Size = new System.Drawing.Size(1059, 647);
            this.Load += new System.EventHandler(this.UC_CoursesOfStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_courses;
        private System.Windows.Forms.Label label1;
    }
}
