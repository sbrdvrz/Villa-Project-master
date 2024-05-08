using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class CounterManager : GenericManager<Counter>, ICounterService
    {
        public CounterManager(IGenericDal<Counter> genericDal) : base(genericDal)
        {
        }
    }
}
