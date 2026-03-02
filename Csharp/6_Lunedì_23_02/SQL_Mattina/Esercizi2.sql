create database Esercizi;

USE Esercizi;

create table Vendite (
    id INT,
    prodotto VARCHAR(100),
    categoria VARCHAR(50),
    quantita INT,
    prezzo_unitario DECIMAL(6,2),
    data_vendita DATE
);

insert into Vendite
values(0, 'prodotto1', 'categoria1', 5, 10.34, '2026-01-01'),
(1, 'prodotto2', 'categoria1', 2, 1.34, '2026-01-04'),
(2, 'prodotto3', 'categoria1', 3, 5.44, '2026-01-03'),
(3, 'prodotto4', 'categoria1', 53, 4.00, '2026-01-02'),
(4, 'prodotto5', 'categoria2', 20, 10.23, '2026-01-23'),
(5, 'prodotto6', 'categoria1', 32, 7.34, '2026-12-01'),
(6, 'prodotto7', 'categoria1', 6, 15.34, '2025-01-01'),
(7, 'prodotto8', 'categoria2', 12, 8.34, '2024-01-01'),
(8, 'prodotto9', 'categoria1', 32, 30.34, '2023-01-01'),
(9, 'prodotto10', 'categoria1', 44, 50.34, '2022-01-01'),
(10, 'prodotto11', 'categoria1', 14, 34.34, '2021-01-01'),
(11, 'prodotto12', 'categoria2', 9, 43.34, '2020-01-01'),
(12, 'prodotto13', 'categoria3', 8, 2.34, '2026-01-02'),
(13, 'prodotto14', 'categoria1', 17, 3.34, '2026-01-03'),
(14, 'prodotto15', 'categoria3', 22, 6.34, '2026-01-04'),
(15, 'prodotto16', 'categoria1', 33, 43.34, '2026-01-05'),
(16, 'prodotto17', 'categoria1', 21, 12.34, '2026-01-06'),
(17, 'prodotto18', 'categoria4', 10, 22.34, '2026-01-07'),
(18, 'prodotto19', 'categoria4', 3, 1.50, '2026-01-08'),
(19, 'prodotto20', 'categoria4', 5, 10.34, '2026-01-09');
