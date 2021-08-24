-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Anamakine: localhost
-- Üretim Zamanı: 19 Haz 2019, 02:14:00
-- Sunucu sürümü: 5.7.17-log
-- PHP Sürümü: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `ogrenci`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admingiris`
--

CREATE TABLE `admingiris` (
  `ad` varchar(100) NOT NULL,
  `sifre` varchar(100) NOT NULL,
  `tarih` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `admingiris`
--

INSERT INTO `admingiris` (`ad`, `sifre`, `tarih`) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3', ''),
('admin', 'admin', '');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrenciekle`
--

CREATE TABLE `ogrenciekle` (
  `numara` int(8) NOT NULL,
  `ad` varchar(60) NOT NULL,
  `soyad` varchar(60) NOT NULL,
  `ogrencino` int(11) NOT NULL,
  `sinif` varchar(60) NOT NULL,
  `bolum` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `tel` int(12) NOT NULL,
  `adres` varchar(30) NOT NULL,
  `cinsiyet` varchar(10) NOT NULL,
  `eklenmezamani` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `ogrenciekle`
--

INSERT INTO `ogrenciekle` (`numara`, `ad`, `soyad`, `ogrencino`, `sinif`, `bolum`, `email`, `tel`, `adres`, `cinsiyet`, `eklenmezamani`) VALUES
(5, 'Mustafa', 'Aksoy', 32417123, 'y3s2', 'Bilgisayar Mühendisiliği', 'blairman@gmail.com', 53876464, 'Turkiye', 'Erkek', '2019-06-18 01:02:53');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrencikayit`
--

CREATE TABLE `ogrencikayit` (
  `id` int(8) NOT NULL,
  `ad` varchar(60) NOT NULL,
  `soyad` varchar(60) NOT NULL,
  `cinsiyet` varchar(10) NOT NULL,
  `ogrencino` int(11) NOT NULL,
  `bolum` varchar(100) NOT NULL,
  `tarih` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `kullaniciadi` varchar(30) NOT NULL,
  `sifre` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `ogrencikayit`
--

INSERT INTO `ogrencikayit` (`id`, `ad`, `soyad`, `cinsiyet`, `ogrencino`, `bolum`, `tarih`, `kullaniciadi`, `sifre`) VALUES
(1, 'Mustafa', 'Aksoy', 'Erkek', 32417123, 'Bilgisayar Mühendisiliği', '2019-06-18 01:02:53', 'musti44', '12345');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `ogrenciekle`
--
ALTER TABLE `ogrenciekle`
  ADD PRIMARY KEY (`numara`);

--
-- Tablo için indeksler `ogrencikayit`
--
ALTER TABLE `ogrencikayit`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `kullaniciadi` (`kullaniciadi`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `ogrenciekle`
--
ALTER TABLE `ogrenciekle`
  MODIFY `numara` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Tablo için AUTO_INCREMENT değeri `ogrencikayit`
--
ALTER TABLE `ogrencikayit`
  MODIFY `id` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
