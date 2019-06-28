USE [ArqSoftwareDotNet]
GO
/****** Object:  Table [dbo].[Atendimento]    Script Date: 27/06/2019 16:05:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Atendimento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[Data] [datetime] NOT NULL,
	[Anamnese] [varchar](250) NULL,
	[ExameFisico] [varchar](250) NULL,
	[CIDPrincipal] [varchar](50) NULL,
	[DataCriacao] [datetime] NULL,
	[DataModificacao] [datetime] NULL,
 CONSTRAINT [PK_Atendimento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 27/06/2019 16:05:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](250) NOT NULL,
	[NomeMae] [varchar](250) NULL,
	[Nascimento] [date] NULL,
	[Sexo] [int] NULL,
	[DataCriacao] [datetime] NULL,
	[DataModificacao] [datetime] NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Atendimento]  WITH CHECK ADD  CONSTRAINT [FK_Atendimento_Paciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Paciente] ([Id])
GO
ALTER TABLE [dbo].[Atendimento] CHECK CONSTRAINT [FK_Atendimento_Paciente]
GO
