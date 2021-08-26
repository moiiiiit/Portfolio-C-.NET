using System.ComponentModel.DataAnnotations;

namespace portfolio_backend.models
{
    public class User
    {
        public int userid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string maintitle { get; set; }
        [Required]
        public string homehellointro { get; set; }
        [Required]
        public string homeprofilepiclink { get; set; }
        [Required]
        public string homeintro { get; set; }
        [Required]
        public string homeexperienceintro { get; set; }
        [Required]
        public int numskilllogos { get; set; }
        [Required]
        public Experience[] experiences { get; set; }
        [Required]
        public Identifier[] identifiers { get; set; }
        [Required]

        public string projectsheadline { get; set; }
        [Required]
        public string projectsintro { get; set; }
        [Required]
        public Project[] projects { get; set; }
        [Required]
        public string resumeiframesrc { get; set; }
        public string resumeiframeresourceurl { get; set; }
        public string contactinstagramlink { get; set; }
        public string contactvscolink { get; set; }
        [Required]
        public string aboutnormal { get; set; }
        [Required]
        public string aboutlight { get; set; }
        [Required]
        public string aboutprofilepicdesc { get; set; }
        [Required]
        public string aboutcasualnormal { get; set; }
        public string contactlinkedinlink { get; set; }
        public string contactemaillink { get; set; }
        public string contactgithublink { get; set; }
        public string altportfoliolink { get; set; }
        public string contactemail { get; set; }
    }
}