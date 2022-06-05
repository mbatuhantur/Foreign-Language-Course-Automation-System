using FLCP.BusinessLogicLayer.Abstract;
using FLCP.DataAccess.Abstract;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public void Delete(int id)
        {
            _paymentDal.Delete(id);
        }

        public IEnumerable<Payment> GetAll()
        {
            return _paymentDal.GetAll();
        }

        public List<PaymentDto> GetAllPayments()
        {
            return _paymentDal.GetAllPayments();
        }

        public Payment GetById(int id)
        {
            return _paymentDal.GetById(id);
        }

        public List<PaymentDto> GetPaymentsByStudentID(int Id)
        {
            return _paymentDal.GetPaymentsByStudentID(Id);
        }

        public void Insert(Payment payment)
        {
            _paymentDal.Insert(payment);
        }

        

        public void Update(Payment payment)
        {
            _paymentDal.Update(payment);
        }
    }
}
