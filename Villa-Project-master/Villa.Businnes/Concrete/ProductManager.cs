using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        public ProductManager(IGenericDal<Product> genericDal) : base(genericDal)
        {
        }
    }
}
