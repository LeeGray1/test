
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/08/2020 14:30:05
-- Generated from EDMX file: C:\Users\leegr\source\repos\test\test\Calories.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Calories];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ExercisesTBLs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExercisesTBLs];
GO
IF OBJECT_ID(N'[dbo].[FoodTBLs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FoodTBLs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExercisesTBLs'
CREATE TABLE [dbo].[ExercisesTBLs] (
    [CalBurned] int  NOT NULL,
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Time] int  NOT NULL
);
GO

-- Creating table 'FoodTBLs'
CREATE TABLE [dbo].[FoodTBLs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Calories] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ExercisesTBLs'
ALTER TABLE [dbo].[ExercisesTBLs]
ADD CONSTRAINT [PK_ExercisesTBLs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FoodTBLs'
ALTER TABLE [dbo].[FoodTBLs]
ADD CONSTRAINT [PK_FoodTBLs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------