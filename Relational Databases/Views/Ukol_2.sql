-- Pohled neni aktualizovatelny
SELECT ZBOZ.KAT AS 'Kategorie', SUM(POLOZ.VCEN) AS 'Celokova Cena', SUM(POLOZ.MNOZ) AS 'Mnozstvi' 
FROM POLOZ 
JOIN ZBOZ ON(POLOZ.KOD = ZBOZ.KOD) 
GROUP BY ZBOZ.KAT;