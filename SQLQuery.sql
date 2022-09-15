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

go

insert into Theme values('Midnight')
insert into Theme values('Nature')
insert into Theme values('Lollipop')
insert into Theme values('Default')
insert into Theme values('Dark')
insert into Theme values('Light')

go

insert into UserInfo values('Allan', 'Kley', 'Akaeli', '1234', 'allanlkley@gmail.com', '2000-09-11', cast('foto de perfil' as varbinary(max)), cast('foto de cover' as varbinary(max)), 'minha descrição', '2022-09-01', 1);
insert into UserInfo values('Preston','Woods','pharetra','VKO51NSX2MK','a.aliquet@protonmail.edu','2010-07-17',cast('OYW18WOQ4DJ811YJD13TBU1VA6VUJ62WAG5BT' as varbinary(max)),cast('TIN35NLH6KV684FDI70WQH2NO5GTR91INF3HX' as varbinary(max)),'Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc','2022-05-3',3);
insert into UserInfo values('Iris','Soto','quam','TLL68KTM6DP','eros.turpis@protonmail.edu','2003-08-23',cast('UXD15SUD5GS327JCU44XBX4RN2PIH68IBV5LZ' as varbinary(max)),cast('SQC85XEF8SS855TKV11JED2JW7NCV48ULE1NP' as varbinary(max)),'Pellentesque ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi metus. Vivamus euismod urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed diam','2022-09-5',6);
insert into UserInfo values('Carla','Navarro','tellus','VSI63NTI4IU','lorem@aol.org','1985-02-06',cast('SPR00WNK6NJ958IMU98QXN1FH9HTD28NRR7FN' as varbinary(max)),cast('EKK30MSU3OR742HBD03ZJE9MI7LWP46LOX3VB' as varbinary(max)),'sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum sociis','2021-12-15',3);
insert into UserInfo values('Maxwell','Lawson','mi','CTQ53UDB3KK','quis.arcu@yahoo.edu','2015-12-15',cast('JTO06FDV4MU328ITP19ELI1XV6GNO84RVP8OU' as varbinary(max)),cast('RNT15JZZ1KP446TMO22JTQ2RG5GNB29XNO2MR' as varbinary(max)),'ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet','2021-10-3',6);
insert into UserInfo values('Miranda','Lester','diam','SIY05ECX3AB','sapien.aenean.massa@google.net','1999-04-20',cast('MKJ33HXB7WV018MFV17CYE0OS1EMD79TOI2MS' as varbinary(max)),cast('IXV32NYE3VU577CEU88LNK9NX1CVO67SAA8QD' as varbinary(max)),'risus. Donec egestas. Aliquam nec enim. Nunc ut erat. Sed nunc est, mollis non, cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam vulputate ullamcorper magna. Sed eu eros. Nam consequat dolor vitae dolor.','2022-07-12',2);
insert into UserInfo values('Kermit','Lane','a','DMB45NES8PV','tristique@yahoo.net','2004-12-13',cast('PEM72TCV6XB356DWG95QXN7CN3OKW50SEU9OF' as varbinary(max)),cast('JJE75XXK6PG453GAM28ZQJ7BK2ISK24RKY2VD' as varbinary(max)),'dui. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Aenean eget magna. Suspendisse tristique neque','2022-03-28',6);
insert into UserInfo values ('Pearl','Crawford','Fusce','HJU37UUO1ED','nisi.a.odio@icloud.org','1969-09-10',cast('EAK72IBC3MC451JJQ22KKQ2YR9VZK84YSE0UM' as varbinary(max)),cast('JBL04XAM4WJ174YMW41XLH5CA5JQS81OQT0OG' as varbinary(max)),'rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit','2022-05-28',3);
insert into UserInfo values('Ali','Witt','nisi','ZYH86EBT7PT','metus.vitae@outlook.ca','2005-07-30',cast('SVC82RPX1RQ762ZBG49GCX7RF7VKW84SXN7YE' as varbinary(max)),cast('XLH34KOO6XE255TNG84PEG1LW7RGX67ENQ1IX' as varbinary(max)),'vel, mauris. Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris','2022-05-11',2);
insert into UserInfo values('Brennan','Carlson','eu','EOB53YMK7ZS','odio@icloud.couk','2007-01-05',cast('POL14KMH3QP078GDK25YWC9AM7JIF03MWD2LQ' as varbinary(max)),cast('KXK14FPC7RQ465LUM47LTI4QK9HYD01VTU8KQ' as varbinary(max)),'aliquet. Phasellus fermentum convallis ligula.','2022-06-21',5);
insert into UserInfo values('Hadley','Richmond','id,','JLP53YAI5DQ','elit@icloud.couk','1986-04-18',cast('LLP87MDL2EF112HUP62HJP9TT6SUS76NZH8NG' as varbinary(max)),cast('QSE50QDL2CX779OII69YQP5EV6MWU70VWQ8WR' as varbinary(max)),'sagittis felis. Donec tempor, est ac mattis semper, dui lectus rutrum','2022-01-7',4);
insert into UserInfo values('Chadwick','Stein','facilisis,','ZPC85IKD3CU','posuere.enim.nisl@yahoo.net','2007-10-05',cast('WJZ75EFY6HF310ZUQ66TDN6IP2RCT32NJD4WG' as varbinary(max)),cast('JQQ41TIM5PP440QTG57QPL4PV3TCW51KGP7EJ' as varbinary(max)),'nibh. Aliquam ornare, libero at auctor ullamcorper, nisl arcu iaculis enim, sit amet','2022-06-8',3);
insert into UserInfo values('Dale','Hester','amet','YMX45LKG8EK','consectetuer.adipiscing@aol.com','2021-11-15',cast('FTF48SEK1XR165WWI69LKT3FC9ZLC27RXG7VP' as varbinary(max)),cast('VRI92UNB1WU622HYQ52GIB9FS0MCG34IWN6FP' as varbinary(max)),'ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum','2022-08-19',6);
insert into UserInfo values('Candace','Olsen','non','MTA74KUL7JF','elit@icloud.ca','2012-04-01',cast('YEH76QYS6WY331CYT44EVE4WG5JTG72KNC0DD' as varbinary(max)),cast('FEM17LDT0AL651RDA45XFF5YL6JNO54CTC4NL' as varbinary(max)),'Integer eu lacus. Quisque imperdiet, erat nonummy ultricies ornare, elit elit fermentum risus, at fringilla purus mauris a nunc. In at pede. Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend egestas. Sed pharetra, felis eget varius ultrices,','2022-07-31',5);
insert into UserInfo values('Bell','Marquez','feugiat','CDL26BQL2RO','imperdiet@icloud.couk','2012-06-03',cast('BTW77TIO3LR691VMD50TLH0XM1VHN93OLJ6JC' as varbinary(max)),cast('URE18KWK1HY573GSG88OFN7FQ6BJR70CQI2RZ' as varbinary(max)),'et, rutrum non, hendrerit id, ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet','2022-04-15',2);
insert into UserInfo values('Velma','Hamilton','lobortis','GVU85RYF3FJ','nam.consequat@google.couk','1968-07-20',cast('XIB67KUJ2RI358JFW41GXB9DH2DCM46IHG3KK' as varbinary(max)),cast('HRV86BOW7KN994IKQ11VNV4RU0CSU40MKN1WO' as varbinary(max)),'ut, pellentesque eget, dictum placerat, augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos. Mauris ut quam vel sapien','2022-08-1',2);
insert into UserInfo values('Mallory','Schultz','eu','LXL42UIY5HR','dui@google.ca','1966-09-05',cast('HWJ63DOR5JL428HAF16EHQ6JI6EMD28YQT7NU' as varbinary(max)),cast('BMA70GQG3RN555BCD75ZLS5WT7JTE38SJW1OT' as varbinary(max)),'nulla at sem molestie sodales. Mauris blandit enim consequat purus. Maecenas libero est, congue a, aliquet vel, vulputate eu, odio. Phasellus at augue id ante dictum cursus. Nunc mauris elit,','2022-02-10',4);
insert into UserInfo values('Ima','Foreman','Donec','IUC58YJE6OR','euismod@yahoo.com','2001-09-09',cast('OMO64BUR8WX499YPU97GXE4QI2GIP31SQR4RE' as varbinary(max)),cast('QEO64GJP9MC285UVJ49CJN1UP1RXK73SGQ3GP' as varbinary(max)),'vel est tempor bibendum. Donec felis orci, adipiscing non, luctus sit amet, faucibus ut, nulla. Cras eu tellus eu augue porttitor','2022-02-28',3);
insert into UserInfo values('Price','Levy','leo.','GSG07VWU5TC','nulla.dignissim@yahoo.couk','2009-03-08',cast('MMK54AUK3UP381LPE35MKD7YS1RTP24CXO7UB' as varbinary(max)),cast('ZGY97TJE1RY385KXK11HGS6VX5EMX80OSV6GO' as varbinary(max)),'non, cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam vulputate ullamcorper magna. Sed eu eros. Nam consequat','2021-12-4',5);
insert into UserInfo values('Upton','Vasquez','gravida','JXC84SAW9KX','consequat.auctor.nunc@yahoo.com','1997-04-02',cast('HNU17UQX5GU747URW29VNS4RT1MLG31BXV4JY' as varbinary(max)),cast('DNG87EFW6PE073SSH22AEM3TK6EXQ38IES3XL' as varbinary(max)),'pulvinar arcu et pede. Nunc sed orci lobortis augue scelerisque mollis. Phasellus libero mauris,','2022-01-28',2);
insert into UserInfo values('Erin','Cote','iaculis','RXU31GWI3ZV','dui.quis@yahoo.net','1965-04-17',cast('FIQ10NGQ5PS784OHP42TBR8VB9TBS46YOJ5NP' as varbinary(max)),cast('HAT82SIS6ZX333SVK55YIN6YO2QIS68USN5DG' as varbinary(max)),'sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi.','2022-06-22',2);

go

insert into UserUser values(2,16);
insert into UserUser values(4,12);
insert into UserUser values(4,16);
insert into UserUser values(4,14);
insert into UserUser values(2,19);
insert into UserUser values(9,15);
insert into UserUser values(3,13);
insert into UserUser values(4,21);
insert into UserUser values(5,20);
insert into UserUser values(8,19);
insert into UserUser values(8,21);
insert into UserUser values(4,13);
insert into UserUser values(6,19);
insert into UserUser values(3,19);
insert into UserUser values(7,17);
insert into UserUser values(8,17);
insert into UserUser values(2,15);
insert into UserUser values(5,18);
insert into UserUser values(7,12);
insert into UserUser values(3,20);     

go

insert into Tag values('Photograph')
insert into Tag values('PixelArt')
insert into Tag values('Painting')
insert into Tag values('Character Design')
insert into Tag values('Cosplay')

go

insert into Post values(cast('TIN35NLH6KV684FDI70WQH2NO5GTR91INF3HX' as varbinary(max)), 'minha descrição', '2022-09-01',0, 1);
insert into Post values(cast('TIN35NLH6KV684FDI70WQH2NO5GTR91INF3HX' as varbinary(max)),'Vivamus sit amet risus. Donec egestas. Aliquam nec enim. Nunc','2022-05-3',0,3);
insert into Post values(cast('SQC85XEF8SS855TKV11JED2JW7NCV48ULE1NP' as varbinary(max)),'Pellentesque ultricies dignissim lacus. Aliquam rutrum lorem ac risus. Morbi metus. Vivamus euismod urna. Nullam lobortis quam a felis ullamcorper viverra. Maecenas iaculis aliquet diam. Sed diam','2022-09-5',0,6);
insert into Post values(cast('EKK30MSU3OR742HBD03ZJE9MI7LWP46LOX3VB' as varbinary(max)),'sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum sociis','2021-12-15',0,3);
insert into Post values(cast('RNT15JZZ1KP446TMO22JTQ2RG5GNB29XNO2MR' as varbinary(max)),'ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet','2021-10-3',0,6);
insert into Post values(cast('IXV32NYE3VU577CEU88LNK9NX1CVO67SAA8QD' as varbinary(max)),'risus. Donec egestas. Aliquam nec enim. Nunc ut erat. Sed nunc est, mollis non, cursus non, egestas a, dui. Cras pellentesque. Sed dictum. Proin eget odio. Aliquam vulputate ullamcorper magna. Sed eu eros. Nam consequat dolor vitae dolor.','2022-07-12',0,2);
insert into Post values(cast('JJE75XXK6PG453GAM28ZQJ7BK2ISK24RKY2VD' as varbinary(max)),'dui. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Aenean eget magna. Suspendisse tristique neque','2022-03-28',0,6);
insert into Post values(cast('JBL04XAM4WJ174YMW41XLH5CA5JQS81OQT0OG' as varbinary(max)),'rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit','2022-05-28',0,3);
insert into Post values(cast('XLH34KOO6XE255TNG84PEG1LW7RGX67ENQ1IX' as varbinary(max)),'vel, mauris. Integer sem elit, pharetra ut, pharetra sed, hendrerit a, arcu. Sed et libero. Proin mi. Aliquam gravida mauris','2022-05-11',0,2);
insert into Post values(cast('KXK14FPC7RQ465LUM47LTI4QK9HYD01VTU8KQ' as varbinary(max)),'aliquet. Phasellus fermentum convallis ligula.','2022-06-21',0,5);
insert into Post values(cast('QSE50QDL2CX779OII69YQP5EV6MWU70VWQ8WR' as varbinary(max)),'sagittis felis. Donec tempor, est ac mattis semper, dui lectus rutrum','2022-01-7',1,4);
insert into Post values(cast('JQQ41TIM5PP440QTG57QPL4PV3TCW51KGP7EJ' as varbinary(max)),'nibh. Aliquam ornare, libero at auctor ullamcorper, nisl arcu iaculis enim, sit amet','2022-06-8',1,3);
insert into Post values(cast('VRI92UNB1WU622HYQ52GIB9FS0MCG34IWN6FP' as varbinary(max)),'ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum','2022-08-19',1,6);
insert into Post values(cast('FEM17LDT0AL651RDA45XFF5YL6JNO54CTC4NL' as varbinary(max)),'Integer eu lacus. Quisque imperdiet, erat nonummy ultricies ornare, elit elit fermentum risus, at fringilla purus mauris a nunc. In at pede. Cras vulputate velit eu sem. Pellentesque ut ipsum ac mi eleifend egestas. Sed pharetra, felis eget varius ultrices,','2022-07-31',1,5);
insert into Post values(cast('URE18KWK1HY573GSG88OFN7FQ6BJR70CQI2RZ' as varbinary(max)),'et, rutrum non, hendrerit id, ante. Nunc mauris sapien, cursus in, hendrerit consectetuer, cursus et, magna. Praesent interdum ligula eu enim. Etiam imperdiet','2022-04-15',1,2);
insert into Post values(cast('HRV86BOW7KN994IKQ11VNV4RU0CSU40MKN1WO' as varbinary(max)),'ut, pellentesque eget, dictum placerat, augue. Sed molestie. Sed id risus quis diam luctus lobortis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos hymenaeos. Mauris ut quam vel sapien','2022-08-1',1,2);

go

insert into comment values(12,1);
insert into comment values(12,4);
insert into comment values(12,9);
insert into comment values(11,7);
insert into comment values(14,6);
insert into comment values(15,8);
insert into comment values(12,8);
insert into comment values(11,10);
insert into comment values(12,3);
insert into comment values(15,10);
insert into comment values(12,4);
insert into comment values(14,10);
insert into comment values(13,15);
insert into comment values(14,13);
insert into comment values(12,6);
insert into comment values(12,15);
insert into comment values(12,1);
insert into comment values(15,1);
insert into comment values(15,16);
insert into comment values(12,3);

go

insert into PostLike values(14,9);
insert into PostLike values(8,11);
insert into PostLike values(15,6);
insert into PostLike values(3,5);
insert into PostLike values(9,2);
insert into PostLike values(15,2);
insert into PostLike values(6,7);
insert into PostLike values(14,12);
insert into PostLike values(5,14);
insert into PostLike values(14,3);
insert into PostLike values(3,13);
insert into PostLike values(2,9);
insert into PostLike values(17,10);
insert into PostLike values(16,13);
insert into PostLike values(6,12);
insert into PostLike values(13,5);
insert into PostLike values(3,7);
insert into PostLike values(2,13);
insert into PostLike values(17,4);
insert into PostLike values(6,1);

go

insert into Collection values('tincidunt','eu enim. Etiam','2021-09-16',1,14);
insert into Collection values('enim, sit','dis parturient montes, nascetur ridiculus mus.','2021-12-5',0,8);
insert into Collection values('inceptos','lorem, auctor quis, tristique','2021-11-13',1,15);
insert into Collection values('Cras dolor dolor,','egestas. Fusce aliquet magna a neque. Nullam','2022-03-15',1,3);
insert into Collection values('lacinia','cursus, diam at pretium aliquet, metus urna','2022-03-25',0,9);
insert into Collection values('nascetur ridiculus mus.','Integer id','2022-07-15',1,15);
insert into Collection values('eu','posuere at, velit. Cras lorem lorem, luctus ut, pellentesque eget,','2022-04-28',0,6);
insert into Collection values('Mauris magna.','mi. Duis risus odio, auctor vitae, aliquet','2021-11-10',1,14);
insert into Collection values('accumsan convallis,','libero et tristique pellentesque, tellus sem mollis dui, in','2021-11-9',0,5);
insert into Collection values('vulputate','purus, in molestie tortor nibh sit amet orci.','2022-06-1',0,14);
insert into Collection values('Fusce aliquet magna','ut cursus luctus, ipsum leo elementum','2021-11-16',0,3);
insert into Collection values('lacus pede','ligula. Donec luctus aliquet odio. Etiam ligula tortor,','2022-07-3',0,2);

go

insert into CollectionPost values(1,6);
insert into CollectionPost values(2,9);
insert into CollectionPost values(5,3);
insert into CollectionPost values(6,4);
insert into CollectionPost values(9,9);
insert into CollectionPost values(11,7);
insert into CollectionPost values(9,4);
insert into CollectionPost values(6,4);
insert into CollectionPost values(8,6);
insert into CollectionPost values(2,1);
insert into CollectionPost values(2,9);
insert into CollectionPost values(11,4);
insert into CollectionPost values(1,1);
insert into CollectionPost values(5,2);
insert into CollectionPost values(2,6);
insert into CollectionPost values(8,7);
insert into CollectionPost values(12,4);
insert into CollectionPost values(6,5);
insert into CollectionPost values(5,9);
insert into CollectionPost values(2,9);