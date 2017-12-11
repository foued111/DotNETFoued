namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("commentforum")]
    public partial class commentforum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public commentforum()
        {
            votecomment = new HashSet<votecomment>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string comment { get; set; }

        public int nbrVotesC { get; set; }

        public int? forumC_id { get; set; }

        public int? userC_id { get; set; }

        public virtual user user { get; set; }

        public virtual forum forum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<votecomment> votecomment { get; set; }
    }
}
