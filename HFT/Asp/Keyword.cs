using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp05.Models
{
    public class Keyword
    {
        [Key]
        public string Id { get; set; }
        public string Word { get; set; }
        public virtual Person person { get; set; }
        public string PId { get; set;}
    }
}
