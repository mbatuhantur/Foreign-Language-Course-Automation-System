using FLCP.BusinessLogicLayer.Concrete;
using FLCP.DataAccess.Concrete;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLCP.UI.UserControls
{
    public partial class UC_PaymentsOfStudent : UserControl
    {
        EfPaymentDal paymentDal = new EfPaymentDal();
        Student student;
        public UC_PaymentsOfStudent(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void UC_PaymentsOfStudent_Load(object sender, EventArgs e)
        {
            PaymentManager paymentManager = new PaymentManager(paymentDal);
            dataGridView_payments.DataSource = paymentManager.GetPaymentsByStudentID(student.Id);
        }
    }
}
