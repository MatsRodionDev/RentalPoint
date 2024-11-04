using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class ClientService : GenericService<Client>, IClientService
    {
        public ClientService(IClientRepository repository) : base(repository)
        {
            
        }
    }
}
