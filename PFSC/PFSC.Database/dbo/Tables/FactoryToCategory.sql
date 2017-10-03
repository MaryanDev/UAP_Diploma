CREATE TABLE [dbo].[FactoryToCategory] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [CategoryId] INT NOT NULL,
    [FactoryId]  INT NOT NULL,
    CONSTRAINT [PK_FactoryToCategory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FactoryToCategory_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_FactoryToCategory_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [dbo].[Factories] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_FactoryToCategory_CategoryId]
    ON [dbo].[FactoryToCategory]([CategoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FactoryToCategory_FactoryId]
    ON [dbo].[FactoryToCategory]([FactoryId] ASC);

