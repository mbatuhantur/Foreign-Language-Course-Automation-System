
namespace FLCP.UI.Forms
{
    partial class LoginForm
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
            this.button_student = new System.Windows.Forms.Button();
            this.button_mentor = new System.Windows.Forms.Button();
            this.button_AdminAndOfficier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_student
            // 
            this.button_student.Location = new System.Drawing.Point(100, 69);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(119, 40);
            this.button_student.TabIndex = 4;
            this.button_student.Text = "STUDENT";
            this.button_student.UseVisualStyleBackColor = true;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // button_mentor
            // 
            this.button_mentor.Location = new System.Drawing.Point(100, 115);
            this.button_mentor.Name = "button_mentor";
            this.button_mentor.Size = new System.Drawing.Size(120, 40);
            this.button_mentor.TabIndex = 5;
            this.button_mentor.Text = "MENTOR";
            this.button_mentor.UseVisualStyleBackColor = true;
            this.button_mentor.Click += new System.EventHandler(this.button_mentor_Click);
            // 
            // button_AdminAndOfficier
            // 
            this.button_AdminAndOfficier.Location = new System.Drawing.Point(100, 161);
            this.button_AdminAndOfficier.Name = "button_AdminAndOfficier";
            this.button_AdminAndOfficier.Size = new System.Drawing.Size(119, 40);
            this.button_AdminAndOfficier.TabIndex = 6;
            this.button_AdminAndOfficier.Text = "ADMIN / OFFICIER";
            this.button_AdminAndOfficier.UseVisualStyleBackColor = true;
            this.button_AdminAndOfficier.Click += new System.EventHandler(this.button_AdminAndOfficier_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(333, 285);
            this.Controls.Add(this.button_AdminAndOfficier);
            this.Controls.Add(this.button_mentor);
            this.Controls.Add(this.button_student);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN SELECTION";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Button button_mentor;
        private System.Windows.Forms.Button button_AdminAndOfficier;
    }
}