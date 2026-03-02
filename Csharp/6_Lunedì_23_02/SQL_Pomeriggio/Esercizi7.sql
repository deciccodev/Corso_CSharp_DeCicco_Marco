SELECT c.nome, o.data_ordine, o.importo
FROM Clienti2 c
INNER JOIN Ordini o ON c.id = o.id_cliente;

SELECT c.nome, o.data_ordine, o.importo
FROM Clienti2 c
LEFT JOIN Ordini o ON c.id = o.id_cliente
ORDER BY c.nome;

SELECT c.nome, o.data_ordine, o.importo
FROM Clienti2 c
RIGHT JOIN Ordini o ON c.id = o.id_cliente
ORDER BY o.data_ordine;
