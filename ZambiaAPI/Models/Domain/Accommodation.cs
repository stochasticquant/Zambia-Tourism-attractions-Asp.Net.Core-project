namespace ZambiaAPI.Models.Domain
{
    public class Accommodation
    {
        public Guid AccommodationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
       
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double PricePerNight { get; set; }
        public string? AccommodationUrl { get; set; }  // The question mark indicates that the property is nullable.
        public string Facilities { get; set; }  
        public double Rating { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int AvailableRooms { get; set; }
        public bool BookingRequired { get; set; }
        public string NearbyAttractions { get; set; }
        public string Accessbility { get; set; }


        // navigation properties
        public Region Region { get; set; }
    }
}
