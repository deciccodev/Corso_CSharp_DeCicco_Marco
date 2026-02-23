create table Ordini (
    id INT,
    id_cliente INT,
    data_ordine DATE,
    importo DECIMAL(7,2)
);

create table Clienti2 (
    id INT,
    nome VARCHAR(100),
    città VARCHAR(100)
);

INSERT INTO Clienti2 (id, nome, città) VALUES
(1, 'Mario Rossi', 'Roma'),
(2, 'Luca Bianchi', 'Milano'),
(3, 'Giulia Verdi', 'Napoli'),
(4, 'Anna Neri', 'Torino'),
(5, 'Marco Gialli', 'Firenze'),
(6, 'Sara Blu', 'Bologna'),
(7, 'Paolo Rosa', 'Genova'),
(8, 'Elena Viola', 'Venezia'),
(9, 'Francesco Marrone', 'Palermo'),
(10, 'Chiara Greco', 'Bari'),
(11, 'Davide Fontana', 'Verona'),
(12, 'Alessia Serra', 'Cagliari'),
(13, 'Stefano Riva', 'Trieste'),
(14, 'Valentina Costa', 'Parma'),
(15, 'Simone De Luca', 'Modena'),
(16, 'Federica Longo', 'Perugia'),
(17, 'Antonio Lombardi', 'Salerno'),
(18, 'Martina Ferri', 'Rimini'),
(19, 'Giorgio Conti', 'Pisa'),
(20, 'Laura Ricci', 'Siena');


INSERT INTO Ordini (id, id_cliente, data_ordine, importo) VALUES
(1, 1, '2025-01-10', 120.50),
(2, 2, '2025-01-12', 89.99),
(3, 3, '2025-01-15', 250.00),
(4, 4, '2025-01-18', 45.30),
(5, 5, '2025-01-20', 310.75),
(6, 6, '2025-01-22', 78.90),
(7, 7, '2025-01-25', 150.00),
(8, 8, '2025-01-28', 99.50),
(9, 9, '2025-02-02', 500.00),
(10, 10, '2025-02-05', 65.00),
(11, 1, '2025-02-10', 220.40),
(12, 3, '2025-02-12', 340.00),
(13, 5, '2025-02-15', 180.60),
(14, 7, '2025-02-18', 75.99),
(15, 9, '2025-02-20', 410.25),
(16, 11, '2025-02-22', 59.99),
(17, 13, '2025-02-25', 420.80),
(18, 15, '2025-02-27', 33.33),
(19, 17, '2025-03-01', 275.80),
(20, 20, '2025-03-03', 149.99);