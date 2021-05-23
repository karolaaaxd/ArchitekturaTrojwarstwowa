CREATE TABLE [dbo].[Recenzja] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [RecenzjaUzytkownika] NVARCHAR (MAX) NULL,
    [Ocena]               FLOAT (53)     NOT NULL,
	[Nick]               NVARCHAR (MAX)     NULL,
    CONSTRAINT [PK_Recenzja] PRIMARY KEY CLUSTERED ([Id] ASC)
);

