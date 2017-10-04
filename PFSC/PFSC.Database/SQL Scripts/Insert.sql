USE Pfsc_DB
GO 

SET IDENTITY_INSERT Roles on
INSERT INTO Roles (Id, Title)
VALUES (1, 'User'),
(2, 'Admin');
SET IDENTITY_INSERT Roles off

SET IDENTITY_INSERT Categories ON 
INSERT INTO Categories (Id, Title, [Description])
VALUES (1, 'Printing business cards', ''),
(2, 'Large format printing', ''),
(3, 'Production of packing', ''),
(4, 'Printing on packaging', ''),
(5, 'Serigraphy', ''),
(6, 'Tampon printing', ''),
(7, 'Flexographic printing', ''),
(8, 'Folding', ''),
(9, 'Thermography', '')
SET IDENTITY_INSERT dbo.Categories OFF

--(10, 'Newspapers', ''),
--(11, 'Magazines', ''),
--(12, 'Books and brochures', ''),
--(13, 'Accident-blank products', ''),
--(14, 




