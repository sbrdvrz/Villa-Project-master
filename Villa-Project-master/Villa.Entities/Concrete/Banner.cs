using MongoDB.Bson;

namespace Villa.Entities.Concrete
{
    public class Banner : BaseEntity
    {
        public string Title { get; set; }
        public string City { get; set; }
        public string ImageUrl { get; set; }
    }
}