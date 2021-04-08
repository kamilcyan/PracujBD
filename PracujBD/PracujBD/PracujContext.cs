using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PracujBD
{
    public partial class PracujContext : DbContext
    {
        public PracujContext()
        {
        }

        public PracujContext(DbContextOptions<PracujContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advice> Advices { get; set; }
        public virtual DbSet<AdviceCategory> AdviceCategories { get; set; }
        public virtual DbSet<BussinesService> BussinesServices { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<JobOffert> JobOfferts { get; set; }
        public virtual DbSet<LevelOfExperience> LevelOfExperiences { get; set; }
        public virtual DbSet<LevelOfLanguage> LevelOfLanguages { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<ServiceUser> ServiceUsers { get; set; }
        public virtual DbSet<TypeOfContract> TypeOfContracts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pracuj;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Advice>(entity =>
            {
                entity.ToTable("Advice");

                entity.Property(e => e.AdviceCategoryId).HasColumnName("Advice_category_id");

                entity.Property(e => e.Body)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnName("Creation_date");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AdviceCategory)
                    .WithMany(p => p.Advices)
                    .HasForeignKey(d => d.AdviceCategoryId)
                    .HasConstraintName("FK_Advice_category_Advice");
            });

            modelBuilder.Entity<AdviceCategory>(entity =>
            {
                entity.ToTable("Advice_category");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BussinesService>(entity =>
            {
                entity.ToTable("Bussines_services");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PublicationTime).HasColumnName("Publication_time");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.Answer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobOffert>(entity =>
            {
                entity.ToTable("Job_offert");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_name");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Job_description");

                entity.Property(e => e.LevelOfExperienceId).HasColumnName("Level_of_experience_id");

                entity.Property(e => e.NiceToHave)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nice_to_have");

                entity.Property(e => e.Post)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Requirements)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Responsabilities)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfContractId).HasColumnName("Type_of_contract_id");

                entity.Property(e => e.WePropose)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("We_propose");

                entity.Property(e => e.Workplace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.LevelOfExperience)
                    .WithMany(p => p.JobOfferts)
                    .HasForeignKey(d => d.LevelOfExperienceId)
                    .HasConstraintName("FK_Level_of_experience_Job_offert");

                entity.HasOne(d => d.TypeOfContract)
                    .WithMany(p => p.JobOfferts)
                    .HasForeignKey(d => d.TypeOfContractId)
                    .HasConstraintName("FK_Type_of_contract_Job_offert");
            });

            modelBuilder.Entity<LevelOfExperience>(entity =>
            {
                entity.ToTable("Level_of_experience");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LevelOfLanguage>(entity =>
            {
                entity.ToTable("Level_of_language");

                entity.Property(e => e.Level)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.Body)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderId).HasColumnName("Sender_id");
            });

            modelBuilder.Entity<ServiceUser>(entity =>
            {
                entity.ToTable("Service_user");

                entity.Property(e => e.Adress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Certification)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Cv)
                    .IsUnicode(false)
                    .HasColumnName("CV");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_birth");

                entity.Property(e => e.Education)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedSalary)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("Expected_salary");

                entity.Property(e => e.Experience)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First_name");

                entity.Property(e => e.Language)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last_name");

                entity.Property(e => e.LevelOfLanguageId).HasColumnName("Level_of_language_id");

                entity.Property(e => e.MessageId).HasColumnName("Message_id");

                entity.Property(e => e.MyApplicationId).HasColumnName("My_application_id");

                entity.Property(e => e.PnoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Pnone_number");

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecomendedOffertId).HasColumnName("Recomended_offert_id");

                entity.Property(e => e.SavedOffertId).HasColumnName("Saved_offert_id");

                entity.Property(e => e.Skills)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.LevelOfLanguage)
                    .WithMany(p => p.ServiceUsers)
                    .HasForeignKey(d => d.LevelOfLanguageId)
                    .HasConstraintName("FK_Level_of_language_Service_user");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.ServiceUsers)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_Message_Service_user");

                entity.HasOne(d => d.MyApplication)
                    .WithMany(p => p.ServiceUserMyApplications)
                    .HasForeignKey(d => d.MyApplicationId)
                    .HasConstraintName("FK_My_application_Service_user");

                entity.HasOne(d => d.RecomendedOffert)
                    .WithMany(p => p.ServiceUserRecomendedOfferts)
                    .HasForeignKey(d => d.RecomendedOffertId)
                    .HasConstraintName("FK_Recomended_offert_Service_user");

                entity.HasOne(d => d.SavedOffert)
                    .WithMany(p => p.ServiceUserSavedOfferts)
                    .HasForeignKey(d => d.SavedOffertId)
                    .HasConstraintName("FK_Saved_offert_Service_user");
            });

            modelBuilder.Entity<TypeOfContract>(entity =>
            {
                entity.ToTable("Type_of_contract");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
