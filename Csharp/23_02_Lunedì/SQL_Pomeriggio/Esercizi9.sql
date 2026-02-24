


create table Libri (
   id INT,
   titolo VARCHAR(100),
   autore VARCHAR(100),
   genere VARCHAR(50),
   anno_pubblicazione INT,
   prezzo DECIMAL(6,2)
);


create table Vendite2 (
   id INT,
   id_libro INT,
   data_vendita DATE,
   quantita INT,
   negozio VARCHAR(100)
);


INSERT INTO Libri VALUES
(1, 'Il codice nascosto', 'Marco Bianchi', 'Thriller', 2018, 18.90),
(2, 'Ombre nel vento', 'Laura Rossi', 'Romanzo', 2020, 15.50),
(3, 'SQL per tutti', 'Giuseppe Verdi', 'Informatica', 2021, 29.99),
(4, 'Storia d''Italia', 'Anna Neri', 'Storico', 2015, 24.00),
(5, 'Il mondo invisibile', 'Paolo Galli', 'Fantasy', 2019, 21.00),
(6, 'La mente brillante', 'Sara Blu', 'Psicologia', 2017, 19.80),
(7, 'Programmare in Python', 'Luca Ferri', 'Informatica', 2022, 34.50),
(8, 'Amore e destino', 'Chiara Rosa', 'Romanzo', 2016, 14.90),
(9, 'Economia moderna', 'Davide Ricci', 'Economia', 2018, 27.30),
(10, 'Viaggio nello spazio', 'Elena Sole', 'Fantascienza', 2021, 22.40),
(11, 'Il castello segreto', 'Marco Bianchi', 'Fantasy', 2014, 17.50),
(12, 'Data Science base', 'Luca Ferri', 'Informatica', 2023, 39.90),
(13, 'Il silenzio del mare', 'Laura Rossi', 'Romanzo', 2019, 16.20),
(14, 'Manuale di diritto', 'Anna Neri', 'Giuridico', 2013, 45.00),
(15, 'La grande guerra', 'Paolo Galli', 'Storico', 2011, 26.80),
(16, 'Psicologia sociale', 'Sara Blu', 'Psicologia', 2020, 23.50),
(17, 'Algoritmi avanzati', 'Giuseppe Verdi', 'Informatica', 2022, 41.00),
(18, 'Cuore ribelle', 'Chiara Rosa', 'Romanzo', 2017, 13.90),
(19, 'Mercati globali', 'Davide Ricci', 'Economia', 2019, 28.00),
(20, 'Oltre le stelle', 'Elena Sole', 'Fantascienza', 2020, 24.10),
(21, 'Il labirinto oscuro', 'Marco Bianchi', 'Thriller', 2022, 20.00),
(22, 'L''arte della guerra', 'Anna Neri', 'Storico', 2012, 30.00),
(23, 'Machine Learning', 'Luca Ferri', 'Informatica', 2023, 42.50),
(24, 'Segreti d''amore', 'Laura Rossi', 'Romanzo', 2015, 12.90),
(25, 'Finanza personale', 'Davide Ricci', 'Economia', 2021, 19.99),
(26, 'Il drago eterno', 'Paolo Galli', 'Fantasy', 2018, 23.40),
(27, 'Introduzione alla filosofia', 'Sara Blu', 'Filosofia', 2016, 18.70),
(28, 'Cybersecurity oggi', 'Giuseppe Verdi', 'Informatica', 2024, 37.90),
(29, 'Viaggio interiore', 'Chiara Rosa', 'Psicologia', 2019, 17.20),
(30, 'Universo parallelo', 'Elena Sole', 'Fantascienza', 2022, 25.00);


INSERT INTO Vendite2 VALUES
(1, 1, '2024-01-10', 3, 'Mondadori Milano'),
(2, 2, '2024-01-12', 2, 'Feltrinelli Roma'),
(3, 3, '2024-01-15', 5, 'Mondadori Milano'),
(4, 5, '2024-01-18', 1, 'Libraccio Torino'),
(5, 7, '2024-01-20', 4, 'Feltrinelli Roma'),
(6, 10, '2024-02-01', 6, 'Mondadori Milano'),
(7, 12, '2024-02-03', 3, 'Amazon Online'),
(8, 15, '2024-02-05', 2, 'Libreria Bologna'),
(9, 18, '2024-02-08', 7, 'Amazon Online'),
(10, 20, '2024-02-10', 5, 'Mondadori Milano'),
(11, 21, '2024-02-12', 4, 'Feltrinelli Roma'),
(12, 23, '2024-02-15', 6, 'Amazon Online'),
(13, 25, '2024-02-18', 3, 'Libraccio Torino'),
(14, 26, '2024-02-20', 2, 'Libreria Bologna'),
(15, 28, '2024-02-22', 5, 'Mondadori Milano'),
(16, 30, '2024-03-01', 4, 'Amazon Online'),
(17, 3, '2024-03-03', 2, 'Feltrinelli Roma'),
(18, 7, '2024-03-05', 3, 'Mondadori Milano'),
(19, 1, '2024-03-08', 1, 'Libreria Bologna'),
(20, 5, '2024-03-10', 4, 'Amazon Online'),
(21, 8, '2024-03-12', 6, 'Feltrinelli Roma'),
(22, 9, '2024-03-15', 2, 'Mondadori Milano'),
(23, 11, '2024-03-18', 3, 'Libraccio Torino'),
(24, 13, '2024-03-20', 4, 'Amazon Online'),
(25, 17, '2024-03-22', 5, 'Libreria Bologna'),
(26, 19, '2024-03-25', 3, 'Mondadori Milano'),
(27, 22, '2024-03-28', 2, 'Feltrinelli Roma'),
(28, 24, '2024-04-01', 4, 'Amazon Online'),
(29, 27, '2024-04-03', 1, 'Libraccio Torino'),
(30, 29, '2024-04-05', 2, 'Mondadori Milano');

INSERT INTO Vendite2 VALUES
(31, 31, '2024-04-07', 3, 'Amazon Online'),
(32, 32, '2024-04-10', 2, 'Mondadori Milano'),
(33, 40, '2024-04-12', 5, 'Feltrinelli Roma'),
(34, 99, '2024-04-15', 1, 'Libreria Bologna');

INSERT INTO Libri VALUES
(80, 'Il libro', 'Brand Kingsley', 'Fantasy', 2010, 10.90);