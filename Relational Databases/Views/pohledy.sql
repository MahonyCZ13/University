USE [master]
GO
/****** Object:  Database [Pohledy]    Script Date: 28.03.2022 17:20:29 ******/
CREATE DATABASE [Pohledy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pohledy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pohledy.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pohledy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Pohledy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Pohledy] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pohledy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pohledy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pohledy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pohledy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pohledy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pohledy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pohledy] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Pohledy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pohledy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pohledy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pohledy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pohledy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pohledy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pohledy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pohledy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pohledy] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Pohledy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pohledy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pohledy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pohledy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pohledy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pohledy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pohledy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pohledy] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Pohledy] SET  MULTI_USER 
GO
ALTER DATABASE [Pohledy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pohledy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pohledy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pohledy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pohledy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pohledy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Pohledy] SET QUERY_STORE = OFF
GO
USE [Pohledy]
GO
/****** Object:  Table [dbo].[KAT]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KAT](
	[KAT] [char](5) NOT NULL,
	[NAZK] [varchar](30) NOT NULL,
	[POPK] [varchar](max) NULL,
	[NADR] [char](5) NULL,
 CONSTRAINT [PK_KAT] PRIMARY KEY CLUSTERED 
(
	[KAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZBOZ]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZBOZ](
	[KOD] [int] NOT NULL,
	[KAT] [char](5) NOT NULL,
	[NAZ] [varchar](30) NOT NULL,
	[POP] [varchar](max) NULL,
	[JCEN] [int] NOT NULL,
	[JEDN] [varchar](20) NULL,
	[SKLAD] [float] NOT NULL,
	[DOST] [int] NOT NULL,
	[AKTI] [int] NOT NULL,
 CONSTRAINT [PK_ZBOZ] PRIMARY KEY CLUSTERED 
(
	[KOD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Napoje]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Napoje] AS
SELECT ZBOZ.NAZ, ZBOZ.KAT, ZBOZ.JCEN, ZBOZ.JEDN, ZBOZ.SKLAD
FROM dbo.ZBOZ 
JOIN KAT ON(ZBOZ.KAT = KAT.KAT) 
WHERE ZBOZ.KAT IN
(
    SELECT KAT.KAT 
    FROM KAT 
    WHERE KAT.NADR LIKE 'nap%'
);
GO
/****** Object:  Table [dbo].[POLOZ]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POLOZ](
	[CISO] [int] NOT NULL,
	[KOD] [int] NOT NULL,
	[MNOZ] [float] NOT NULL,
	[VCEN] [int] NOT NULL,
 CONSTRAINT [PK_POLOZ] PRIMARY KEY CLUSTERED 
(
	[CISO] ASC,
	[KOD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PrehledObjednavek]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Pohled neni aktualizovatelny
CREATE VIEW [dbo].[PrehledObjednavek] AS
SELECT ZBOZ.KAT AS 'Kategorie', SUM(POLOZ.VCEN) AS 'Celokova Cena', SUM(POLOZ.MNOZ) AS 'Mnozstvi' 
FROM POLOZ 
JOIN ZBOZ ON(POLOZ.KOD = ZBOZ.KOD) 
GROUP BY ZBOZ.KAT;
GO
/****** Object:  Table [dbo].[OBJ]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OBJ](
	[CISO] [int] NOT NULL,
	[ZAK] [varchar](30) NOT NULL,
	[DAT] [varchar](20) NOT NULL,
	[DATOD] [varchar](20) NULL,
	[STAV] [char](1) NOT NULL,
	[PLAT] [char](1) NOT NULL,
	[DOPR] [char](1) NOT NULL,
	[JMEN] [varchar](50) NOT NULL,
	[PRIJM] [varchar](50) NOT NULL,
	[ULIC] [varchar](100) NOT NULL,
	[PSC] [char](5) NOT NULL,
	[MEST] [varchar](100) NOT NULL,
	[POZN] [varchar](max) NULL,
 CONSTRAINT [PK_OBJ] PRIMARY KEY CLUSTERED 
(
	[CISO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZAK]    Script Date: 28.03.2022 17:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZAK](
	[LOG] [varchar](30) NOT NULL,
	[JMEN] [varchar](50) NOT NULL,
	[PRIJM] [varchar](50) NOT NULL,
	[ULIC] [varchar](100) NOT NULL,
	[PSC] [char](5) NOT NULL,
	[MEST] [varchar](100) NOT NULL,
	[EMAIL] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ZAK] PRIMARY KEY CLUSTERED 
(
	[LOG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'dest ', N'destiláty', N'tvrdý alkohol', N'napAl')
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'limo ', N'limonády', N'nealkoholické nápoje nejruznejších príchutí', N'napNA')
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'minVo', N'minerální vody', N'pramenité minerální a stolní vody', N'napNA')
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'nap  ', N'nápoje', N'zboží, které lze pít', NULL)
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'napAl', N'nápoje alkoholické', N'alkohol', N'nap  ')
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'napNA', N'nápoje nealkoholické', N'nápoje, které neobsahují alkohol', N'nap  ')
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'ovze ', N'ovoce, zelenina', N'neco dobrého pro zdraví', NULL)
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'pec  ', N'pecivo', N'chléb, housky, rohlíky, sladké pecivo atd.', NULL)
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'pivo ', N'pivo', N'piva ruzných druhu', N'napAl')
INSERT [dbo].[KAT] ([KAT], [NAZK], [POPK], [NADR]) VALUES (N'vino ', N'víno', N'nejruznejší druhy vína', N'napAl')
GO
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (1, N'krec', N'04-01-2006', N'11-01-2006', N'o', N'1', N'2', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (2, N'krec', N'12-10-2006', N'12-12-2006', N'o', N'1', N'1', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (3, N'krec', N'23-11-2006', N'25-11-2006', N'o', N'2', N'3', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (4, N'strakova', N'10-01-2007', N'11-01-2007', N'o', N'1', N'2', N'Miluše', N'Straková', N'Žehunská 843', N'19800', N'Praha 9 - Kyje', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (6, N'krec', N'30-01-2007', N'02-04-2007', N'o', N'1', N'2', N'Tomáš', N'Krec', N'Pražská 4', N'54101', N'Trutnov', N'zásilku mi prosím dodejte v dopoledních hodinách')
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (7, N'krec', N'15-04-2007', N'15-04-2007', N'o', N'1', N'1', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (8, N'bohus', N'15-05-2007', N'17-05-2007', N'o', N'2', N'1', N'Bohuslav', N'Rejholec', N'Laudova 1014', N'16300', N'Praha 6 - Repy', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (9, N'krec', N'16-05-2007', N'16-05-2007', N'o', N'1', N'1', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (10, N'novota', N'23-08-2007', N'25-08-2007', N'o', N'3', N'4', N'Blanka', N'Novotná', N'Mírové námestí 55', N'55001', N'Broumov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (11, N'krec', N'02-10-2007', N'02-12-2007', N'o', N'2', N'3', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (12, N'bohus', N'10-10-2007', N'10-10-2007', N'o', N'3', N'3', N'Bohuslav', N'Rejholec', N'Laudova 1014', N'16300', N'Praha 6 - Repy', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (13, N'bohus', N'02-12-2007', N'13-02-2008', N'o', N'2', N'2', N'Bohuslav', N'Rejholec', N'Laudova 1014', N'16300', N'Praha 6 - Repy', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (14, N'masin', N'06-01-2008', N'07-01-2008', N'o', N'1', N'4', N'František', N'Mašín', N'Puškinova 1', N'68201', N'Vyškov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (15, N'novota', N'02-02-2008', N'13-02-2008', N'o', N'1', N'2', N'Blanka', N'Novotná', N'Mírové námestí 55', N'55001', N'Broumov', N'Prosím o dodání ve vecerních hodinách')
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (16, N'bohus', N'03-02-2008', N'04-02-2008', N'o', N'2', N'2', N'Bohuslav', N'Rejholec', N'Laudova 1014', N'16300', N'Praha 6 - Repy', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (17, N'masin', N'13-02-2008', N'15-02-2008', N'o', N'3', N'3', N'František', N'Mašín', N'Puškinova 591', N'68201', N'Vyškov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (18, N'masin', N'17-04-2008', N'19-04-2008', N'o', N'3', N'4', N'František', N'Mašín', N'Puškinova 591', N'68201', N'Vyškov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (19, N'vencka', N'13-05-2008', N'16-05-2008', N'o', N'3', N'3', N'Jana', N'Vencovská', N'Jarní 457', N'17000', N'Praha 7', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (20, N'novotny', N'24-09-2008', N'26-01-2009', N'o', N'2', N'1', N'Antonín', N'Novotný', N'Havlíckova 139', N'35103', N'Velká Hledsebe', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (21, N'masin', N'10-10-2008', N'10-11-2008', N'o', N'1', N'1', N'František', N'Mašín', N'Puškinova 591', N'68201', N'Vyškov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (22, N'novota', N'15-10-2008', N'16-10-2008', N'o', N'1', N'4', N'Blanka', N'Novotná', N'Mírové námestí 55', N'55001', N'Broumov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (23, N'novota', N'17-11-2008', N'21-11-2008', N'o', N'2', N'2', N'Blanka', N'Novotná', N'Mírové námestí 55', N'55001', N'Broumov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (24, N'novota', N'01-12-2008', N'14-01-2009', N'o', N'1', N'4', N'Blanka', N'Novotná', N'Mírové námestí 55', N'55001', N'Broumov', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (25, N'janouskova', N'12-12-2008', N'15-01-2009', N'o', N'2', N'1', N'Denisa', N'Janoušková', N'Dvorákova 645', N'60200', N'Brno', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (26, N'abraham', N'23-12-2008', N'29-01-2009', N'o', N'3', N'3', N'Karel', N'Abrahámek', N'Smetanova 70', N'27351', N'Unhošt', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (27, N'rubek', N'02-01-2009', NULL, N'v', N'1', N'2', N'Jirí', N'Rubek', N'Janošíkova 709', N'64300', N'Brno', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (28, N'skocka', N'01-06-2009', N'01-06-2009', N'o', N'1', N'4', N'Zdena', N'Skocdopolová', N'Vokrojova 3378', N'14300', N'Praha 4 - Modrany', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (29, N'strakova', N'01-06-2009', NULL, N'p', N'3', N'3', N'Miluše', N'Straková', N'Žehunská 843', N'19800', N'Praha 9 - Kyje', NULL)
INSERT [dbo].[OBJ] ([CISO], [ZAK], [DAT], [DATOD], [STAV], [PLAT], [DOPR], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [POZN]) VALUES (30, N'bohus', N'30-06-2009', NULL, N'v', N'2', N'2', N'Bohuslav', N'Rejholec', N'Laudova 1014', N'16300', N'Praha 6 - Repy', NULL)
GO
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1000, 4, 40)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1007, 10, 130)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1010, 5, 157)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1014, 3, 88)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1019, 3, 121)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1020, 1, 26)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1021, 2, 56)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1023, 0.5, 33)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1024, 10, 120)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1025, 5, 80)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (1, 1026, 5, 220)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (2, 1009, 6, 51)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (2, 1015, 10, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (2, 1017, 1, 24)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (2, 1022, 1, 29)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (2, 1024, 2, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (3, 1000, 5, 50)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (3, 1008, 2, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (3, 1015, 20, 50)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (3, 1017, 1, 24)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (4, 1009, 2, 17)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (4, 1019, 1, 40)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (6, 1004, 2, 128)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (6, 1005, 1, 79)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (6, 1006, 4, 224)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (7, 1016, 50, 1500)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (8, 1017, 1, 24)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (9, 1009, 1, 8)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (10, 1009, 6, 51)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (10, 1016, 1, 30)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (11, 1000, 10, 100)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (11, 1001, 10, 195)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (11, 1002, 5, 75)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (11, 1003, 10, 120)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (12, 1011, 1, 34)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (12, 1021, 0.5, 14)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (12, 1026, 1, 44)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (13, 1011, 2, 69)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (13, 1017, 2, 50)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (13, 1021, 2, 58)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (14, 1000, 20, 200)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (14, 1004, 2, 128)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (15, 1007, 1, 13)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (15, 1016, 2, 65)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (15, 1018, 10, 30)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (15, 1021, 1, 29)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (15, 1025, 4, 64)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (16, 1010, 5, 157)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (16, 1022, 2, 61)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (17, 1002, 4, 60)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (18, 1005, 2, 173)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (18, 1006, 2, 112)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (19, 1008, 20, 250)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (20, 1015, 10, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (20, 1017, 1, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (20, 1018, 6, 21)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (20, 1024, 1, 13)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (21, 1003, 2, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (21, 1013, 6, 198)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (21, 1019, 1, 40)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (21, 1025, 2, 35)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (22, 1000, 10, 100)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (22, 1024, 2, 26)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (22, 1026, 1, 44)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (23, 1013, 1, 33)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (23, 1020, 1, 28)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (24, 1005, 1, 86)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (25, 1002, 30, 450)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (26, 1006, 1, 56)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (27, 1008, 3, 39)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (27, 1018, 10, 35)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (27, 1026, 1, 44)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (28, 1003, 6, 75)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (28, 1015, 20, 60)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (28, 1017, 1, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (28, 1025, 4, 70)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (29, 1016, 2, 68)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (29, 1017, 1, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (29, 1024, 2, 26)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (30, 1016, 2, 68)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (30, 1017, 1, 25)
INSERT [dbo].[POLOZ] ([CISO], [KOD], [MNOZ], [VCEN]) VALUES (30, 1020, 20, 560)
GO
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'abraham', N'Karel', N'Abrahámek', N'Smetanova 70', N'27351', N'Unhošt', N'abraham@centrum.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'bohus', N'Bohuslav', N'Rejholec', N'Laudova 1014', N'16300', N'Praha 6 - Repy', N'rejholec@gmail.com')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'ilja', N'Ilja', N'Novák', N'Vokrojova 3384', N'14300', N'Praha', N'ilja-novak@seznam.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'janouskova', N'Denisa', N'Janoušková', N'Dvorákova 645', N'60200', N'Brno', N'xjand05@vse.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'krec', N'Tomáš', N'Krec', N'M. Pujmannové 286', N'54101', N'Trutnov', N'krecek@seznam.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'masin', N'František', N'Mašín', N'Puškinova 591', N'68201', N'Vyškov', N'franta.masin@seznam.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'novota', N'Blanka', N'Novotná', N'Mírové námestí 55', N'55001', N'Broumov', N'novota@atlas.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'novotny', N'Antonín', N'Novotný', N'Havlíckova 139', N'35103', N'Velká Hledsebe', N'nov.ant@seznam.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'rubek', N'Jirí', N'Rubek', N'Janošíkova 709', N'64300', N'Brno - Chrlice', N'rubi@seznam.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'skocka', N'Zdena', N'Skocdopolová', N'Vokrojova 3378', N'14300', N'Praha 4 - Modrany', N'skocdopolova@centrum.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'strakova', N'Miluše', N'Straková', N'Žehunská 843', N'19800', N'Praha 9 - Kyje', N'strakova.miluse@seznam.cz')
INSERT [dbo].[ZAK] ([LOG], [JMEN], [PRIJM], [ULIC], [PSC], [MEST], [EMAIL]) VALUES (N'vencka', N'Jana', N'Vencovská', N'Jarní 457', N'17000', N'Praha 7 - Bubenec', N'vencova@centrum.cz')
GO
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1000, N'pivo ', N'Braník', N'svetlé pivo ve skle', 11, N'láhev 0,5 l', 100, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1001, N'pivo ', N'Budejovický Budvar', N'svetlý ležák ve skle', 20, N'láhev 0,5 l', 250, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1002, N'pivo ', N'Gambrinus svetlý', N'svetlé pivo ve skle', 15, N'láhev 0,5 l', 200, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1003, N'pivo ', N'Staropramen', N'svetlé pivo ve skle', 12, N'láhev 0,5 l', 0, 1, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1004, N'vino ', N'Frankovka', N'suché víno', 65, N'láhev 0,75 l', 10, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1005, N'vino ', N'Modrý Portugal', NULL, 86, N'láhev 0,75 l', 1, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1006, N'vino ', N'Svatovavrinecké', N'suché víno', 56, N'láhev 0,75 l', 0, 3, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1007, N'minVo', N'Mattoni broskev', N'minerální voda s príchutí broskve', 15, N'láhev 1,5 l', 20, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1008, N'minVo', N'Mattoni', N'minerální voda bez príchuti', 13, N'láhev 1,5 l', 120, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1009, N'minVo', N'Podebradka', N'minerální voda bez príchuti', 10, N'láhev 1,5 l', 82, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1010, N'limo ', N'7UP', NULL, 33, N'láhev 2 l', 30, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1011, N'limo ', N'Coca-cola', NULL, 36, N'láhev 2 l', 80, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1012, N'limo ', N'Fanta divoká malina', N'limonáda s príchutí divoké maliny', 33, N'láhev 2 l', 20, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1013, N'limo ', N'Fanta pomeranc', N'limonáda s príchutí pomerance', 33, N'láhev 2 l', 42, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1014, N'limo ', N'Fanta lemonic', N'limonáda s príchutí lemonic', 33, N'láhev 2 l', 0, 0, 0)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1015, N'pec  ', N'rohlík', NULL, 3, N'ks', 150, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1016, N'pec  ', N'toustový chléb', NULL, 34, N'kg', 20, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1017, N'pec  ', N'chléb', NULL, 25, N'kg', 15, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1018, N'pec  ', N'houska', NULL, 3, N'ks', 110, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1019, N'ovze ', N'banán', NULL, 43, N'kg', 20, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1020, N'ovze ', N'citron', NULL, 28, N'kg', 2, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1021, N'ovze ', N'jablko cervené', N'cervené jablko', 30, N'kg', 10, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1022, N'ovze ', N'jablko zelené', N'zelené jablko', 32, N'kg', 5, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1023, N'ovze ', N'mango', NULL, 75, N'kg', 0, 0, 0)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1024, N'ovze ', N'brambory', NULL, 13, N'kg', 25, 0, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1025, N'ovze ', N'okurka', N'salátová okurka', 17, N'ks', 0, 1, 1)
INSERT [dbo].[ZBOZ] ([KOD], [KAT], [NAZ], [POP], [JCEN], [JEDN], [SKLAD], [DOST], [AKTI]) VALUES (1026, N'ovze ', N'rajská jablka', NULL, 44, N'kg', 2, 0, 1)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_NAZ_KAT]    Script Date: 28.03.2022 17:20:29 ******/
ALTER TABLE [dbo].[KAT] ADD  CONSTRAINT [AK_NAZ_KAT] UNIQUE NONCLUSTERED 
(
	[NAZK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [AK_NAZ_ZBOZ]    Script Date: 28.03.2022 17:20:29 ******/
ALTER TABLE [dbo].[ZBOZ] ADD  CONSTRAINT [AK_NAZ_ZBOZ] UNIQUE NONCLUSTERED 
(
	[NAZ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OBJ] ADD  DEFAULT ('p') FOR [STAV]
GO
ALTER TABLE [dbo].[KAT]  WITH CHECK ADD  CONSTRAINT [FK_KAT_KAT] FOREIGN KEY([NADR])
REFERENCES [dbo].[KAT] ([KAT])
GO
ALTER TABLE [dbo].[KAT] CHECK CONSTRAINT [FK_KAT_KAT]
GO
ALTER TABLE [dbo].[OBJ]  WITH CHECK ADD  CONSTRAINT [FK_OBJ_ZAK] FOREIGN KEY([ZAK])
REFERENCES [dbo].[ZAK] ([LOG])
GO
ALTER TABLE [dbo].[OBJ] CHECK CONSTRAINT [FK_OBJ_ZAK]
GO
ALTER TABLE [dbo].[POLOZ]  WITH CHECK ADD  CONSTRAINT [FK_POLOZ_OBJ] FOREIGN KEY([CISO])
REFERENCES [dbo].[OBJ] ([CISO])
GO
ALTER TABLE [dbo].[POLOZ] CHECK CONSTRAINT [FK_POLOZ_OBJ]
GO
ALTER TABLE [dbo].[POLOZ]  WITH CHECK ADD  CONSTRAINT [FK_POLOZ_ZBOZ] FOREIGN KEY([KOD])
REFERENCES [dbo].[ZBOZ] ([KOD])
GO
ALTER TABLE [dbo].[POLOZ] CHECK CONSTRAINT [FK_POLOZ_ZBOZ]
GO
ALTER TABLE [dbo].[ZBOZ]  WITH CHECK ADD  CONSTRAINT [FK_ZBOZ_KAT] FOREIGN KEY([KAT])
REFERENCES [dbo].[KAT] ([KAT])
GO
ALTER TABLE [dbo].[ZBOZ] CHECK CONSTRAINT [FK_ZBOZ_KAT]
GO
ALTER TABLE [dbo].[OBJ]  WITH CHECK ADD  CONSTRAINT [CKC_DOPR_OBJ] CHECK  (([DOPR]='4' OR [DOPR]='3' OR [DOPR]='2' OR [DOPR]='1'))
GO
ALTER TABLE [dbo].[OBJ] CHECK CONSTRAINT [CKC_DOPR_OBJ]
GO
ALTER TABLE [dbo].[OBJ]  WITH CHECK ADD  CONSTRAINT [CKC_PLAT_OBJ] CHECK  (([PLAT]='3' OR [PLAT]='2' OR [PLAT]='1'))
GO
ALTER TABLE [dbo].[OBJ] CHECK CONSTRAINT [CKC_PLAT_OBJ]
GO
ALTER TABLE [dbo].[OBJ]  WITH CHECK ADD  CONSTRAINT [CKC_STAV_OBJ] CHECK  (([STAV]='o' OR [STAV]='v' OR [STAV]='p'))
GO
ALTER TABLE [dbo].[OBJ] CHECK CONSTRAINT [CKC_STAV_OBJ]
GO
USE [master]
GO
ALTER DATABASE [Pohledy] SET  READ_WRITE 
GO
