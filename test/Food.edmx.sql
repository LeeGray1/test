
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/06/2020 18:21:47
-- Generated from EDMX file: C:\Users\leegr\source\repos\test\test\Food.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Food_Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FoodNames'
CREATE TABLE [dbo].[FoodNames] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Foodcalory_Id] int  NOT NULL
);
GO

-- Creating table 'Foodcalories'
CREATE TABLE [dbo].[Foodcalories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Calories] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FoodNames'
ALTER TABLE [dbo].[FoodNames]
ADD CONSTRAINT [PK_FoodNames]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Foodcalories'
ALTER TABLE [dbo].[Foodcalories]
ADD CONSTRAINT [PK_Foodcalories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Foodcalory_Id] in table 'FoodNames'
ALTER TABLE [dbo].[FoodNames]
ADD CONSTRAINT [FK_FoodNameFoodcalories]
    FOREIGN KEY ([Foodcalory_Id])
    REFERENCES [dbo].[Foodcalories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FoodNameFoodcalories'
CREATE INDEX [IX_FK_FoodNameFoodcalories]
ON [dbo].[FoodNames]
    ([Foodcalory_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------