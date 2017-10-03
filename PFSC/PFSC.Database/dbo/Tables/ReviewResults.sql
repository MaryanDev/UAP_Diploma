CREATE TABLE [dbo].[ReviewResults] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Desc]  NVARCHAR (MAX) NULL,
    [Title] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_ReviewResults] PRIMARY KEY CLUSTERED ([Id] ASC)
);

