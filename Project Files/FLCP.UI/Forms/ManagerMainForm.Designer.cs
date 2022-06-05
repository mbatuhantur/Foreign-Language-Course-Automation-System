
namespace FLCP.UI.Forms
{
    partial class ManagerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainForm));
            this.panel_LEFT = new System.Windows.Forms.Panel();
            this.button_CourseRequest = new System.Windows.Forms.Button();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.button_Payment = new System.Windows.Forms.Button();
            this.button_Student = new System.Windows.Forms.Button();
            this.button_WorkingDay = new System.Windows.Forms.Button();
            this.button_Lecturer = new System.Windows.Forms.Button();
            this.button_Language = new System.Windows.Forms.Button();
            this.button_CourseRegistration = new System.Windows.Forms.Button();
            this.button_Classroom_Course = new System.Windows.Forms.Button();
            this.button_City_Branch_Region = new System.Windows.Forms.Button();
            this.panel_USER_CONTROL_AREA = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_LEFT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_LEFT
            // 
            this.panel_LEFT.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_LEFT.Controls.Add(this.pictureBox1);
            this.panel_LEFT.Controls.Add(this.button_CourseRequest);
            this.panel_LEFT.Controls.Add(this.panel_slide);
            this.panel_LEFT.Controls.Add(this.button_Payment);
            this.panel_LEFT.Controls.Add(this.button_Student);
            this.panel_LEFT.Controls.Add(this.button_WorkingDay);
            this.panel_LEFT.Controls.Add(this.button_Lecturer);
            this.panel_LEFT.Controls.Add(this.button_Language);
            this.panel_LEFT.Controls.Add(this.button_CourseRegistration);
            this.panel_LEFT.Controls.Add(this.button_Classroom_Course);
            this.panel_LEFT.Controls.Add(this.button_City_Branch_Region);
            this.panel_LEFT.Location = new System.Drawing.Point(-2, -1);
            this.panel_LEFT.Name = "panel_LEFT";
            this.panel_LEFT.Size = new System.Drawing.Size(225, 740);
            this.panel_LEFT.TabIndex = 0;
            // 
            // button_CourseRequest
            // 
            this.button_CourseRequest.Image = ((System.Drawing.Image)(resources.GetObject("button_CourseRequest.Image")));
            this.button_CourseRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CourseRequest.Location = new System.Drawing.Point(8, 568);
            this.button_CourseRequest.Name = "button_CourseRequest";
            this.button_CourseRequest.Size = new System.Drawing.Size(183, 46);
            this.button_CourseRequest.TabIndex = 8;
            this.button_CourseRequest.Text = "COURSE REQUESTS";
            this.button_CourseRequest.UseVisualStyleBackColor = true;
            this.button_CourseRequest.Click += new System.EventHandler(this.button_CourseRequest_Click);
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_slide.Location = new System.Drawing.Point(197, 151);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(23, 46);
            this.panel_slide.TabIndex = 0;
            // 
            // button_Payment
            // 
            this.button_Payment.Image = ((System.Drawing.Image)(resources.GetObject("button_Payment.Image")));
            this.button_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Payment.Location = new System.Drawing.Point(8, 515);
            this.button_Payment.Name = "button_Payment";
            this.button_Payment.Size = new System.Drawing.Size(183, 46);
            this.button_Payment.TabIndex = 7;
            this.button_Payment.Text = "PAYMENT OPERATIONS";
            this.button_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Payment.UseVisualStyleBackColor = true;
            this.button_Payment.Click += new System.EventHandler(this.button_Payment_Click);
            // 
            // button_Student
            // 
            this.button_Student.Image = ((System.Drawing.Image)(resources.GetObject("button_Student.Image")));
            this.button_Student.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Student.Location = new System.Drawing.Point(8, 463);
            this.button_Student.Name = "button_Student";
            this.button_Student.Size = new System.Drawing.Size(183, 46);
            this.button_Student.TabIndex = 6;
            this.button_Student.Text = "STUDENTS";
            this.button_Student.UseVisualStyleBackColor = true;
            this.button_Student.Click += new System.EventHandler(this.button_Student_Click);
            // 
            // button_WorkingDay
            // 
            this.button_WorkingDay.Image = ((System.Drawing.Image)(resources.GetObject("button_WorkingDay.Image")));
            this.button_WorkingDay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_WorkingDay.Location = new System.Drawing.Point(8, 411);
            this.button_WorkingDay.Name = "button_WorkingDay";
            this.button_WorkingDay.Size = new System.Drawing.Size(183, 46);
            this.button_WorkingDay.TabIndex = 5;
            this.button_WorkingDay.Text = "WORKING DAYS";
            this.button_WorkingDay.UseVisualStyleBackColor = true;
            this.button_WorkingDay.Click += new System.EventHandler(this.button_WorkingDay_Click);
            // 
            // button_Lecturer
            // 
            this.button_Lecturer.Image = ((System.Drawing.Image)(resources.GetObject("button_Lecturer.Image")));
            this.button_Lecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Lecturer.Location = new System.Drawing.Point(8, 359);
            this.button_Lecturer.Name = "button_Lecturer";
            this.button_Lecturer.Size = new System.Drawing.Size(183, 46);
            this.button_Lecturer.TabIndex = 4;
            this.button_Lecturer.Text = "LECTURER";
            this.button_Lecturer.UseVisualStyleBackColor = true;
            this.button_Lecturer.Click += new System.EventHandler(this.button_Lecturer_Click);
            // 
            // button_Language
            // 
            this.button_Language.Image = ((System.Drawing.Image)(resources.GetObject("button_Language.Image")));
            this.button_Language.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Language.Location = new System.Drawing.Point(8, 307);
            this.button_Language.Name = "button_Language";
            this.button_Language.Size = new System.Drawing.Size(183, 46);
            this.button_Language.TabIndex = 3;
            this.button_Language.Text = "LANGUAGE";
            this.button_Language.UseVisualStyleBackColor = true;
            this.button_Language.Click += new System.EventHandler(this.button_Language_Click);
            // 
            // button_CourseRegistration
            // 
            this.button_CourseRegistration.Image = ((System.Drawing.Image)(resources.GetObject("button_CourseRegistration.Image")));
            this.button_CourseRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_CourseRegistration.Location = new System.Drawing.Point(8, 255);
            this.button_CourseRegistration.Name = "button_CourseRegistration";
            this.button_CourseRegistration.Size = new System.Drawing.Size(183, 46);
            this.button_CourseRegistration.TabIndex = 2;
            this.button_CourseRegistration.Text = "COURSE REGISTRATION";
            this.button_CourseRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CourseRegistration.UseVisualStyleBackColor = true;
            this.button_CourseRegistration.Click += new System.EventHandler(this.button_CourseRegistration_Click);
            // 
            // button_Classroom_Course
            // 
            this.button_Classroom_Course.Image = ((System.Drawing.Image)(resources.GetObject("button_Classroom_Course.Image")));
            this.button_Classroom_Course.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Classroom_Course.Location = new System.Drawing.Point(8, 203);
            this.button_Classroom_Course.Name = "button_Classroom_Course";
            this.button_Classroom_Course.Size = new System.Drawing.Size(183, 46);
            this.button_Classroom_Course.TabIndex = 1;
            this.button_Classroom_Course.Text = "CLASSROM - COURSE";
            this.button_Classroom_Course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Classroom_Course.UseVisualStyleBackColor = true;
            this.button_Classroom_Course.Click += new System.EventHandler(this.button_Classroom_Course_Click);
            // 
            // button_City_Branch_Region
            // 
            this.button_City_Branch_Region.Image = ((System.Drawing.Image)(resources.GetObject("button_City_Branch_Region.Image")));
            this.button_City_Branch_Region.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_City_Branch_Region.Location = new System.Drawing.Point(8, 151);
            this.button_City_Branch_Region.Name = "button_City_Branch_Region";
            this.button_City_Branch_Region.Size = new System.Drawing.Size(183, 46);
            this.button_City_Branch_Region.TabIndex = 0;
            this.button_City_Branch_Region.Text = "REGION - CITY - BRANCH";
            this.button_City_Branch_Region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_City_Branch_Region.UseVisualStyleBackColor = true;
            this.button_City_Branch_Region.Click += new System.EventHandler(this.button_City_Branch_Region_Click);
            // 
            // panel_USER_CONTROL_AREA
            // 
            this.panel_USER_CONTROL_AREA.BackColor = System.Drawing.Color.DarkGray;
            this.panel_USER_CONTROL_AREA.Location = new System.Drawing.Point(229, -1);
            this.panel_USER_CONTROL_AREA.Name = "panel_USER_CONTROL_AREA";
            this.panel_USER_CONTROL_AREA.Size = new System.Drawing.Size(1404, 740);
            this.panel_USER_CONTROL_AREA.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 105);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 739);
            this.Controls.Add(this.panel_USER_CONTROL_AREA);
            this.Controls.Add(this.panel_LEFT);
            this.Name = "ManagerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager & Officier Home";
            this.Load += new System.EventHandler(this.ManagerMainForm_Load);
            this.panel_LEFT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_LEFT;
        private System.Windows.Forms.Button button_City_Branch_Region;
        private System.Windows.Forms.Button button_Classroom_Course;
        private System.Windows.Forms.Button button_Language;
        private System.Windows.Forms.Button button_CourseRegistration;
        private System.Windows.Forms.Button button_Lecturer;
        private System.Windows.Forms.Button button_WorkingDay;
        private System.Windows.Forms.Button button_Payment;
        private System.Windows.Forms.Button button_Student;
        private System.Windows.Forms.Panel panel_USER_CONTROL_AREA;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Button button_CourseRequest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}