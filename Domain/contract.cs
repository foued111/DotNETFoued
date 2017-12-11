namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("contract")]
    public partial class contract
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }       

        public int? id_user { get; set; }

        [Required]
        [StringLength(255)]
        public string reason { get; set; }

        [Required]
        [StringLength(255)]
        public string confirmation { get; set; }

        [Required]
        [Column(TypeName = "blob")]
        public byte[] contractPDF { get; set; }

        public virtual user user { get; set; }
    }
}
