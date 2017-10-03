CREATE TABLE [dbo].[MachineToFactory] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [FactoryId] INT NOT NULL,
    [MachineId] INT NOT NULL,
    CONSTRAINT [PK_MachineToFactory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MachineToFactory_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [dbo].[Factories] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MachineToFactory_MachineModels_MachineId] FOREIGN KEY ([MachineId]) REFERENCES [dbo].[MachineModels] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_MachineToFactory_FactoryId]
    ON [dbo].[MachineToFactory]([FactoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_MachineToFactory_MachineId]
    ON [dbo].[MachineToFactory]([MachineId] ASC);

