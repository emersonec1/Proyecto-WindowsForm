USE [master]
GO
/****** Object:  Database [bibliotecaEmerson]    Script Date: 10-06-2025 16:56:45 ******/
CREATE DATABASE [bibliotecaEmerson]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bibliotecaEmerson', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\bibliotecaEmerson.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bibliotecaEmerson_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\bibliotecaEmerson_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [bibliotecaEmerson] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bibliotecaEmerson].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bibliotecaEmerson] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET ARITHABORT OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bibliotecaEmerson] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bibliotecaEmerson] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bibliotecaEmerson] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bibliotecaEmerson] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bibliotecaEmerson] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bibliotecaEmerson] SET  MULTI_USER 
GO
ALTER DATABASE [bibliotecaEmerson] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bibliotecaEmerson] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bibliotecaEmerson] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bibliotecaEmerson] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bibliotecaEmerson] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bibliotecaEmerson] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [bibliotecaEmerson] SET QUERY_STORE = ON
GO
ALTER DATABASE [bibliotecaEmerson] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [bibliotecaEmerson]
GO
/****** Object:  Table [dbo].[Lector]    Script Date: 10-06-2025 16:56:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lector](
	[idLector] [int] IDENTITY(1,1) NOT NULL,
	[Run] [varchar](13) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[fono] [int] NULL,
	[direccion] [varchar](200) NOT NULL,
	[sexo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libro]    Script Date: 10-06-2025 16:56:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libro](
	[IdLibro] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[Autor] [varchar](100) NOT NULL,
	[Editorial] [varchar](100) NULL,
	[ISBN] [varchar](20) NULL,
	[AñoPublicacion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamo]    Script Date: 10-06-2025 16:56:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamo](
	[IdPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdLector] [int] NOT NULL,
	[FechaPrestamo] [date] NOT NULL,
	[FechaDevolucion] [date] NULL,
	[idLibro] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 10-06-2025 16:56:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[NombreRol] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10-06-2025 16:56:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Contraseña] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Lector] ON 

INSERT [dbo].[Lector] ([idLector], [Run], [Nombre], [Apellido], [email], [fono], [direccion], [sexo]) VALUES (9, N'15.628.694-k', N'nani', N'ninini', N'nnn@nnn.cl', 9384838, N'poppp 13', N'Femenino')
INSERT [dbo].[Lector] ([idLector], [Run], [Nombre], [Apellido], [email], [fono], [direccion], [sexo]) VALUES (10, N'1-9', N'asd', N'aaa', N'asd@a.com', 123, N'asd', N'Femenino')
SET IDENTITY_INSERT [dbo].[Lector] OFF
GO
SET IDENTITY_INSERT [dbo].[Libro] ON 

INSERT [dbo].[Libro] ([IdLibro], [Titulo], [Autor], [Editorial], [ISBN], [AñoPublicacion]) VALUES (2, N'Harry Potter', N'JK Rowling', N'Nose', N'3345534a', 2000)
INSERT [dbo].[Libro] ([IdLibro], [Titulo], [Autor], [Editorial], [ISBN], [AñoPublicacion]) VALUES (3, N'1', N'1a', N'1', N'1', 1231)
SET IDENTITY_INSERT [dbo].[Libro] OFF
GO
SET IDENTITY_INSERT [dbo].[Prestamo] ON 

INSERT [dbo].[Prestamo] ([IdPrestamo], [IdUsuario], [IdLector], [FechaPrestamo], [FechaDevolucion], [idLibro]) VALUES (3, 1, 9, CAST(N'2025-06-11' AS Date), CAST(N'2025-06-18' AS Date), 2)
INSERT [dbo].[Prestamo] ([IdPrestamo], [IdUsuario], [IdLector], [FechaPrestamo], [FechaDevolucion], [idLibro]) VALUES (4, 4, 9, CAST(N'2025-06-10' AS Date), CAST(N'2025-06-12' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Prestamo] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (1, N'Administrador')
INSERT [dbo].[Rol] ([IdRol], [NombreRol]) VALUES (2, N'Bibliotecario')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [IdRol], [Nombre], [Apellido], [Correo], [Contraseña]) VALUES (1, 1, N'Emerson', N'Castillo', N'ee@ee.cl', N'123')
INSERT [dbo].[Usuario] ([IdUsuario], [IdRol], [Nombre], [Apellido], [Correo], [Contraseña]) VALUES (4, 2, N'Ayleen', N'Castillo', N'ac@ac.cl', N'123')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Lector__CAF0366E4EB47A15]    Script Date: 10-06-2025 16:56:45 ******/
ALTER TABLE [dbo].[Lector] ADD UNIQUE NONCLUSTERED 
(
	[Run] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Libro__447D36EA513A5BAF]    Script Date: 10-06-2025 16:56:45 ******/
ALTER TABLE [dbo].[Libro] ADD UNIQUE NONCLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Rol__4F0B537FCDF396AE]    Script Date: 10-06-2025 16:56:45 ******/
ALTER TABLE [dbo].[Rol] ADD UNIQUE NONCLUSTERED 
(
	[NombreRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuario__60695A196FEDE3E6]    Script Date: 10-06-2025 16:56:45 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD FOREIGN KEY([IdLector])
REFERENCES [dbo].[Lector] ([idLector])
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD FOREIGN KEY([idLibro])
REFERENCES [dbo].[Libro] ([IdLibro])
GO
ALTER TABLE [dbo].[Prestamo]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
USE [master]
GO
ALTER DATABASE [bibliotecaEmerson] SET  READ_WRITE 
GO
