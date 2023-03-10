USE [master]
GO
/****** Object:  Database [Skola]    Script Date: 28.03.2022 17:21:02 ******/
CREATE DATABASE [Skola]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Skola', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Skola.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Skola_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Skola_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Skola] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Skola].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Skola] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Skola] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Skola] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Skola] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Skola] SET ARITHABORT OFF 
GO
ALTER DATABASE [Skola] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Skola] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Skola] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Skola] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Skola] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Skola] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Skola] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Skola] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Skola] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Skola] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Skola] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Skola] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Skola] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Skola] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Skola] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Skola] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Skola] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Skola] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Skola] SET  MULTI_USER 
GO
ALTER DATABASE [Skola] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Skola] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Skola] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Skola] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Skola] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Skola] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Skola] SET QUERY_STORE = OFF
GO
USE [Skola]
GO
/****** Object:  Table [dbo].[Predmet]    Script Date: 28.03.2022 17:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predmet](
	[kod] [char](5) NOT NULL,
	[nazev] [varchar](20) NOT NULL,
	[syllabus] [text] NULL,
	[garant] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[kod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 28.03.2022 17:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[rc] [varchar](11) NOT NULL,
	[jmeno] [varchar](50) NOT NULL,
	[specializace] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zapis]    Script Date: 28.03.2022 17:21:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zapis](
	[rc] [varchar](11) NOT NULL,
	[kod] [char](5) NOT NULL,
	[semestr] [char](5) NOT NULL,
	[znamka] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rc] ASC,
	[kod] ASC,
	[semestr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Predmet] ([kod], [nazev], [syllabus], [garant]) VALUES (N'01DBS', N'Databaze', NULL, N'Blaha')
INSERT [dbo].[Predmet] ([kod], [nazev], [syllabus], [garant]) VALUES (N'01SQL', N'Jazyk SQL', NULL, N'Blaha')
INSERT [dbo].[Predmet] ([kod], [nazev], [syllabus], [garant]) VALUES (N'02LS ', N'Logicke systemy', NULL, N'Farada')
INSERT [dbo].[Predmet] ([kod], [nazev], [syllabus], [garant]) VALUES (N'02MAA', N'Matematika', NULL, N'Janecek')
INSERT [dbo].[Predmet] ([kod], [nazev], [syllabus], [garant]) VALUES (N'02SJ ', N'Spanelsky jazyk', NULL, N'Garcia')
GO
INSERT [dbo].[Student] ([rc], [jmeno], [specializace]) VALUES (N'123457/1234', N'Igor Holub', N'SWI')
INSERT [dbo].[Student] ([rc], [jmeno], [specializace]) VALUES (N'123458/1234', N'Jaroslav Teska', N'DBS')
INSERT [dbo].[Student] ([rc], [jmeno], [specializace]) VALUES (N'123459/1234', N'Jan Novak', N'DBS')
INSERT [dbo].[Student] ([rc], [jmeno], [specializace]) VALUES (N'123460/1234', N'Jan Bok', N'DBS')
INSERT [dbo].[Student] ([rc], [jmeno], [specializace]) VALUES (N'800520/1234', N'Jan Fejfar', N'SWI')
GO
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'123459/1234', N'01DBS', N'2010L', 1)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'123459/1234', N'02LS ', N'2010L', 2)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'123459/1234', N'02MAA', N'2010L', 3)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'123460/1234', N'02LS ', N'2011L', 2)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'123460/1234', N'02MAA', N'2011L', 3)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'800520/1234', N'01DBS', N'2010Z', 4)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'800520/1234', N'01DBS', N'2011Z', 3)
INSERT [dbo].[Zapis] ([rc], [kod], [semestr], [znamka]) VALUES (N'800520/1234', N'01SQL', N'2010Z', 1)
GO
ALTER TABLE [dbo].[Zapis]  WITH CHECK ADD FOREIGN KEY([kod])
REFERENCES [dbo].[Predmet] ([kod])
GO
ALTER TABLE [dbo].[Zapis]  WITH CHECK ADD FOREIGN KEY([rc])
REFERENCES [dbo].[Student] ([rc])
GO
ALTER TABLE [dbo].[Zapis]  WITH CHECK ADD CHECK  (([ZNAMKA]>=(1) AND [ZNAMKA]<=(4)))
GO
USE [master]
GO
ALTER DATABASE [Skola] SET  READ_WRITE 
GO
