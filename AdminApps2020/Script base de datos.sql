
CREATE DATABASE [ADMINAPPS]
USE [ADMINAPPS]

-- Creacion de tablas
CREATE TABLE [dbo].[ACTIVIDAD](
	[Fecha] [date] NULL,
	[Tipo] [varchar](50),
	[Nombre] [varchar](max),
	[Descripcion] [varchar](max),
	[Aplicacion] [varchar](250),
	[Usuario] [varchar](50),
	[Estado] [nchar](10),
	[Id] [int] IDENTITY(1,1) PRIMARY KEY
)

CREATE TABLE [dbo].[ACTIVIDADDETALLE](
	[Fecha] [date] NULL,
	[Descripcion] [varchar](max),
	[Minutos] [int],
	[Responsable] [varchar](250),
	[Observaciones] [varchar](max),
	[ActividadId] [int] FOREIGN KEY REFERENCES [dbo].[ACTIVIDAD](Id),
	[Id] [int] IDENTITY(1,1) PRIMARY KEY
)

CREATE TABLE [dbo].[PROVEEDOR](
	[Proveedor] [varchar](250) NULL,
	[Nit] [varchar](50) NULL,
	[Observaciones] [varchar](max) NULL,
	[Estado] [bit] NULL,
	[Id] [int] IDENTITY(1,1) PRIMARY KEY
)

CREATE TABLE [dbo].[CONTACTO](
	[Nombres] [varchar](250),
	[Cargo] [varchar](50),
	[Telefonos] [varchar](50),
	[Ext] [varchar](10),
	[Celulares] [varchar](50),
	[Observaciones] [varchar](max),
	[Correos] [varchar](max),
	[Vpn] [varchar](50),
	[ProveedorId] [int] FOREIGN KEY REFERENCES [dbo].[PROVEEDOR](Id),
	[Estado] [bit],
	[Id] [int] IDENTITY(1,1) PRIMARY KEY 
)

CREATE TABLE [dbo].[SERVIDOR](
	[Nombre] [varchar](250),
	[Ip] [varchar](50),
	[Usuario] [varchar](50),
	[Pw] [varchar](50),
	[Ambiente] [varchar](50),
	[Descripcion] [varchar](max),
	[Observaciones] [varchar](max),
	[Tipo] [varchar](50),
	[Estado] [bit],
	[Id] [int] IDENTITY(1,1) PRIMARY KEY
)

CREATE TABLE [dbo].[APLICACION](
	[Nombre] [varchar](250),
	[Descripcion] [varchar](max),
	[Tipo] [varchar](50),
	[Administrador] [varchar](50),
	[Observaciones] [varchar](max),
	[ProveedorId] [int] FOREIGN KEY REFERENCES [dbo].[PROVEEDOR](Id),
	[ServidorId] [int] FOREIGN KEY REFERENCES [dbo].[SERVIDOR](Id),
	[Estado] [bit],
	[Id] [int] IDENTITY(1,1)
)

CREATE TABLE [dbo].[USUARIO](
	[Usuario] [varchar](50) UNIQUE,
	[Contraseña] [varchar](15),
	[Nivel] [varchar](50),
	[Estado] [bit],
	[Id] [int] IDENTITY(1,1) PRIMARY KEY
)

-- Creacion de vistas
CREATE VIEW [dbo].[ACTIVIDADINFORME_VIEW]
AS
SELECT        dbo.ACTIVIDAD.Fecha, dbo.ACTIVIDAD.Tipo, dbo.ACTIVIDAD.Nombre, dbo.ACTIVIDAD.Descripcion, dbo.ACTIVIDAD.Aplicacion, dbo.ACTIVIDAD.Usuario, dbo.ACTIVIDAD.Estado, dbo.ACTIVIDAD.Id, 
                         dbo.ACTIVIDADDETALLE.Fecha AS FechaDet, dbo.ACTIVIDADDETALLE.Descripcion AS DescripcionDet, dbo.ACTIVIDADDETALLE.Observaciones
FROM            dbo.ACTIVIDAD INNER JOIN
                         dbo.ACTIVIDADDETALLE ON dbo.ACTIVIDAD.Id = dbo.ACTIVIDADDETALLE.ActividadId


CREATE VIEW [dbo].[APLICACION_VIEW]
AS
SELECT        dbo.PROVEEDOR.Proveedor, dbo.SERVIDOR.Nombre AS Servidor, dbo.SERVIDOR.Ip, dbo.SERVIDOR.Ambiente, dbo.APLICACION.Nombre AS Aplicacion, dbo.APLICACION.Descripcion, dbo.APLICACION.Tipo, 
                         dbo.APLICACION.Administrador, dbo.APLICACION.Observaciones, dbo.APLICACION.ProveedorId, dbo.APLICACION.ServidorId, dbo.APLICACION.Estado, dbo.APLICACION.Id
FROM            dbo.PROVEEDOR INNER JOIN
                         dbo.APLICACION ON dbo.PROVEEDOR.Id = dbo.APLICACION.ProveedorId INNER JOIN
                         dbo.SERVIDOR ON dbo.SERVIDOR.Id = dbo.APLICACION.ServidorId

CREATE VIEW [dbo].[CONTACTO_VIEW]
AS
SELECT        dbo.PROVEEDOR.Proveedor, dbo.CONTACTO.Nombres, dbo.CONTACTO.Cargo, dbo.CONTACTO.Telefonos, dbo.CONTACTO.Ext, dbo.CONTACTO.Celulares, dbo.CONTACTO.Observaciones, dbo.CONTACTO.Correos, 
                         dbo.CONTACTO.Vpn, dbo.CONTACTO.ProveedorId, dbo.CONTACTO.Estado, dbo.CONTACTO.Id
FROM            dbo.PROVEEDOR INNER JOIN
                         dbo.CONTACTO ON dbo.PROVEEDOR.Id = dbo.CONTACTO.ProveedorId

-- REINICIAR ID
DBCC CHECKIDENT (<nombre_tabla>, RESEED,0)