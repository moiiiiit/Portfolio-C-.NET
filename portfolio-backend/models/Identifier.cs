using System.ComponentModel.DataAnnotations;

namespace portfolio_backend.models
{
    public class Identifier
    {
        public int identifierid { get; set; }
        [Required]
        public string identifiername { get; set; }
    }
}