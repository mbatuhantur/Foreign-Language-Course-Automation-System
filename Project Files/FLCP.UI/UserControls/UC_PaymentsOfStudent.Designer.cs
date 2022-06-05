
namespace FLCP.UI.UserControls
{
    partial class UC_PaymentsOfStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_payments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(393, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY PAYMENTS";
            // 
            // dataGridView_payments
            // 
            this.dataGridView_payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_payments.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_payments.Location = new System.Drawing.Point(3, 82);
            this.dataGridView_payments.Name = "dataGridView_payments";
            this.dataGridView_payments.RowTemplate.Height = 25;
            this.dataGridView_payments.Size = new System.Drawing.Size(1053, 370);
            this.dataGridView_payments.TabIndex = 1;
            // 
            // UC_PaymentsOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView_payments);
            this.Controls.Add(this.label1);
            this.Name = "UC_PaymentsOfStudent";
            this.Size = new System.Drawing.Size(1059, 647);
            this.Load += new System.EventHandler(this.UC_PaymentsOfStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_payments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_payments;
    }
}
