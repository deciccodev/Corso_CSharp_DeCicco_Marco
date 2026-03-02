insert into Libri (id, titolo, autore, genere, anno_pubblicazione, prezzo) values
(56, 'Il Nome della Rosa', 'Umberto Eco', 'Storico', 1980, 18.50),
(57, 'La Divina Commedia', 'Dante Alighieri', 'Poesia', 1320, 25.00),
(58, '1984', 'George Orwell', 'Distopico', 1949, 15.00);

insert into Vendite2 (id, id_libro, data_vendita, quantita, negozio) values
(1, 56, '2025-02-01', 2, 'Libreria Centrale'),
(2, 57, '2025-02-03', 1, 'BookCity Milano'),
(3, 58, '2025-02-05', 3, 'Cartoleria Roma'),
(4, 1, '2025-02-07', 1, 'Negozio Non Incluso');

select l.titolo, v.negozio, v.quantita, v.quantita * l.prezzo as prezzo_totale
from Vendite2 v
inner join Libri l on v.id_libro = l.id
where v.negozio in('Libreria Centrale', 'BookCity Milano', 'Cartoleria Roma');

select l.titolo, v.data_vendita, l.prezzo, v.quantita
from Libri l
right join Vendite2 v on l.id = v.id_libro
where v.data_vendita between '2020-01-01' and '2022-12-31'
and v.negozio like lower('%Book%');

select l.titolo, l.autore, l.prezzo, v.data_vendita
from Libri l
inner join Vendite2 v on v.id_libro = l.id
where lower(l.genere) in('Fantasy', 'Horror', 'Giallo')
and l.anno_pubblicazione > '2015%'
order by l.anno_pubblicazione desc;