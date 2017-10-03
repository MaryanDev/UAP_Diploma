CREATE TABLE [dbo].[Ratings] (
    [Id]        INT     IDENTITY (1, 1) NOT NULL,
    [FactoryId] INT     NOT NULL,
    [RankValue] TINYINT NOT NULL,
    [UserId]    INT     NOT NULL,
    CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Ratings_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [dbo].[Factories] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Ratings_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Ratings_FactoryId]
    ON [dbo].[Ratings]([FactoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Ratings_UserId]
    ON [dbo].[Ratings]([UserId] ASC);

