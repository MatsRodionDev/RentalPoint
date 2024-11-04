using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class EventService : GenericService<Event>, IEventService
    {
        public EventService(IEventRepository repository) : base(repository)
        {

        }
    }
}
