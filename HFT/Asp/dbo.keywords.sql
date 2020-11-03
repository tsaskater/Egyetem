CREATE TABLE [dbo].[Keywords] (
    [Id]   NVARCHAR (450) NOT NULL,
    [Word] NVARCHAR (MAX) NULL,
    [PId]  NVARCHAR (450) NULL,
    CONSTRAINT [PK_Keywords] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Keywords_People_PId] FOREIGN KEY ([PId]) REFERENCES [dbo].[People] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Keywords_PId]
    ON [dbo].[Keywords]([PId] ASC);

