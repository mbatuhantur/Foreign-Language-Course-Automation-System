
namespace FLCP.UI.UserControls
{
    partial class UC_CoursesOfMentor
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_courses
            // 
            this.dataGridView_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courses.Location = new System.Drawing.Point(115, 66);
            this.dataGridView_courses.Name = "dataGridView_courses";
            this.dataGridView_courses.RowTemplate.Height = 25;
            this.dataGridView_courses.Size = new System.Drawing.Size(666, 241);
            this.dataGridView_courses.TabIndex = 0;
            // 
            // UC_CoursesOfMentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_courses);
            this.Name = "UC_CoursesOfMentor";
            this.Size = new System.Drawing.Size(966, 614);
            this.Load += new System.EventHandler(this.UC_CoursesOfMentor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_courses;
    }
}
