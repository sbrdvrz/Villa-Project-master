using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class MessageManager : GenericManager<Message>, IMessageService
    {
        public MessageManager(IGenericDal<Message> genericDal) : base(genericDal)
        {
        }
    }
}
