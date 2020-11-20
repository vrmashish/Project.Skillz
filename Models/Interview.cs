using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project.Skillz.Models
{   
    public enum Assess
    {
        Subjective,
        Objective,
        Both
    }
    public enum skill
    {
        Begineer,
        Intermediate,
        Advanced
    }
    public class Interview
    {

        public int id { get; set; }

        [Display(Name = "Interview Name")]
        [Required]
        public string InterviewName { get; set; }
        [Display(Name = "Skill Level")]
        [Required]
        public skill SkillLevel { get; set; }
        [Display(Name = "Assessment Modes")]
        [Required]
        public Assess AssessmentModes { get; set; }
        [Display(Name ="Status")]
        public string Status { get; set; }
        public string Questions { get; set; }
    }

    public class DashBoardDbContext : DbContext
    {
       public DbSet<Interview> interviews { get; set; }
    }
}