/*CREATE TABLE [dbo].[Car]
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] SMALLINT NOT NULL, 
    [DailyPrice] MONEY NOT NULL, 
    [Description] NVARCHAR(100) NULL
);

CREATE TABLE [dbo].[Brand]
(
	[BrandId] INT NOT NULL PRIMARY KEY, 
    [BrandName] NVARCHAR(100) NOT NULL
);

CREATE TABLE [dbo].[Color]
(
	[ColorId] INT NOT NULL PRIMARY KEY, 
    [ColorName] NVARCHAR(100) NOT NULL
);*/
/*
INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (1,1,1,2019,21000,'Yeni gibi');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (2,7,3,2020,1800,'Hasarli');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (3,2,5,2001,1000,'Uzun yol araci');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (4,4,7,2008,10000, 'taksi');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (5,3,2,2007,8000, 'tamir gormus');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (6,3,4,2006,5000, 'taksi');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (7,4,6,2005,15000, 'ic dekorasyon');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (8,5,8,2021,50000, 'sifir');

INSERT INTO [dbo].[Car] ([CarId], [BrandId],[ColorId],[ModelYear],[DailyPrice],[Description])
VALUES (9,6,9,2021,45000, 'sifir gibi');
*/
 insert into [dbo].[Brand] (BrandId, BrandName) values (1, 'Audi');
 insert into [dbo].[Brand] (BrandId, BrandName) values (2, 'BMW');
 insert into [dbo].[Brand] (BrandId, BrandName) values (3, 'Mercedes - AMG');
 insert into [dbo].[Brand] (BrandId, BrandName) values (4, 'Mercedes - Benz');
 insert into [dbo].[Brand] (BrandId, BrandName) values (5, 'Opel');
 insert into [dbo].[Brand] (BrandId, BrandName) values (6, 'Porsche');
 insert into [dbo].[Brand] (BrandId, BrandName) values (7, 'Volkswagen');  
 

 insert into [dbo].[Color] (ColorId, ColorName) values (1,'Red');
 insert into [dbo].[Color] (ColorId, ColorName) values (2,'Orange');
 insert into [dbo].[Color] (ColorId, ColorName) values (3,'Yellow');
 insert into [dbo].[Color] (ColorId, ColorName) values (4,'Green');
 insert into [dbo].[Color] (ColorId, ColorName) values (5,'Blue');
 insert into [dbo].[Color] (ColorId, ColorName) values (6,'Cyan');
 insert into [dbo].[Color] (ColorId, ColorName) values (7,'Purple');
 insert into [dbo].[Color] (ColorId, ColorName) values (8,'White');
 insert into [dbo].[Color] (ColorId, ColorName) values (9,'Black');