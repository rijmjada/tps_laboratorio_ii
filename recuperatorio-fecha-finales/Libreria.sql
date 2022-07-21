
CREATE DATABASE Libreria
GO  

use Libreria
GO  

CREATE TABLE [dbo].[libros]  
(  
 [codigo] [int] PRIMARY KEY IDENTITY(1,1),  
 [titulo] [varchar] (50) NOT NULL,  
 [autor] [varchar](50) NOT NULL,  
 [paginas] [int] NOT NULL,
 [precio] [float] NOT NULL,
 [id_genero] [int] NOT NULL,
 [id_origen] [int] NOT NULL
); 
GO

CREATE TABLE clientes  
(  
 [id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,  
 [nombre] [varchar] (50) NOT NULL,  
 [apellido] [varchar](50) NOT NULL,  
 [dni] [int] NOT NULL,
 [direccion] varchar(100) NOT NULL,
); 
GO

CREATE TABLE facturas  
(  
 [id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,  
 [fecha] [DATE] NOT NULL,  
 [producto] [varchar](70) NOT NULL,  
 [monto] [float] NOT NULL,
 [id_cliente] [int] FOREIGN KEY REFERENCES clientes(id) NOT NULL
); 
GO

insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Brannon Fulop', 1161, 5467.35, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Books', 'Andres Tubb', 1484, 4647.38, 6, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Grocery', 'Jodi Backson', 8545, 453.52, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Toys', 'Karlens Avo', 2821, 9760.21, 7, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Toys', 'Bette-ann Seckom', 887, 9383.73, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Baby', 'Bentlee McCarlie', 1425, 2610.59, 6, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Automotive', 'Humfrey Spowage', 261, 6811.8, 7, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Computers', 'Christiane Easby', 6791, 9320.1, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Hilario Freschini', 1448, 9408.74, 4, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Jewelry', 'Donetta Catford', 9306, 5772.57, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Tools', 'Saraann McCadden', 4311, 5098.9, 3, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Kids', 'Gage Miranda', 3635, 8678.02, 4, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Computers', 'Lydia Rushmare', 2758, 7979.59, 6, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Outdoors', 'Ariana Bockett', 242, 7511.99, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Industrial', 'Brietta Kidman', 8734, 9310.75, 2, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Music', 'Benito Lodwig', 6898, 9288.98, 6, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Outdoors', 'Kane Hunte', 8643, 8457.52, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Damon Casier', 9333, 2152.08, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Outdoors', 'Lelia Skpsey', 6350, 4811.44, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Jewelry', 'Berkeley Laviss', 691, 6707.3, 3, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Judah Grint', 6015, 1882.92, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Rodrique O'' Mahony', 7591, 8528.43, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Baby', 'Melantha Seabourne', 6444, 8052.14, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Clothing', 'Jemimah Formigli', 5723, 5958.93, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Grocery', 'Zerk Lyster', 4015, 7078.47, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Clothing', 'Adey Temlett', 1804, 8889.81, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Bartlet Cherrison', 4661, 5066.12, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Georas Withnall', 3590, 6773.64, 2, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Jewelry', 'Valina Itzhaiek', 1885, 4237.77, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Trace Challens', 6189, 7618.11, 6, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Clothing', 'Wanids Mushawe', 1953, 3115.55, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Addy Ridout', 5610, 8344.72, 2, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Books', 'Rocky Clowsley', 9522, 3815.79, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Shoes', 'Dimitri Valsler', 7062, 2226.41, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Alvera Ashwin', 421, 9309.9, 6, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Derrik Sissot', 2654, 1492.72, 2, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Kids', 'Bobbie Cressey', 1145, 783.15, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Jewelry', 'Sonny Balwin', 312, 9288.4, 4, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Jewelry', 'Travers Gibb', 1319, 3649.47, 6, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Health', 'Joly Chorlton', 4230, 3470.42, 4, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Books', 'Gallard Lavallie', 8163, 6767.03, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Rebekkah Clift', 6614, 6001.61, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Kids', 'Alan Bontein', 6370, 4278.11, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Kids', 'Angel McClinton', 218, 6304.12, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Anitra Davis', 8338, 1146.12, 7, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Books', 'Julietta Figliovanni', 7333, 341.19, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Marlowe Littrell', 3434, 4646.74, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Jewelry', 'Clemmy Kay', 343, 7436.51, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Free Catford', 9382, 6658.37, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Toys', 'Jerrold Rubinsztein', 154, 6398.33, 4, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Computers', 'Kasey Fowell', 5238, 9577.84, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Computers', 'Sloan McLeod', 5140, 8701.36, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Melissa Ruddock', 2001, 4304.83, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Automotive', 'Winona Hearse', 2917, 2867.08, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Health', 'Rainer Bullene', 5385, 6019.6, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Tools', 'Cheri MacLaverty', 893, 9696.0, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Electronics', 'Horten Yggo', 3308, 4280.53, 4, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Automotive', 'Travus Stevenson', 7264, 3083.64, 3, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Berny Godfree', 8265, 7791.34, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Marcia Vasser', 4150, 6264.46, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Shoes', 'Ludovika Napoleon', 3795, 3046.19, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Shoes', 'Rosie Scowen', 1848, 6104.83, 7, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Automotive', 'Nye Noulton', 7653, 2971.45, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Nolly Snelle', 415, 2674.86, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Baby', 'Othello Beddoes', 8864, 8812.93, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Books', 'Ediva Dunstone', 2344, 4099.9, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Grocery', 'Ulrikaumeko Caddan', 2871, 9910.38, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Books', 'Timmie Sandeson', 3089, 8252.21, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Outdoors', 'Lizbeth Newlove', 4037, 7163.87, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Kids', 'Bartolemo Seine', 1597, 8119.85, 6, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Clothing', 'Vicki Durram', 183, 672.86, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Clothing', 'Cleopatra Beneteau', 1573, 8247.8, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Computers', 'Newton Gillcrist', 862, 5685.73, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Electronics', 'Gaynor Hoy', 1339, 8934.05, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Austin Ogdahl', 8761, 5190.22, 4, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Outdoors', 'Saudra Delacourt', 5860, 9004.17, 6, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Outdoors', 'Rog Sturges', 1176, 9422.53, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Drucy Keele', 5150, 5557.38, 2, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Industrial', 'Randall Chamberlain', 5651, 5597.33, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Tools', 'Sid Anchor', 5252, 6786.0, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Health', 'Merle Johnstone', 4212, 3661.79, 3, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Grocery', 'Annnora Childes', 774, 572.32, 7, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Kip Witherbed', 187, 2143.29, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Syman Stickford', 7948, 8355.02, 6, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Games', 'Dallas Sibthorp', 9292, 2399.33, 5, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Beauty', 'Oliver Alven', 7929, 4412.17, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Computers', 'Albert Teasell', 6698, 1092.69, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Automotive', 'Lynelle Cogley', 2682, 6850.28, 7, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Tools', 'Ely Clausewitz', 6086, 3641.16, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Isobel Norvill', 5146, 6441.64, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Sports', 'Felike Hubbert', 6983, 5089.9, 3, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Toys', 'Drud Pitney', 6040, 6727.11, 2, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Beauty', 'Tull Erley', 7203, 2438.62, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Health', 'Patti Dudek', 8776, 9176.39, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Movies', 'Alvis Bemrose', 8463, 3240.97, 7, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Home', 'Rosco Wingrove', 1237, 7600.99, 5, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Shoes', 'Georgetta Blowfield', 8300, 9578.14, 3, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Industrial', 'Rhett Christensen', 1826, 6590.53, 1, 2);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Shoes', 'Artair Laphorn', 1272, 2267.59, 1, 1);
insert into libros (titulo, autor, paginas, precio, id_genero, id_origen) values ('Industrial', 'Dominick Jonin', 3573, 8064.85, 4, 2);


insert into clientes (nombre, apellido, dni, direccion) values ('Tiff', 'Sreenan', 5767370, '2271 Alpine Circle');
insert into clientes (nombre, apellido, dni, direccion) values ('Marcellina', 'Faich', 4949118, '27025 Ilene Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Norean', 'Iremonger', 5525679, '03 Service Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Ursulina', 'Pellew', 2792390, '2805 Roxbury Plaza');
insert into clientes (nombre, apellido, dni, direccion) values ('Weston', 'Bisacre', 8797537, '828 Katie Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Helene', 'Janodet', 9634172, '8512 American Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Olympe', 'Crissil', 1223456, '02595 Dottie Pass');
insert into clientes (nombre, apellido, dni, direccion) values ('Sidoney', 'Kaplan', 7221831, '27 Alpine Avenue');
insert into clientes (nombre, apellido, dni, direccion) values ('Annis', 'Kidwell', 9287989, '1 Schmedeman Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Munmro', 'Losty', 5002066, '47217 Dexter Junction');
insert into clientes (nombre, apellido, dni, direccion) values ('Jaquelin', 'Karchowski', 5235752, '4 Independence Park');
insert into clientes (nombre, apellido, dni, direccion) values ('Conan', 'McLaggan', 2226288, '07618 Kingsford Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Brittni', 'Wraxall', 1123700, '3 Atwood Trail');
insert into clientes (nombre, apellido, dni, direccion) values ('Berty', 'Lesmonde', 5898066, '5586 Blue Bill Park Trail');
insert into clientes (nombre, apellido, dni, direccion) values ('Tybalt', 'Hechlin', 2606844, '57 Ridge Oak Plaza');
insert into clientes (nombre, apellido, dni, direccion) values ('Vladimir', 'Congreave', 3722109, '808 Becker Court');
insert into clientes (nombre, apellido, dni, direccion) values ('Toddie', 'Lemonby', 5531047, '1834 Chinook Pass');
insert into clientes (nombre, apellido, dni, direccion) values ('Shannon', 'Itschakov', 8241441, '9 Crowley Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Zach', 'Crosen', 7489932, '9 Artisan Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Basile', 'Hanham', 1278515, '144 Warner Way');
insert into clientes (nombre, apellido, dni, direccion) values ('Syman', 'Hudghton', 5115778, '8 Westridge Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Lem', 'Leborgne', 5001733, '3010 Bashford Lane');
insert into clientes (nombre, apellido, dni, direccion) values ('Skelly', 'Isoldi', 6497009, '111 Lighthouse Bay Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Waite', 'Ryland', 8674963, '28059 Namekagon Trail');
insert into clientes (nombre, apellido, dni, direccion) values ('Roch', 'Mafham', 1692206, '9247 Caliangt Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Dahlia', 'Gorges', 6630496, '14 Fairview Court');
insert into clientes (nombre, apellido, dni, direccion) values ('Nat', 'Thow', 9622804, '4959 Stoughton Terrace');
insert into clientes (nombre, apellido, dni, direccion) values ('Celesta', 'Mannion', 6188758, '77 Dakota Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Konstantin', 'Messer', 5447851, '6476 Kim Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Izabel', 'Bracegirdle', 3627440, '546 Maryland Drive');
insert into clientes (nombre, apellido, dni, direccion) values ('Cyrill', 'Lamerton', 9087044, '988 Buena Vista Pass');
insert into clientes (nombre, apellido, dni, direccion) values ('Mozes', 'Roeby', 2077082, '080 Norway Maple Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Annnora', 'Piggford', 7378710, '72048 Carioca Circle');
insert into clientes (nombre, apellido, dni, direccion) values ('Bryana', 'Arrighetti', 1807163, '20 Bartillon Center');
insert into clientes (nombre, apellido, dni, direccion) values ('Kary', 'Back', 9043906, '3 Gale Trail');
insert into clientes (nombre, apellido, dni, direccion) values ('Mickie', 'Sprason', 5904399, '3034 Summerview Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Kirstyn', 'Simmen', 6340668, '3 Logan Junction');
insert into clientes (nombre, apellido, dni, direccion) values ('Mattias', 'Tampion', 8298558, '39074 Caliangt Trail');
insert into clientes (nombre, apellido, dni, direccion) values ('Nickola', 'Curnok', 2720686, '698 Emmet Place');
insert into clientes (nombre, apellido, dni, direccion) values ('Rene', 'Ahern', 3996425, '4 Tomscot Place');
insert into clientes (nombre, apellido, dni, direccion) values ('Alain', 'Frape', 5595027, '42 Fremont Pass');
insert into clientes (nombre, apellido, dni, direccion) values ('Wash', 'Barehead', 6223420, '91355 Orin Terrace');
insert into clientes (nombre, apellido, dni, direccion) values ('Theodore', 'Mattock', 9769693, '3 7th Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Meriel', 'Khristoforov', 4324269, '81635 Donald Lane');
insert into clientes (nombre, apellido, dni, direccion) values ('Chrissie', 'Shotboult', 7979384, '5639 Loftsgordon Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Daisi', 'Growy', 2015900, '5681 Helena Avenue');
insert into clientes (nombre, apellido, dni, direccion) values ('Korrie', 'Sarah', 8928978, '6055 Gulseth Center');
insert into clientes (nombre, apellido, dni, direccion) values ('Verena', 'Sopper', 9674376, '5 Armistice Terrace');
insert into clientes (nombre, apellido, dni, direccion) values ('Meg', 'Chatelot', 1637538, '55 Kropf Circle');
insert into clientes (nombre, apellido, dni, direccion) values ('Bourke', 'Ivatts', 6003633, '489 Center Road');
insert into clientes (nombre, apellido, dni, direccion) values ('Thurstan', 'Targe', 2763981, '433 Express Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Lacey', 'Lindeberg', 6091904, '6 Laurel Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Robbyn', 'Reucastle', 7162476, '15 Brickson Park Terrace');
insert into clientes (nombre, apellido, dni, direccion) values ('Raffarty', 'Yakubowicz', 7712510, '46343 Little Fleur Pass');
insert into clientes (nombre, apellido, dni, direccion) values ('Diana', 'Twidale', 6969796, '5619 Arapahoe Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Elia', 'Tapper', 9962339, '3 Corry Terrace');
insert into clientes (nombre, apellido, dni, direccion) values ('Nikolia', 'Alyonov', 1360448, '646 Huxley Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Meier', 'Klulisek', 9708923, '398 Mesta Lane');
insert into clientes (nombre, apellido, dni, direccion) values ('Emiline', 'Hurche', 5304657, '2454 Boyd Circle');
insert into clientes (nombre, apellido, dni, direccion) values ('Beret', 'Baudi', 6330290, '0 Sundown Place');
insert into clientes (nombre, apellido, dni, direccion) values ('Wylma', 'Escofier', 3515708, '16677 Carioca Center');
insert into clientes (nombre, apellido, dni, direccion) values ('Quint', 'O''Cahsedy', 8471411, '8 Kedzie Way');
insert into clientes (nombre, apellido, dni, direccion) values ('Alison', 'Maharg', 1506358, '281 American Ash Park');
insert into clientes (nombre, apellido, dni, direccion) values ('Cortney', 'Northidge', 6883988, '7 Maple Wood Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Juliet', 'Sibbald', 1248709, '75 Northridge Park');
insert into clientes (nombre, apellido, dni, direccion) values ('Faulkner', 'Cadigan', 8918018, '8376 School Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Aylmar', 'Bartkiewicz', 1782653, '2 Tony Way');
insert into clientes (nombre, apellido, dni, direccion) values ('Helen-elizabeth', 'De La Cote', 4429379, '8 Gina Junction');
insert into clientes (nombre, apellido, dni, direccion) values ('Innis', 'Normanell', 9248903, '1274 Onsgard Court');
insert into clientes (nombre, apellido, dni, direccion) values ('Earle', 'Grimsdike', 2604756, '10558 Parkside Hill');
insert into clientes (nombre, apellido, dni, direccion) values ('Jacklin', 'Hukins', 6726446, '5 Kim Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Oliy', 'McInnerny', 3076228, '16 Arkansas Center');
insert into clientes (nombre, apellido, dni, direccion) values ('Simonne', 'Pottery', 3440155, '341 Mitchell Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Derward', 'Bechley', 1242944, '1157 Dwight Drive');
insert into clientes (nombre, apellido, dni, direccion) values ('Gabie', 'Bellard', 2586496, '589 Luster Place');
insert into clientes (nombre, apellido, dni, direccion) values ('Rube', 'Bevens', 6048116, '17569 Dennis Place');
insert into clientes (nombre, apellido, dni, direccion) values ('Georas', 'Ranger', 2988998, '2509 Boyd Avenue');
insert into clientes (nombre, apellido, dni, direccion) values ('Durand', 'Foulkes', 2806691, '9 Donald Parkway');
insert into clientes (nombre, apellido, dni, direccion) values ('Sydney', 'Martt', 2208212, '23 Forest Dale Alley');
insert into clientes (nombre, apellido, dni, direccion) values ('Yardley', 'Mangham', 2301767, '6123 Lawn Plaza');
insert into clientes (nombre, apellido, dni, direccion) values ('Agnes', 'Riping', 8007136, '66357 Talisman Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Maridel', 'Chin', 4580972, '5547 Badeau Street');
insert into clientes (nombre, apellido, dni, direccion) values ('Skipton', 'Gamon', 7918166, '01550 Oak Valley Street');
insert into clientes (nombre, apellido, dni, direccion) values ('Gabrila', 'Van der Kruijs', 1434230, '7 Dahle Junction');
insert into clientes (nombre, apellido, dni, direccion) values ('Keir', 'O'' Connell', 6309432, '22 Atwood Drive');
insert into clientes (nombre, apellido, dni, direccion) values ('Ambrosius', 'Vidyapin', 2682890, '4932 Jay Circle');
insert into clientes (nombre, apellido, dni, direccion) values ('Colin', 'Minshaw', 6627073, '0 Judy Court');
insert into clientes (nombre, apellido, dni, direccion) values ('Dyanne', 'Hoyle', 4972623, '94 American Ash Lane');
insert into clientes (nombre, apellido, dni, direccion) values ('Mattie', 'Youles', 9909483, '932 Arapahoe Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Zoe', 'Allsobrook', 1353036, '1 Holmberg Road');
insert into clientes (nombre, apellido, dni, direccion) values ('Demetre', 'Gradon', 2373096, '582 Randy Plaza');
insert into clientes (nombre, apellido, dni, direccion) values ('Ritchie', 'Huikerby', 4622861, '846 Reinke Point');
insert into clientes (nombre, apellido, dni, direccion) values ('Thebault', 'Ayers', 8218312, '766 Spenser Circle');
insert into clientes (nombre, apellido, dni, direccion) values ('Marie-ann', 'Girardetti', 7328919, '23 Hoffman Parkway');
insert into clientes (nombre, apellido, dni, direccion) values ('Harlene', 'Birkenshaw', 3707864, '2552 Holy Cross Lane');
insert into clientes (nombre, apellido, dni, direccion) values ('Roseann', 'Souttar', 2016948, '0811 Jay Road');
insert into clientes (nombre, apellido, dni, direccion) values ('Merline', 'Measey', 2821668, '6918 Independence Plaza');
insert into clientes (nombre, apellido, dni, direccion) values ('Yehudit', 'Roglieri', 1956988, '34417 Vahlen Junction');
insert into clientes (nombre, apellido, dni, direccion) values ('Christi', 'Paydon', 9226097, '8031 Stoughton Crossing');
insert into clientes (nombre, apellido, dni, direccion) values ('Camel', 'Palin', 5214877, '112 Dovetail Junction');


insert into facturas (fecha, producto, monto, id_cliente) values ('2021-10-30', 'B. Riley Financial, Inc.', 9546.57, 22);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-12-10', 'Gabelli Utility Trust (The)', 4706.67, 100);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-14', 'Stifel Financial Corporation', 1241.85, 88);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-04', 'Rite Aid Corporation', 8515.7, 82);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-11-28', 'Universal Electronics Inc.', 5233.68, 6);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-26', 'Build-A-Bear Workshop, Inc.', 2993.0, 81);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-03', 'Republic First Bancorp, Inc.', 7136.33, 27);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-26', 'Encore Wire Corporation', 1752.87, 59);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-05', 'First Trust International Multi-Asset Diversified Income Index', 9390.28, 92);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-10', 'HC2 Holdings, Inc.', 2142.47, 5);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-01', 'VictoryShares US Large Cap High Div Volatility Wtd ETF', 8235.35, 95);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-03', 'Medigus Ltd.', 4289.27, 83);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-04', 'Medovex Corp.', 3936.21, 30);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-14', 'Yext, Inc.', 8536.07, 35);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-15', 'KT Corporation', 2768.5, 22);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-12-18', 'Great Western Bancorp, Inc.', 6919.08, 27);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-12-31', 'Omega Protein Corporation', 9004.04, 99);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-26', 'Presidio, Inc.', 8175.84, 41);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-12-31', 'M I Acquisitions, Inc.', 3558.96, 2);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-02-21', 'HV Bancorp, Inc.', 3290.26, 99);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-06', 'Chemung Financial Corp', 5678.86, 12);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-31', 'VOXX International Corporation', 9482.97, 25);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-09', 'Anadarko Petroleum Corporation', 1234.14, 7);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-10-18', 'PAR Technology Corporation', 7033.34, 8);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-26', 'Philip Morris International Inc', 4353.78, 16);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-14', 'Avista Healthcare Public Acquisition Corp.', 3200.16, 40);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-02-25', 'Kronos Worldwide Inc', 8551.92, 15);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-09-26', 'Liberty Broadband Corporation', 2507.46, 37);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-04', 'Plains Group Holdings, L.P.', 1610.04, 66);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-02', 'Crawford & Company', 4742.84, 39);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-04', 'Becton, Dickinson and Company', 7375.81, 54);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-09-14', 'Celldex Therapeutics, Inc.', 5498.74, 92);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-24', 'Regal Entertainment Group', 3815.45, 70);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-05', 'Terex Corporation', 1161.31, 53);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-10', 'Marcus Corporation (The)', 2192.9, 63);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-22', 'PRGX Global, Inc.', 2281.92, 15);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-15', 'Osisko Gold Royalties Ltd', 5983.6, 75);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-12-02', 'Spirit Airlines, Inc.', 7981.85, 77);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-11-11', 'Och-Ziff Capital Management Group LLC', 1193.73, 28);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-22', 'BlackRock, Inc.', 4408.92, 78);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-11-07', 'Prosperity Bancshares, Inc.', 6045.62, 64);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-23', 'iShares Commodities Select Strategy ETF', 1480.63, 87);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-12-22', 'StoneCastle Financial Corp', 1662.91, 64);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-14', 'Southern Copper Corporation', 3746.52, 36);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-18', 'Kimco Realty Corporation', 6072.18, 65);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-02-11', 'German American Bancorp, Inc.', 6462.32, 61);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-28', 'AppFolio, Inc.', 1830.64, 42);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-19', 'NII Holdings, Inc.', 5054.3, 15);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-02-19', 'American Tower Corporation (REIT)', 2065.73, 27);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-14', 'PowerShares S&P SmallCap Industrials Portfolio', 1732.62, 71);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-03', 'Spectrum Pharmaceuticals, Inc.', 9283.01, 91);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-18', 'Landmark Bancorp Inc.', 9532.11, 96);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-25', 'Citigroup Inc.', 8527.18, 36);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-30', 'International Business Machines Corporation', 4896.49, 66);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-19', 'W.R. Berkley Corporation', 9355.58, 18);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-10', 'Lawson Products, Inc.', 5022.89, 17);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-10', 'PowerShares DWA Healthcare Momentum Portfolio', 5396.06, 59);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-22', 'GNC Holdings, Inc.', 4977.44, 79);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-09-01', 'Nuveen California Quality Municipal Income Fund', 2330.5, 39);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-15', 'Legg Mason, Inc.', 2713.89, 61);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-18', 'EOG Resources, Inc.', 2977.95, 88);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-23', 'MACOM Technology Solutions Holdings, Inc.', 4768.2, 4);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-29', 'GCP Applied Technologies Inc.', 5523.1, 98);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-19', 'NanoString Technologies, Inc.', 2685.34, 96);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-02', 'Proteostasis Therapeutics, Inc.', 8873.4, 37);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-12', 'iFresh Inc.', 7964.15, 56);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-20', 'BlackRock Utility and Infrastructure Trust', 9606.26, 96);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-31', 'ARMOUR Residential REIT, Inc.', 1195.89, 37);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-02', 'Aegon NV', 4856.62, 90);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-14', 'M&T Bank Corporation', 9082.93, 42);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-01', 'Nortech Systems Incorporated', 8057.56, 6);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-02-10', 'Univar Inc.', 9807.27, 84);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-06', 'Federal Realty Investment Trust', 4299.48, 28);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-06', 'MiMedx Group, Inc', 2133.58, 98);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-09-13', 'ArQule, Inc.', 1639.97, 57);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-16', 'Cerus Corporation', 6457.56, 49);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-16', 'The GDL Fund', 9398.77, 49);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-03', 'Ampco-Pittsburgh Corporation', 9202.17, 42);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-12', 'Blackrock MuniHoldings Fund, Inc.', 6460.01, 93);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-10', 'Marriot Vacations Worldwide Corporation', 9132.38, 22);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-03-06', 'Nortel Inversora SA', 1168.49, 71);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-08', 'Genius Brands International, Inc.', 2228.5, 71);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-10-17', 'Essent Group Ltd.', 3974.23, 89);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-01', 'FS Bancorp, Inc.', 3143.61, 47);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-09-08', 'The Charles Schwab Corporation', 6943.08, 31);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-10', 'Juniper Networks, Inc.', 9161.1, 57);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-11-15', 'ICF International, Inc.', 7548.0, 58);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-01', 'Capricor Therapeutics, Inc.', 7266.47, 3);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-17', 'Belmond Ltd.', 4802.91, 46);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-05-02', 'Global Indemnity Limited', 8753.32, 43);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-12', 'The Joint Corp.', 8382.45, 29);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-07-04', 'Encore Wire Corporation', 8275.19, 92);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-02-13', 'First Trust Large Cap Value AlphaDEX Fund', 2063.29, 31);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-01-18', 'Energy Recovery, Inc.', 2736.3, 15);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-04-01', 'Westrock Company', 2230.14, 72);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-10-17', 'Preferred Apartment Communities, Inc.', 4809.19, 52);
insert into facturas (fecha, producto, monto, id_cliente) values ('2022-06-08', 'Shutterfly, Inc.', 5569.01, 49);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-08-09', 'Highland/iBoxx Senior Loan ETF', 8767.31, 52);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-11-24', 'Simmons First National Corporation', 9284.0, 3);
insert into facturas (fecha, producto, monto, id_cliente) values ('2021-10-14', 'PulteGroup, Inc.', 4338.92, 38);