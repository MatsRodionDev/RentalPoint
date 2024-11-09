using AutoMapper;
using RentalPoint.Api.Dto;
using RentalPoint.Api.Models;

namespace RentalPoint.Api.Profiles
{
    public class ApiProfile : Profile
    {
        public ApiProfile() 
        {
            CreateMap<Item, ItemRequest>()
                .ReverseMap();
            CreateMap<Item, ItemResponse>()
                .ReverseMap();

            CreateMap<Category, CategoryRequest>()
                .ReverseMap();
            CreateMap<Category, CategoryResponse>()
                .ReverseMap();

            CreateMap<Client, ClientRequest>()
                .ReverseMap();
            CreateMap<Client, ClientResponse>()
                .ReverseMap();
            CreateMap<Client, ClientReviewResponse>()
                .ReverseMap();

            CreateMap<Review, ReviewRequest>()
                .ReverseMap();
            CreateMap<Review, ReviewResponse>()
                .ReverseMap();

            CreateMap<Rental, RentalRequest>()
                .ReverseMap();
            CreateMap<Rental, RentalResponse>()
                .ReverseMap();
        }
    }
}
