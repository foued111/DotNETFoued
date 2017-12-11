namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("participation")]
    public partial class participation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public DateTime? dateParticipation { get; set; }

        public int heuredebut { get; set; }

        public int? action_id { get; set; }

        public int? ngo_id { get; set; }

        public int? volunteer_id { get; set; }

        public virtual action action { get; set; }

        public virtual user user { get; set; }

        public virtual user user1 { get; set; }
    }
}
