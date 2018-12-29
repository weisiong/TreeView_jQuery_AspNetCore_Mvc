USE [master]
GO

CREATE DATABASE [VehiclesDB]
GO

USE [VehiclesDB]
GO

CREATE TABLE [VehicleTypes](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_VehicleTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
-----------------

CREATE TABLE [VehicleSubTypes](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[VehicleTypeId] [int] NOT NULL,
 CONSTRAINT [PK_VehicleSubTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[VehicleSubTypes]  WITH CHECK ADD  CONSTRAINT [FK_VehicleSubTypes_VehicleTypes] FOREIGN KEY([VehicleTypeId])
REFERENCES [dbo].[VehicleTypes] ([Id])
GO

ALTER TABLE [dbo].[VehicleSubTypes] CHECK CONSTRAINT [FK_VehicleSubTypes_VehicleTypes]
GO


-----------------------
INSERT INTO [VehicleTypes]
           ([Id]
           ,[Name])
     VALUES
           (1
           ,'Cars')
GO
INSERT INTO [VehicleTypes]
           ([Id]
           ,[Name])
     VALUES
           (2
           ,'Bikes')
GO
--------------------------
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (1
           , 'Alto'
           , 1)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (2
           , 'WagonR'
           ,1)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (3
           , 'Scorpio'
           , 1)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (4
           , 'Duster'
           ,1)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (5
           , 'Discover'
           ,2)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (6
           , 'Avenger'
           ,2)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (7
           , 'Unicorn'
           ,2)           
GO
INSERT INTO [VehicleSubTypes]
           ([Id]
           ,[Name]
           ,[VehicleTypeId])
     VALUES
           (8
           , 'Karizma'
           ,2)           
GO

