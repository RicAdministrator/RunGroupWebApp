USE [RunGroups]

SELECT * FROM [dbo].[Addressses] -- has data after seed
SELECT * FROM [dbo].[AspNetRoleClaims]	
SELECT * FROM [dbo].[AspNetRoles] -- has data after seed
SELECT * FROM [dbo].[AspNetUserClaims]
SELECT * FROM [dbo].[AspNetUserLogins]
SELECT * FROM [dbo].[AspNetUserRoles] --
SELECT * FROM [dbo].[AspNetUsers] --
SELECT * FROM [dbo].[AspNetUserTokens]
SELECT * FROM [dbo].[Clubs] --
SELECT * FROM [dbo].[Races] --

---------------------------------------------


SELECT * FROM dbo.Clubs WHERE Id = 1

--UPDATE 
--	dbo.Clubs 
--SET 
--	[Description] = 'Running Club 1 description', 
--	AppUserId = '2712bb9f-31f1-4361-98fb-e1739c575169'
--WHERE 
--	Id = 1

--UPDATE 
--	dbo.Clubs
--SET
--	AppUserId = '6c402275-1721-4c21-8265-a0b99ed65242'
--WHERE
--	Id = 2

-------------------------------------------------------------------------------------------------------------------------------------

SELECT * FROM dbo.Races

--DELETE FROM dbo.Races WHERE Id = 4

--UPDATE 
--	dbo.Races 
--SET 
--	Title = 'Running Race 3',
--	[Description] = 'Running Race 3 description',
--	[Image] = 'https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360' 
--WHERE 
--	Id = 5

--UPDATE 
--	dbo.Races
--SET 
--	AppUserId = '2712bb9f-31f1-4361-98fb-e1739c575169'
--WHERE
--	Id = 1
-------------------------------------------------------------------------------------------------------------------------------------	
SELECT 
	* 
FROM 
	dbo.AspNetUsers anu INNER JOIN
	dbo.AspNetUserRoles anur ON anu.Id = anur.UserId

--DELETE FROM dbo.AspNetUsers WHERE Id = '5dfbe676-13bf-4064-b9b5-ca2b48b945ef'

--UPDATE 
--	dbo.AspNetUsers
--SET
--	Pace = 2,
--	Mileage = 2,
--	ProfileImageUrl = 'https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360',
--	City = 'Antipolo',
--	[State] = 'Rizal'
--WHERE
--	Id = '2712bb9f-31f1-4361-98fb-e1739c575169'

--UPDATE 
--	dbo.AspNetUsers
--SET
--	Pace = 3,
--	Mileage = 4,
--	ProfileImageUrl = 'https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360'
--WHERE
--	Id = '5b56925b-9650-4134-b37a-9f5018e9d6aa'

--UPDATE 
--	dbo.AspNetUsers
--SET
--	Email = 'rmarinas@gmail.com',
--	NormalizedEmail = 'RMARINAS@GMAIL.COM',
--	ProfileImageUrl = 'https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360'
--WHERE
--	Id = '6c402275-1721-4c21-8265-a0b99ed65242'


-------------------------------------------------------------------------------------------------------------------------------------
