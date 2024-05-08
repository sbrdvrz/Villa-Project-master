using Villa.Businnes.Abstrack;
using Villa.Data.Abstrack;
using Villa.Entities.Concrete;

namespace Villa.Businnes.Concrete
{
    public class QuestManager : GenericManager<Quest>, IQuestService
    {
        public QuestManager(IGenericDal<Quest> genericDal) : base(genericDal)
        {
        }
    }
}
