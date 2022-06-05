using FLCP.DataAccess.Abstract;
using FLCP.DataAccess.Model;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Concrete
{
    public class EfPaymentDal : IPaymentDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedPayment = context.Payments.Find(id);
                context.Payments.Remove(deletedPayment);
                context.SaveChanges();
            }
        }

        public IEnumerable<Payment> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Payment>().ToList();
            }
        }

        public List<PaymentDto> GetAllPayments()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var payments = from c in context.Payments
                             select new PaymentDto()
                             {
                                 Id = c.Id,
                                 PaymentTitle = c.PaymentTitle,
                                 PaymentDescription = c.PaymentDescription,
                                 PaymentType =(bool)c.PaymentType,
                                 PaymentStatus = (bool)c.PaymentStatus,
                                 StudentId = c.StudentId,
                                 CourseId = c.CourseId,
                                 NumberOfInstallments = (int)c.NumberOfInstallments
                                 
                             };
                return payments.ToList();
            }
        }

        public Payment GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Payments.Find(id);
            }
        }

        public List<PaymentDto> GetPaymentsByStudentID(int Id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var payments = from c in context.Payments
                               select new PaymentDto()
                               {
                                   Id = c.Id,
                                   PaymentTitle = c.PaymentTitle,
                                   PaymentDescription = c.PaymentDescription,
                                   PaymentType = (bool)c.PaymentType,
                                   PaymentStatus = (bool)c.PaymentStatus,
                                   StudentId = c.StudentId,
                                   CourseId = c.CourseId,
                                   NumberOfInstallments = (int)c.NumberOfInstallments

                               };
                return payments.Where(x => x.StudentId == Id).ToList();
            }
        }

        public void Insert(Payment payment)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();
            }
        }

        

        public void Update(Payment payment)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Payments.Update(payment);
                context.SaveChanges();
            }
        }
    }
}
