USE Pfsc_DB
GO 

SET IDENTITY_INSERT Roles on
INSERT INTO Roles (Id, Title)
VALUES (1, 'User'),
(2, 'Admin');
SET IDENTITY_INSERT Roles off

SET IDENTITY_INSERT dbo.PrintingTechnologies ON 
INSERT INTO dbo.PrintingTechnologies (Id, Title, [Description]) VALUES 
(1, 'Офсетний друк', ''),
(2, 'Широкоформатний друк', ''),
(3, 'Трафаретний друк', ''),
(4, 'Тампонний друк', ''),
(5, 'Флексогрфія', ''),
(6, 'Термографія', ''),
(7, 'Високий друк', ''),
(8, 'Цифровий друк', ''),
(9, 'Глибокий друк', ''),
(10, '3-D друк', '')
SET IDENTITY_INSERT dbo.Categories OFF

SET IDENTITY_INSERT dbo.PrintingProductions ON
INSERT INTO dbo.PrintingProductions
(
	Id,
    [Description],
    Title
)
VALUES 
(1, 'Газети',  ''),
(2, 'Плакати',  ''),
(3, 'Книги',  ''),
(4, 'Візитки',  ''),
(5, 'Бланки',  ''),
(6, 'Журнали',  ''),
(7, 'Друк на одязі',  ''),
(8, 'Друк на пакованнях',  ''),
(9, 'Виробництво паковань', ''),
(10, 'Зшивання', '')
--(11, '', ''),
--(12, '', ''),
--(13, '', '')
SET IDENTITY_INSERT dbo.PrintingProductions OFF

SET IDENTITY_INSERT dbo.CityDistricts ON
INSERT INTO dbo.CityDistricts
(
	Id,
    Title
)
VALUES (1, 'Галицький'),
(2, 'Шевченківський'),
(3, 'Франківський'),
(4, 'Личаківський'),
(5, 'Залізничний'),
(6, 'Сихівський')
SET IDENTITY_INSERT dbo.CityDistricts OFF

SET IDENTITY_INSERT dbo.Users ON
INSERT INTO dbo.Users
(
	Id,
    AvatarPath,
    DateOfBirth,
    Email,
    FirstName,
    LastName,
    [Password],
    RoleId
)
VALUES
(1, '', '', 'mr.maykher@gmail.com', 'Maryan', '', 'maryan1995', 2)
SET IDENTITY_INSERT dbo.Users OFF





