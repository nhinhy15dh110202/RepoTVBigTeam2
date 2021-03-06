/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 []
      ,[SellerName]
      ,[SellerAdress]
      ,[SellerLimit]
      ,[SellerStatus]
      ,[SellerNote]
  FROM [TVBigTeam2].[dbo].[Seller]

insert into Seller (SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Janina Crippes', '65 Norway Maple Road', 29, 0, null);
insert into Seller (SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Fredi Peacey', '805 Atwood Park', 61, 0, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Phillipe Bosman', '45 Petterle Parkway', 11, 1, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Kimberley Hugland', '9 Victoria Crossing', 62, 0, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Adlai Tzarkov', '2197 Jackson Street', 63, 1, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Zaneta Grieg', '1 Burrows Point', 92, 1, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Cassie Abade', '8075 Thackeray Avenue', 99, 1, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Jamey Lushey', '173 Wayridge Plaza', 53, 1, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Maryann Kluger', '43 Evergreen Lane', 75, 0, null);
insert into Seller ( SellerName, SellerAdress, SellerLimit, SellerStatus, SellerNote) values ('Collete Lumpkin', '3 Starling Alley', 99, 1, null);