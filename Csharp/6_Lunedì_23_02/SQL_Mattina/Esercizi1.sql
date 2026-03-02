/*select distinct Region from Country
where Continent = 'Europe';*/

/*select Name, Population from City
where CountryCode = 'USA' and Population > 1000000
order by Population desc;*/

/*select Continent, COUNT(*) as Stati, SUM(Population) as Popolazione_Totale
from Country
group by Continent
order by Popolazione_Totale desc;*/

/*create table Libri(
	id INT PRIMARY KEY auto_increment,
    titolo VARCHAR(100),
    autore VARCHAR(100),
    genere varchar(50),
    prezzo decimal(5,2),
    anno_pubblicazione int
);*/

/*insert into Libri
values(5, 'titolo_libro6', 'autore_libro6', 'giallo', 10, 2026);*/

/*select genere, count(*) as tot_libri, avg(prezzo) as media_prezzo
from libri
group by genere
order by genere desc;*/

/*select * from Libri
where anno_pubblicazione > 2010
order by anno_pubblicazione desc, prezzo asc;*/

