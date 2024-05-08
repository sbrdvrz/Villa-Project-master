using MongoDB.Bson;

namespace Villa.DTO.Dtos.Counter
{
    public class UpdateCounterDto
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Count { get; set; }
    }
}
