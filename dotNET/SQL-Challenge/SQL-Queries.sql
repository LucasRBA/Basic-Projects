--1)
 SELECT Name, Year FROM dbo.Movies;

 --2)
 SELECT Name, Year, MovieLength 
    FROM dbo.Movies
    ORDER BY Year;

--3)
SELECT Name, Year, MovieLength 
    FROM dbo.Movies
    Where Year=1985;

--4)
SELECT Name, Year, MovieLength 
    FROM dbo.Movies
    Where Year=1997;

--5)
SELECT Name, Year, MovieLength 
    FROM dbo.Movies
    Where Year>2000;   

--6)
SELECT Name, Year, MovieLength 
    FROM dbo.Movies
    WHERE MovieLength > 100
    ORDER BY MovieLength; 

--7)
SELECT Year,COUNT(*) AS NumberOfMovies
FROM dbo.Movies
GROUP BY Year
ORDER BY NumberOfMovies DESC;

--8)
SELECT * FROM dbo.[Actor/Actress]
    WHERE Gender = 'M';

--9)
SELECT * FROM dbo.[Actor/Actress]
    WHERE Gender = 'F'
    ORDER BY FirstName;

--10)
SELECT dbo.Movies.Name, dbo.GenresName.MovieGenre  FROM dbo.Movies
    JOIN dbo.MovieGenre 
    ON dbo.Movies.Id = dbo.MovieGenre.MovieId
    JOIN dbo.GenresName
    ON dbo.MovieGenre.GenreId = dbo.GenresName.Id;

--11)
SELECT dbo.Movies.Name, dbo.GenresName.MovieGenre  FROM dbo.Movies
    JOIN dbo.MovieGenre 
    ON dbo.Movies.Id = dbo.MovieGenre.MovieId
    JOIN dbo.GenresName
    ON dbo.MovieGenre.GenreId = dbo.GenresName.Id
    WHERE dbo.GenresName.MovieGenre = 'Mystery';

--12)
SELECT M.[Name],AA.[FirstName] AS 'First Name',AA.[LastName] AS 'Last Name',MC.[Role] AS Role
    FROM [dbo].[Movies] M
    JOIN [dbo].[MovieCast] MC 
    ON M.[Id] = MC.[MovieId]
    JOIN [dbo].[Actor/Actress] AA 
    ON MC.[ActorId] = AA.[Id];
