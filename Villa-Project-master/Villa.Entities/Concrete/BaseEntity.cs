using MongoDB.Bson;

namespace Villa.Entities.Concrete
{
    public class BaseEntity
    {
        public ObjectId Id { get; set; }
    }
}
