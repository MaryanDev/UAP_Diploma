CREATE TABLE [dbo].[CityDistricts] (
    [Id]    INT            IDENTITY (1, 1) NOT NULL,
    [Title] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_CityDistricts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

