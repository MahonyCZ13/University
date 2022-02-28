SELECT DISTINCT Predmet.nazev, Predmet.garant 
FROM Predmet 
WHERE Predmet.kod
NOT IN (SELECT kod FROM Zapis)