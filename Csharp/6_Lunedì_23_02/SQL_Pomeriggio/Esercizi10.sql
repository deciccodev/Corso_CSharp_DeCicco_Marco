SELECT l.titolo, l.autore, v.data_vendita, v.negozio
FROM Libri l
INNER JOIN Vendite2 v ON l.id = v.id_libro
WHERE LOWER(l.autore) LIKE '%king%';

SELECT l.titolo, l.anno_pubblicazione, l.prezzo, v.data_vendita
FROM Libri l
LEFT JOIN Vendite2 v ON l.id = v.id_libro
WHERE l.anno_pubblicazione BETWEEN 2000 AND 2010;
