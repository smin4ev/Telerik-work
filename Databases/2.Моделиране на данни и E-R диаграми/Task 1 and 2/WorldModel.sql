USE [master]
GO
/****** Object:  Database [WorldModelDB]    Script Date: 08/23/14 22:45:09 ******/
CREATE DATABASE [WorldModelDB] ON  PRIMARY 
( NAME = N'WorldModelDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\WorldModelDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WorldModelDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\WorldModelDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WorldModelDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WorldModelDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WorldModelDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WorldModelDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WorldModelDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WorldModelDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WorldModelDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WorldModelDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WorldModelDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [WorldModelDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WorldModelDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WorldModelDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WorldModelDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WorldModelDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WorldModelDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WorldModelDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WorldModelDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WorldModelDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WorldModelDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WorldModelDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WorldModelDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WorldModelDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WorldModelDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WorldModelDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WorldModelDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WorldModelDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WorldModelDB] SET  MULTI_USER 
GO
ALTER DATABASE [WorldModelDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WorldModelDB] SET DB_CHAINING OFF 
GO
USE [WorldModelDB]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 08/23/14 22:45:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[Address_text] [text] NOT NULL,
	[TownID] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 08/23/14 22:45:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[ContinetID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[ContinetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 08/23/14 22:45:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinetID] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persons]    Script Date: 08/23/14 22:45:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressID] [int] NOT NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 08/23/14 22:45:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[TownID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[TownID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (1, N'Ivan Vazov 33', 2)
INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (2, N'Dondukov 15', 1)
INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (3, N'Berlin shtrace', 3)
INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (4, N'Milano street 17', 7)
INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (5, N'Ulica v Rio', 5)
INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (6, N'Vitoshka 25', 1)
INSERT [dbo].[Addresses] ([AddressID], [Address_text], [TownID]) VALUES (7, N'Ruski 20', 9)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (1, N'Evropa')
INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (2, N'Asia')
INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (3, N'Sounh America')
INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (4, N'North America')
INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (5, N'Afrika')
INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (6, N'Australia')
INSERT [dbo].[Continents] ([ContinetID], [Name]) VALUES (7, N'Anctarctica')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (2, N'Germany', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (3, N'Canada', 4)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (4, N'Australia', 6)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (5, N'Nigeria', 5)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (6, N'Kenya', 5)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (7, N'Italy', 1)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (8, N'China', 2)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (9, N'Brazil', 3)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (10, N'Algir', 5)
INSERT [dbo].[Countries] ([CountryID], [Name], [ContinetID]) VALUES (11, N'UK', 1)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (1, N'Pesho', N'Petrov', 1)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (2, N'Ivan ', N'Iliev', 6)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (3, N'Fernando', N'Fernandov', 5)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (4, N'Gunter', N'Gras', 3)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (5, N'Angela', N'Merkel', 3)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (6, N'Boyko', N'Borisov', 2)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (7, N'Mitko', N'Mitkov ', 2)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (8, N'Marko', N'Materaci', 4)
INSERT [dbo].[Persons] ([PersonID], [FirstName], [LastName], [AddressID]) VALUES (9, N'Krum', N'Savov', 2)
SET IDENTITY_INSERT [dbo].[Persons] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (2, N'Varna', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (3, N'Berlin', 2)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (5, N'Rio', 9)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (7, N'Milano', 7)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (8, N'Sidney', 4)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (9, N'Plovdiv', 1)
INSERT [dbo].[Towns] ([TownID], [Name], [CountryID]) VALUES (10, N'Rome', 7)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownID])
REFERENCES [dbo].[Towns] ([TownID])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinetID])
REFERENCES [dbo].[Continents] ([ContinetID])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_Persons_Addresses] FOREIGN KEY([AddressID])
REFERENCES [dbo].[Addresses] ([AddressID])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_Persons_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries1] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries1]
GO
USE [master]
GO
ALTER DATABASE [WorldModelDB] SET  READ_WRITE 
GO
