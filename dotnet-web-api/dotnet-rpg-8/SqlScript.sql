IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Skills] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Damage] int NOT NULL,
    CONSTRAINT [PK_Skills] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Users] (
    [Id] int NOT NULL IDENTITY,
    [Username] nvarchar(max) NOT NULL,
    [PasswordHash] varbinary(max) NOT NULL,
    [PasswordSalt] varbinary(max) NOT NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Characters] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [HitPoints] int NOT NULL,
    [Strength] int NOT NULL,
    [Defense] int NOT NULL,
    [Intelligence] int NOT NULL,
    [Class] int NOT NULL,
    [UserId] int NULL,
    [Fights] int NOT NULL,
    [Victories] int NOT NULL,
    [Defeats] int NOT NULL,
    CONSTRAINT [PK_Characters] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Characters_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id])
);
GO

CREATE TABLE [CharacterSkill] (
    [CharactersId] int NOT NULL,
    [SkillsId] int NOT NULL,
    CONSTRAINT [PK_CharacterSkill] PRIMARY KEY ([CharactersId], [SkillsId]),
    CONSTRAINT [FK_CharacterSkill_Characters_CharactersId] FOREIGN KEY ([CharactersId]) REFERENCES [Characters] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_CharacterSkill_Skills_SkillsId] FOREIGN KEY ([SkillsId]) REFERENCES [Skills] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Weapons] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [Damage] int NOT NULL,
    [CharacterId] int NOT NULL,
    CONSTRAINT [PK_Weapons] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Weapons_Characters_CharacterId] FOREIGN KEY ([CharacterId]) REFERENCES [Characters] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Damage', N'Name') AND [object_id] = OBJECT_ID(N'[Skills]'))
    SET IDENTITY_INSERT [Skills] ON;
INSERT INTO [Skills] ([Id], [Damage], [Name])
VALUES (1, 30, N'Fireball'),
(2, 20, N'Frenzy'),
(3, 50, N'Blizzard');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Damage', N'Name') AND [object_id] = OBJECT_ID(N'[Skills]'))
    SET IDENTITY_INSERT [Skills] OFF;
GO

CREATE INDEX [IX_CharacterSkill_SkillsId] ON [CharacterSkill] ([SkillsId]);
GO

CREATE INDEX [IX_Characters_UserId] ON [Characters] ([UserId]);
GO

CREATE UNIQUE INDEX [IX_Weapons_CharacterId] ON [Weapons] ([CharacterId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240428160934_Initial-create', N'8.0.4');
GO

COMMIT;
GO

