--drop table oyuncuListesi
--drop table transferListesi
INSERT INTO oyuncuListesi VALUES('Faruk',	'Aygün',	21,	6713,	'Kaleci',	2544, 'Futbol',	'Galatasaray')
INSERT INTO oyuncuListesi VALUES('Furkan',	'Baltacý',	21,	6713,	'Defans',	2544, 'Futbol',	'Galatasaray')
INSERT INTO transferListesi VALUES('Furkan','Baltaci', 21,6713,	'Defans', 2544, 'Futbol','Galatasaray')
INSERT INTO transferListesi VALUES('Simge', 'Sarac', 20, 8542, 'Oyun Kurucu', 43646, 'Futbol', 'Kasýmpaþa')
INSERT INTO oyuncuListesi VALUES('Simge', 'Sarac', 20, 8542, 'Oyun Kurucu', 43646, 'Futbol', 'Kasýmpaþa')
INSERT INTO transferListesi VALUES('Mbaye','Diagne', 27,6713,	'Forvet', 2544, 'Futbol','Kasýmpaþa')
INSERT INTO transferListesi VALUES('Deniz', 'Türüç', 24, 8542, 'Orta Saha', 43646, 'Futbol', 'Kayserispor')
--delete from oyuncuListesi where id = 2

CREATE TABLE oyuncuListesi
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	ad NVARCHAR(30),
	soyad NVARCHAR(30),
	yas	INT,
	maas INT,
	mevki NVARCHAR(30),
	piyasaDegeri INT,
	sporDali NVARCHAR(30),
	Takim NVARCHAR(30)
)
GO


CREATE TABLE transferListesi
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	ad NVARCHAR(30),
	soyad NVARCHAR(30),
	yas	INT,
	maas INT,
	mevki NVARCHAR(30),
	PiyasaDegeri INT,
	sporDali NVARCHAR(30),
	Takim NVARCHAR(30)
)
GO

CREATE TABLE giris
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	lisansNo INT,
	parola NVARCHAR(30)	
)
GO

--INSERT INTO transferListesi VALUES('Simge', 'Saraç', 20, 85342, 'Oyun Kurucu', 4646, 'Basketbol', 'Galatasaray')
--INSERT INTO giris VALUES(01234567890, 'parola')
--delete from transferListesi where id = 3
SELECT * FROM oyuncuListesi
SELECT * FROM transferListesi
SELECT * FROM giris