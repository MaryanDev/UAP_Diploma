CREATE TABLE [dbo].[FactoryImages] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FactoryId] INT            NOT NULL,
    [Path]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_FactoryImages] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FactoryImages_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [dbo].[Factories] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FactoryImages_FactoryId]
    ON [dbo].[FactoryImages]([FactoryId] ASC);

