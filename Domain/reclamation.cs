namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("reclamation")]
    public partial class reclamation
    {
        [Key]
        public int idReclamation { get; set; }

        public DateTime? dateSolution { get; set; }

        public DateTime? dateTraitement { get; set; }

        [StringLength(255)]
        public string message { get; set; }

        public DateTime? reclamationDate { get; set; }

        [StringLength(255)]
        public string status { get; set; }

        [StringLength(255)]
        public string subject { get; set; }

        [StringLength(255)]
        public string userToClaim { get; set; }

        public int? usr_id { get; set; }

        public virtual user user { get; set; }
    }
}
