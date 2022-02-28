SELECT Student.jmeno, Predmet.nazev, Zapis.semestr, Zapis.znamka 
FROM Zapis 
    JOIN 
        Predmet ON(Zapis.kod = Predmet.kod) 
    JOIN 
        Student ON(Zapis.rc = Student.rc) 
    WHERE 
        Zapis.semestr LIKE '%L'
    ORDER BY Zapis.semestr, Predmet.nazev ASC