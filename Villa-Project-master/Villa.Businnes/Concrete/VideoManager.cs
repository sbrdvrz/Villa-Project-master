using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class VideoManager : GenericManager<Video>, IVideoService
    {
        public VideoManager(IGenericDal<Video> genericDal) : base(genericDal)
        {
        }
    }
}
