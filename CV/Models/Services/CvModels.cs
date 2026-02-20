namespace CV.Models
{
    // <summary>Represents a single project in the portfolio.</summary>
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string DemoUrl { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
    }

    // <summary>A category of skills, e.g. "Languages" with a list of skill names.</summary>
    public class SkillCategory
    {
        public string CategoryName { get; set; } = string.Empty;
        public string Icon { get; set; } = "bi-code-slash"; // Bootstrap Icons class
        public List<string> Skills { get; set; } = new();
    }

    // <summary>One entry in the education/certification timeline.</summary>
    public class EducationItem
    {
        public string DateRange { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // The top-level ViewModel passed to views that need the full CV.
    public class CvData
    {
        // Personal Info
        public string FullName { get; set; } = "Wandile";
        public string Title { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string LinkedInUrl { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;

        // Home page stats
        public int YearsCoding { get; set; }
        public int ProjectsBuilt { get; set; }
        public int TechCount { get; set; }

        // Collections
        public List<Project> Projects { get; set; } = new();
        public List<SkillCategory> SkillCategories { get; set; } = new();
        public List<EducationItem> Education { get; set; } = new();
    }
}