CREATE TABLE [dbo].[MachineManufacturers] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Country]     NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Title]       NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_MachineManufacturers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

