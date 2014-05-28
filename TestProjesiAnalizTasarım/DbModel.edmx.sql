
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2014 22:15:18
-- Generated from EDMX file: c:\users\-zaferayan-\documents\visual studio 2012\Projects\TestProjesiAnalizTasarım\TestProjesiAnalizTasarım\DbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Kargo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Müşteri_inherits_Kişi]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kişi_Müşteri] DROP CONSTRAINT [FK_Müşteri_inherits_Kişi];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Kişi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kişi];
GO
IF OBJECT_ID(N'[dbo].[Kişi_Müşteri]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kişi_Müşteri];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Kişi'
CREATE TABLE [dbo].[Kişi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(max)  NOT NULL,
    [Soyad] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kişi_Müşteri'
CREATE TABLE [dbo].[Kişi_Müşteri] (
    [Şirket] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Kişi'
ALTER TABLE [dbo].[Kişi]
ADD CONSTRAINT [PK_Kişi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Kişi_Müşteri'
ALTER TABLE [dbo].[Kişi_Müşteri]
ADD CONSTRAINT [PK_Kişi_Müşteri]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'Kişi_Müşteri'
ALTER TABLE [dbo].[Kişi_Müşteri]
ADD CONSTRAINT [FK_Müşteri_inherits_Kişi]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Kişi]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------