use [master]
GO

IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'mahalleMarketi')
BEGIN
CREATE DATABASE [mahalleMarketi]
END
GO

use [mahalleMarketi]
GO

IF NOT EXISTS (select * from sysobjects where name='market')
BEGIN
CREATE TABLE market(
    kullaniciAdi VARCHAR(50) NOT NULL,
    sifre VARCHAR(50) NOT NULL
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='musteri')
BEGIN
CREATE TABLE musteri(
    mNo INT PRIMARY KEY,
    ad VARCHAR(50) NOT NULL,
    soyad VARCHAR(50) NOT NULL,
    telno VARCHAR(20) NOT NULL,
    toplamSatis FLOAT NOT NULL,
    toplamBorc FLOAT NOT NULL,
    toplamOdenen FLOAT
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='odeme')
BEGIN
CREATE TABLE odeme(
    odemeNo INT PRIMARY KEY,
    odemeTutari FLOAT NOT NULL,
    odemeTarihi DATE NOT NULL,
    mNo INT FOREIGN KEY REFERENCES musteri(mNo) 
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='tedarikci')
BEGIN
CREATE TABLE tedarikci(
    tNo INT PRIMARY KEY,
    tBorc FLOAT NOT NULL,
    tOdemeBilgileri VARCHAR(100) NOT NULL,
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='urun')
BEGIN
CREATE TABLE urun(
    urunKodu INT PRIMARY KEY,
    barkodNo VARCHAR(12) NOT NULL,
    stokMiktari INT NOT NULL,
    satisFiyati FLOAT NOT NULL
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='urunListesi')
BEGIN
CREATE TABLE urunListesi(
    ulNo INT PRIMARY KEY,
    urunKodu INT FOREIGN KEY REFERENCES urun(urunKodu),
    birimFiyat FLOAT NOT NULL,
    miktar INT NOT NULL 
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='irsaliye')
BEGIN
CREATE TABLE irsaliye(
    irsaliyeNo INT PRIMARY KEY,
    irsaliyeTarih DATE NOT NULL,
    irsaliyeTutar FLOAT NOT NULL,
    ulNo INT FOREIGN KEY REFERENCES urunListesi(ulNo),
    tNo INT FOREIGN KEY REFERENCES tedarikci(tNo)
)
END
GO

IF NOT EXISTS (select * from sys.columns where
    object_id = OBJECT_ID(N'[dbo].[urun]') 
    AND name = 'irsaliyeNo'
)
BEGIN
ALTER TABLE urun ADD irsaliyeNo INT NOT NULL FOREIGN KEY REFERENCES irsaliye(irsaliyeNo)
END
GO

IF NOT EXISTS (select * from sysobjects where name='cariSatis')
BEGIN
CREATE TABLE cariSatis (
    csNo INT PRIMARY KEY,
    csTarih DATE NOT NULL ,
    csTutar FLOAT NOT NULL,
    ulNo INT FOREIGN KEY REFERENCES urunListesi(ulNo),
    mNo INT FOREIGN KEY REFERENCES musteri(mNo),
)
END
GO

IF NOT EXISTS (select * from sysobjects where name='pesinSatis')
BEGIN
CREATE TABLE pesinSatis (
    psNo INT PRIMARY KEY,
    psTarih DATE NOT NULL ,
    psTutar FLOAT NOT NULL,
    ulNo INT FOREIGN KEY REFERENCES urunListesi(ulNo),
)
END
GO