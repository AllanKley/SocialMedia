using Model;
using Bogus;
using System.Linq;
using static System.Text.Encoding;

using (var context = new SocialMediaContext()){
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();


    // Theme Faker ------------------------
    var themes = new string[] {"Midnight", "Nature", "Lollipop", "Default", "Dark", "Light"};
    var ThemeFaker = themes.Select(theme => new Theme(theme)).ToList();
    context.Themes.AddRange(ThemeFaker);
    context.SaveChanges();
    ThemeFaker.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

    // User Faker ------------------------
    var UserFaker = new Faker<User>("pt_BR")
    .RuleFor(c => c.FirstName, f => f.Name.FirstName())
    .RuleFor(c => c.LastName, f => f.Name.LastName())
    .RuleFor(c => c.AboutUser, f => string.Join(" ", f.Lorem.Words(5)))
    .RuleFor(c => c.Active, f => f.PickRandom(new bool[] {true, false}))
    .RuleFor(c => c.Birthday, f => f.Date.Between(DateTime.Parse("1950-05-05"), DateTime.Parse("2006-05-05")))
    .RuleFor(c => c.CreationDate, f => f.Date.Recent(500))
    .RuleFor(c => c.EmailAddress, (f, user) => f.Internet.Email(user.FirstName, user.LastName).ToLower())
    .RuleFor(c => c.Password, f => f.Internet.Password())
    .RuleFor(c => c.Theme, f => f.PickRandom(ThemeFaker))
    .RuleFor(c => c.UserName, (f, user) => f.Internet.UserName(user.FirstName, user.LastName))
    .RuleFor(c => c.ProfilePicture, f => ASCII.GetBytes(f.Internet.Avatar()))
    .RuleFor(c => c.CoverPicture, f => ASCII.GetBytes(f.Image.Nature(640, 480)));
    var users = UserFaker.Generate(500);
    context.Users.AddRange(users);
    context.SaveChanges();
    users.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

    // UserUser Faker ----------------------
    var UserUserFaker = new Faker<UserUser>("pt_BR")
    .RuleFor(c => c.UserFollowed, f => f.PickRandom(users))
    .RuleFor(c => c.UserFollowing, (f, user) => f.PickRandom(users.Where(u => u.Id != user.UserFollowed.Id)));
    var userUsers = UserUserFaker.Generate(50);
    context.UserUsers.AddRange(userUsers);
    context.SaveChanges();
    userUsers.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);


    // Tag Faker ---------------------------
    var TagFaker = new string[] {"Photograph", "PixelArt", "Painting", "Character Design", "Cosplay"};
    var tags = TagFaker.Select(tag => new Tag(tag)).ToList();
    context.Tags.AddRange(tags);
    context.SaveChanges();
    tags.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

    // Post Faker --------------------------
    var PostFaker = new Faker<Post>("pt_BR")
    .RuleFor(c => c.Description, f => string.Join(" ", f.Lorem.Words(5)))
    .RuleFor(c => c.CreationDate, f => f.Date.Recent(500))
    .RuleFor(c => c.User, f => f.PickRandom(users))
    .RuleFor(c => c.Comment, f => f.PickRandom(new bool[] {true, false}));
    var posts = PostFaker.Generate(500);
    context.Posts.AddRange(posts);
    context.SaveChanges();
    posts.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

    // Picture Faker -----------------------
    var PictureFaker = new Faker<Picture>("pt_BR")
    .RuleFor(c => c.PictureString, f => ASCII.GetBytes(f.Image.PicsumUrl()))
    .RuleFor(c => c.Post, f => f.PickRandom(posts));
    var pictures = PictureFaker.Generate(50);
    context.Pictures.AddRange(pictures);
    context.SaveChanges();
    pictures.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

    // TagPost Faker -----------------------
    var TagPostFaker = new Faker<TagPost>("pt_BR")
    .RuleFor(c => c.Tag, f => f.PickRandom(tags))
    .RuleFor(c => c.Post, f => f.PickRandom(posts));
    var tagPosts = TagPostFaker.Generate(100);
    context.TagPosts.AddRange(tagPosts);
    context.SaveChanges();
    tagPosts.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);

    // PostLike Faker -----------------------
    var PostLikeFaker = new Faker<PostLike>("pt_BR")
    .RuleFor(c => c.User, f => f.PickRandom(users))
    .RuleFor(c => c.Post, f => f.PickRandom(posts));
    var postLikes = PostLikeFaker.Generate(100);
    context.PostLikes.AddRange(postLikes);
    context.SaveChanges();
    postLikes.ForEach(t => context.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged);


    // Comment Faker -----------------------
    // var CommentFaker = new Faker<Comment>("pt_BR")
    // .RuleFor(c => c.Comment, f => f.PickRandom(posts.Where(p => p.Comment == true)))
    // .RuleFor(c => c.Post, f => f.PickRandom(posts));

}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
