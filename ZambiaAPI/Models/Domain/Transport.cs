namespace ZambiaAPI.Models.Domain
{
    public class Transport
    {
        public Guid TransportId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Guid RegionId { get; set; }
        public string Availability { get; set; }
        public string PriceRange { get; set; }
        public string ContactInfo { get; set; }
        public string? TransportUrl { get; set; }  // The question mark indicates that the property is nullable.

        // navigation properties
        public ICollection<Region> Regions { get; set; }




    }
}
