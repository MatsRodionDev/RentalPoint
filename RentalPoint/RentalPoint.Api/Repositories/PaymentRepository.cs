using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class PaymentRepository : GenericRepository<Payment> , IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
