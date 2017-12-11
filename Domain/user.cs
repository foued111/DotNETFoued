namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            action = new HashSet<action>();
            action1 = new HashSet<action>();
            commentforum = new HashSet<commentforum>();
            forum = new HashSet<forum>();
            localisation = new HashSet<localisation>();
            participation = new HashSet<participation>();
            participation1 = new HashSet<participation>();
            reclamation = new HashSet<reclamation>();
            voteforum = new HashSet<voteforum>();
            votecomment = new HashSet<votecomment>();
            action2 = new HashSet<action>();
            contract = new HashSet<contract>();
        }

        public user(string firstName, string lastName, string phoneNum, string password, string login, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.password = password;
            this.login = login;
            this.email = email;
        }

        public user(int id, string firstName, string lastName, string phoneNum, string password, string login, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNum = phoneNum;
            this.password = password;
            this.login = login;
            this.email = email;
        }

        public user(int id, string nameAssociation, string phoneNum, string password, string login, string email)
        {
            this.id = id;
            NameAssociation = nameAssociation;
            this.phoneNum = phoneNum;
            this.password = password;
            this.login = login;
            this.email = email;
        }

        [Required]
        [StringLength(31)]
        public string DTYPE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string firstName { get; set; }

        public int inc { get; set; }

        [StringLength(255)]
        public string isAllowed { get; set; }

        [StringLength(255)]
        public string lastName { get; set; }

        [StringLength(255)]
        public string login { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string phoneNum { get; set; }

        [StringLength(255)]
        public string Preference { get; set; }

        public float? latitudeV { get; set; }

        public float? longitudeV { get; set; }

        [StringLength(255)]
        public string NameAssociation { get; set; }

        [StringLength(255)]
        public string Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<action> action { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<action> action1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commentforum> commentforum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<forum> forum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<localisation> localisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participation> participation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participation> participation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reclamation> reclamation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<voteforum> voteforum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<votecomment> votecomment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<action> action2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contract> contract { get; set; }
        public virtual Collection<Don> dons { get; set; }
    }
}
