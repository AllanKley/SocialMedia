using Model;
using Bogus;
using static System.Text.Encoding;

using (var context = new SocialMediaContext()){
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    var t = new string[] {"Midnight", "Nature", "Lollipop", "Default", "Dark", "Light"};
    var ThemeFaker = t.Select(theme => new Theme(theme));

    context.Themes.AddRange(ThemeFaker);
    context.SaveChanges();

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
    users.ForEach(u => {context.Entry(u.Theme).State = Microsoft.EntityFrameworkCore.EntityState.Unchanged;});
    context.SaveChanges(); 
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
