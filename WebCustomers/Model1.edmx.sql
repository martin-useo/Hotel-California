
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2021 19:29:40
-- Generated from EDMX file: C:\Users\Martí\Documents\4t\Sofware\Assignments\Assignment4\Hotel-California\WebCustomers\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Hotel-California];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[ModelStoreContainer].[FK__Booked_Ro__Clien__22FF2F51]', 'F') IS NOT NULL
    ALTER TABLE [ModelStoreContainer].[Booked_Rooms] DROP CONSTRAINT [FK__Booked_Ro__Clien__22FF2F51];
GO
IF OBJECT_ID(N'[ModelStoreContainer].[FK__Booked_Ro__Rooms__220B0B18]', 'F') IS NOT NULL
    ALTER TABLE [ModelStoreContainer].[Booked_Rooms] DROP CONSTRAINT [FK__Booked_Ro__Rooms__220B0B18];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Rooms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rooms];
GO
IF OBJECT_ID(N'[ModelStoreContainer].[Booked_Rooms]', 'U') IS NOT NULL
    DROP TABLE [ModelStoreContainer].[Booked_Rooms];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [Clients_ID] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Rooms'
CREATE TABLE [dbo].[Rooms] (
    [Rooms_ID] int  NOT NULL,
    [People_Count] int  NOT NULL,
    [Quality] nvarchar(50)  NOT NULL,
    [Size] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Booked_Rooms'
CREATE TABLE [dbo].[Booked_Rooms] (
    [Rooms_ID] int  NULL,
    [Clients_ID] int  NULL,
    [Begins] datetime  NOT NULL,
    [Ends] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Clients_ID] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([Clients_ID] ASC);
GO

-- Creating primary key on [Rooms_ID] in table 'Rooms'
ALTER TABLE [dbo].[Rooms]
ADD CONSTRAINT [PK_Rooms]
    PRIMARY KEY CLUSTERED ([Rooms_ID] ASC);
GO

-- Creating primary key on [Begins], [Ends] in table 'Booked_Rooms'
ALTER TABLE [dbo].[Booked_Rooms]
ADD CONSTRAINT [PK_Booked_Rooms]
    PRIMARY KEY CLUSTERED ([Begins], [Ends] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Clients_ID] in table 'Booked_Rooms'
ALTER TABLE [dbo].[Booked_Rooms]
ADD CONSTRAINT [FK__Booked_Ro__Clien__22FF2F51]
    FOREIGN KEY ([Clients_ID])
    REFERENCES [dbo].[Clients]
        ([Clients_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Booked_Ro__Clien__22FF2F51'
CREATE INDEX [IX_FK__Booked_Ro__Clien__22FF2F51]
ON [dbo].[Booked_Rooms]
    ([Clients_ID]);
GO

-- Creating foreign key on [Rooms_ID] in table 'Booked_Rooms'
ALTER TABLE [dbo].[Booked_Rooms]
ADD CONSTRAINT [FK__Booked_Ro__Rooms__220B0B18]
    FOREIGN KEY ([Rooms_ID])
    REFERENCES [dbo].[Rooms]
        ([Rooms_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Booked_Ro__Rooms__220B0B18'
CREATE INDEX [IX_FK__Booked_Ro__Rooms__220B0B18]
ON [dbo].[Booked_Rooms]
    ([Rooms_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------