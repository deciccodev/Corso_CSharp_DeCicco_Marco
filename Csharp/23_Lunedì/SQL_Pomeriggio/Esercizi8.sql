SELECT c.nome, COUNT(*) AS totale_ordini_effettuati, SUM(importo) AS somma_totale
FROM clienti2 c
INNER JOIN Ordini o ON c.id = o.id_cliente
GROUP BY c.id, c.nome;

SELECT DISTINCT c.nome, c.città
FROM clienti2 c
LEFT JOIN Ordini o ON c.id = o.id_cliente
WHERE o.data_ordine IS NULL;

SELECT o.id AS id_ordine, o.data_ordine, o.importo, NULL AS cliente
FROM Clienti2 c
RIGHT JOIN Ordini o ON c.id = o.id_cliente
WHERE c.id IS NULL;