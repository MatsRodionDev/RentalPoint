using RentalPoint.Api.Interfaces.Repositories;
using RentalPoint.Api.Interfaces.Services;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository) : base(repository)
        {

        }
    }
}
