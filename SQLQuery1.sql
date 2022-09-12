create table Theme (
 Id int identity primary key,
 ThemeName varchar(50),
);

go

create table UserInfo (
	Id int identity primary key,
	FirstName varchar(50) not null,
	LastName varchar(50),
	UserName varchar(70) not null,
	Password varchar(max),
	EmailAddress varchar(254) not null,
	Birthday date,
	ProfilePicture varbinary(max),
	CoverPicture varbinary(max),
	AboutUser varchar(300),
	CreationDate datetime,
	ThemeId int FOREIGN KEY REFERENCES Theme(Id)
);

go

create table UserUser (
	UserFollowingId int FOREIGN KEY REFERENCES UserInfo(Id),
	UserFollowedId int FOREIGN KEY REFERENCES UserInfo(Id)
);

go

create table Tag (
	Id int identity primary key,
	TagName varchar(50)
);

go

create table Post (
	Id int identity primary key,
	Picture varbinary(max),
	Description varchar(300),
	CreationDate datetime not null,
	Comment bit,
	UserId int FOREIGN KEY REFERENCES UserInfo(Id)
);

go

create table TagPost (
	TagId int FOREIGN KEY REFERENCES Tag(Id),
	PostId int FOREIGN KEY REFERENCES Post(Id)
);

go

create table PostLike (
	UserId int FOREIGN KEY REFERENCES UserInfo(Id),
	PostId int FOREIGN KEY REFERENCES Post(Id)
);

go

create table Collection (
	Id int identity primary key,
	CollectionName varchar(40) not null,
	Description varchar(300),
	CreationDate datetime,
	Secret bit,
	UserId int FOREIGN KEY REFERENCES UserInfo(Id),
);

go

create table CollectionPost (
	CollectionId int FOREIGN KEY REFERENCES Collection(Id),
	PostId int FOREIGN KEY REFERENCES Post(Id)
);

go

create table Comment (
	CommentId int FOREIGN KEY REFERENCES Post(Id),
	PostId int FOREIGN KEY REFERENCES Post(Id)
);