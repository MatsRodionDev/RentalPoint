using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class EventRepository : GenericRepository<Event> , IEventRepository
    {
        public EventRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
