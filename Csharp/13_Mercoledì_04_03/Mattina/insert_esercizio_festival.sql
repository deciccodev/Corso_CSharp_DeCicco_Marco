-- Artisti
INSERT INTO Artisti (nome, tipo) VALUES
('Coldplay', 'band'),
('Ed Sheeran', 'singolo'),
('Dua Lipa', 'singolo'),
('Imagine Dragons', 'band'),
('Adele', 'singolo');

-- Palchi
INSERT INTO Palchi (nome, capienza) VALUES
('Main Stage', 50000),
('Second Stage', 20000),
('Acoustic Stage', 5000);

-- Sponsor
INSERT INTO Sponsor (nome) VALUES
('Coca-Cola'), ('Red Bull'), ('Spotify'), ('Nike');

-- Performance_live
INSERT INTO Performance_live (id_artista, id_palco, data_performance) VALUES
(1, 1, '2026-06-01 20:00:00'),
(2, 2, '2026-06-01 18:00:00'),
(3, 3, '2026-06-01 19:00:00'),
(1, 1, '2026-06-02 20:00:00'),
(4, 2, '2026-06-02 21:00:00'),
(5, 3, '2026-06-02 19:00:00');

-- Collaborazioni
INSERT INTO Collaborazioni (id_performance, id_artista) VALUES
(1, 1), (1, 2),
(2, 2), (2, 3),
(3, 3),
(4, 1), (4, 5),
(5, 4),
(6, 5);

-- Biglietti
INSERT INTO Biglietti (id_performance, prezzo, tipo) VALUES
(1, 100, 'base'), (1, 200, 'vip'),
(2, 80, 'base'),  (2, 150, 'vip'),
(3, 50, 'base'),  (3, 120, 'vip'),
(4, 110, 'base'), (4, 220, 'vip'),
(5, 90, 'base'),  (5, 180, 'vip'),
(6, 95, 'base'),  (6, 190, 'vip');

-- Spettatori
INSERT INTO Spettatori (nome) VALUES
('Alice'), ('Bob'), ('Charlie'), ('David'), ('Eva'), ('Frank');

-- Pagamenti
INSERT INTO Pagamenti (id_spettatore, id_biglietto, importo, data_pagamento) VALUES
(1, 1, 100, '2026-05-01 10:00:00'),
(2, 2, 200, '2026-05-01 11:00:00'),
(3, 3, 80, '2026-05-02 12:00:00'),
(4, 4, 150, '2026-05-02 13:00:00'),
(5, 5, 50, '2026-05-03 14:00:00'),
(6, 6, 120, '2026-05-03 15:00:00'),
(1, 7, 110, '2026-05-04 10:00:00'),
(2, 8, 220, '2026-05-04 11:00:00'),
(3, 9, 90, '2026-05-05 12:00:00'),
(4,10, 180, '2026-05-05 13:00:00'),
(5,11, 95, '2026-05-06 14:00:00'),
(6,12, 190, '2026-05-06 15:00:00');

-- Sponsor_artisti
INSERT INTO Sponsor_artisti (id_sponsor, id_artista) VALUES
(1, 1), (2, 3), (3, 2), (4, 5);

-- Sponsor_performance
INSERT INTO Sponsor_performance (id_sponsor, id_performance) VALUES
(1, 1), (2, 2), (3, 3), (1, 4), (4, 6);

-- Staff_tecnico
INSERT INTO Staff_tecnico (nome, ruolo, id_palco) VALUES
('Marco', 'Sound Engineer', 1),
('Luca', 'Lighting', 1),
('Sara', 'Stage Manager', 2),
('Anna', 'Sound Engineer', 3),
('Giovanni', 'Lighting', 2);

-- Staff_performance
INSERT INTO Staff_performance (id_staff, id_performance) VALUES
(1, 1), (2, 1),
(3, 2),
(4, 3),
(1, 4), (2, 4),
(3, 5),
(4, 6);