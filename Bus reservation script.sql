USE [master]
GO

/****** Object:  Database [BusReservation]    Script Date: 21-11-2021 12:06:03 ******/
CREATE DATABASE [BusReservation]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusReservation', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MASQLEXPRESS\MSSQL\DATA\BusReservation.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusReservation_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MASQLEXPRESS\MSSQL\DATA\BusReservation_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusReservation].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BusReservation] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BusReservation] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BusReservation] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BusReservation] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BusReservation] SET ARITHABORT OFF 
GO

ALTER DATABASE [BusReservation] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [BusReservation] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BusReservation] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BusReservation] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BusReservation] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BusReservation] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BusReservation] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BusReservation] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BusReservation] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BusReservation] SET  ENABLE_BROKER 
GO

ALTER DATABASE [BusReservation] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BusReservation] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BusReservation] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BusReservation] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BusReservation] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BusReservation] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BusReservation] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BusReservation] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BusReservation] SET  MULTI_USER 
GO

ALTER DATABASE [BusReservation] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BusReservation] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BusReservation] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BusReservation] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BusReservation] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BusReservation] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BusReservation] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BusReservation] SET  READ_WRITE 
GO

