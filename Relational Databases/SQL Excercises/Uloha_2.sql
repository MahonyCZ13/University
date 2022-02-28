SELECT Predmet.nazev, Predmet.garant, Zapis.semestr FROM Zapis JOIN Predmet ON(Zapis.kod = Predmet.kod)
WHERE Zapis.semestr = '2010L' AND Predmet.garant <> 'Blaha'