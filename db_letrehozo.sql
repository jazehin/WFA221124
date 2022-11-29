CREATE DATABASE pelda;
USE pelda;

CREATE TABLE emberek (
  id INT PRIMARY KEY IDENTITY,
  nev VARCHAR(120) NOT NULL,
  nem BIT NULL,
  szul DATE NULL);

TRUNCATE TABLE emberek;
  
INSERT INTO emberek VALUES
('Cserepes Virág', 0, '2000-06-12'),
('Füty Imre',      1, '1986-07-01'),
('Para Zita',      0, '2006-10-01'),
('Lapos Elemér',   1, '2010-01-31'),
('Viz Elek',       1, '1999-11-23'),
('Végh Béla',      1, '1971-02-28'),
('Példa Lóránt',   1, '1995-03-18'),
('Másik Lukrécia', 0, '1990-07-11');