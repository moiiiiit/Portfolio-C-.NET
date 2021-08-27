using System.ComponentModel.DataAnnotations;

namespace portfolio_backend.models{
    public class Experience{
        public int experienceid { get; set; }
        [Required]
        public string positiontitle { get; set; }
        [Required]
        public string company {get; set;}
        public string timeperiod { get; set; }
        public string bullet1 { get; set; }
        public string bullet2 { get; set; }
        public int userid { get; set; }
    }
}