-- Cambiar a master para crear la base (opcional)
USE master;
GO

-- 1. CREACIÓN DE LA BASE DE DATOS (si no existe)
IF DB_ID(N'VETERINARIA_DB') IS NULL
BEGIN
    CREATE DATABASE VETERINARIA_DB;
END
GO

-- Usar la base de datos creada
USE VETERINARIA_DB;
GO

-------------------------------------------------------------------------------------------------------
-- 2. CREACIÓN DE TABLAS DE CATÁLOGO (ESPECIES, RAZAS, VETERINARIOS, SERVICIOS, ESTADOS_TURNO)
-------------------------------------------------------------------------------------------------------

-- ESPECIES
CREATE TABLE [dbo].[ESPECIES] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NULL,
	CONSTRAINT [PK_ESPECIES] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- RAZAS
CREATE TABLE [dbo].[RAZAS] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NULL,
	[IdEspecie] INT NULL,
	CONSTRAINT [PK_RAZAS] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- VETERINARIOS
CREATE TABLE [dbo].[VETERINARIOS] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] VARCHAR(100) NULL,
	[Matricula] VARCHAR(20) NULL,
	[Email] VARCHAR(100) NULL,
	[Telefono] VARCHAR(50) NULL,
	[Activo] BIT NULL CONSTRAINT DF_VETERINARIOS_Activo DEFAULT (1),
	CONSTRAINT [PK_VETERINARIOS] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- SERVICIOS
CREATE TABLE [dbo].[SERVICIOS] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] VARCHAR(100) NOT NULL,
	[Descripcion] VARCHAR(500) NULL,
	[CostoEstimado] MONEY NULL,
	[Activo] BIT NULL CONSTRAINT DF_SERVICIOS_Activo DEFAULT (1),
	CONSTRAINT [PK_SERVICIOS] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- ESTADOS_TURNO
CREATE TABLE [dbo].[ESTADOS_TURNO] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Descripcion] VARCHAR(50) NOT NULL,
	CONSTRAINT [PK_ESTADOS_TURNO] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-------------------------------------------------------------------------------------------------------
-- 3. CREACIÓN DE TABLAS TRANSACCIONALES (CLIENTES, PACIENTES, TURNOS, HISTORIAL_MEDICO)
-------------------------------------------------------------------------------------------------------

-- CLIENTES
CREATE TABLE [dbo].[CLIENTES] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] VARCHAR(100) NULL,
	[DNI_CUIT] VARCHAR(20) NULL,
	[Email] VARCHAR(100) NULL,
	[Telefono] VARCHAR(50) NULL,
	[Direccion] VARCHAR(250) NULL,
	[Localidad] VARCHAR(100) NULL,
	[Activo] BIT NULL CONSTRAINT DF_CLIENTES_Activo DEFAULT (1),
	CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- PACIENTES
CREATE TABLE [dbo].[PACIENTES] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Nombre] VARCHAR(50) NULL,
	[IdEspecie] INT NULL,
	[IdRaza] INT NULL,
	[IdCliente] INT NULL,
	[FechaNacimiento] DATE NULL,
	[Sexo] CHAR(1) NULL,
	[ColorPelaje] VARCHAR(50) NULL,
	[Peso] DECIMAL(8,2) NULL,
	[ObservacionesGenerales] VARCHAR(500) NULL,
	[Activo] BIT NULL CONSTRAINT DF_PACIENTES_Activo DEFAULT (1),
	CONSTRAINT [PK_PACIENTES] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- TURNOS 
CREATE TABLE [dbo].[TURNOS] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IdPaciente] INT NOT NULL,
	[IdVeterinario] INT NOT NULL,
	[IdServicio] INT NOT NULL,
	[FechaHoraInicio] DATETIME NOT NULL,
	[IdEstado] INT NOT NULL,
	[NotasInternas] VARCHAR(250) NULL,
	CONSTRAINT [PK_TURNOS] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-- HISTORIAL_MEDICO
CREATE TABLE [dbo].[HISTORIAL_MEDICO] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[IdTurno] INT NOT NULL,
	[MotivoConsulta] VARCHAR(200) NULL,
	[Diagnostico] VARCHAR(500) NULL,
	[Tratamiento] VARCHAR(500) NULL,
	[PrecioFinal] MONEY NULL,
	CONSTRAINT [PK_HISTORIAL_MEDICO] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

-------------------------------------------------------------------------------------------------------
-- 4. DEFINICIÓN DE CLAVES FORÁNEAS
-------------------------------------------------------------------------------------------------------

ALTER TABLE [dbo].[RAZAS]
ADD CONSTRAINT [FK_RAZAS_ESPECIES] FOREIGN KEY([IdEspecie])
REFERENCES [dbo].[ESPECIES]([Id]);
GO

ALTER TABLE [dbo].[PACIENTES]
ADD CONSTRAINT [FK_PACIENTES_ESPECIES] FOREIGN KEY([IdEspecie])
REFERENCES [dbo].[ESPECIES]([Id]);
GO

ALTER TABLE [dbo].[PACIENTES]
ADD CONSTRAINT [FK_PACIENTES_RAZAS] FOREIGN KEY([IdRaza])
REFERENCES [dbo].[RAZAS]([Id]);
GO

ALTER TABLE [dbo].[PACIENTES]
ADD CONSTRAINT [FK_PACIENTES_CLIENTES] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[CLIENTES]([Id]);
GO

ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [FK_TURNOS_PACIENTES] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[PACIENTES]([Id]);
GO

ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [FK_TURNOS_VETERINARIOS] FOREIGN KEY([IdVeterinario])
REFERENCES [dbo].[VETERINARIOS]([Id]);
GO

ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [FK_TURNOS_SERVICIOS] FOREIGN KEY([IdServicio])
REFERENCES [dbo].[SERVICIOS]([Id]);
GO

ALTER TABLE [dbo].[TURNOS]
ADD CONSTRAINT [FK_TURNOS_ESTADOS] FOREIGN KEY([IdEstado])
REFERENCES [dbo].[ESTADOS_TURNO]([Id]);
GO

ALTER TABLE [dbo].[HISTORIAL_MEDICO]
ADD CONSTRAINT [FK_HISTORIAL_TURNOS] FOREIGN KEY([IdTurno])
REFERENCES [dbo].[TURNOS]([Id]);
GO

-------------------------------------------------------------------------------------------------------
-- 5. INSERCIÓN DE DATOS DE EJEMPLO
-------------------------------------------------------------------------------------------------------

INSERT INTO [dbo].[ESPECIES] ([Descripcion]) VALUES
('Perro'),
('Gato'),
('Ave'),
('Roedor');
GO

INSERT INTO [dbo].[RAZAS] ([Descripcion], [IdEspecie]) VALUES
('Labrador Retriever', 1),
('Pastor Alemán', 1),
('Chihuahua', 1),
('Siamés', 2),
('Persa', 2),
('Común Europeo', 2);
GO

INSERT INTO [dbo].[VETERINARIOS] ([Nombre], [Matricula], [Email], [Telefono], [Activo]) VALUES
('Dr. Ricardo Castro', 'MP-1548', 'ricardo.vet@clinic.com', '1155551234', 1),
('Dra. Sol Martínez', 'MP-3091', 'sol.martinez@vetpro.com', '1144445678', 1);
GO

INSERT INTO [dbo].[SERVICIOS] ([Nombre], [Descripcion], [CostoEstimado]) VALUES
(N'Consultas Generales', N'Exámenes físicos y evaluación de salud general.', 1800),
(N'Vacunaciones', N'Aplicación de vacunas esenciales.', 1500),
(N'Desparasitaciones', N'Tratamientos contra parásitos internos y externos.', 1000),
(N'Esterilización y Castración', N'Cirugías básicas de control reproductivo.', 6000),
(N'Tratamiento Afecciones Comunes', N'Atención de infecciones leves o heridas.', 2000),
(N'Cuidado Dental Básico', N'Revisión y limpieza dental manual.', 2500),
(N'Atención de Emergencias Básicas', N'Primeros auxilios para estabilizar casos leves.', 3000),
(N'Asesoramiento General', N'Consejos sobre alimentación, higiene y cuidado preventivo.', 1000),
(N'Certificados de Salud', N'Emisión de certificados básicos para viajes o adopciones.', 800),
(N'Farmacia Básica - Suministro', N'Entrega y venta de medicamentos comunes y antiparasitarios.', 500);
GO

INSERT INTO [dbo].[ESTADOS_TURNO] ([Descripcion]) VALUES
(N'Atendido'),
(N'Confirmado'),
(N'Pendiente'),
(N'Cancelado');
GO

INSERT INTO [dbo].[CLIENTES] ([Nombre], [DNI_CUIT], [Email], [Telefono], [Direccion], [Localidad], [Activo]) VALUES
(N'Mariana Rodríguez', '28555123', 'mariana.ejemplo@mail.com', '1122334455', N'Av. Rivadavia 1234', N'CABA', 1),
(N'Carlos Sánchez', '30999456', 'carlos.ejemplo@mail.com', '1133224455', N'Calle Falsa 100', N'Quilmes', 1);
GO

INSERT INTO [dbo].[PACIENTES] ([Nombre], [IdEspecie], [IdRaza], [IdCliente], [FechaNacimiento], [Sexo], [ColorPelaje], [Peso], [ObservacionesGenerales], [Activo]) VALUES
(N'Bobby', 1, 1, 1, '2018-05-15', 'M', N'Dorado', 32.50, N'Requiere medicación diaria.', 1),
(N'Luna', 2, 4, 2, '2020-11-20', 'H', N'Blanco y Negro', 4.10, N'Muy nerviosa en la consulta.', 1);
GO

INSERT INTO [dbo].[TURNOS] ([IdPaciente], [IdVeterinario], [IdServicio], [FechaHoraInicio], [IdEstado]) VALUES
(1, 1, 1, DATEADD(hour, -10, GETDATE()), 1);
GO

INSERT INTO [dbo].[TURNOS] ([IdPaciente], [IdVeterinario], [IdServicio], [FechaHoraInicio], [IdEstado]) VALUES
(2, 2, 2, DATEADD(day, 2, DATEADD(hour, 15, GETDATE())), 3);
GO

INSERT INTO [dbo].[HISTORIAL_MEDICO] ([IdTurno], [MotivoConsulta], [Diagnostico], [Tratamiento], [PrecioFinal]) VALUES
(1, N'Control anual y chequeo de cadera.', N'Artritis leve controlada.', N'Ajuste de dosis de AINEs.', 1800);
GO