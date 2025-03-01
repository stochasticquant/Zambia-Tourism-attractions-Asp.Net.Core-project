using System.ComponentModel.DataAnnotations;

namespace ZambiaAPI.Models.Domain
{
    public class Region
    {
        
        public Guid RegionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionUrl { get; set; }  // The question mark indicates that the property is nullable.
        public Guid AccommodationId { get; set; }
        public Guid TourGuideId { get; set; }
        public Guid TransportId { get; set; }

        // navigation properties : this is how entity framework knows how to join the tables
        public Accommodation Accommodation { get; set; }
        public TourGuide TourGuide { get; set; }
        public Transport Transport { get; set; }

    }
}
