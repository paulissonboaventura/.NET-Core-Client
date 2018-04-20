CREATE TABLE [dbo].[Evento] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Descricao] NVARCHAR (50) NULL,
    [Ativo]     BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

