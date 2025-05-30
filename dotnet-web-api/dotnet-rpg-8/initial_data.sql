-- Вмъкване на данни в таблицата с герои (Characters)
INSERT INTO Characters (Id, Name, HitPoints, Strength, Defense, Intelligence, Class, UserId, Fights, Victories, Defeats)
VALUES
    (1, 'Gandalf', 30, 10, 10, 10, 'Knight'),
    (2, 'Aragorn', 30, 10, 10, 10, 'Knight'),
    (3, 'Legolas', 30, 10, 10, 10, 'Knight'),

-- Вмъкване на данни в таблицата с потребители (Users)
INSERT INTO Users (Id, Username, Email)
VALUES
    (1, 'user1', 'user1@example.com'),
    (2, 'user2', 'user2@example.com'),
    (3, 'user3', 'user3@example.com');

-- Вмъкване на данни в таблицата с оръжия (Weapons)
INSERT INTO Weapons (Id, Name, Damage, Type)
VALUES
    (1, 'Sword', 30, 'Melee'),
    (2, 'Bow', 25, 'Ranged'),
    (3, 'Staff', 20, 'Magic');

-- Вмъкване на данни в таблицата с умения (Skills)
INSERT INTO Skills (Id, Name, Description, CharacterId)
VALUES
    (1, 'Fireball', 'Launches a fiery projectile.', 1),
    (2, 'Stealth', 'Allows the character to move undetected.', 2),
    (3, 'Healing', 'Restores health to the character.', 3);
