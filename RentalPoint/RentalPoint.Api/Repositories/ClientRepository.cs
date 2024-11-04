using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class ClientRepository : GenericRepository<Client> , IClientRepository
    {
        public ClientRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
