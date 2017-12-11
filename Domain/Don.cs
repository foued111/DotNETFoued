using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Don
    {
        [Key]
        public int DonId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime dateDon { get; set; }
        public string Type { get; set; }
        public string picture { get; set; }
        public int? id { get; set; }
        [ForeignKey("id")]
        public virtual user usr { get; set; }
    }
}
