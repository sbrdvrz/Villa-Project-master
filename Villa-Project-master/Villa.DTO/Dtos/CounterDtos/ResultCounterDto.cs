using MongoDB.Bson;

namespace Villa.DTO.Dtos.Counter
{
    public class ResultCounterDto
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Count { get; set; }
    }
}
