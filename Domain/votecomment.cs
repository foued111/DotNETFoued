namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("votecomment")]
    public partial class votecomment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? id_comment { get; set; }

        public int? id_user { get; set; }

        public virtual commentforum commentforum { get; set; }

        public virtual user user { get; set; }
    }
}
