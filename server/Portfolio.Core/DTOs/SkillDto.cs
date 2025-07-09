namespace Portfolio.API.Models.DTOs
{
    public class SkillDto
    {
        public int Id { get; set; }                    // Unique identifier
        public string Name { get; set; }               // Skill or technology name(e.g. "C#", "React")
        public string Category { get; set; }           //Category (e.g. Frontend, Backend)
        public string? IconUrl { get; set; }            //URL to skill icon
    }


}
