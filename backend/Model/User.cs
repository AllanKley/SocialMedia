using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class User
    {
        public User()
        {
            Collections = new HashSet<Collection>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string UserName { get; set; } = null!;
        public string? Password { get; set; }
        public string EmailAddress { get; set; } = null!;
        public DateTime? Birthday { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public byte[]? CoverPicture { get; set; }
        public string? AboutUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ThemeId { get; set; }
        public bool? Active {get; set;}

        public virtual Theme? Theme { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
        public virtual ICollection<Post> Posts { get; set; }


        public static List<User> GetAll(){
            using (var context = new SocialMediaContext())
            {
                var usuarios = context.Users.ToList();

                return usuarios;
            }
        }

        public static List<User> GetAllActive(){
            using (var context = new SocialMediaContext())
            {
                var usuarios = context.Users.Where(c => c.Active == true).ToList();

                return usuarios;
            }
        }

        public void Save()
        {
            using(var context = new SocialMediaContext())
            {
                context.Add(this);
                context.SaveChanges();
            }
        }

        public void Update(){
            using(var context = new SocialMediaContext())
            {
                var user = context.Users
                .Where(x => x.Id == this.Id)
                .Single();

                user.FirstName = this.FirstName;
                user.LastName = this.LastName;
                user.UserName = this.UserName;
                user.Password = this.Password;
                user.EmailAddress = this.EmailAddress;
                user.Birthday = this.Birthday;
                user.ProfilePicture = this.ProfilePicture;
                user.CoverPicture = this.CoverPicture;
                user.AboutUser = this.AboutUser;
                
                context.SaveChanges();
            }
        }

        public void UpdateTheme(){
            using(var context = new SocialMediaContext())
            {
                var user = context.Users
                .Where(x => x.Id == this.Id)
                .Single();

                user.Theme = this.Theme;
                
                context.SaveChanges();
            }
        }

        public void Deactivate(int id)

    }
}
