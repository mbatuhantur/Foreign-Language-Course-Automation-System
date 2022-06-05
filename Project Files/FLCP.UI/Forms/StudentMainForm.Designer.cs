
namespace FLCP.UI.Forms
{
    partial class StudentMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.button_Courses = new System.Windows.Forms.Button();
            this.button_payments = new System.Windows.Forms.Button();
            this.button_CourseRequests = new System.Windows.Forms.Button();
            this.panel_UserControlArea = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_left.Controls.Add(this.panel_slide);
            this.panel_left.Controls.Add(this.button_Courses);
            this.panel_left.Controls.Add(this.button_payments);
            this.panel_left.Controls.Add(this.button_CourseRequests);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(233, 647);
            this.panel_left.TabIndex = 0;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.Navy;
            this.panel_slide.Location = new System.Drawing.Point(186, 162);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(30, 42);
            this.panel_slide.TabIndex = 1;
            // 
            // button_Courses
            // 
            this.button_Courses.Location = new System.Drawing.Point(3, 258);
            this.button_Courses.Name = "button_Courses";
            this.button_Courses.Size = new System.Drawing.Size(177, 42);
            this.button_Courses.TabIndex = 2;
            this.button_Courses.Text = "My Courses";
            this.button_Courses.UseVisualStyleBackColor = true;
            this.button_Courses.Click += new System.EventHandler(this.button_Courses_Click);
            // 
            // button_payments
            // 
            this.button_payments.Location = new System.Drawing.Point(3, 210);
            this.button_payments.Name = "button_payments";
            this.button_payments.Size = new System.Drawing.Size(177, 42);
            this.button_payments.TabIndex = 1;
            this.button_payments.Text = "My Payments";
            this.button_payments.UseVisualStyleBackColor = true;
            this.button_payments.Click += new System.EventHandler(this.button_payments_Click);
            // 
            // button_CourseRequests
            // 
            this.button_CourseRequests.Location = new System.Drawing.Point(3, 162);
            this.button_CourseRequests.Name = "button_CourseRequests";
            this.button_CourseRequests.Size = new System.Drawing.Size(177, 42);
            this.button_CourseRequests.TabIndex = 0;
            this.button_CourseRequests.Text = "My Course Requests";
            this.button_CourseRequests.UseVisualStyleBackColor = true;
            this.button_CourseRequests.Click += new System.EventHandler(this.button_CourseRequests_Click);
            // 
            // panel_UserControlArea
            // 
            this.panel_UserControlArea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_UserControlArea.Location = new System.Drawing.Point(240, 0);
            this.panel_UserControlArea.Name = "panel_UserControlArea";
            this.panel_UserControlArea.Size = new System.Drawing.Size(1059, 647);
            this.panel_UserControlArea.TabIndex = 1;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 647);
            this.Controls.Add(this.panel_UserControlArea);
            this.Controls.Add(this.panel_left);
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Main Screen";
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button_Courses;
        private System.Windows.Forms.Button button_payments;
        private System.Windows.Forms.Button button_CourseRequests;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_UserControlArea;
    }
}