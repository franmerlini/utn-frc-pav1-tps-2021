USE [BugTrackerTPI]
GO
/****** Object:  Table [dbo].[Asignaciones]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaciones](
	[id_asignacion] [int] IDENTITY(1,1) NOT NULL,
	[n_asignacion] [varchar](40) NOT NULL,
	[monto] [numeric](10, 2) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_asignacion] PRIMARY KEY CLUSTERED 
(
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsistenciaUsuarios]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsistenciaUsuarios](
	[fecha] [date] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_estado_asistencia] [int] NOT NULL,
	[comentario] [varchar](500) NULL,
	[hora_ingreso] [time](7) NULL,
	[hora_salida] [time](7) NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_AsistenciaUsuarios_1] PRIMARY KEY CLUSTERED 
(
	[fecha] ASC,
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Descuentos]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuentos](
	[id_descuento] [int] IDENTITY(1,1) NOT NULL,
	[n_descuento] [varchar](40) NOT NULL,
	[monto] [numeric](10, 2) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_descuento] PRIMARY KEY CLUSTERED 
(
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosAsistencia]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosAsistencia](
	[id_estado_asistencia] [int] NOT NULL,
	[n_estados_asistencia] [varchar](20) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_estados_asistencia] PRIMARY KEY CLUSTERED 
(
	[id_estado_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoAsignaciones]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoAsignaciones](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_asignacion] [int] NOT NULL,
	[monto] [numeric](10, 2) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_sueldoasignacion] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC,
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoDescuentos]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoDescuentos](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_descuento] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[monto] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldoDescuento] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC,
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoPerfilHistorico]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoPerfilHistorico](
	[id_perfil] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[sueldo] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldoPerfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sueldos]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sueldos](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[sueldo_bruto] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldo] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/10/2021 11:05:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Asignaciones] ON 

INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (1, N'Presentismo', CAST(10000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (2, N'Hijos', CAST(5000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (3, N'Título Universitario', CAST(12000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (4, N'Título Terciario', CAST(8000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (5, N'Título Técnico', CAST(6000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (6, N'Permanencia', CAST(10800.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (7, N'Productividad', CAST(20000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (8, N'Horas Extras', CAST(500.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto], [borrado]) VALUES (9, N'Otros', CAST(1333.00 AS Numeric(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Asignaciones] OFF
GO
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2018-09-12' AS Date), 1, 3, NULL, CAST(N'05:00:00' AS Time), CAST(N'03:00:00' AS Time), 0)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2018-09-12' AS Date), 4, 2, N'32', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-07-13' AS Date), 7, 1, N'pedro', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-01' AS Date), 8, 1, N'', CAST(N'21:39:00' AS Time), CAST(N'21:39:00' AS Time), 0)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-20' AS Date), 28, 1, N'Presente', CAST(N'08:00:00' AS Time), CAST(N'16:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-21' AS Date), 4, 2, N'Se nos perdió miguel', CAST(N'22:55:00' AS Time), CAST(N'22:55:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-21' AS Date), 8, 2, N'Injustificado', CAST(N'22:42:00' AS Time), CAST(N'23:42:00' AS Time), 0)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-22' AS Date), 4, 1, N'Prueba', CAST(N'13:12:00' AS Time), CAST(N'15:12:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-23' AS Date), 4, 2, N'Prueba', CAST(N'17:28:00' AS Time), CAST(N'17:28:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-24' AS Date), 28, 6, N'', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-24' AS Date), 29, 6, N'', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-24' AS Date), 35, 6, N'', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-09-29' AS Date), 6, 3, N'Le agarró el covid', CAST(N'22:43:00' AS Time), CAST(N'22:43:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-10-09' AS Date), 1, 1, N'', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
INSERT [dbo].[AsistenciaUsuarios] ([fecha], [id_usuario], [id_estado_asistencia], [comentario], [hora_ingreso], [hora_salida], [borrado]) VALUES (CAST(N'2021-10-12' AS Date), 7, 6, N'', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), 1)
GO
SET IDENTITY_INSERT [dbo].[Descuentos] ON 

INSERT [dbo].[Descuentos] ([id_descuento], [n_descuento], [monto], [borrado]) VALUES (1, N'Gastos', CAST(500.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Descuentos] ([id_descuento], [n_descuento], [monto], [borrado]) VALUES (2, N'Gastos2', CAST(1000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Descuentos] ([id_descuento], [n_descuento], [monto], [borrado]) VALUES (3, N'Gastos3', CAST(100000.00 AS Numeric(10, 2)), 0)
INSERT [dbo].[Descuentos] ([id_descuento], [n_descuento], [monto], [borrado]) VALUES (4, N'Gastos4', CAST(500.00 AS Numeric(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Descuentos] OFF
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia], [borrado]) VALUES (1, N'Presente', 0)
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia], [borrado]) VALUES (2, N'Ausente', 0)
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia], [borrado]) VALUES (3, N'Carpeta Médica', 0)
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia], [borrado]) VALUES (4, N'Licencia x Estudios', 0)
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia], [borrado]) VALUES (5, N'Licencia Vacaciones', 0)
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia], [borrado]) VALUES (6, N'Sin Asignar', 0)
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 

INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Tester', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Desarrollador', 0)
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (4, N'Responsable de Reportes', 0)
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
INSERT [dbo].[SueldoAsignaciones] ([id_usuario], [fecha], [id_asignacion], [monto], [cantidad]) VALUES (1, CAST(N'2021-10-16' AS Date), 2, CAST(15000.00 AS Numeric(10, 2)), 3)
INSERT [dbo].[SueldoAsignaciones] ([id_usuario], [fecha], [id_asignacion], [monto], [cantidad]) VALUES (1, CAST(N'2021-10-17' AS Date), 2, CAST(15000.00 AS Numeric(10, 2)), 3)
INSERT [dbo].[SueldoAsignaciones] ([id_usuario], [fecha], [id_asignacion], [monto], [cantidad]) VALUES (8, CAST(N'2021-10-14' AS Date), 8, CAST(5000.00 AS Numeric(10, 2)), 10)
INSERT [dbo].[SueldoAsignaciones] ([id_usuario], [fecha], [id_asignacion], [monto], [cantidad]) VALUES (8, CAST(N'2021-10-15' AS Date), 7, CAST(20000.00 AS Numeric(10, 2)), 1)
INSERT [dbo].[SueldoAsignaciones] ([id_usuario], [fecha], [id_asignacion], [monto], [cantidad]) VALUES (8, CAST(N'2021-10-16' AS Date), 7, CAST(20000.00 AS Numeric(10, 2)), 1)
INSERT [dbo].[SueldoAsignaciones] ([id_usuario], [fecha], [id_asignacion], [monto], [cantidad]) VALUES (8, CAST(N'2021-10-17' AS Date), 2, CAST(15000.00 AS Numeric(10, 2)), 3)
GO
INSERT [dbo].[SueldoDescuentos] ([id_usuario], [fecha], [id_descuento], [cantidad], [monto]) VALUES (8, CAST(N'2021-10-14' AS Date), 1, 3, CAST(1500.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2021-10-12' AS Date), CAST(1111.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2021-10-13' AS Date), CAST(1111110.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2021-10-14' AS Date), CAST(100000.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2021-10-15' AS Date), CAST(200000.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2021-10-16' AS Date), CAST(200000.00 AS Numeric(10, 2)))
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2021-10-17' AS Date), CAST(240000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (1, CAST(N'2021-10-13' AS Date), CAST(1500.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (1, CAST(N'2021-10-16' AS Date), CAST(200000.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (1, CAST(N'2021-10-17' AS Date), CAST(240000.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (8, CAST(N'2021-10-12' AS Date), CAST(1111.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (8, CAST(N'2021-10-13' AS Date), CAST(1111110.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (8, CAST(N'2021-10-14' AS Date), CAST(100000.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (8, CAST(N'2021-10-15' AS Date), CAST(200000.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (8, CAST(N'2021-10-16' AS Date), CAST(200000.00 AS Numeric(10, 2)))
INSERT [dbo].[Sueldos] ([id_usuario], [fecha], [sueldo_bruto]) VALUES (8, CAST(N'2021-10-17' AS Date), CAST(220000.00 AS Numeric(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'administrador', N'123', N'admin@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'Tester Ariel', N'12345', N'ariel@gmail.com', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 3, N'Tester Miguel', N'12345', N'miguel@gmail.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 2, N'Tester Ana', N'12345', N'ana@gmail.com', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 3, N'Tester Diego', N'12345', N'diego@gmail.com', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 4, N'Tester Micaela', N'12345', N'mica@gmail.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (8, 1, N'ADMIN', N'123', N'admin@gmail.com', N'A', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (25, 1, N'Port', N'dQfDcIXQh', N'pwilhelmy0@youtube.com', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (26, 4, N'Eva', N'6UmXjb70', N'espensly1@tiny.cc', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (27, 2, N'Bell', N'egHhmXdr', N'bswyne2@ihg.com', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (28, 4, N'Julio', N'A3uTqLK2', N'jpryell3@china.com.cn', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (29, 1, N'Mirelle', N'ZYp80Gi', N'mvenour4@digg.com', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (30, 2, N'Baxter', N'7xuPhKgP', N'bhadden5@phpbb.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (31, 4, N'Donnell', N'hpMtnfWR', N'dbraffington6@theatlantic.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (33, 1, N'Thadeus', N'BruJOx3av', N'tsummergill8@youku.com', N'S', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (34, 4, N'Milka', N'WCerS2', N'mjouannisson9@mozilla.com', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (35, 3, N'Creighton', N'PK6EhU2tJ3', N'creckea@sohu.com', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (36, 4, N'Car', N'PC5icbmaCv', N'cspadonib@nps.gov', N'N', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (44, 2, N'Alejandro', N'123', N'alejandro@gmail.com', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (45, 1, N'franky', N'admin123', N'correo@email.com', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (46, 2, N'TESTER', N'123', N'tester@hotmail.com', N'A', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2045, 1, N'marcos', N'admin123', N'marcuchi@gmail.com', N'A', 1)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2046, 3, N'DESARROLLADOR', N'123', N'desarrollador@gmail.com', N'A', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2047, 4, N'REPORTES', N'123', N'reportes@gmail.com', N'S', 0)
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2048, 1, N'admin1', N'123', N'a', N'A', 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Usuarios]    Script Date: 27/10/2021 11:05:46 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Usuarios] ON [dbo].[Usuarios]
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asignaciones] ADD  CONSTRAINT [DF__Asignacio__borra__4C6B5938]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Descuentos] ADD  CONSTRAINT [DF__Descuento__borra__498EEC8D]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[EstadosAsistencia] ADD  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[AsistenciaUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_AsistenciaUsuarios_EstadosAsistencia] FOREIGN KEY([id_estado_asistencia])
REFERENCES [dbo].[EstadosAsistencia] ([id_estado_asistencia])
GO
ALTER TABLE [dbo].[AsistenciaUsuarios] CHECK CONSTRAINT [FK_AsistenciaUsuarios_EstadosAsistencia]
GO
ALTER TABLE [dbo].[AsistenciaUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_AsistenciaUsuarios_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[AsistenciaUsuarios] CHECK CONSTRAINT [FK_AsistenciaUsuarios_Usuarios]
GO
ALTER TABLE [dbo].[SueldoAsignaciones]  WITH CHECK ADD  CONSTRAINT [fk_seldoAsig_asignacion] FOREIGN KEY([id_asignacion])
REFERENCES [dbo].[Asignaciones] ([id_asignacion])
GO
ALTER TABLE [dbo].[SueldoAsignaciones] CHECK CONSTRAINT [fk_seldoAsig_asignacion]
GO
ALTER TABLE [dbo].[SueldoAsignaciones]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_asig] FOREIGN KEY([id_usuario], [fecha])
REFERENCES [dbo].[Sueldos] ([id_usuario], [fecha])
GO
ALTER TABLE [dbo].[SueldoAsignaciones] CHECK CONSTRAINT [fk_sueldo_asig]
GO
ALTER TABLE [dbo].[SueldoDescuentos]  WITH CHECK ADD  CONSTRAINT [fk_seldoDesc_descuento] FOREIGN KEY([id_descuento])
REFERENCES [dbo].[Descuentos] ([id_descuento])
GO
ALTER TABLE [dbo].[SueldoDescuentos] CHECK CONSTRAINT [fk_seldoDesc_descuento]
GO
ALTER TABLE [dbo].[SueldoDescuentos]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_desc] FOREIGN KEY([id_usuario], [fecha])
REFERENCES [dbo].[Sueldos] ([id_usuario], [fecha])
GO
ALTER TABLE [dbo].[SueldoDescuentos] CHECK CONSTRAINT [fk_sueldo_desc]
GO
ALTER TABLE [dbo].[SueldoPerfilHistorico]  WITH CHECK ADD  CONSTRAINT [fk_sueldoPerfil_permfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[SueldoPerfilHistorico] CHECK CONSTRAINT [fk_sueldoPerfil_permfiles]
GO
ALTER TABLE [dbo].[Sueldos]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Sueldos] CHECK CONSTRAINT [fk_sueldo_usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
