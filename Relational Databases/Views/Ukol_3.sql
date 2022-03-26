-- Pohled neni aktualizovatelny
CREATE VIEW MojeObjednavky AS
SELECT ZAK.[LOG] AS 'User', OBJ.DAT, OBJ.DATOD, SUM(POLOZ.VCEN) AS 'Celkova Cena', SUM(POLOZ.MNOZ) AS 'Mnozstvi' --OBJ.DAT, OBJ.DATOD,
FROM POLOZ 
JOIN OBJ ON(POLOZ.CISO = OBJ.CISO) JOIN ZAK ON(OBJ.ZAK = ZAK.[LOG])
WHERE ZAK.[LOG] IN 
(
    DECLARE @user AS VARCHAR(10) = 'rubek'    
    SELECT ZAK.[LOG] 
    FROM ZAK 
    WHERE ZAK.[LOG] = @user
)    
GROUP BY ZAK.[LOG];