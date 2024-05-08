using MongoDB.Bson;

namespace Villa.DTO.Dtos.QuestDtos
{
    public class ResultQuestDto
    {
        public ObjectId Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
