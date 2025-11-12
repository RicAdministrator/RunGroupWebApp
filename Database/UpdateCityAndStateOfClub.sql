USE [RunGroups]

DECLARE @City NVARCHAR(MAX) = 'Quezon City'
DECLARE @State NVARCHAR(MAX) = 'Metro Manila'

UPDATE 
	dbo.Addressses
SET
	City = @City,
	[State] = @State
WHERE
	id IN (3, 5)