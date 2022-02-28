SELECT DISTINCT Predmet.nazev FROM Predmet JOIN Zapis ON(Zapis.kod = Predmet.kod) JOIN Student ON(Student.rc = Zapis.rc)
WHERE Student.jmeno = 'Jan Fejfar'