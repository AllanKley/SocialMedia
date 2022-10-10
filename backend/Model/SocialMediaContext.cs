using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Model
{
    public partial class SocialMediaContext : DbContext
    {
        public SocialMediaContext()
        {
        }

        public SocialMediaContext(DbContextOptions<SocialMediaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Collection> Collections { get; set; } = null!;
        public virtual DbSet<CollectionPost> CollectionPosts { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Picture> Pictures { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostLike> PostLikes { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<TagPost> TagPosts { get; set; } = null!;
        public virtual DbSet<Theme> Themes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserUser> UserUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=SNCCH01LABF121\TEW_SQLEXPRESS;Initial Catalog=SocialMedia;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collection>(entity =>
            {
                entity.ToTable("Collection");

                entity.Property(e => e.CollectionName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Collections)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Collectio__UserI__398D8EEE");
            });

            modelBuilder.Entity<CollectionPost>(entity =>
            {

                entity.ToTable("CollectionPost");

                entity.HasOne(d => d.Collection)
                    .WithMany()
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("FK__Collectio__Colle__3B75D760");

                entity.HasOne(d => d.Post)
                    .WithMany()
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Collectio__PostI__3C69FB99");
            });

            modelBuilder.Entity<Comment>(entity =>
            {

                entity.ToTable("Comment");

                entity.HasOne(d => d.CommentPost)
                    .WithMany()
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK__Comment__Comment__3E52440B");

                entity.HasOne(d => d.Post)
                    .WithMany()
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Comment__PostId__3F466844");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("Picture");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Pictures)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Picture__PostId__30F848ED");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Post__UserId__2E1BDC42");
            });

            modelBuilder.Entity<PostLike>(entity =>
            {

                entity.ToTable("PostLike");

                entity.HasOne(d => d.Post)
                    .WithMany()
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__PostLike__PostId__36B12243");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PostLike__UserId__35BCFE0A");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.TagName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TagPost>(entity =>
            {

                entity.ToTable("TagPost");

                entity.HasOne(d => d.Post)
                    .WithMany()
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__TagPost__PostId__33D4B598");

                entity.HasOne(d => d.Tag)
                    .WithMany()
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK__TagPost__TagId__32E0915F");
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.ToTable("Theme");

                entity.Property(e => e.ThemeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("UserInfo");

                entity.Property(e => e.AboutUser)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Active).IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK__UserInfo__ThemeI__267ABA7A");
            });

            modelBuilder.Entity<UserUser>(entity =>
            {

                entity.ToTable("UserUser");

                entity.HasOne(d => d.UserFollowed)
                    .WithMany()
                    .HasForeignKey(d => d.UserFollowedId)
                    .HasConstraintName("FK__UserUser__UserFo__29572725");

                entity.HasOne(d => d.UserFollowing)
                    .WithMany()
                    .HasForeignKey(d => d.UserFollowingId)
                    .HasConstraintName("FK__UserUser__UserFo__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
