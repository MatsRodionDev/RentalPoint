using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Repositories
{
    public class CategoryRepository : GenericRepository<Category> , ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
