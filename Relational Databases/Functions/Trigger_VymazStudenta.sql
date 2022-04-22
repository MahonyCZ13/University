CREATE TRIGGER Vymaz_Studenta ON dbo.Student FOR DELETE
AS
BEGIN
	INSERT INTO dbo.Vyrazeni_Studenti (rc, jmeno, specializace) 
		SELECT rc, jmeno, specializace FROM deleted d
END
