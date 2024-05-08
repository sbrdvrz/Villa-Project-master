using MongoDB.Bson;

namespace Villa.DTO.Dtos.VideoDtos
{
    public class ResultVideoDto
    {
        public ObjectId Id { get; set; }
        public string VideoUrl { get; set; }
    }
}
