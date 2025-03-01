using ZambiaAPI.Models.Domain;

namespace ZambiaAPI.Models.DTO
{
    public class RegionsDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string? RegionUrl { get; set; }  // The question mark indicates that the property is nullable.

    }
}
