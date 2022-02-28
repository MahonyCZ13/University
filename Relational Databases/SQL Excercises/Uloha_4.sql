SELECT Predmet.nazev, AVG(Zapis.znamka) AS 'Prumer'
FROM Zapis JOIN Predmet ON(Predmet.kod = Zapis.kod) GROUP BY Predmet.nazev