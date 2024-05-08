using Villa.Businnes.Abstrack;
using Villa.Businnes.Concrete;
using Villa.Data.Abstrack;
using Villa.Data.EntityFramework;
using Villa.Data.Repositories;

namespace Villa.WebUI.Extensions
{
    public static class Config
    {
        public static void AddServiceExtension(this IServiceCollection Services)
        {
            Services.AddScoped<IBannerDal, EfBannerDal>();
            Services.AddScoped<IBannerService, BannerManager>();

            Services.AddScoped<IContactDal, EfContactDal>();
            Services.AddScoped<IContactService, ContactManager>();

            Services.AddScoped<ICounterDal, EfCounterDal>();
            Services.AddScoped<ICounterService, CounterManager>();

            Services.AddScoped<IDealDal, EfDealDal>();
            Services.AddScoped<IDealService, DealManager>();

            Services.AddScoped<IFeatureDal, EfFeatureDal>();
            Services.AddScoped<IFeatureService, FeatureManager>();

            Services.AddScoped<IMessageDal, EfMessageDal>();
            Services.AddScoped<IMessageService, MessageManager>();

            Services.AddScoped<IProductDal, EfProductDal>();
            Services.AddScoped<IProductService, ProductManager>();

            Services.AddScoped<IQuestDal, EfQuestDal>();
            Services.AddScoped<IQuestService, QuestManager>();

            Services.AddScoped<IVideoDal, EfVideoDal>();
            Services.AddScoped<IVideoService, VideoManager>();

            Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
        }
    }
}
