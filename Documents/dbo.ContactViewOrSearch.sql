ALTER PROCEDURE dbo.ContactViewOrSearch
@ContactName nvarchar(50)
AS
	SELECT *
	FROM tab_contato
	WHERE name LIKE @ContactName+'%'