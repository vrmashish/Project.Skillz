using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Skillz.Models
{
    public class Interview
    {
        [Required]
        public bool selected { get; set; }
        public int id { get; set; }
        [Display(Name ="#")]
        [Required]
        public int serialNo { get; set; }
        [Display(Name ="Interview Name")]
        [Required]
        public string InterviewName { get; set; }
        [Display(Name ="Skill Level")]
        [Required]
        public string SkillLevel { get; set; }

        public string AssessmentModes { get; set; }
        public string Status { get; set; }
        public string Questions { get; set; }
    }
}