CREATE OR REPLACE DATABASE [MoviesDB]
GO
USE [Movies]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor/Actress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NULL,
	[LastName] [varchar](20) NULL,
	[Gender] [varchar](1) NULL,
 CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieCast](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ActorId] [int] NOT NULL,
	[MovieId] [int] NULL,
	[Role] [varchar](30) NULL,
 CONSTRAINT [PK_MovieCast] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Year] [int] NULL,
	[MovieLength] [int] NULL,
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovieGenre]    Script Date: 08/05/2022 23:14:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovieGenre](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GenreId] [int] NULL,
	[MovieId] [int] NULL,
 CONSTRAINT [PK_MovieGenre] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenresName](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MovieGenre] [varchar](20) NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actor/Actress] ON 
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (1, N'James', N'Stewart', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (2, N'Deborah', N'Kerr', N'F')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (3, N'Peter', N'OToole', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (4, N'Robert', N'DeNiro', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (6, N'Harrison', N'Ford', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (7, N'Stephen', N'Baldwin', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (8, N'Jack', N'Nicholson', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (9, N'Mark', N'Wahlberg', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (10, N'Woody', N'Allen', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (11, N'Claire', N'Danes', N'F')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (12, N'Tim', N'Robbins', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (13, N'Kevin', N'Spacey', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (14, N'Kate', N'Winslet', N'F')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (15, N'Robin', N'Williams', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (16, N'Jon', N'Voight', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (17, N'Ewan', N'McGregor', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (18, N'Christian', N'Bale', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (19, N'Maggie', N'Gyllenhaal', N'F')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (20, N'Dev', N'Patel', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (21, N'Sigourney', N'Weaver', N'F')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (22, N'David', N'Aston', N'M')
GO
INSERT [dbo].[Actor/Actress] ([Id], [FirstName], [LastName], [Gender]) VALUES (23, N'Ali', N'Astin', N'F')
GO
SET IDENTITY_INSERT [dbo].[Actor/Actress] OFF
GO
SET IDENTITY_INSERT [dbo].[MovieCast] ON 
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (1, 1, 1, N'John Scottie Ferguson')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (2, 2, 2, N'Miss Giddens')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (3, 3, 3, N'T.E. Lawrence')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (4, 4, 4, N'Michael')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (5, 6, 6, N'Rick Deckard')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (6, 7, 8, N'McManus')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (7, 9, 10, N'Eddie Adams')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (8, 10, 11, N'Alvy Singer')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (9, 11, 12, N'San')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (10, 12, 13, N'Andy Dufresne')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (11, 13, 14, N'Lester Burnham')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (12, 14, 15, N'Rose DeWitt Bukater')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (13, 15, 16, N'Sean Maguire')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (14, 16, 17, N'Ed')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (15, 17, 18, N'Renton')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (16, 19, 20, N'Elizabeth Darko')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (17, 20, 21, N'Older Jamal')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (18, 21, 22, N'Ripley')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (19, 13, 23, N'Bobby Darin')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (20, 8, 9, N'J.J. Gittes')
GO
INSERT [dbo].[MovieCast] ([Id], [ActorId], [MovieId], [Role]) VALUES (21, 18, 19, N'Alfred Borden')
GO
SET IDENTITY_INSERT [dbo].[MovieCast] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (1, N'Vertigo', 1958, 128)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (2, N'The Innocents', 1961, 100)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (3, N'Lawrence of Arabia', 1962, 216)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (4, N'The Deer Hunter', 1978, 183)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (5, N'Amadeus', 1984, 160)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (6, N'Blade Runner', 1982, 117)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (7, N'Eyes Wide Shut', 1999, 159)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (8, N'The Usual Suspects', 1995, 106)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (9, N'Chinatown', 1974, 130)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (10, N'Boogie Nights', 1997, 155)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (11, N'Annie Hall', 1977, 93)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (12, N'Princess Mononoke', 1997, 134)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (13, N'The Shawshank Redemption', 1994, 142)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (14, N'American Beauty', 1999, 122)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (15, N'Titanic', 1997, 194)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (16, N'Good Will Hunting ', 1997, 126)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (17, N'Deliverance', 1972, 109)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (18, N'Trainspotting', 1996, 94)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (19, N'The Prestige', 2006, 130)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (20, N'Donnie Darko', 2001, 113)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (21, N'Slumdog Millionaire', 2008, 120)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (22, N'Aliens', 1986, 137)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (23, N'Beyond the Sea', 2004, 118)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (24, N'Avatar', 2009, 162)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (25, N'Braveheart', 1995, 178)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (26, N'Seven Samurai', 1954, 207)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (27, N'Spirited Away', 2001, 125)
GO
INSERT [dbo].[Movies] ([Id], [Name], [Year], [MovieLength]) VALUES (28, N'Back to the Future ', 1985, 116)
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[MovieGenre] ON 
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (1, 1, 22)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (2, 2, 17)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (3, 2, 3)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (4, 3, 12)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (5, 5, 11)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (6, 6, 8)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (7, 6, 13)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (8, 7, 26)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (9, 7, 28)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (10, 7, 18)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (11, 7, 21)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (12, 8, 2)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (13, 9, 23)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (14, 10, 7)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (15, 10, 27)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (16, 10, 1)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (17, 11, 14)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (18, 12, 6)
GO
INSERT [dbo].[MovieGenre] ([Id], [GenreId], [MovieId]) VALUES (19, 13, 4)
GO
SET IDENTITY_INSERT [dbo].[MovieGenre] OFF
GO
SET IDENTITY_INSERT [dbo].[GenresName] ON 
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (1, N'Action')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (2, N'Adventure')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (3, N'Animation')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (4, N'Biography')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (5, N'Comedy')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (6, N'Crime')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (7, N'Drama')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (8, N'Horror')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (9, N'Musical')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (10, N'Mystery')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (11, N'Romance')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (12, N'Thriller')
GO
INSERT [dbo].[GenresName] ([Id], [MovieGenre]) VALUES (13, N'War')
GO
SET IDENTITY_INSERT [dbo].[GenresName] OFF
GO
ALTER TABLE [dbo].[MovieCast]  WITH CHECK ADD  CONSTRAINT [FK__ElencoFil__IdAto__2C3393D0] FOREIGN KEY([ActorId])
REFERENCES [dbo].[Actor/Actress] ([Id])
GO
ALTER TABLE [dbo].[MovieCast] CHECK CONSTRAINT [FK__ElencoFil__IdAto__2C3393D0]
GO
ALTER TABLE [dbo].[MovieCast]  WITH CHECK ADD  CONSTRAINT [FK__ElencoFil__IdFil__2D27B809] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movies] ([Id])
GO
ALTER TABLE [dbo].[MovieCast] CHECK CONSTRAINT [FK__ElencoFil__IdFil__2D27B809]
GO
ALTER TABLE [dbo].[MovieGenre]  WITH CHECK ADD  CONSTRAINT [FK__FilmesGen__IdFil__2F10007B] FOREIGN KEY([MovieId])
REFERENCES [dbo].[Movies] ([Id])
GO
ALTER TABLE [dbo].[MovieGenre] CHECK CONSTRAINT [FK__FilmesGen__IdFil__2F10007B]
GO
ALTER TABLE [dbo].[MovieGenre]  WITH CHECK ADD  CONSTRAINT [FK__FilmesGen__IdGen__2E1BDC42] FOREIGN KEY([GenreId])
REFERENCES [dbo].[GenresName] ([Id])
GO
ALTER TABLE [dbo].[MovieGenre] CHECK CONSTRAINT [FK__FilmesGen__IdGen__2E1BDC42]
GO
