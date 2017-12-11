namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("users")]
    public partial class users
    {
        [Required]
        [StringLength(31)]
        public string DTYPE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LasttName { get; set; }

        [StringLength(255)]
        public string Password { get; set; }

        public int PhoneNumber { get; set; }

        [StringLength(255)]
        public string NameNgo { get; set; }

        [StringLength(255)]
        public string latitude { get; set; }

        [StringLength(255)]
        public string longitude { get; set; }

        [StringLength(255)]
        public string preferences { get; set; }
    }
}
