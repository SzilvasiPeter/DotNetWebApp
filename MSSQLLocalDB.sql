CREATE DATABASE MyMovieDB

SELECT NAME FROM sys.Databases

USE MyMovieDB
CREATE TABLE Movies (MovieID INT, NAME NVARCHAR(255), Year INT)
INSERT INTO Movies VALUES (1, "Halloween", 1978)
INSERT INTO Movies VALUES (2, "Psycho", 1960)
INSERT INTO Movies VALUES (3, "The Texas Chainsaw Massacre", 1974)
INSERT INTO Movies VALUES (4, "The Exorcist", 1973)
INSERT INTO Movies VALUES (5, "Night of the Living Dead", 1968)
GO

SELECT * FROM Movies