CREATE TABLE [dbo].[MachineModels] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Description]    NVARCHAR (MAX) NULL,
    [ManufacturerId] INT            NOT NULL,
    [Title]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_MachineModels] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MachineModels_MachineManufacturers_ManufacturerId] FOREIGN KEY ([ManufacturerId]) REFERENCES [dbo].[MachineManufacturers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MachineModels_ManufacturerId]
    ON [dbo].[MachineModels]([ManufacturerId] ASC);

