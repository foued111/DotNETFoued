namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
  

    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class VoluntContext : DbContext
    {
        static VoluntContext()
        {
             Database.SetInitializer<VoluntContext>(null);
        }

        public VoluntContext()
            : base("name=volunteering")
        {
        }

        public virtual DbSet<action> action { get; set; }
        public virtual DbSet<comment> comment { get; set; }
        public virtual DbSet<commentforum> commentforum { get; set; }
        public virtual DbSet<forum> forum { get; set; }
        public virtual DbSet<localisation> localisation { get; set; }
        public virtual DbSet<participation> participation { get; set; }
        public virtual DbSet<reclamation> reclamation { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<votecomment> votecomment { get; set; }
        public virtual DbSet<voteforum> voteforum { get; set; }
        public virtual DbSet<contract> contract { get; set; }
        public virtual DbSet<Don> don { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<action>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<action>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<action>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<action>()
                .HasMany(e => e.comment)
                .WithOptional(e => e.action)
                .HasForeignKey(e => e.action_id);

            modelBuilder.Entity<action>()
                .HasMany(e => e.localisation)
                .WithOptional(e => e.action)
                .HasForeignKey(e => e.act_id);

            modelBuilder.Entity<action>()
                .HasMany(e => e.participation)
                .WithOptional(e => e.action)
                .HasForeignKey(e => e.action_id);

            modelBuilder.Entity<action>()
                .HasMany(e => e.user2)
                .WithMany(e => e.action2)
                .Map(m => m.ToTable("action_user").MapRightKey("volunteer_id"));

            modelBuilder.Entity<comment>()
                .Property(e => e.comment1)
                .IsUnicode(false);

            modelBuilder.Entity<commentforum>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<commentforum>()
                .HasMany(e => e.votecomment)
                .WithOptional(e => e.commentforum)
                .HasForeignKey(e => e.id_comment);

            modelBuilder.Entity<forum>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<forum>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<forum>()
                .Property(e => e.question)
                .IsUnicode(false);

            modelBuilder.Entity<forum>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<forum>()
                .HasMany(e => e.commentforum)
                .WithOptional(e => e.forum)
                .HasForeignKey(e => e.forumC_id);

            modelBuilder.Entity<forum>()
                .HasMany(e => e.voteforum)
                .WithOptional(e => e.forum)
                .HasForeignKey(e => e.id_forum);

            modelBuilder.Entity<localisation>()
                .Property(e => e.distance)
                .IsUnicode(false);

            modelBuilder.Entity<localisation>()
                .Property(e => e.rayon)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.userToClaim)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.isAllowed)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phoneNum)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Preference)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.NameAssociation)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.action)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.ngo_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.action1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.manager_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.commentforum)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.userC_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.forum)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.userF_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.localisation)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.volunt_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.participation)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.volunteer_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.participation1)
                .WithOptional(e => e.user1)
                .HasForeignKey(e => e.ngo_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reclamation)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.usr_id);

            modelBuilder.Entity<user>()
                .HasMany(e => e.voteforum)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.id_user);

            modelBuilder.Entity<user>()
                .HasMany(e => e.votecomment)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.id_user);

            //modelBuilder.Entity<user>()
            //    .HasMany(e => e.contract)
            //    .WithOptional(e => e.user)
            //    .HasForeignKey(e => e.id_user);

            modelBuilder.Entity<users>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.LasttName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.NameNgo)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.latitude)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.longitude)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.preferences)
                .IsUnicode(false);

            //modelBuilder.Entity<contract>()
            //    .Property(e => e.reason)
            //    .IsUnicode(false);

            //modelBuilder.Entity<contract>()
            //    .Property(e => e.confirmation)
            //    .IsUnicode(false);

            //modelBuilder.Entity<contract>()
            //    .Property(e => e.contractPDF)
            //    .GetType();        
        }
    }
}
