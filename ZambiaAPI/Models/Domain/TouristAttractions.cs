namespace ZambiaAPI.Models.Domain
{
    public class TouristAttractions
    {
        public Guid TouristAttractionsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double SizeInKm2 { get; set; }
        public string? AttractionUrl { get; set; }  // The question mark indicates that the property is nullable.
        public Guid RegionId { get; set; }

        public Guid RatingId { get; set; }

        // navigation properties
        public Region Region { get; set; }
        public Rating Rating { get; set; }


    }
}