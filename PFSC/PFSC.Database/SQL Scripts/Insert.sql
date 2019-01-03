USE Pfsc_DB
GO 

SET IDENTITY_INSERT Roles on
INSERT INTO Roles (Id, Title)
VALUES (1, 'User'),
(2, 'Admin'),
(3, 'FactoryAdmin');
SET IDENTITY_INSERT Roles off

SET IDENTITY_INSERT dbo.PrintingTechnologies ON 
INSERT INTO dbo.PrintingTechnologies (Id, Title, [Description]) VALUES 
(1, N'Офсетний друк', ''),
(2, N'Широкоформатний друк', ''),
(3, N'Трафаретний друк', ''),
(4, N'Тампонний друк', ''),
(5, N'Флексогрфія', ''),
(6, N'Термографія', ''),
(7, N'Високий друк', ''),
(8, N'Цифровий друк', ''),
(9, N'Глибокий друк', ''),
(10, N'3-D друк', '')
SET IDENTITY_INSERT dbo.PrintingTechnologies OFF

SET IDENTITY_INSERT dbo.PrintingProductions ON
INSERT INTO dbo.PrintingProductions
(
	Id,
    Title,
	[Description]
)
VALUES 
(1, N'Газети',  ''),
(2, N'Плакати',  ''),
(3, N'Книги',  ''),
(4, N'Візитки',  ''),
(5, N'Бланки',  ''),
(6, N'Журнали',  ''),
(7, N'Друк на одязі',  ''),
(8, N'Друк на пакованнях',  ''),
(9, N'Виробництво паковань', ''),
(10, N'Зшивання', '')
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
VALUES (1, N'Галицький'),
(2, N'Шевченківський'),
(3, N'Франківський'),
(4, N'Личаківський'),
(5, N'Залізничний'),
(6, N'Сихівський')
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
(31, '', '', 'mr.maykher@gmail.com', 'Maryan', '', 'maryan1995', 2);


insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (1, null, '2017-04-20', 'erussel0@bbc.co.uk', 'Eddie', 'Russel', 'FSeBsN3q', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (2, null, '2017-02-28', 'hwhite1@un.org', 'Harlene', 'White', 'nwSvmeY', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (3, null, '2017-02-13', 'mgeraudel2@dailymail.co.uk', 'Marion', 'Geraudel', 'C3eznnR', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (4, null, '2017-08-28', 'gogilby3@narod.ru', 'Germain', 'Ogilby', 'rCZN8d7uSuQ', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (5, null, '2016-11-12', 'eattwooll4@xing.com', 'Ezechiel', 'Attwooll', 'cR2cexw9', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (6, null, '2017-08-10', 'bfilyakov5@cnn.com', 'Berny', 'Filyakov', '70Bc6T0F0WW', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (7, null, '2017-03-28', 'grollinshaw6@phpbb.com', 'Gaye', 'Rollinshaw', 'QTEcFq9', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (8, null, '2017-06-14', 'bsenussi7@fc2.com', 'Beth', 'Senussi', '5UEk9T0gVL', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (9, null, '2017-01-03', 'slarenson8@nps.gov', 'Sophey', 'Larenson', 'QAyuxBeI', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (10, null, '2017-01-25', 'cseacombe9@jalbum.net', 'Clarita', 'Seacombe', 'OdPVNAp4i', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (11, null, '2017-04-07', 'smacdowalla@qq.com', 'Sasha', 'MacDowall', '3ENeeHKtBtR', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (12, null, '2016-10-27', 'fshelleyb@cnbc.com', 'Frayda', 'Shelley', 'EurndsP', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (13, null, '2017-07-14', 'opopplestonec@cloudflare.com', 'Opalina', 'Popplestone', 'M1l0rlAgkY4', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (14, null, '2017-07-09', 'bbettlestoned@mayoclinic.com', 'Bartholomeus', 'Bettlestone', 'RgKaLkgaQ', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (15, null, '2016-10-18', 'dlathome@dell.com', 'Del', 'Lathom', 'o9yg1nW8wc', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (16, null, '2017-06-10', 'bissettf@wikia.com', 'Bordie', 'Issett', 'w7kiinb', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (17, null, '2017-05-16', 'bricciardig@w3.org', 'Baxie', 'Ricciardi', '659D4eKiq', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (18, null, '2016-12-12', 'amcneillh@usgs.gov', 'Amory', 'McNeill', 'ETXLFqi', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (19, null, '2017-07-29', 'lhuxtablei@a8.net', 'Lindsey', 'Huxtable', 'AYlaHCxnZz', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (20, null, '2017-01-03', 'rderricoatj@hubpages.com', 'Rod', 'Derricoat', 'aSOKXx', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (21, null, '2017-01-20', 'emoark@samsung.com', 'Else', 'Moar', 'woL0aegw', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (22, null, '2017-03-08', 'cskitchl@4shared.com', 'Corenda', 'Skitch', 'uc0av6HzlMx', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (23, null, '2017-08-13', 'wscoullerm@edublogs.org', 'Wilone', 'Scouller', 'NCiL5TQVA1', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (24, null, '2016-10-20', 'bbunnern@printfriendly.com', 'Bonnee', 'Bunner', 'qezyJWijC', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (25, null, '2016-10-30', 'avigerso@elegantthemes.com', 'Augustus', 'Vigers', 'RxtKvXiR3Cqe', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (26, null, '2016-12-04', 'lmaccartp@indiatimes.com', 'Lisette', 'MacCart', 'C3P8CHm', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (27, null, '2017-01-23', 'msidwellq@sfgate.com', 'Minnaminnie', 'Sidwell', '49XvZvP6og', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (28, null, '2017-06-23', 'dhalsor@mtv.com', 'Dale', 'Halso', 'WwgEYof', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (29, null, '2017-03-17', 'jghents@merriam-webster.com', 'Josephine', 'Ghent', 'KbfWKoF', 1);
insert into Users (Id, AvatarPath, DateOfBirth, Email, FirstName, LastName, [Password], RoleId) values (30, null, '2016-10-25', 'ssoutent@slashdot.org', 'Sarajane', 'Souten', 'UpITcl8qGeX0', 1);
SET IDENTITY_INSERT dbo.Users OFF

SET IDENTITY_INSERT dbo.MachineManufacturers ON
INSERT INTO dbo.MachineManufacturers
(
	Id,
    Country,
    [Description],
    Title
)
VALUES
(1, 'Germany', '', 'WINDMÖLLER & HÖLSCHER'),
(2, 'Italy', '', 'Uteco Converting S.p.A.'),
(3, 'Germany', '', 'Saldoflex S.r.l.'),
(4, 'USA', '', 'MOSS'),
(5, 'Germany', '', 'Leibinger'),
(6, 'Japan','','HITACHI Industrial Components & Equipment '),
(7, 'Denmark', '', 'Heidelberger Druckmaschinen AG'),
(8, 'Italy','', 'Giugni S.r.l.'),
(9, 'Spain', '', 'Domino')
SET IDENTITY_INSERT dbo.MachineManufacturers OFF

SET IDENTITY_INSERT dbo.Machines ON
INSERT INTO dbo.Machines
(
	Id,
    [Description],
    ManufacturerId,
    Title
)
VALUES
(1, '', 1, 'MIRAFLEX II C'),
(2, '', 1, 'FLEXA 820'),
(3, '', 2, ' Diamond HP 112 GL'),
(4, '', 2, ' Onyx SIL'),
(5, '', 3, 'SUPERFLEXOL STACK-GEARLESS'),
(6, '', 3, 'FLEXI'),
(7, '', 4, 'MO 3012'),
(8, '', 4, 'MO 2012 SPU'),
(9, '', 5, 'JET2neo'),
(10, '', 5, 'JET3up MI'),
(11, '', 6, 'UX-D160W'),
(12, '', 6, 'RX-SD160W, RX-SD160W-6M'),
(13, '', 7, 'Omnifire 250'),
(14, '', 7, 'Speedmaster SX 52 Edition'),
(15, '', 8, 'MINIFLEX 533'),
(16, '', 9, 'N600i')
SET IDENTITY_INSERT dbo.Machines OFF

SET IDENTITY_INSERT dbo.ReviewResults ON
INSERT INTO dbo.ReviewResults
(
	Id,
    Title,
    [Description]
)
VALUES
(1, N'Відмінно', ''),
(2, N'Добре', ''),
(3, N'Задовільно', ''),
(4, N'Незадовільно', ''),
(5, N'Погано', ''),
(6, N'Дуже погано', '')
SET IDENTITY_INSERT dbo.ReviewResults OFF

SET IDENTITY_INSERT dbo.Factories ON
INSERT INTO dbo.Factories
(
	Id,
    [Address],
    CountOfEmplyees,
    DateCreated,
    [Description],
    DistrictId,
    Lattitude,
    Longittude,
    SiteUrl,
    Title,
    IsApproved
)
VALUES
(1, N'м. Львів, вул. Стрийська, 202', '22-50', NULL,  N'<p>Продукція, послуги:</p>
<p>Офсетний друк, рекламні матеріали, друк каталогів, євробуклетів, флаєрів, виготовлення коробок, коробки з мікрогофри, паперові пакети, друк фірмових бланків, буклетів, презентації, книги, газети, журнали, ресторанні меню, запрошення, друк календарів, постерів, плакатів, брошури тощо.</p>
<p>Оптовий продаж картонно-паперової продукції: картон целюлозний, макулатурний, палітурний, папір офсетний, газетний, крейдований, офісний.</p>
<p>Рекламна інформація:</p>
<p>Ми пропонуємо виробництво наступних видів упаковки:<br />&bull; Коробки для взуттєвих фабрик<br />&bull; Різні контейнери для упакування їжі<br />&bull; Упаковки для цукрових заводів<br />&bull; Коробки для кондитерських виробів<br />&bull; Нестандартні упаковки з картону</p>
<p>Габаритна поліграфія:<br />&bull; Книги<br />&bull; Журнали<br />&bull; Проспекти<br />&bull; Плакати<br />&bull; Блокноти</p>
<p>Дрібна поліграфія:<br />&bull; Візитка<br />&bull; Буклети<br />&bull; Флаєра<br />&bull; Календарі<br />&bull; Листівки</p>
<p>Переваги співпраці з нами:<br />&bull; 5-и річний досвід у сфері поліграфії<br />&bull; Сучасне обладнання та власна виробнича база<br />&bull; Індивідуальна розробка дизайну<br />&bull; Дотримуємося термінів прописаних договором<br />&bull; При замовленні друку передоплата 30%<br />&bull; Друкуємо тиражі в 2 рази швидше<br />&bull; Доставка будь &ndash; яке місто Західної України<br />&bull; Доставимо під самі двері</p>', 1, 49.7975535, 24.0129542, 'www.media.biz.ua', N'ПРАЙД МЕДІА, ТОВ', 1),
(2, N'м. Львів, вул. Сахарова, 82, оф. 9', '30-40', NULL, N'<p>Галузі по КВЕД:</p>
<p>Виробництво виробів з паперу та картону<br />Видання книг<br />Поліграфічна діяльність та пов&rsquo;язані з нею послуги<br />Продукція, послуги:</p>
<p>Спеціалізація - оперативний повнокольоровий та чорно-білий лазерний друк.</p>
<p>Виготовлення візиток, буклетів, листівок, флаєрів, постерів, плакатів, афіш, квитків, лотерей, брошур, меню і т.п. в самі стислі терміни.</p>
<p>Персоналізований друк: лотереї з порядковими номерами, квитки на заходи з вдрукованими місцями і цінами, запрошення з вдрукованими прізвищами і т.д.</p>
<p>Виготовлення книг, брошур будь-якої складності<br />- мінімальний тираж 20 прим.<br />- при тиражі понад 300 прим. - Знижки !!!</p>
<p>Всі види післядрукарської обробки: порізка, біговка, ламінування, перфорація, скріплення скобами та на пружину.</p>', 2, 49.8198671, 24.0155795, 'www.cifradruk.com.ua', N'ЛЬВІВСЬКА ЦИФРОВА ДРУКАРНЯ, ТОВ', 1),
(3, N'м. Львів, вул. Наукова, 5', NULL, NULL, N'<p>Продукція, послуги:</p>
<p>- Видавничі послуги: від рукопису &ndash; до книги; наклад - від 1-го примірника; верстка; художнє оформлення.<br />- Поліграфічні послуги: листовий друк до А2 формату;<br />- Післядрукарські послуги: безшвейне скріплення блоків (фреза, бокова проклейка), шиття дротом (на скобу), скріплення пружиною, рулонна ламінація, порізка, біговка, номерація.<br />- Виготовлення каталогів та журналів.<br />- Друк візитних карток.<br />- Виготовлення календарів: квартальних, кишенькових, настінних.<br />- Цифровий повноколірний друк &ndash; до А3 формату.</p>
<p>Рекламна інформація:</p>
<p>&laquo;Видавництво &laquo;Бона&raquo; видає та виготовляє літературу найрізноманітнішої тематики &ndash; як художню, для масового читача, так і тематичну. Видавництво також здійснює випуск книг за замовленням авторів: надає редакційно-видавничі послуги (набір, верстка, редагування, художнє оформлення, виготовлення оригінал-макетів, тощо).</p>', 3, 49.8022245, 24.0053932, 'www.bona-kr.lviv.ua', N'БОНА, ВИДАВНИЦТВО, ПП', 1),
(4, N'м. Львів, вул. Городоцька, 282', '15-20', NULL, N'<p>Галузі по КВЕД:</p>
<p>Виробництво інших виробів з паперу та картону<br />Брошурувально-палітурна та оздоблювальна діяльність<br />Оптова торгівля непродовольчими споживчими товарами<br />Продукція, послуги:</p>
<p>ТзОВ спеціалізоване підприємство &rdquo;ЕККО&rdquo;, яке успішно працює на ринку поліграфії з 1992 року, пропонує самоклеючі етикетки з повноколірним друком на різних типах паперу та плівки флексографічним і трафаретним способом (з можливим їх поєднанням).</p>
<p>Додатково за бажанням клієнта пропонується:<br />- УФ-лакування;<br />- ламінування;<br />- гаряче та холодне тиснення фольгою;<br />- конгревне тиснення;<br />- застосовуються спеціальні види лакування (надання матового та об&rsquo;ємного ефектів);<br />- друк на термозбіжних рукавах;<br />- цифровий друк малих тиражів;<br />- складні імітації дорогих винних паперів;<br />- металеві етикетки.</p>', 3, 49.8307614, 23.9668733, 'www.sp-ekko.com.ua', N'ЕККО, ТОВ', 1),
(5, N'м. Львів, просп. Чорновола, 45а корп. 8', NULL, NULL,N'<p>Галузі по КВЕД:</p>
<p>Інша поліграфічна діяльність<br />Консультування з питань інформатизації<br />Розроблення програмного забезпечення та консультування в цій сфері<br />Оброблення даних<br />Діяльність, пов&rsquo;язана з банками даних<br />Дослідження кон&rsquo;юнктури ринку та виявлення суспільної думки<br />Рекламна діяльність<br />Продукція, послуги:</p>
<p>ВСІ ВИДИ РЕКЛАМИ. Рекламна компанія &laquo;Леосвіт&raquo; пропонує Вам сучасний дизайн, якісне та своєчасне виконання замовлень, поліграфічної продукції, рекламу в регіональних ЗМІ а також будь-які види зовнішньої реклами, широкоформатний друк, створення та підтримку веб-сторінок, а також:</p>
<p>- Виготовлення аудіо- відеопродукції<br />- Брендінг<br />- Організація та проведення промоакцій<br />- Графічний дизайн<br />- Розміщення внутрішньої реклами<br />- Виготовлення внутрішньої реклами<br />- Маркетинг та реклама в Інтернеті<br />- Маркетинговий Консалтинг<br />- Офсетний друк<br />- Розміщення зовнішньої реклами<br />- Виготовлення зовнішньої реклами<br />- Реклама у пресі<br />- Реклама на радіо<br />- Комплексні рекламні кампанії<br />- Друк на сувенірній продукції<br />- Реклама на телебаченні<br />- Широкоформатний друк<br />- Вебдизайн та розробка веб-сайтів</p>', 2, 49.851373, 24.0207953, 'www.leosvit.com', N'ЛЕОСВІТ, РЕКЛАМНА КОМПАНІЯ', 1),
(6, N'м. Львів, пл. Петрушевича, 2, оф. 225', NULL, NULL, N'<p>Галузі по КВЕД:</p>
<p>Інша поліграфічна діяльність<br />Рекламна діяльність<br />Продукція, послуги:</p>
<p>&rdquo;ArtPro&rdquo; рекламна агенція повного циклу.</p>
<p>Ми надаємо послуги з розробки, розміщенню та виготовленню реклами в будь-якому регіоні Україні, у всіх, доступних на сьогоднішній день, видах рекламного простору.</p>
<p>1. Комплексні рекламні компанії, дизайнерські послуги<br />2. Реклама в/на транспорті<br />3. Виготовлення рекламних вивісок, зовнішнє оформлення приміщень<br />4. Поліграфія та широкоформатний друк<br />5. BTL-акції<br />6. Виготовлення сувенірної продукції<br />7. Реклама на білбордах, сітілайтах, холдерах, брандмауерах<br />8. Безадресна розсилка рекламних матеріалів, реклама в ліфтах<br />9. Створення сайтів, просування в інтернеті<br />10. Реклама в ЗМІ</p>
<p>Рекламна інформація:</p>
<p>&laquo;Art&amp;Pro&raquo; дарує Вам час та спокій. Вас перестануть турбувати питання, де замовити візитки чи обклеїти вітрину, як це оплатити та доставити. Адже рекламна агенція повного циклу &ndash; це дуже зручно. Ми зробимо все за Вас!</p>
<p>Працюйте з експертами у своїй справі. В нас більше 6 років досвіду на ринку реклами. Перевірені часом методи та підходи дозволять нам з впевненістю говорити про свою професійність. Звісно, дорога до досконалості була не без помилок і ще не завершена, але ми прагнемо до ідеалу та бажаємо досягти його кожному. На базі колишньої рекламної агенції &rdquo;Простір&rdquo;, відтепер &rdquo;Art&amp;Pro&rdquo;, ми створюємо нові стратегії, ідеї та конструктивні рішення, вдосконалюючи їх і себе щодня!&rdquo;</p>', 1, 49.8326826, 24.0361897, 'www.artpro.agency', N'ART&PRO', 1),
(7, N'м. Львів, вул. Володимира Великого, 2', NULL, NULL, N'<p>Галузі по КВЕД:</p>
<p>Інша поліграфічна діяльність<br />Брошурувально-палітурна та оздоблювальна діяльність<br />Продукція, послуги:</p>
<p>Наша друкарня надає такі послуги:<br />- Виробництво повного циклу.<br />- Креативний дизайн, розробка логотипу та фірмового стилю, підготовка до друку, web-дизайн Львів. <br />- Фотопослуги: рекламна, весільна та художня зйомка, художня обробка фото, комп&rsquo;ютерний монтаж, друг візиток у Львові виготовлення запрошень.<br />- Офсетний друк: візитки, флаєри, відкритки та запрошення, листівки, буклети, плакати, календарі, каталоги, папки, фірмові бланки, конверти, наклейки, етикетки, журнали, книги, виготовлення магнітиків, пивні підставки, упаковка та коробки. <br />- Післядрукарські послуги: висікання, біговка, склейка, перфорація, нумерація, брошурування, скріплення скобою, біндерування, листопідбір.</p>
<p>Рекламна інформація:</p>
<p>Серед наших переваги є:<br />- ціни виробника;<br />- висока якість друку;<br />- оперативність;<br />- індивідуальний підхід до кожного клієнта</p>', 4, 49.8087493, 24.0129304, 'www.levko.com.ua', N'ЛЕВКО, ДРУКАРНЯ', 1)
SET IDENTITY_INSERT dbo.Factories OFF

SET IDENTITY_INSERT dbo.Reviews ON
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (1, '2014-05-01', 1, 6, 'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.

In sagittis dui vel n', 'posuere metus vitae ipsum.', 16);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (2, '2017-01-19', 5, 2, 'Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.

Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.

Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', 'ante ipsum primis', 23);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (3, '2013-11-20', 3, 6, 'Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.

Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', 'a nibh', 9);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (4, '2016-05-26', 7, 6, 'Aenean fermentum. Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.', 'blandit nam nulla integer pede justo lacinia eget', 26);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (5, '2017-04-01', 4, 1, 'Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.

Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh.

In quis justo. Maecenas rhoncus aliquam lacus. Morbi quis tortor id nulla ultrices aliquet.', 'lobortis ligula sit amet eleifend pede libero quis orci', 18);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (6, '2014-12-13', 1, 6, 'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus.

Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero.', 'molestie hendrerit at vulputate vitae nisl aenean lectus pellentesque eget nunc', 30);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (7, '2014-06-22', 2, 6, 'Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.

Fusce consequat. Nulla nisl. Nunc nisl.

Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus. Duis at velit eu est congue elementum.', 'habitasse platea dictumst etiam faucibus cursus urna ut tellus nulla ut erat id mauris vulputate', 4);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (8, '2015-03-13', 7, 2, 'Nulla ut erat id mauris vulputate elementum. Nullam varius. Nulla facilisi.

Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.

Quisque porta volutpat erat. Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.', 'orci nullam molestie nibh in lectus pellentesque at nulla', 10);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (9, '2016-05-12', 1, 3, 'Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.', 'interdum venenatis turpis enim blandit mi in', 30);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (10, '2017-01-26', 1, 6, 'Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.

Nullam porttitor lacus at turpis. Donec posuere metus vitae ipsum. Aliquam non mauris.

Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.', 'leo maecenas pulvinar lobortis est phasellus sit amet erat nulla tempus vivamus in felis eu sapien cursus vestibulum proin eu', 3);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (11, '2016-08-31', 6, 2, 'Duis bibendum. Morbi non quam nec dui luctus rutrum. Nulla tellus.

In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.

Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.', 'vitae ipsum aliquam', 8);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (12, '2014-12-31', 6, 1, 'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.', 'lorem ipsum dolor sit amet consectetuer adipiscing elit proin', 25);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (13, '2016-01-24', 4, 4, 'Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.

Fusce consequat. Nulla nisl. Nunc nisl.', 'eros elementum pellentesque', 4);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (14, '2017-04-14', 3, 6, 'Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.

Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.

Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus. In est risus, auctor sed, tristique in, tempus sit amet, sem.', 'cras mi pede malesuada in imperdiet et commodo vulputate justo in blandit ultrices enim lorem ipsum dolor sit amet', 1);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (15, '2017-09-15', 3, 6, 'Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl. Nunc rhoncus dui vel sem.

Sed sagittis. Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus.', 'massa donec dapibus duis at velit eu est congue elementum in hac habitasse platea', 14);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (16, '2016-07-30', 3, 4, 'Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.

Etiam vel augue. Vestibulum rutrum rutrum neque. Aenean auctor gravida sem.', 'vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae nulla', 27);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (17, '2016-01-10', 1, 4, 'Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.

Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.', 'eget massa tempor convallis nulla neque libero convallis', 24);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (18, '2015-11-29', 6, 4, 'Suspendisse potenti. In eleifend quam a odio. In hac habitasse platea dictumst.', 'augue vestibulum ante ipsum primis in faucibus orci luctus', 16);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (19, '2015-07-14', 2, 5, 'Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.', 'faucibus accumsan odio curabitur convallis duis consequat dui nec nisi volutpat eleifend', 8);
insert into Reviews (Id, DateCreated, FactoryId, ReviewResultId, [Text], Title, UserId) values (20, '2014-07-30', 5, 4, 'Proin interdum mauris non ligula pellentesque ultrices. Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.

Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.

Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.', 'ut erat id mauris vulputate elementum nullam varius nulla facilisi cras non velit nec', 14);
SET IDENTITY_INSERT dbo.Reviews OFF


SET IDENTITY_INSERT dbo.Ratings ON
insert into Ratings (Id, FactoryId, RankValue, UserId) values (1, 2, 3, 19);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (2, 5, 5, 1);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (3, 1, 2, 12);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (4, 5, 4, 23);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (5, 2, 5, 25);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (6, 6, 1, 24);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (7, 2, 5, 17);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (8, 6, 2, 29);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (9, 1, 3, 29);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (10, 6, 4, 8);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (11, 2, 4, 13);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (12, 2, 1, 14);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (13, 2, 2, 6);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (14, 4, 2, 1);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (15,2, 4, 8);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (16, 2, 2, 22);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (17, 2, 4, 14);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (18, 2, 3, 26);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (19, 1, 5, 30);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (20, 1, 1, 24);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (21, 2, 4, 1);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (22, 6, 2, 10);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (23, 6, 4, 10);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (24, 4, 5, 11);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (25, 6, 3, 14);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (26, 6, 3, 15);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (27, 5, 4, 10);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (28, 4, 2, 18);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (29, 5, 4, 25);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (30, 3, 2, 1);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (31, 7, 1, 4);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (32, 5, 5, 2);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (33, 4, 3, 14);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (34, 5, 3, 29);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (35, 4, 5, 26);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (36, 2, 4, 24);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (37, 5, 5, 9);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (38, 6, 5, 18);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (39, 3, 2, 26);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (40, 2, 4, 21);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (41, 3, 3, 30);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (42, 2, 4, 8);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (43, 1, 5, 27);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (44, 4, 2, 2);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (45, 4, 1, 4);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (46, 1, 2, 25);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (47, 5, 5, 10);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (48, 1, 5, 7);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (49, 3, 1, 28);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (50, 1, 4, 19);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (51, 3, 5, 19);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (52, 3, 5, 19);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (53, 3, 5, 19);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (54, 3, 5, 19);
insert into Ratings (Id, FactoryId, RankValue, UserId) values (55, 3, 5, 19);
SET IDENTITY_INSERT dbo.Ratings OFF


SET IDENTITY_INSERT dbo.MachinesToFactories ON


insert into MachinesToFactories (Id, FactoryId, MachineId) values (1, 1, 15);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (2, 5, 15);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (3, 2, 7);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (4, 1, 2);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (5, 5, 16);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (6, 4, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (7, 3, 14);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (8, 5, 8);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (9, 4, 14);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (10, 7, 13);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (11, 7, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (12, 2, 15);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (13, 3, 12);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (14, 4, 15);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (15, 1, 14);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (16, 7, 16);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (17, 2, 7);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (18, 5, 5);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (19, 6, 10);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (20, 5, 4);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (21, 3, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (22, 4, 1);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (23, 5, 1);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (24, 3, 16);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (25, 1, 1);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (26, 7, 15);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (27, 5, 11);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (28, 4, 11);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (29, 5, 1);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (30, 7, 8);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (31, 5, 1);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (32, 5, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (33, 5, 11);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (34, 4, 11);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (35, 7, 2);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (36, 6, 1);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (37, 7, 2);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (38, 7, 3);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (39, 7, 11);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (40, 6, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (41, 6, 11);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (42, 4, 4);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (43, 7, 5);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (44, 3, 3);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (45, 4, 9);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (46, 6, 10);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (47, 5, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (48, 7, 6);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (49, 7, 8);
insert into MachinesToFactories (Id, FactoryId, MachineId) values (50, 4, 15);

SET IDENTITY_INSERT dbo.MachinesToFactories OFF


SET IDENTITY_INSERT dbo.FactoryToTechnology ON
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (1, 1, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (2, 5, 4);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (3, 10, 6);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (4, 9, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (5, 4, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (6, 6, 1);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (7, 8, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (8, 4, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (9, 4, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (10, 10, 6);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (11, 3, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (12, 8, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (13, 2, 7);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (14, 5, 6);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (15, 4, 1);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (16, 5, 5);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (17, 8, 7);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (18, 5, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (19, 10, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (20, 9, 4);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (21, 10, 7);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (22, 5, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (23, 10, 7);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (24, 1, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (25, 9, 6);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (26, 7, 7);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (27, 8, 5);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (28, 6, 7);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (29, 9, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (30, 6, 4);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (31, 3, 5);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (32, 7, 4);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (33, 1, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (34, 1, 1);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (35, 1, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (36, 5, 4);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (37, 1, 3);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (38, 3, 4);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (39, 8, 2);
insert into FactoryToTechnology (Id, CategoryId, FactoryId) values (40, 5, 5);
SET IDENTITY_INSERT dbo.FactoryToTechnology OFF

SET IDENTITY_INSERT dbo.FactoryToProduction ON
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (1, 5, 7);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (2, 3, 10);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (3, 4, 1);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (4, 6, 8);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (5, 6, 1);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (6, 4, 2);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (7, 5, 6);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (8, 6, 8);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (9, 7, 7);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (10, 5, 5);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (11, 3, 7);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (12, 5, 5);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (13, 3, 5);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (14, 1, 8);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (15, 1, 8);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (16, 2, 1);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (17, 1, 3);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (18, 7, 9);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (19, 1, 7);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (20, 5, 5);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (21, 4, 3);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (22, 6, 2);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (23, 3, 9);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (24, 3, 3);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (25, 5, 6);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (26, 4, 6);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (27, 1, 7);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (28, 1, 1);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (29, 3, 10);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (30, 3, 9);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (31, 4, 8);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (32, 4, 10);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (33, 2, 7);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (34, 3, 5);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (35, 5, 2);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (36, 6, 6);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (37, 2, 2);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (38, 5, 6);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (39, 6, 5);
insert into FactoryToProduction (Id, FactoryId, PrintingProductionId) values (40, 4, 5);
SET IDENTITY_INSERT dbo.FactoryToProduction OFF

SET IDENTITY_INSERT dbo.FactoryWorkingHours ON
INSERT INTO dbo.FactoryWorkingHours
(
	Id,
    [DayOfWeek],
    FactoryId,
    FromTime,
    ToTime
)
VALUES (1, 1, 1, '08-00', '18-00'),
(2, 2, 1, '08-00', '18-00'),
(3, 3, 1, '08-00', '18-00'),
(4, 4, 1, '08-00', '18-00'),
(5, 5, 1, '08-00', '18-00'),
(6, 6, 1, '08-00', '18-00'),
(7, 7, 1, NULL, NULL),

(8, 1, 2, '08-00', '18-00'),
(9, 2, 2, '08-00', '18-00'),
(10, 3, 2, '08-00', '18-00'),
(11, 4, 2, '08-00', '18-00'),
(12, 5, 2, '08-00', '18-00'),
(13, 6, 2, '08-00', '18-00'),
(14, 7, 2, NULL, NULL),

(15, 1, 3, '08-00', '18-00'),
(16, 2, 3, '08-00', '18-00'),
(17, 3, 3, '08-00', '18-00'),
(18, 4, 3, '08-00', '18-00'),
(19, 5, 3, '08-00', '18-00'),
(20, 6, 3, '08-00', '18-00'),
(21, 7, 3, NULL, NULL),

(22, 1, 4, '08-00', '18-00'),
(23, 2, 4, '08-00', '18-00'),
(24, 3, 4, '08-00', '18-00'),
(25, 4, 4, '08-00', '18-00'),
(26, 5, 4, '08-00', '18-00'),
(27, 6, 4, '08-00', '18-00'),
(28, 7, 4, NULL, NULL),

(29, 1, 5, '08-00', '18-00'),
(30, 2, 5, '08-00', '18-00'),
(31, 3, 5, '08-00', '18-00'),
(32, 4, 5, '08-00', '18-00'),
(33, 5, 5, '08-00', '18-00'),
(34, 6, 5, '08-00', '18-00'),
(35, 7, 5, NULL, NULL),

(36, 1, 6, '08-00', '18-00'),
(37, 2, 6, '08-00', '18-00'),
(38, 3, 6, '08-00', '18-00'),
(39, 4, 6, '08-00', '18-00'),
(40, 5, 6, '08-00', '18-00'),
(41, 6, 6, '08-00', '18-00'),
(42, 7, 6, NULL, NULL),

(43, 1, 7, '08-00', '18-00'),
(44, 2, 7, '08-00', '18-00'),
(45, 3, 7, '08-00', '18-00'),
(46, 4, 7, '08-00', '18-00'),
(47, 5, 7, '08-00', '18-00'),
(48, 6, 7, '08-00', '18-00'),
(49, 7, 7, NULL, NULL)
SET IDENTITY_INSERT dbo.FactoryWorkingHours OFF


SET IDENTITY_INSERT dbo.FactoryImages ON
INSERT INTO dbo.FactoryImages
(
	Id,
    FactoryId,
    [Path]
)
VALUES
(1, 1, N'/Content/Images/factory/f1/1.1.jpg'),
(2, 1, N'/Content/Images/factory/f1/1.2.jpg'),
(3, 1, N'/Content/Images/factory/f1/1.3.jpg'),
(4, 1, N'/Content/Images/factory/f1/1.4.jpg'),
(5, 1, N'/Content/Images/factory/f1/1.5.jpg'),
(6, 1, N'/Content/Images/factory/f1/1.6.jpg'),

(7, 2, N'/Content/Images/factory/f2/2.1.jpg'),
(8, 2, N'/Content/Images/factory/f2/2.2.jpg'),
(9, 2, N'/Content/Images/factory/f2/2.3.jpg'),
(10, 2, N'/Content/Images/factory/f2/2.4.jpg'),
(11, 2, N'/Content/Images/factory/f2/2.5.jpg'),
(12, 2, N'/Content/Images/factory/f2/2.6.jpg'),
(13, 2, N'/Content/Images/factory/f2/2.7.jpg'),

(14, 3, N'/Content/Images/factory/f3/3.1.jpg'),
(15, 3, N'/Content/Images/factory/f3/3.2.jpg'),
(16, 3, N'/Content/Images/factory/f3/3.3.jpg'),
(17, 3, N'/Content/Images/factory/f3/3.4.jpg'),
(18, 3, N'/Content/Images/factory/f3/3.5.jpg'),
(19, 3, N'/Content/Images/factory/f3/3.6.jpg'),

(20, 4, N'/Content/Images/factory/f4/4.1.jpg'),
(21, 4, N'/Content/Images/factory/f4/4.2.jpg'),
(31, 4, N'/Content/Images/factory/f4/4.3.jpg'),
(41, 4, N'/Content/Images/factory/f4/4.4.jpg'),
(51, 4, N'/Content/Images/factory/f4/4.5.jpg')
SET IDENTITY_INSERT dbo.FactoryImages OFF

SET IDENTITY_INSERT [dbo].[Positions] ON
INSERT INTO [dbo].[Positions] (Id, [Description])
VALUES 
(1, N'Молодший друкар'),
(2, N'Друкар'),
(3, N'Старший друкар'),
(4, N'Менеджер'),
(5, N'Менеджер по продажам'),
(6, N'Механік'),
(7, N'Директор')
SET IDENTITY_INSERT [dbo].[Positions] OFF


SET IDENTITY_INSERT [dbo].[Employees] ON
INSERT INTO [dbo].[Employees] (Id, DateOfBirth, EndDate, FactoryId, FirstName, LastName, Phone, PositionId, Salary, StartDate, AvatarPath)
VALUES
(1, '2016-10-18', NULL, 1,	N'Іван', N'Іваненко', '+38054748493', 1, 5500, '2016-10-18', NULL),
(2, '2016-10-18', NULL, 1,	N'Петро', N'Гриценко', '+38054748493', 2, 6500, '2016-10-18', NULL),
(3, '2016-10-18', NULL, 1,	N'Сергій', N'Науменко', '+38054748493', 3, 7500, '2016-10-18', NULL),
(4, '2016-10-18', NULL, 1,	N'Андрій', N'Кравченко', '+38054748493', 4, 8500, '2016-10-18', NULL),
(5, '2016-10-18', NULL, 1,	N'Оксана', N'Сович', '+38054748493', 5, 7500, '2016-10-18', NULL),
(6, '2016-10-18', NULL, 1,	N'Дмитро', N'Гончарук', '+38054748493', 6, 5500, '2016-10-18', NULL),
(7, '2016-10-18', NULL, 1,	N'Семен', N'Григоренко', '+38054748493', 3, 8500, '2016-10-18', NULL),
(9, '2016-10-18', NULL, 1,	N'Олег', N'Видорович', '+38054748493', 6, 4500, '2016-10-18', NULL),
(10, '2016-10-18', NULL, 1, N'Олексій', N'Шевчук', '+38054748493', 7, 9500, '2016-10-18', NULL),
(11, '2016-10-18', NULL, 1, N'Георгій', N'Семенюк', '+38054748493', 4, 6500, '2016-10-18', NULL),
(12, '2016-10-18', NULL, 1, N'Іван', N'Сидорович', '+38054748493', 3, 7500, '2016-10-18', NULL),
(13, '2016-10-18', NULL, 1, N'Микола', N'Ярема', '+38054748493', 1, 3500, '2016-10-18', null)
SET IDENTITY_INSERT [dbo].[Employees] OFF

SET IDENTITY_INSERT [dbo].[OrderStates] ON
INSERT INTO [dbo].[OrderStates] (Id, [Status])
VALUES
(1, N'Новий'),
(2, N'Розглянуто'),
(3, N'В Процесі'),
(4, N'Виконано'),
(5, N'Відмінено')
SET IDENTITY_INSERT [dbo].[OrderStates] OFF

SET IDENTITY_INSERT [dbo].[OrderValues] ON
INSERT INTO [dbo].[OrderValues](Id, [Value])
VALUES
(1, N'Низький пріоритет'),
(2, N'Середній пріоритет'),
(3, N'Високий пріоритет'),
(4, N'Максимальний пріоритет')
SET IDENTITY_INSERT [dbo].[OrderValues] OFF

SET IDENTITY_INSERT [dbo].[Orders] ON
INSERT INTO [dbo].[Orders] (Id, CompletedDate, CreatedDate, CustormerPhone, [Description], EmployeeId, FactoryId, IsCompleted, OrderStateId, OrderValueId, Price, CustomerName)
VALUES
(1, '2016-10-18', '2016-10-18', '+38054748493', N'Замовлення паковань.', NULL, 1, 0, 1, 2, 210, N'Петро Іванович'),
(2, '2016-10-18', '2016-10-18', '+38054748493', N'Замовлення паковань.', NULL, 1, 0, 1, 2, 210, N'Петро Іванович'),
(3, '2016-10-18', '2016-10-18', '+38054748493', N'Замовлення паковань.', NULL, 1, 0, 1, 2, 210, N'Петро Іванович'),
(4, '2016-10-18', '2016-10-18', '+38054748493', N'Замовлення паковань.', NULL, 1, 0, 1, 2, 210, N'Петро Іванович'),
(5, '2016-10-18', '2016-10-18', '+38054748493', N'Замовлення паковань.', NULL, 1, 0, 1, 2, 210, N'Петро Іванович'),
(6, '2016-10-18', '2016-10-18', '+38054748493', N'Замовлення паковань.', null, 1, 0, 1, 2, 210, N'Петро Іванович')
SET IDENTITY_INSERT [dbo].[Orders] OFF

















