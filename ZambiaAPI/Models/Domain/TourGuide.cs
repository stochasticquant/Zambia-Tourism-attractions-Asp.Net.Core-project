namespace ZambiaAPI.Models.Domain
{
    public class TourGuide
    {

        public Guid TourGuideId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        
        public string LanguagesSpoken { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public double PricePerHour { get; set; }
        public double? Rating { get; set; }

        // navigation properties
        public Region Region { get; set; }
    }
}
