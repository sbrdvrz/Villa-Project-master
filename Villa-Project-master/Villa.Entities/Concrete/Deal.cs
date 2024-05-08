namespace Villa.Entities.Concrete
{
    public class Deal : BaseEntity
    {
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
