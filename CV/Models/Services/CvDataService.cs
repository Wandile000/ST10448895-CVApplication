using CV.Models;
using CV.Models;

namespace CV.Models.Services
{
    /// <summary>
    /// Provides all CV data to the application.
    public class CvDataService
    {
        public CvData GetCvData()
        {
            return new CvData
            {


                FullName = "Wandile Zuke",
                Title = "Final-Year IT Student ",
                Location = "Johannesburg, South Africa",
                Email = "ST10448895@myemeris.edu.za",
                GitHubUrl = "https://github.com/Wandile000",
                LinkedInUrl = "https://www.linkedin.com/in/wandile-zuke-974571315/",
                Bio = "Organized and dependable candidate successful at managing multiple priorities with a positive attitude. Willingness\r\nto take on added responsibilities to meet team goals. Complex problem-solver with analytical and driven mindset.\r\nDedicated to achieving demanding development objectives according to tight schedules while producing impeccable\r\ncode.",
                YearsCoding = 3,
                ProjectsBuilt = 3,
                TechCount = 2,

                // SKILLS
                SkillCategories = new List<SkillCategory>
                {
                    new SkillCategory
                    {
                        CategoryName = "Languages",
                        Icon = "bi-code-slash",
                        Skills = new List<string> { "C#", "Java", "HTML5", "SQL", "Kotlin" }
                    },
                    new SkillCategory
                    {
                        CategoryName = "Frameworks & Libraries",
                        Icon = "bi-layers",
                        Skills = new List<string> { "ASP.NET Core", "Entity Framework Core", "Bootstrap 5" }
                    },
                    new SkillCategory
                    {
                        CategoryName = "Tools & Platforms",
                        Icon = "bi-tools",
                        Skills = new List<string> { "Git", "GitHub", "Visual Studio 2022", "Azure", "Docker" }
                    },
                    new SkillCategory
                    {
                        CategoryName = "Databases",
                        Icon = "bi-database",
                        Skills = new List<string> { "SQL Server", "PostgreSQL", "SQLite", "MongoDB" }
                    },
                    new SkillCategory
                    {
                        CategoryName = "Soft Skills",
                        Icon = "bi-person-check",
                        Skills = new List<string> { "Problem Solving", "Team Collaboration", "Communication", "Adaptability" }
                    }
                },

                // PROJECTS
                // 

                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "CV Portfolio Website",
                        Description = "A professional portfolio built with ASP.NET Core 9 MVC. " +
                                      "Features a modern dark theme, responsive design, C# data services, and Azure deployment.",
                        GitHubUrl = "https://github.com/Wandile000/ST10448895-CVApplication.git",
                        DemoUrl = "",
                        Tags = new List<string> { "ASP.NET Core 9", "C#", "MVC", "Bootstrap 5" }
                    },
                    new Project
                    {
                        Title = "Basic-Cyber-chat-bot",
                        Description = "This chatbot acts like your personal cyber safety guide. When launched, it greets the user, plays a welcome audio (optional), and explains various cybersecurity topics in both technical and simplified formats.",
                        GitHubUrl = "https://github.com/Wandile000/Basic-Cyber-chat-bot.git",                        
                        Tags = new List<string> { "C#" }
                    },
                    new Project
                    {
                        Title = "Contract Monthly Claim System",
                        Description = "Contract Monthly Claim System (CMCS) is a web-based ASP.NET Core MVC application designed to streamline and manage monthly claim submissions within academic institutions.",
                        GitHubUrl = "https://github.com/ZukeWandile/ContractMonthlyClaimSystem.git",
                        DemoUrl = "",
                        Tags = new List<string> { "ASP.NET Core 9", "C#", "MVC" }
                    }
                },

                // EDUCATION

                Education = new List<EducationItem>
                {
                    new EducationItem
                    {
                        DateRange = "2024 — Present",
                        Degree = "Bachelor of Science in Computer Science",
                        Institution = "Emeris Ruimsig",
                        Description = "The IIE Bachelor of Computer and Information Sciences in Application Development, available at Emeris, provides candidates with a thorough theoretical grounding and knowledge base in the key principles of information technology (IT), programming, mobile application development across platforms, web development, database design, troubleshooting, testing, connectivity, customisation and project management."
                    },
                
                }
            };
        }
    }
}