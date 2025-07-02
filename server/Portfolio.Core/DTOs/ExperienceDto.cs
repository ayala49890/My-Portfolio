namespace Portfolio.API.Models.DTOs
{
    public class ExperienceDto
    {
        public int Id { get; set; }                        // Unique identifier
        public string CompanyName { get; set; }            // Company name
        public string Role { get; set; }                    // Job title / role
        public DateTime StartDate { get; set; }             // Start date
        public DateTime? EndDate { get; set; }               // End date (nullable if currently employed)
        public string Description { get; set; }              // Role description / achievements

    }
}
