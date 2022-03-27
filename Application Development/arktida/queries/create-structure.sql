create table Staty (
    cid int NOT NULL AUTO_INCREMENT,
    nazev varchar(20),
    rozloha int, 
    obyvatelstvo int,
    PRIMARY KEY (cid)
)

create table mesta (
    mid int NOT NULL AUTO_INCREMENT,
    cid int NOT NULL,
    nazev varchar(20),
    rozloha int, 
    obyvatele int,
    PRIMARY KEY (mid),
    FOREIGN KEY (cid) REFERENCES Staty(cid)
);