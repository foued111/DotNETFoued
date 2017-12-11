namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("localisation")]
    public partial class localisation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string distance { get; set; }

        [StringLength(255)]
        public string rayon { get; set; }

        public int? act_id { get; set; }

        public int? volunt_id { get; set; }

        public virtual action action { get; set; }

        public virtual user user { get; set; }
    }
}
