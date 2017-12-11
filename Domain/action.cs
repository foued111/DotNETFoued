namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("action")]
    public partial class action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public action()
        {
            comment = new HashSet<comment>();
            localisation = new HashSet<localisation>();
            participation = new HashSet<participation>();
            user2 = new HashSet<user>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public DateTime? dateEnd { get; set; }

        public DateTime? dateStart { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public DateTime? heuredebut { get; set; }

        [Column(TypeName = "tinyblob")]
        public byte[] image { get; set; }

        public float latitudeA { get; set; }

        public float longitudeA { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int nbrVol { get; set; }

        public int? manager_id { get; set; }

        public int? ngo_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        public virtual user user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<localisation> localisation { get; set; }

        public virtual user user1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participation> participation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user2 { get; set; }
    }
}
