CREATE TABLE [dbo].[Users] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [AvatarPath]  NVARCHAR (MAX) NULL,
    [DateOfBirth] DATETIME2 (7)  NOT NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [FirstName]   NVARCHAR (MAX) NULL,
    [LastName]    NVARCHAR (MAX) NULL,
    [Password]    NVARCHAR (MAX) NULL,
    [RoleId]      INT            NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Users_RoleId]
    ON [dbo].[Users]([RoleId] ASC);

