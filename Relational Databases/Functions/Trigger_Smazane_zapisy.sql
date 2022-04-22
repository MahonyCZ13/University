CREATE TRIGGER Zaloha ON dbo.Predmet FOR DELETE
AS
BEGIN
DECLARE
	@semestr VARCHAR(50),
	@jmeno VARCHAR(50),
	@specializace VARCHAR(50),
	@predmet VARCHAR(50),
	@znamka INT

IF NOT EXISTS (SELECT * FROM sys.tables WHERE name='Smazane_zapisy')
    CREATE TABLE Smazane_zapisy (
        semestr VARCHAR(50),
		jmeno VARCHAR(50),
		specializace VARCHAR(50),
		predmet VARCHAR(50),
		znamka INT
    )

SET @semestr = (SELECT Zapis.semestr FROM deleted d JOIN Zapis ON(d.kod = Zapis.kod) WHERE Zapis.kod = d.kod)
SET @jmeno = (SELECT Student.jmeno FROM deleted d JOIN Zapis ON(d.kod = Zapis.kod) JOIN Student ON (Zapis.rc = Student.rc))
SET @specializace = (SELECT Student.specializace FROM deleted d JOIN Zapis ON(d.kod = Zapis.kod) JOIN Student ON (Zapis.rc = Student.rc))
SET @predmet = (SELECT nazev FROM deleted d)
SET @znamka = (SELECT Zapis.znamka FROM deleted d JOIN Zapis ON(d.kod = Zapis.kod) WHERE Zapis.kod = d.kod)

INSERT INTO Smazane_zapisy (semestr, jmeno, specializace, predmet, znamka) VALUES (@semestr, @jmeno, @specializace, @predmet, @znamka)

END