SELECT Student.jmeno, COUNT(Zapis.kod) AS 'Pocet zapsanych predmetu' FROM Student JOIN Zapis ON(Zapis.rc = Student.rc) GROUP BY Student.jmeno