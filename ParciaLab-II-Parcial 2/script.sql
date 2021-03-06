USE [master]
GO
/****** Object:  Database [Parcial_Pedidos]    Script Date: 24/11/2020 18:51:46 ******/
CREATE DATABASE [Parcial_Pedidos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parcial_Pedidos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Parcial_Pedidos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Parcial_Pedidos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Parcial_Pedidos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Parcial_Pedidos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parcial_Pedidos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Parcial_Pedidos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parcial_Pedidos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parcial_Pedidos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parcial_Pedidos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parcial_Pedidos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Parcial_Pedidos] SET  MULTI_USER 
GO
ALTER DATABASE [Parcial_Pedidos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parcial_Pedidos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Parcial_Pedidos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Parcial_Pedidos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Parcial_Pedidos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Parcial_Pedidos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Parcial_Pedidos] SET QUERY_STORE = OFF
GO
USE [Parcial_Pedidos]
GO
/****** Object:  Table [dbo].[bebida]    Script Date: 24/11/2020 18:51:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bebida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NOT NULL,
	[precio] [int] NOT NULL,
	[gusto] [nchar](25) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 24/11/2020 18:51:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NOT NULL,
	[tipoUno] [nchar](10) NULL,
	[pedidoUno] [int] NOT NULL,
	[tipoDos] [nchar](10) NULL,
	[pedidoDos] [int] NOT NULL,
	[totalAPagar] [int] NOT NULL,
	[lugarDeEntrega] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comidas]    Script Date: 24/11/2020 18:51:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comidas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](25) NOT NULL,
	[precio] [int] NOT NULL,
	[tipo] [nchar](25) NOT NULL,
	[condimentos] [nchar](5) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bebida] ON 

INSERT [dbo].[bebida] ([id], [nombre], [precio], [gusto]) VALUES (1, N'fanta     ', 125, N'con gas                  ')
INSERT [dbo].[bebida] ([id], [nombre], [precio], [gusto]) VALUES (2, N'pepsi     ', 135, N'con gas                  ')
INSERT [dbo].[bebida] ([id], [nombre], [precio], [gusto]) VALUES (3, N'agua      ', 110, N'sin gas                  ')
INSERT [dbo].[bebida] ([id], [nombre], [precio], [gusto]) VALUES (5, N'jugo      ', 135, N'sin gas                  ')
SET IDENTITY_INSERT [dbo].[bebida] OFF
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id], [nombre], [tipoUno], [pedidoUno], [tipoDos], [pedidoDos], [totalAPagar], [lugarDeEntrega]) VALUES (1, N'mauricio  ', N'comida    ', 1, N'bebida    ', 2, 325, N'local     ')
INSERT [dbo].[cliente] ([id], [nombre], [tipoUno], [pedidoUno], [tipoDos], [pedidoDos], [totalAPagar], [lugarDeEntrega]) VALUES (7, N'lucaino   ', N'comida    ', 2, N'comida    ', 2, 255, N'brasil    ')
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[comidas] ON 

INSERT [dbo].[comidas] ([id], [nombre], [precio], [tipo], [condimentos]) VALUES (1, N'pizza                    ', 200, N'sin verduras             ', N'true ')
INSERT [dbo].[comidas] ([id], [nombre], [precio], [tipo], [condimentos]) VALUES (2, N'tallarines               ', 120, N'vegetariana              ', N'false')
INSERT [dbo].[comidas] ([id], [nombre], [precio], [tipo], [condimentos]) VALUES (3, N'nioquis                  ', 130, N'no vegetariana           ', N'true ')
SET IDENTITY_INSERT [dbo].[comidas] OFF
GO
ALTER TABLE [dbo].[comidas] ADD  CONSTRAINT [DF_comidas_condimentos]  DEFAULT (N'X') FOR [condimentos]
GO
USE [master]
GO
ALTER DATABASE [Parcial_Pedidos] SET  READ_WRITE 
GO
