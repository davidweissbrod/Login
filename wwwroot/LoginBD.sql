USE [master]
GO
/****** Object:  Database [LoginBD]    Script Date: 28/9/2023 08:22:35 ******/
CREATE DATABASE [LoginBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LoginBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LoginBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LoginBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LoginBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LoginBD] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoginBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoginBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LoginBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LoginBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LoginBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LoginBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [LoginBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LoginBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LoginBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LoginBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LoginBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LoginBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LoginBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LoginBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LoginBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LoginBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LoginBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LoginBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LoginBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LoginBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LoginBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LoginBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LoginBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LoginBD] SET RECOVERY FULL 
GO
ALTER DATABASE [LoginBD] SET  MULTI_USER 
GO
ALTER DATABASE [LoginBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LoginBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LoginBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LoginBD] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LoginBD] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LoginBD', N'ON'
GO
ALTER DATABASE [LoginBD] SET QUERY_STORE = OFF
GO
USE [LoginBD]
GO
/****** Object:  User [alumno]    Script Date: 28/9/2023 08:22:35 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 28/9/2023 08:22:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[contraseña] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[mail] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Usuario] ([idUsuario], [username], [contraseña], [nombre], [apellido], [mail]) VALUES (1, N'juanceto07', N'ostras', N'Juan', N'Martinez', N'juanceto@gmail.com')
INSERT [dbo].[Usuario] ([idUsuario], [username], [contraseña], [nombre], [apellido], [mail]) VALUES (2, N'AguenteChicago', N'chicagoVamos', N'Julian', N'Roitman', N'julianroitman@gmail.com')
INSERT [dbo].[Usuario] ([idUsuario], [username], [contraseña], [nombre], [apellido], [mail]) VALUES (3, N'san06', N'ianroitman06', N'Santiago', N'Butler', N'san2006@gmail.com')
INSERT [dbo].[Usuario] ([idUsuario], [username], [contraseña], [nombre], [apellido], [mail]) VALUES (4, N'pajachi', N'boca', N'Thiago', N'Palachi', N'thiapala@gmail.com')
INSERT [dbo].[Usuario] ([idUsuario], [username], [contraseña], [nombre], [apellido], [mail]) VALUES (5, N'leito', N'messi', N'Leonel', N'Kristal', N'leo.kristal@gmail.com')
GO
USE [master]
GO
ALTER DATABASE [LoginBD] SET  READ_WRITE 
GO
