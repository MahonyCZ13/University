CREATE PROCEDURE ROKNAR (
	@jmeno VARCHAR(20)
)
AS
BEGIN

DECLARE @vysledek VARCHAR(2)

SET @vysledek = (SELECT SUBSTRING(dbo.Student.rc, 1, 2) AS prvni FROM dbo.Student WHERE Student.jmeno LIKE '%' + @jmeno)

IF @vysledek > 22
	PRINT '19' + @vysledek
ELSE
	PRINT '20' + @vysledek

END