CREATE TABLE [dbo].[Reviews] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [DateCreated]    DATETIME2 (7)  NOT NULL,
    [FactoryId]      INT            NOT NULL,
    [ReviewResultId] INT            NOT NULL,
    [Text]           NVARCHAR (MAX) NULL,
    [Title]          NVARCHAR (MAX) NULL,
    [UserId]         INT            NOT NULL,
    CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reviews_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [dbo].[Factories] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Reviews_ReviewResults_ReviewResultId] FOREIGN KEY ([ReviewResultId]) REFERENCES [dbo].[ReviewResults] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Reviews_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Reviews_FactoryId]
    ON [dbo].[Reviews]([FactoryId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Reviews_ReviewResultId]
    ON [dbo].[Reviews]([ReviewResultId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Reviews_UserId]
    ON [dbo].[Reviews]([UserId] ASC);

