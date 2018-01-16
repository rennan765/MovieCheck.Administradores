IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [TB_Endereco] (
    [UsuarioId] int NOT NULL IDENTITY,
    [Bairro] nvarchar(max),
    [Cep] nvarchar(max),
    [Cidade] nvarchar(max),
    [Complemento] nvarchar(max),
    [Estado] nvarchar(max),
    [Logradouro] nvarchar(max),
    [Numero] int NOT NULL,
    CONSTRAINT [PK_TB_Endereco] PRIMARY KEY ([UsuarioId])
);

GO

CREATE TABLE [TB_Telefone] (
    [Id] int NOT NULL IDENTITY,
    [Ddd] int NOT NULL,
    [Numero] nvarchar(max),
    [Tipo] int NOT NULL,
    CONSTRAINT [PK_TB_Telefone] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TB_Usuario] (
    [Id] int NOT NULL IDENTITY,
    [Discriminator] nvarchar(max) NOT NULL,
    [Email] nvarchar(max),
    [EnderecoUsuarioId] int,
    [Nome] nvarchar(max),
    [Senha] nvarchar(max),
    [Status] int NOT NULL,
    [Cpf] nvarchar(max),
    [Tipo] int,
    [ClienteId] int,
    CONSTRAINT [PK_TB_Usuario] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TB_Usuario_TB_Endereco_EnderecoUsuarioId] FOREIGN KEY ([EnderecoUsuarioId]) REFERENCES [TB_Endereco] ([UsuarioId]) ON DELETE NO ACTION
);

GO

CREATE TABLE [TB_Usuario_Telefone] (
    [UsuarioId] int NOT NULL,
    [TelefoneId] int NOT NULL,
    CONSTRAINT [PK_TB_Usuario_Telefone] PRIMARY KEY ([UsuarioId], [TelefoneId]),
    CONSTRAINT [FK_TB_Usuario_Telefone_TB_Telefone_TelefoneId] FOREIGN KEY ([TelefoneId]) REFERENCES [TB_Telefone] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TB_Usuario_Telefone_TB_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_Usuario] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_TB_Usuario_EnderecoUsuarioId] ON [TB_Usuario] ([EnderecoUsuarioId]);

GO

CREATE INDEX [IX_TB_Usuario_ClienteId] ON [TB_Usuario] ([ClienteId]);

GO

CREATE INDEX [IX_TB_Usuario_Telefone_TelefoneId] ON [TB_Usuario_Telefone] ([TelefoneId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20171207001437_Usuario', N'1.1.2');

GO

