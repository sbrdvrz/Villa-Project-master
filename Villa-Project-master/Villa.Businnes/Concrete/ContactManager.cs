using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class ContactManager : GenericManager<Contact>, IContactService
    {
        public ContactManager(IGenericDal<Contact> genericDal) : base(genericDal)
        {
        }
    }
}
