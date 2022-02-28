SELECT Predmet.nazev, MIN(Zapis.znamka) AS 'Nejlepsi znamka' 
FROM Predmet 
JOIN 
    Zapis ON(Predmet.kod = Zapis.kod) 
GROUP BY Predmet.nazev