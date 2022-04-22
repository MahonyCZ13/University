CREATE PROCEDURE SEX (
	@jmeno VARCHAR(20)
)
AS
BEGIN

DECLARE @vysledek VARCHAR(1)

SET @vysledek = (SELECT SUBSTRING(dbo.Student.rc, 3, 1) AS prvni FROM dbo.Student WHERE Student.jmeno LIKE '%' + @jmeno)

IF @vysledek > 1
	PRINT 'F'
ELSE
	PRINT 'M'

END