BEGIN TRANSACTION

CREATE TABLE staty (
  cid int NOT NULL IDENTITY(1,1) PRIMARY KEY,
  nazev varchar(20) DEFAULT NULL,
  rozloha int DEFAULT NULL,
  obyvatelstvo int DEFAULT NULL
)

INSERT INTO staty (nazev, rozloha, obyvatelstvo) VALUES
('Norsko', 385207, 5425270),
('Svedsko', 450285, 10402000),
('Finsko', 338455, 5538000),
('Dansko', 42933, 5873000),
('Kanada', 9984000, 38526000),
('Rusko', 17098000, 145578000),
('Gronsko', 2166000, 56081),
('Island', 102775, 371580),
('USA', 3796000, 331893000);

CREATE TABLE mesta (
  mid int NOT NULL IDENTITY(1,1) PRIMARY KEY,
  cid int NOT NULL,
  nazev varchar(20) DEFAULT NULL,
  rozloha int DEFAULT NULL,
  obyvatele int DEFAULT NULL,
  temp int DEFAULT NULL,
  FOREIGN KEY (cid) REFERENCES staty(cid)
) 

INSERT INTO mesta (cid, nazev, rozloha, obyvatele, temp) VALUES
(1, 'Oslo', 480, 698000, 12),
(1, 'Bergen', 464, 285000, 16),
(1, 'Alta', 3849, 20789, 11),
(1, 'Longyearbyen', 850, 2386, -7),
(2, 'Stockholm', 563, 850000, 15),
(2, 'Malmo', 252, 152000, 16),
(2, 'Jokkmokk', 56, 452, 11),
(3, 'Helsinky', 495, 482000, 12),
(3, 'Tampere', 369, 263000, 12),
(4, 'Kodan', 620, 456000, 16),
(4, 'Odense', 585, 342000, 17),
(5, 'Montreal', 682, 1600000, 18),
(5, 'Tuktoyaktuk', 78, 125, -9),
(5, 'Fort McPherson', 65, 194, 2),
(6, 'Moskva', 2561, 12000000, 12),
(6, 'Murmansk', 165, 56000, 10),
(6, 'Khodovarikha', 25, 112, -15),
(7, 'Nuuk', 690, 19000, -5),
(7, 'Proven', 545, 1532, -20),
(8, 'Rejkjavik', 273, 131000, 10),
(8, 'Svalbard', 111, 12562, 8),
(9, 'Washington', 177, 689256, 18),
(9, 'Anchorage', 5079, 298610, 5),
(9, 'Elim', 7, 366, 11);

COMMIT;
