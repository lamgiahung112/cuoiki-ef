
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/25/2023 11:44:51
-- Generated from EDMX file: C:\Users\Admin\source\repos\CUOIKI-EF\CUOIKI-EF\DatabaseModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Projects__Manage__2A6B46EF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projects] DROP CONSTRAINT [FK__Projects__Manage__2A6B46EF];
GO
IF OBJECT_ID(N'[dbo].[FK__Tasks__Assignee__37C5420D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK__Tasks__Assignee__37C5420D];
GO
IF OBJECT_ID(N'[dbo].[FK__Tasks__Assigner__38B96646]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK__Tasks__Assigner__38B96646];
GO
IF OBJECT_ID(N'[dbo].[FK__TeamMembe__Emplo__34E8D562]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamMembers] DROP CONSTRAINT [FK__TeamMembe__Emplo__34E8D562];
GO
IF OBJECT_ID(N'[dbo].[FK__Teams__TechLeadI__3118447E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams] DROP CONSTRAINT [FK__Teams__TechLeadI__3118447E];
GO
IF OBJECT_ID(N'[dbo].[FK__WorkSessi__Emplo__278EDA44]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkSessions] DROP CONSTRAINT [FK__WorkSessi__Emplo__278EDA44];
GO
IF OBJECT_ID(N'[dbo].[FK__Stages__ProjectI__2D47B39A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Stages] DROP CONSTRAINT [FK__Stages__ProjectI__2D47B39A];
GO
IF OBJECT_ID(N'[dbo].[FK__Teams__StageID__30242045]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams] DROP CONSTRAINT [FK__Teams__StageID__30242045];
GO
IF OBJECT_ID(N'[dbo].[FK__TeamMembe__TeamI__33F4B129]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamMembers] DROP CONSTRAINT [FK__TeamMembe__TeamI__33F4B129];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[Stages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Stages];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO
IF OBJECT_ID(N'[dbo].[TeamMembers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamMembers];
GO
IF OBJECT_ID(N'[dbo].[Teams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams];
GO
IF OBJECT_ID(N'[dbo].[WorkSessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkSessions];
GO
IF OBJECT_ID(N'[dbo].[WorkLeaves]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkLeaves];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID] nvarchar(50)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Address] nvarchar(255)  NOT NULL,
    [Birth] datetime  NOT NULL,
    [EmployeeStatus] nvarchar(255)  NOT NULL,
    [Password] nvarchar(255)  NOT NULL,
    [Gender] nvarchar(255)  NOT NULL,
    [Role] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Projects'
CREATE TABLE [dbo].[Projects] (
    [ID] nvarchar(50)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Description] nvarchar(255)  NOT NULL,
    [ManagerID] nvarchar(50)  NOT NULL,
    [CreatedAt] datetime  NOT NULL
);
GO

-- Creating table 'Stages'
CREATE TABLE [dbo].[Stages] (
    [ID] nvarchar(50)  NOT NULL,
    [ProjectID] nvarchar(50)  NOT NULL,
    [Description] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [ID] nvarchar(50)  NOT NULL,
    [Assignee] nvarchar(50)  NOT NULL,
    [Assigner] nvarchar(50)  NOT NULL,
    [Description] nvarchar(255)  NOT NULL,
    [Title] nvarchar(255)  NOT NULL,
    [StartingTime] datetime  NOT NULL,
    [EndingTime] datetime  NOT NULL,
    [Status] nvarchar(255)  NOT NULL,
    [CreatedAt] datetime  NOT NULL,
    [UpdatedAt] datetime  NOT NULL,
    [TeamID] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'TeamMembers'
CREATE TABLE [dbo].[TeamMembers] (
    [ID] nvarchar(50)  NOT NULL,
    [TeamID] nvarchar(50)  NOT NULL,
    [EmployeeID] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [ID] nvarchar(50)  NOT NULL,
    [StageID] nvarchar(50)  NOT NULL,
    [TechLeadID] nvarchar(50)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'WorkSessions'
CREATE TABLE [dbo].[WorkSessions] (
    [ID] nvarchar(50)  NOT NULL,
    [EmployeeID] nvarchar(50)  NULL,
    [StartingTime] datetime  NOT NULL,
    [EndingTime] datetime  NULL
);
GO

-- Creating table 'WorkLeaves'
CREATE TABLE [dbo].[WorkLeaves] (
    [ID] nvarchar(50)  NOT NULL,
    [FromDate] datetime  NOT NULL,
    [ToDate] datetime  NOT NULL,
    [ReasonOfLeave] nvarchar(max)  NOT NULL,
    [EmployeeID] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [PK_Projects]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Stages'
ALTER TABLE [dbo].[Stages]
ADD CONSTRAINT [PK_Stages]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TeamMembers'
ALTER TABLE [dbo].[TeamMembers]
ADD CONSTRAINT [PK_TeamMembers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [PK_Teams]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'WorkSessions'
ALTER TABLE [dbo].[WorkSessions]
ADD CONSTRAINT [PK_WorkSessions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'WorkLeaves'
ALTER TABLE [dbo].[WorkLeaves]
ADD CONSTRAINT [PK_WorkLeaves]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ManagerID] in table 'Projects'
ALTER TABLE [dbo].[Projects]
ADD CONSTRAINT [FK__Projects__Manage__2A6B46EF]
    FOREIGN KEY ([ManagerID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Projects__Manage__2A6B46EF'
CREATE INDEX [IX_FK__Projects__Manage__2A6B46EF]
ON [dbo].[Projects]
    ([ManagerID]);
GO

-- Creating foreign key on [Assignee] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK__Tasks__Assignee__37C5420D]
    FOREIGN KEY ([Assignee])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Tasks__Assignee__37C5420D'
CREATE INDEX [IX_FK__Tasks__Assignee__37C5420D]
ON [dbo].[Tasks]
    ([Assignee]);
GO

-- Creating foreign key on [Assigner] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK__Tasks__Assigner__38B96646]
    FOREIGN KEY ([Assigner])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Tasks__Assigner__38B96646'
CREATE INDEX [IX_FK__Tasks__Assigner__38B96646]
ON [dbo].[Tasks]
    ([Assigner]);
GO

-- Creating foreign key on [EmployeeID] in table 'TeamMembers'
ALTER TABLE [dbo].[TeamMembers]
ADD CONSTRAINT [FK__TeamMembe__Emplo__34E8D562]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeamMembe__Emplo__34E8D562'
CREATE INDEX [IX_FK__TeamMembe__Emplo__34E8D562]
ON [dbo].[TeamMembers]
    ([EmployeeID]);
GO

-- Creating foreign key on [TechLeadID] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [FK__Teams__TechLeadI__3118447E]
    FOREIGN KEY ([TechLeadID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Teams__TechLeadI__3118447E'
CREATE INDEX [IX_FK__Teams__TechLeadI__3118447E]
ON [dbo].[Teams]
    ([TechLeadID]);
GO

-- Creating foreign key on [EmployeeID] in table 'WorkSessions'
ALTER TABLE [dbo].[WorkSessions]
ADD CONSTRAINT [FK__WorkSessi__Emplo__278EDA44]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__WorkSessi__Emplo__278EDA44'
CREATE INDEX [IX_FK__WorkSessi__Emplo__278EDA44]
ON [dbo].[WorkSessions]
    ([EmployeeID]);
GO

-- Creating foreign key on [ProjectID] in table 'Stages'
ALTER TABLE [dbo].[Stages]
ADD CONSTRAINT [FK__Stages__ProjectI__2D47B39A]
    FOREIGN KEY ([ProjectID])
    REFERENCES [dbo].[Projects]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Stages__ProjectI__2D47B39A'
CREATE INDEX [IX_FK__Stages__ProjectI__2D47B39A]
ON [dbo].[Stages]
    ([ProjectID]);
GO

-- Creating foreign key on [StageID] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [FK__Teams__StageID__30242045]
    FOREIGN KEY ([StageID])
    REFERENCES [dbo].[Stages]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Teams__StageID__30242045'
CREATE INDEX [IX_FK__Teams__StageID__30242045]
ON [dbo].[Teams]
    ([StageID]);
GO

-- Creating foreign key on [TeamID] in table 'TeamMembers'
ALTER TABLE [dbo].[TeamMembers]
ADD CONSTRAINT [FK__TeamMembe__TeamI__33F4B129]
    FOREIGN KEY ([TeamID])
    REFERENCES [dbo].[Teams]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__TeamMembe__TeamI__33F4B129'
CREATE INDEX [IX_FK__TeamMembe__TeamI__33F4B129]
ON [dbo].[TeamMembers]
    ([TeamID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------