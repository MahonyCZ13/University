CREATE PROCEDURE Znamka_zapis (
	@rc VARCHAR(11),
	@kod VARCHAR(5),
	@semestr VARCHAR(5),
	@znamka INT
)
AS
BEGIN

DECLARE @prumer FLOAT

INSERT INTO Zapis (rc, kod, semestr, znamka) VALUES (@rc, @kod, @semestr, @znamka)

SET @prumer = (SELECT AVG(Zapis.znamka) FROM Zapis WHERE Zapis.rc = @rc AND @kod IN (SELECT Zapis.kod FROM Zapis WHERE Zapis.kod = @kod))

PRINT @prumer
PRINT @semestr
PRINT @kod

END