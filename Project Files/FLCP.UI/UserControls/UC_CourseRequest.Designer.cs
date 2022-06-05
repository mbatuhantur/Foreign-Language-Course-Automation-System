
namespace FLCP.UI.UserControls
{
    partial class UC_CourseRequest
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
            this.dataGridView_courseRequest = new System.Windows.Forms.DataGridView();
            this.button_createPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courseRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_courseRequest
            // 
            this.dataGridView_courseRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_courseRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_courseRequest.Location = new System.Drawing.Point(25, 26);
            this.dataGridView_courseRequest.Name = "dataGridView_courseRequest";
            this.dataGridView_courseRequest.RowTemplate.Height = 25;
            this.dataGridView_courseRequest.Size = new System.Drawing.Size(1355, 534);
            this.dataGridView_courseRequest.TabIndex = 0;
            // 
            // button_createPdf
            // 
            this.button_createPdf.Location = new System.Drawing.Point(629, 620);
            this.button_createPdf.Name = "button_createPdf";
            this.button_createPdf.Size = new System.Drawing.Size(133, 51);
            this.button_createPdf.TabIndex = 1;
            this.button_createPdf.Text = "CREATE REPORT";
            this.button_createPdf.UseVisualStyleBackColor = true;
            this.button_createPdf.Click += new System.EventHandler(this.button_createPdf_Click);
            // 
            // UC_CourseRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_createPdf);
            this.Controls.Add(this.dataGridView_courseRequest);
            this.Name = "UC_CourseRequest";
            this.Size = new System.Drawing.Size(1404, 740);
            this.Load += new System.EventHandler(this.UC_CourseRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_courseRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_courseRequest;
        private System.Windows.Forms.Button button_createPdf;
    }
}
