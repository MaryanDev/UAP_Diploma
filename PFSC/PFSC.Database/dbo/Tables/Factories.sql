CREATE TABLE [dbo].[Factories] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Address]         NVARCHAR (MAX) NULL,
    [CountOfEmplyees] INT            NOT NULL,
    [DateCreated]     DATETIME2 (7)  NOT NULL,
    [Description]     NVARCHAR (MAX) NULL,
    [DistrictId]      INT            NOT NULL,
    [Lattitude]       FLOAT (53)     NOT NULL,
    [Longittude]      FLOAT (53)     NOT NULL,
    [SiteUrl]         NVARCHAR (MAX) NULL,
    [Title]           NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Factories] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Factories_CityDistricts_DistrictId] FOREIGN KEY ([DistrictId]) REFERENCES [dbo].[CityDistricts] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Factories_DistrictId]
    ON [dbo].[Factories]([DistrictId] ASC);

