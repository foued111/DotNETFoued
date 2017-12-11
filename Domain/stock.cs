using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("stock")]
    public class stock
    {

        [Key]
        public int Id { get; set; }
    
        public string description { get; set; }
     
        public string type { get; set; }
    }
}
