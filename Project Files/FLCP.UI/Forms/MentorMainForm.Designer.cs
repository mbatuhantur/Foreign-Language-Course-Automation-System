
namespace FLCP.UI.Forms
{
    partial class MentorMainForm
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
            this.button_workingDays = new System.Windows.Forms.Button();
            this.button_courses = new System.Windows.Forms.Button();
            this.panel_user_control_area = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_left.Controls.Add(this.panel_slide);
            this.panel_left.Controls.Add(this.button_workingDays);
            this.panel_left.Controls.Add(this.button_courses);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(229, 614);
            this.panel_left.TabIndex = 0;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.DarkBlue;
            this.panel_slide.Location = new System.Drawing.Point(195, 175);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(27, 41);
            this.panel_slide.TabIndex = 2;
            // 
            // button_workingDays
            // 
            this.button_workingDays.Location = new System.Drawing.Point(12, 223);
            this.button_workingDays.Name = "button_workingDays";
            this.button_workingDays.Size = new System.Drawing.Size(166, 45);
            this.button_workingDays.TabIndex = 1;
            this.button_workingDays.Text = "My Working Days";
            this.button_workingDays.UseVisualStyleBackColor = true;
            this.button_workingDays.Click += new System.EventHandler(this.button_workingDays_Click);
            // 
            // button_courses
            // 
            this.button_courses.Location = new System.Drawing.Point(12, 174);
            this.button_courses.Name = "button_courses";
            this.button_courses.Size = new System.Drawing.Size(166, 42);
            this.button_courses.TabIndex = 0;
            this.button_courses.Text = "My Courses";
            this.button_courses.UseVisualStyleBackColor = true;
            this.button_courses.Click += new System.EventHandler(this.button_courses_Click);
            // 
            // panel_user_control_area
            // 
            this.panel_user_control_area.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_user_control_area.Location = new System.Drawing.Point(236, 0);
            this.panel_user_control_area.Name = "panel_user_control_area";
            this.panel_user_control_area.Size = new System.Drawing.Size(966, 614);
            this.panel_user_control_area.TabIndex = 1;
            // 
            // MentorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 614);
            this.Controls.Add(this.panel_user_control_area);
            this.Controls.Add(this.panel_left);
            this.Name = "MentorMainForm";
            this.Text = "MentorMainForm";
            this.Load += new System.EventHandler(this.MentorMainForm_Load);
            this.panel_left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button_workingDays;
        private System.Windows.Forms.Button button_courses;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_user_control_area;
    }
}