using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SignalRTest.Models
{
    public class tblMes
    {
        [Key]
        public int Id { get; set; } 
        public string User { get; set; }
        public string Message { get; set; }
        [NotMapped]
        public DateTime Timestamp { get; set; }
    }
}
