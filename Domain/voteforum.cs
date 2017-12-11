namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("voteforum")]
    public partial class voteforum
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? id_forum { get; set; }

        public int? id_user { get; set; }

        public virtual forum forum { get; set; }

        public virtual user user { get; set; }
    }
}
