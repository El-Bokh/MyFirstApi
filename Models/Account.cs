using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstApi.Models
{
    [Table("tblaccounts")] 
    public class Account
    {
        [Key]
        public int AccID { get; set; }

        public string AccName { get; set; } = string.Empty;
    }
}
