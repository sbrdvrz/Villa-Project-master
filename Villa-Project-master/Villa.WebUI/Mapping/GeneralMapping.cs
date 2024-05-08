using AutoMapper;
using Villa.DTO.Dtos.BannerDtos;
using Villa.DTO.Dtos.ContactDtos;
using Villa.DTO.Dtos.Counter;
using Villa.DTO.Dtos.DealDtos;
using Villa.DTO.Dtos.FeatureDtos;
using Villa.DTO.Dtos.MessageDtos;
using Villa.DTO.Dtos.ProductDtos;
using Villa.DTO.Dtos.QuestDtos;
using Villa.DTO.Dtos.VideoDtos;
using Villa.Entities.Concrete;

namespace Villa.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();
            CreateMap<Banner, CreateBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();

            CreateMap<Contact,ResultContactDto>().ReverseMap(); 
            CreateMap<Contact,UpdateContactDto>().ReverseMap(); 
            CreateMap<Contact,CreateContactDto>().ReverseMap(); 

            CreateMap<Counter,ResultCounterDto>().ReverseMap();
            CreateMap<Counter,UpdateCounterDto>().ReverseMap();
            CreateMap<Counter,CreateCounterDto>().ReverseMap();

            CreateMap<Deal,ResultDealDto>().ReverseMap();
            CreateMap<Deal,UpdateDealDto>().ReverseMap();
            CreateMap<Deal,CreateDealDto>().ReverseMap();

            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();

            CreateMap<Quest,ResultQuestDto>().ReverseMap();
            CreateMap<Quest,UpdateQuestDto>().ReverseMap();
            CreateMap<Quest,CreateQuestDto>().ReverseMap();

            CreateMap<Video,ResultVideoDto>().ReverseMap();
            CreateMap<Video,UpdateVideoDto>().ReverseMap();
            CreateMap<Video,CreateVideoDto>().ReverseMap();
        }
    }
}
