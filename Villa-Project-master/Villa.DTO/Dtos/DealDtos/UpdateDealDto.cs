using MongoDB.Bson;

namespace Villa.DTO.Dtos.DealDtos
{
    public class UpdateDealDto
    {
        public ObjectId Id { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Square { get; set; }
        public string FloorNumber { get; set; }
        public int RoomCount { get; set; }
        public bool ParkingArea { get; set; }
        public string PaymentType { get; set; }
    }
}
