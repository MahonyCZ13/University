create table KAT (
KAT CHAR(5) not null,
NAZK VARCHAR(30) not null,
POPK VARCHAR(max),
NADR CHAR(5),
constraint PK_KAT primary key (KAT),
constraint AK_NAZ_KAT unique (NAZK)
);

alter table KAT
add constraint FK_KAT_KAT foreign key (NADR)
references KAT (KAT);
create table ZBOZ (
KOD INT not null,
KAT CHAR(5) not null,
NAZ VARCHAR(30) not null,
POP VARCHAR(max),
JCEN INT not null,
JEDN VARCHAR(20),
SKLAD FLOAT not null,
DOST INT not null,
AKTI INT not null,
constraint PK_ZBOZ primary key (KOD),
constraint AK_NAZ_ZBOZ unique (NAZ)
);

alter table ZBOZ
add constraint FK_ZBOZ_KAT foreign key (KAT)
references KAT (KAT);

create table ZAK (
LOG VARCHAR(30) not null,
JMEN VARCHAR(50) not null,
PRIJM VARCHAR(50) not null,
ULIC VARCHAR(100) not null,
PSC CHAR(5) not null,
MEST VARCHAR(100) not null,
EMAIL VARCHAR(100) not null,
constraint PK_ZAK primary key (LOG)
);

create table OBJ (
CISO INT not null,
ZAK VARCHAR(30) not null,
DAT VARCHAR(20) not null,
DATOD VARCHAR(20),
STAV CHAR(1) default 'p' not null
constraint CKC_STAV_OBJ check (STAV in ('p','v','o')),
PLAT CHAR(1) not null
constraint CKC_PLAT_OBJ check (PLAT in ('1','2','3')),
DOPR CHAR(1) not null
constraint CKC_DOPR_OBJ check (DOPR in ('1','2','3','4')),
JMEN VARCHAR(50) not null,
PRIJM VARCHAR(50) not null,
ULIC VARCHAR(100) not null,
PSC CHAR(5) not null,
MEST VARCHAR(100) not null,
POZN VARCHAR(max),
constraint PK_OBJ primary key (CISO)
);

alter table OBJ
add constraint FK_OBJ_ZAK foreign key (ZAK)
references ZAK (LOG);

create table POLOZ (
CISO INT not null,
KOD INT not null,
MNOZ FLOAT not null,
VCEN INT not null,
constraint PK_POLOZ primary key (CISO, KOD)
);

alter table POLOZ
add constraint FK_POLOZ_OBJ foreign key (CISO)
references OBJ (CISO);

alter table POLOZ
add constraint FK_POLOZ_ZBOZ foreign key (KOD)
references ZBOZ (KOD);

insert into KAT values ('nap','nápoje','zboží, které lze pít',NULL);
insert into KAT values ('napAl','nápoje alkoholické','alkohol','nap');
insert into KAT values ('pivo','pivo','piva různých druhů','napAl');
insert into KAT values ('vino','víno','nejrůznější druhy vína','napAl');
insert into KAT values ('dest','destiláty','tvrdý alkohol','napAl');
insert into KAT values ('napNA','nápoje nealkoholické','nápoje, které neobsahují alkohol','nap');
insert into KAT values ('minVo','minerální vody','pramenité minerální a stolní vody','napNA');
insert into KAT values ('limo','limonády','nealkoholické nápoje nejrůznějších příchutí','napNA');
insert into KAT values ('pec','pečivo','chléb, housky, rohlíky, sladké pečivo atd.',NULL);
insert into KAT values ('ovze','ovoce, zelenina','něco dobrého pro zdraví',NULL);

insert into ZBOZ values (1000,'pivo','Braník','světlé pivo ve skle',11,'láhev 0,5 l',100,0,1);
insert into ZBOZ values (1001,'pivo','Budějovický Budvar','světlý ležák ve skle',20,'láhev 0,5 l',250,0,1);
insert into ZBOZ values (1002,'pivo','Gambrinus světlý','světlé pivo ve skle',15,'láhev 0,5 l',200,0,1);
insert into ZBOZ values (1003,'pivo','Staropramen','světlé pivo ve skle',12.5,'láhev 0,5 l',0,1,1);
insert into ZBOZ values (1004,'vino','Frankovka','suché víno',65,'láhev 0,75 l',10,0,1);
insert into ZBOZ values (1005,'vino','Modrý Portugal',NULL,86.5,'láhev 0,75 l',1,0,1);
insert into ZBOZ values (1006,'vino','Svatovavřinecké','suché víno',56,'láhev 0,75 l',0,3,1);
insert into ZBOZ values (1007,'minVo','Mattoni broskev','minerální voda s příchutí broskve',15,'láhev 1,5 l',20,0,1);
insert into ZBOZ values (1008,'minVo','Mattoni','minerální voda bez příchuti',13,'láhev 1,5 l',120,0,1);
insert into ZBOZ values (1009,'minVo','Poděbradka','minerální voda bez příchuti',10,'láhev 1,5 l',82,0,1);
insert into ZBOZ values (1010,'limo','7UP',NULL,33,'láhev 2 l',30,0,1);
insert into ZBOZ values (1011,'limo','Coca-cola',NULL,36,'láhev 2 l',80,0,1);
insert into ZBOZ values (1012,'limo','Fanta divoká malina','limonáda s příchutí divoké maliny',33,'láhev 2 l',20,0,1);
insert into ZBOZ values (1013,'limo','Fanta pomeranč','limonáda s příchutí pomeranče',33,'láhev 2 l',42,0,1);
insert into ZBOZ values (1014,'limo','Fanta lemonic','limonáda s příchutí lemonic',33,'láhev 2 l',0,0,0);
insert into ZBOZ values (1015,'pec','rohlík',NULL,3,'ks',150,0,1);
insert into ZBOZ values (1016,'pec','toustový chléb',NULL,34,'kg',20,0,1);
insert into ZBOZ values (1017,'pec','chléb',NULL,25,'kg',15,0,1);
insert into ZBOZ values (1018,'pec','houska',NULL,3.5,'ks',110,0,1);
insert into ZBOZ values (1019,'ovze','banán',NULL,43.5,'kg',20,0,1);
insert into ZBOZ values (1020,'ovze','citron',NULL,28,'kg',2,0,1);
insert into ZBOZ values (1021,'ovze','jablko červené','červené jablko',30,'kg',10,0,1);
insert into ZBOZ values (1022,'ovze','jablko zelené','zelené jablko',32,'kg',5,0,1);
insert into ZBOZ values (1023,'ovze','mango',NULL,75,'kg',0,0,0);
insert into ZBOZ values (1024,'ovze','brambory',NULL,13,'kg',25,0,1);
insert into ZBOZ values (1025,'ovze','okurka','salátová okurka',17.5,'ks',0,1,1);
insert into ZBOZ values (1026,'ovze','rajská jablka',NULL,44.5,'kg',2,0,1);

insert into ZAK values ('novotny','Antonín','Novotný','Havlíčkova 139','35103','Velká Hleďsebe','nov.ant@seznam.cz');
insert into ZAK values ('abraham','Karel','Abrahámek','Smetanova 70','27351','Unhošť','abraham@centrum.cz');
insert into ZAK values ('rubek','Jiří','Rubek','Janošíkova 709','64300','Brno - Chrlice','rubi@seznam.cz');
insert into ZAK values ('bohus','Bohuslav','Rejholec','Laudova 1014','16300','Praha 6 - Řepy','rejholec@gmail.com');
insert into ZAK values ('masin','František','Mašín','Puškinova 591','68201','Vyškov','franta.masin@seznam.cz');
insert into ZAK values ('novota','Blanka','Novotná','Mírové náměstí 55','55001','Broumov','novota@atlas.cz');
insert into ZAK values ('vencka','Jana','Vencovská','Jarní 457','17000','Praha 7 - Bubeneč','vencova@centrum.cz');
insert into ZAK values ('skocka','Zdena','Skočdopolová','Vokrojova 3378','14300','Praha 4 - Modřany','skocdopolova@centrum.cz');
insert into ZAK values ('janouskova','Denisa','Janoušková','Dvořákova 645','60200','Brno','xjand05@vse.cz');
insert into ZAK values ('strakova','Miluše','Straková','Žehuňská 843','19800','Praha 9 - Kyje','strakova.miluse@seznam.cz');
insert into ZAK values ('krec','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov','krecek@seznam.cz');
insert into ZAK values ('ilja','Ilja','Novák','Vokrojova 3384','14300','Praha','ilja-novak@seznam.cz');

insert into OBJ values (1,'krec','04-01-2006','11-01-2006','o','1','2','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov',NULL);
insert into OBJ values (2,'krec','12-10-2006','12-12-2006','o','1','1','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov',NULL);
insert into OBJ values (3,'krec','23-11-2006','25-11-2006','o','2','3','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov',NULL);
insert into OBJ values (4,'strakova','10-01-2007','11-01-2007','o','1','2','Miluše','Straková','Žehuňská 843','19800','Praha 9 - Kyje',NULL);
insert into OBJ values (6,'krec','30-01-2007','02-04-2007','o','1','2','Tomáš','Křeč','Pražská 4','54101','Trutnov','zásilku mi prosím dodejte v dopoledních hodinách');
insert into OBJ values (7,'krec','15-04-2007','15-04-2007','o','1','1','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov',NULL);
insert into OBJ values (8,'bohus','15-05-2007','17-05-2007','o','2','1','Bohuslav','Rejholec','Laudova 1014','16300','Praha 6 - Řepy',NULL);
insert into OBJ values (9,'krec','16-05-2007','16-05-2007','o','1','1','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov',NULL);
insert into OBJ values (10,'novota','23-08-2007','25-08-2007','o','3','4','Blanka','Novotná','Mírové náměstí 55','55001','Broumov',NULL);
insert into OBJ values (11,'krec','02-10-2007','02-12-2007','o','2','3','Tomáš','Křeč','M. Pujmannové 286','54101','Trutnov',NULL);
insert into OBJ values (12,'bohus','10-10-2007','10-10-2007','o','3','3','Bohuslav','Rejholec','Laudova 1014','16300','Praha 6 - Řepy',NULL);
insert into OBJ values (13,'bohus','02-12-2007','13-02-2008','o','2','2','Bohuslav','Rejholec','Laudova 1014','16300','Praha 6 - Řepy',NULL);
insert into OBJ values (14,'masin','06-01-2008','07-01-2008','o','1','4','František','Mašín','Puškinova 1','68201','Vyškov',NULL);
insert into OBJ values (15,'novota','02-02-2008','13-02-2008','o','1','2','Blanka','Novotná','Mírové náměstí 55','55001','Broumov','Prosím o dodání ve večerních hodinách');
insert into OBJ values (16,'bohus','03-02-2008','04-02-2008','o','2','2','Bohuslav','Rejholec','Laudova 1014','16300','Praha 6 - Řepy',NULL);
insert into OBJ values (17,'masin','13-02-2008','15-02-2008','o','3','3','František','Mašín','Puškinova 591','68201','Vyškov',NULL);
insert into OBJ values (18,'masin','17-04-2008','19-04-2008','o','3','4','František','Mašín','Puškinova 591','68201','Vyškov',NULL);
insert into OBJ values (19,'vencka','13-05-2008','16-05-2008','o','3','3','Jana','Vencovská','Jarní 457','17000','Praha 7',NULL);
insert into OBJ values (20,'novotny','24-09-2008','26-01-2009','o','2','1','Antonín','Novotný','Havlíčkova 139','35103','Velká Hleďsebe',NULL);
insert into OBJ values (21,'masin','10-10-2008','10-11-2008','o','1','1','František','Mašín','Puškinova 591','68201','Vyškov',NULL);
insert into OBJ values (22,'novota','15-10-2008','16-10-2008','o','1','4','Blanka','Novotná','Mírové náměstí 55','55001','Broumov',NULL);
insert into OBJ values (23,'novota','17-11-2008','21-11-2008','o','2','2','Blanka','Novotná','Mírové náměstí 55','55001','Broumov',NULL);
insert into OBJ values (24,'novota','01-12-2008','14-01-2009','o','1','4','Blanka','Novotná','Mírové náměstí 55','55001','Broumov',NULL);
insert into OBJ values (25,'janouskova','12-12-2008','15-01-2009','o','2','1','Denisa','Janoušková','Dvořákova 645','60200','Brno',NULL);
insert into OBJ values (26,'abraham','23-12-2008','29-01-2009','o','3','3','Karel','Abrahámek','Smetanova 70','27351','Unhošť',NULL);
insert into OBJ values (27,'rubek','02-01-2009',NULL,'v','1','2','Jiří','Rubek','Janošíkova 709','64300','Brno',NULL);
insert into OBJ values (28,'skocka','01-06-2009','01-06-2009','o','1','4','Zdena','Skočdopolová','Vokrojova 3378','14300','Praha 4 - Modřany',NULL);
insert into OBJ values (29,'strakova','01-06-2009',NULL,'p','3','3','Miluše','Straková','Žehuňská 843','19800','Praha 9 - Kyje',NULL);
insert into OBJ values (30,'bohus','30-06-2009',NULL,'v','2','2','Bohuslav','Rejholec','Laudova 1014','16300','Praha 6 - Řepy',NULL);

insert into POLOZ values (1,'1000',4,40);
insert into POLOZ values (1,'1007',10,130);
insert into POLOZ values (1,'1010',5,157.5);
insert into POLOZ values (1,'1014',3,88.5);
insert into POLOZ values (1,'1019',3,121.5);
insert into POLOZ values (1,'1020',1,26);
insert into POLOZ values (1,'1021',2,56);
insert into POLOZ values (1,'1023',0.5,33.8);
insert into POLOZ values (1,'1024',10,120);
insert into POLOZ values (1,'1025',5,80);
insert into POLOZ values (1,'1026',5,220);
insert into POLOZ values (2,'1009',6,51);
insert into POLOZ values (2,'1015',10,25);
insert into POLOZ values (2,'1017',1,24.5);
insert into POLOZ values (2,'1022',1,29.5);
insert into POLOZ values (2,'1024',2,25);
insert into POLOZ values (3,'1000',5,50);
insert into POLOZ values (3,'1008',2,25);
insert into POLOZ values (3,'1015',20,50);
insert into POLOZ values (3,'1017',1,24.5);
insert into POLOZ values (4,'1009',2,17);
insert into POLOZ values (4,'1019',1,40.5);
insert into POLOZ values (6,'1004',2,128);
insert into POLOZ values (6,'1005',1,79);
insert into POLOZ values (6,'1006',4,224);
insert into POLOZ values (7,'1016',50,1500);
insert into POLOZ values (8,'1017',1,24.5);
insert into POLOZ values (9,'1009',1,8.5);
insert into POLOZ values (10,'1009',6,51);
insert into POLOZ values (10,'1016',1,30);
insert into POLOZ values (11,'1000',10,100);
insert into POLOZ values (11,'1001',10,195);
insert into POLOZ values (11,'1002',5,75);
insert into POLOZ values (11,'1003',10,120);
insert into POLOZ values (12,'1011',1,34.5);
insert into POLOZ values (12,'1021',0.5,14.5);
insert into POLOZ values (12,'1026',1,44);
insert into POLOZ values (13,'1011',2,69);
insert into POLOZ values (13,'1017',2,50);
insert into POLOZ values (13,'1021',2,58);
insert into POLOZ values (14,'1000',20,200);
insert into POLOZ values (14,'1004',2,128);
insert into POLOZ values (15,'1007',1,13);
insert into POLOZ values (15,'1016',2,65);
insert into POLOZ values (15,'1018',10,30);
insert into POLOZ values (15,'1021',1,29);
insert into POLOZ values (15,'1025',4,64);
insert into POLOZ values (16,'1010',5,157.5);
insert into POLOZ values (16,'1022',2,61);
insert into POLOZ values (17,'1002',4,60);
insert into POLOZ values (18,'1005',2,173);
insert into POLOZ values (18,'1006',2,112);
insert into POLOZ values (19,'1008',20,250);
insert into POLOZ values (20,'1015',10,25);
insert into POLOZ values (20,'1017',1,25);
insert into POLOZ values (20,'1018',6,21);
insert into POLOZ values (20,'1024',1,13);
insert into POLOZ values (21,'1003',2,25);
insert into POLOZ values (21,'1013',6,198);
insert into POLOZ values (21,'1019',1,40.5);
insert into POLOZ values (21,'1025',2,35);
insert into POLOZ values (22,'1000',10,100);
insert into POLOZ values (22,'1024',2,26);
insert into POLOZ values (22,'1026',1,44.5);
insert into POLOZ values (23,'1013',1,33);
insert into POLOZ values (23,'1020',1,28);
insert into POLOZ values (24,'1005',1,86.5);
insert into POLOZ values (25,'1002',30,450);
insert into POLOZ values (26,'1006',1,56);
insert into POLOZ values (27,'1008',3,39);
insert into POLOZ values (27,'1018',10,35);
insert into POLOZ values (27,'1026',1,44.5);
insert into POLOZ values (28,'1003',6,75);
insert into POLOZ values (28,'1015',20,60);
insert into POLOZ values (28,'1017',1,25);
insert into POLOZ values (28,'1025',4,70);
insert into POLOZ values (29,'1016',2,68);
insert into POLOZ values (29,'1017',1,25);
insert into POLOZ values (29,'1024',2,26);
insert into POLOZ values (30,'1016',2,68);
insert into POLOZ values (30,'1017',1,25);
insert into POLOZ values (30,'1020',20,560);