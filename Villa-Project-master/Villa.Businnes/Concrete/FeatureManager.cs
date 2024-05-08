using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class FeatureManager : GenericManager<Feature>, IFeatureService
    {
        public FeatureManager(IGenericDal<Feature> genericDal) : base(genericDal)
        {
        }
    }
}
