using System.ComponentModel.DataAnnotations;

namespace portfolio_backend.models{
    public class Project{
        public int projectid { get; set; }
        [Required]
        public string projecttitle { get; set; }
        public string medialink {get; set;}
        public string mediaorientation { get; set; }
        public string projecturl { get; set; }
        [Required]
        public string description { get; set; }
        public string imglink { get; set; }
        public int userid { get; set; }
    }
}