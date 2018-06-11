# TestApp
# Project Title
SPA with GRUD Operations using WebAPI , AngularJs, Bootstrap
# Prerequisites
You need to install MSSQL2014,SSMS,VS2017Community.

# Getting Started
Download the solution, find Web.config file  and change the connection string using your sql server name:

    <add name="DefaultConnection" connectionString="Data Source=Your Server Name;Initial Catalog=Company;Integrated Security=True;" providerName="System.Data.SqlClient" />

Start SQL Server Management Studio and create Company.dbo

Add to database Company the table Employees:

CREATE TABLE [dbo].[Employees] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Position]  NVARCHAR (50) NOT NULL,
    [Age]       INT           NOT NULL,
    [StartDate] DATE          NOT NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED ([Id] ASC)
);

Insert into table Employees.dbo records.
Run the solution.
