SELECT Predmet.garant, COUNT(Predmet.kod) AS 'Pocet predmetu' 
FROM Predmet 
GROUP BY Predmet.garant
HAVING COUNT(Predmet.kod) > 1