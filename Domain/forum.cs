namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("forum")]
    public partial class forum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public forum()
        {
            commentforum = new HashSet<commentforum>();
            voteforum = new HashSet<voteforum>();
        }

        public forum(int id, string subject, string question, string description, string date)
        {
            this.id = id;
            this.subject = subject;
            this.question = question;
            this.description = description;
            this.date = date;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]        
        public string date { get; set; }

        [StringLength(255)]
        [Required]
        public string description { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        public int likes { get; set; }

        [StringLength(255)]
        [Required]
        public string question { get; set; }

        [StringLength(255)]
        [Required]
        public string subject { get; set; }

        public int? userF_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentforum> commentforum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<voteforum> voteforum { get; set; }

        public virtual user user { get; set; }
    }
}
