using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class BannerManager : GenericManager<Banner>, IBannerService
    {
        public BannerManager(IGenericDal<Banner> genericDal) : base(genericDal)
        {
        }
    }
}
