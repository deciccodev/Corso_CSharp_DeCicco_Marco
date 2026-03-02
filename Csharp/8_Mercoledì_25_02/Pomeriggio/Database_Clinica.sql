create database clinica;
use clinica;
create table Ricovero(
    id_ricovero int auto_increment primary key,
    id_paziente int not null references Paziente(id_paziente),
    id_reparto int not null references Reparto(id_reparto),
    data_ingresso datetime not null,
    data_dimissione datetime null
);

create table Pagamento (
    id_pagamento int auto_increment primary key,
    id_appuntamento int not null references Appuntamento(id_appuntamento),
    importo decimal(10,2) not null check (importo >= 0),
    metodo_pagamento varchar(50) not null,
    data_pagamento datetime not null
);
	
create table Specializzazione(
 id_specializzazione int AUTO_INCREMENT,
 nome varchar (100) UNIQUE NOT NULL,
 PRIMARY KEY (id_specializzazione)
 );

create table Appuntamento(
 id_appuntamento int AUTO_INCREMENT,
 id_paziente int NOT NULL,
 id_medico int NOT NULL,
 data_appuntamento date NOT NULL,
 stato ENUM("Prenotato", "Completato", "Annullato") NOT NULL,
 costo decimal(6,2),
 PRIMARY KEY (id_appuntamento),
 FOREIGN KEY (id_paziente) References Paziente(id_paziente),
 FOREIGN KEY (id_medico) References Medico(id_medico)
 );
 
create table Paziente(
id_paziente int primary key auto_increment,
nome varchar(50) not null,
cognome varchar(50) not null,
data_nascita date not null,
codice_fiscale varchar(16) not null unique,
telefono varchar(10),
email varchar(50),
data_registrazione date
);

create table Medico (
id_medico int primary key auto_increment,
nome varchar(50) not null,
cognome varchar(50) not null,
id_specializzazione int not null references Specializzazione(id_specializzazione), 
stipendio decimal(10,2) not null,
data_assunzione date
);

create table Prescrizione(
id_prescrizione int auto_increment not null,
id_appuntamento int not null,
descrizione varchar(300),
data_prescrizione date,
primary key (id_prescrizione),
foreign key (id_appuntamento) references Appuntamento(id_appuntamento)
);

create table Reparto(
id_reparto int auto_increment,
nome varchar(50),
numero_posti int,
primary key (id_reparto)
);

-- Specializzazioni
INSERT INTO Specializzazione (nome) VALUES 
('Cardiologia'), ('Neurologia'), ('Ortopedia'), ('Pediatria'), ('Oncologia');

-- Reparti
INSERT INTO Reparto (nome, numero_posti) VALUES 
('Terapia Intensiva', 10), ('Chirurgia d''Urgenza', 20), ('Medicina Generale', 30), ('Pediatria Settore A', 15);

-- Medici (10 medici)
INSERT INTO Medico (nome, cognome, id_specializzazione, stipendio, data_assunzione) VALUES 
('Mario', 'Rossi', 1, 4500.00, '2020-01-15'), ('Elena', 'Bianchi', 1, 4800.00, '2019-05-20'),
('Luca', 'Verdi', 2, 5000.00, '2018-03-10'), ('Giulia', 'Neri', 2, 4200.00, '2021-11-01'),
('Marco', 'Gialli', 3, 3900.00, '2022-02-15'), ('Sofia', 'Viola', 3, 5200.00, '2015-06-30'),
('Paolo', 'Bruni', 4, 3500.00, '2023-01-10'), ('Chiara', 'Rosa', 4, 3600.00, '2023-04-12'),
('Alessandro', 'Fabbri', 5, 6000.00, '2010-09-05'), ('Francesca', 'Costa', 5, 5800.00, '2012-08-20');

-- Pazienti (20 pazienti)
INSERT INTO Paziente (nome, cognome, data_nascita, codice_fiscale, telefono, email, data_registrazione) VALUES 
('Antonio', 'Esposito', '1980-05-12', 'SPSNTN80E12H501A', '3331112223', 'antonio@email.com', '2024-01-10'),
('Maria', 'Romano', '1992-08-24', 'RMNMRA92M64F205Z', '3332223334', 'maria@email.com', '2024-01-15'),
('Giuseppe', 'Ricci', '1975-03-30', 'RCCGPP75C30L219B', '3334445556', 'giuseppe@email.com', '2024-02-01'),
('Anna', 'Marino', '1988-11-05', 'MRNANN88S45F839O', '3336667778', 'anna@email.com', '2024-02-10'),
('Giovanni', 'Greco', '1960-12-20', 'GRCGNN60T20H501U', '3338889990', 'giovanni@email.com', '2024-02-15'),
('Roberto', 'Ferri', '1985-06-15', 'FRRRBT85H15F205T', '3330001112', 'roberto@email.com', '2024-02-20'),
('Laura', 'Molinari', '1995-09-10', 'MLNLRA95P50L219C', '3331114445', 'laura@email.com', '2024-02-25'),
('Stefano', 'Gallo', '1972-01-30', 'GLLSTF72A30H501M', '3332225556', 'stefano@email.com', '2024-03-01'),
('Paola', 'Conti', '1983-04-18', 'CNTPLA83D58F205R', '3333336667', 'paola@email.com', '2024-03-05'),
('Vincenzo', 'De Luca', '1965-07-25', 'DLCVNC65L25L219Q', '3334447778', 'vincenzo@email.com', '2024-03-10'),
('Sonia', 'Russo', '1990-10-12', 'RSSSNA90R52H501G', '3335558889', 'sonia@email.com', '2024-03-15'),
('Davide', 'Ferrara', '1978-02-28', 'FRRDVD78B28F205K', '3336669990', 'davide@email.com', '2024-03-20'),
('Elena', 'Giordano', '1987-11-15', 'GRDLNE87S55L219X', '3337770001', 'elena@email.com', '2024-03-25'),
('Giorgio', 'Manfredi', '1955-03-05', 'MNFGRG55C05H501L', '3338881112', 'giorgio@email.com', '2024-04-01'),
('Valentina', 'Serra', '1998-12-30', 'SRRVNT98T70F205W', '3339992223', 'valentina@email.com', '2024-04-05'),
('Fabio', 'D''Angelo', '1982-05-20', 'DNGFBA82E20L219E', '3330003334', 'fabio@email.com', '2024-04-10'),
('Monica', 'Lombardi', '1974-09-14', 'LMBMNC74P54H501Y', '3331115556', 'monica@email.com', '2024-04-15'),
('Pietro', 'Barbieri', '1968-08-22', 'BRBPTR68M22F205J', '3332226667', 'pietro@email.com', '2024-04-20'),
('Alessia', 'Pellegrini', '1993-01-10', 'PLLLSS93A50L219I', '3333337778', 'alessia@email.com', '2024-04-25'),
('Claudio', 'Mariani', '1970-11-02', 'MRNCLD70S02H501K', '3334448889', 'claudio@email.com', '2024-05-01');

-- Appuntamenti (30 appuntamenti)
INSERT INTO Appuntamento (id_paziente, id_medico, data_appuntamento, stato, costo) VALUES 
(1, 1, '2026-02-01', 'Completato', 150.00), (1, 2, '2026-02-05', 'Completato', 200.00),
(1, 1, '2026-02-10', 'Completato', 150.00), (1, 3, '2026-02-15', 'Completato', 250.00),
(1, 1, '2026-02-20', 'Prenotato', 150.00),
(2, 1, '2026-01-10', 'Completato', 150.00), (2, 1, '2026-01-20', 'Completato', 150.00),
(2, 1, '2026-02-01', 'Completato', 150.00), (2, 5, '2026-02-10', 'Completato', 300.00),
(3, 3, '2026-02-12', 'Completato', 250.00), (4, 4, '2026-02-13', 'Annullato', 100.00),
(5, 5, '2026-02-14', 'Completato', 300.00), (6, 6, '2026-02-15', 'Completato', 180.00),
(7, 7, '2026-02-16', 'Completato', 120.00), (8, 8, '2026-02-17', 'Completato', 120.00),
(9, 9, '2026-02-18', 'Completato', 350.00), (10, 10, '2026-02-19', 'Completato', 400.00),
(11, 1, '2026-02-20', 'Prenotato', 150.00), (12, 2, '2026-02-21', 'Completato', 200.00),
(13, 3, '2026-02-22', 'Completato', 250.00), (14, 4, '2026-02-23', 'Completato', 100.00),
(15, 5, '2026-02-24', 'Completato', 300.00), (16, 6, '2026-01-05', 'Completato', 180.00),
(17, 7, '2026-01-06', 'Completato', 120.00), (18, 8, '2026-01-07', 'Completato', 120.00),
(19, 9, '2026-01-08', 'Completato', 350.00), (20, 10, '2026-01-09', 'Completato', 400.00),
(3, 1, '2026-01-10', 'Completato', 150.00), (5, 1, '2026-01-11', 'Completato', 150.00),
(1, 4, '2026-01-12', 'Completato', 100.00);

-- Ricoveri (10 ricoveri)
INSERT INTO Ricovero (id_paziente, id_reparto, data_ingresso, data_dimissione) VALUES 
(1, 1, '2026-01-15 10:00:00', '2026-01-20 09:00:00'),
(1, 1, '2026-02-22 14:00:00', NULL),
(2, 2, '2026-02-01 08:30:00', '2026-02-05 16:00:00'),
(3, 3, '2026-02-10 11:00:00', NULL),
(4, 4, '2026-02-15 09:00:00', NULL),
(5, 1, '2026-02-18 10:00:00', '2026-02-20 18:00:00'),
(6, 2, '2026-02-20 15:00:00', NULL),
(7, 3, '2026-02-21 12:00:00', NULL),
(8, 4, '2026-02-22 08:00:00', NULL),
(20, 1, '2026-02-23 20:00:00', NULL);

-- Pagamenti (20 pagamenti)
INSERT INTO Pagamento (id_appuntamento, importo, metodo_pagamento, data_pagamento) VALUES 
(1, 150.00, 'Carta', '2026-02-01 10:30:00'), (2, 200.00, 'Contanti', '2026-02-05 12:00:00'),
(3, 150.00, 'Carta', '2026-02-10 11:00:00'), (4, 250.00, 'Bonifico', '2026-02-15 15:00:00'),
(6, 150.00, 'Carta', '2026-01-10 10:00:00'), (7, 150.00, 'Carta', '2026-01-20 10:00:00'),
(8, 150.00, 'Contanti', '2026-02-01 10:00:00'), (9, 300.00, 'Carta', '2026-02-10 12:00:00'),
(10, 250.00, 'Carta', '2026-02-12 11:30:00'), (12, 300.00, 'Bonifico', '2026-02-14 16:00:00'),
(13, 180.00, 'Contanti', '2026-02-15 17:00:00'), (14, 120.00, 'Carta', '2026-02-16 10:00:00'),
(15, 120.00, 'Carta', '2026-02-17 11:00:00'), (16, 350.00, 'Carta', '2026-02-18 10:00:00'),
(17, 400.00, 'Bonifico', '2026-02-19 14:00:00'), (19, 200.00, 'Carta', '2026-02-21 12:00:00'),
(28, 150.00, 'Carta', '2026-01-10 11:00:00'), (29, 150.00, 'Carta', '2026-01-11 11:00:00'),
(30, 100.00, 'Contanti', '2026-01-12 12:00:00'), (20, 250.00, 'Carta', '2026-02-22 10:00:00');

INSERT INTO Pagamento (id_appuntamento, importo, metodo_pagamento, data_pagamento) VALUES 
(5, 850.00, 'Carta', '2025-02-13 10:00:00');

INSERT INTO Prescrizione (id_appuntamento, descrizione, data_prescrizione) VALUES 
(1, 'Cardioaspirina 100mg una volta al giorno', '2024-01-10'),
(2, 'Crema idratante per dermatite', '2024-01-11'),
(4, 'Riposo assoluto per 5 giorni', '2024-01-13'),
(6, 'Ecografia di controllo tra 6 mesi', '2024-01-15'),
(9, 'Ciclo di chemioterapia preventiva', '2024-01-18'),
(7, 'Analisi del sangue complete e controllo colesterolo', '2024-01-16'),
(8, 'Collirio antinfiammatorio 3 volte al giorno per una settimana', '2024-01-17'),
(10, 'Integrazione di vitamina D e calcio per 3 mesi', '2024-01-19'),
(11, 'Holter cardiaco delle 24 ore da programmare', '2024-02-01'),
(14, 'Risonanza magnetica nucleare colonna lombo-sacrale', '2024-02-04'),
(15, 'Fisioterapia riabilitativa 2 sedute a settimana', '2024-02-05'),
(18, 'Ibuprofene 400mg al bisogno per dolori articolari', '2024-02-08'),
(19, 'Tac torace di controllo post-operatorio', '2024-02-09'),
(21, 'Dieta iposodica e monitoraggio pressione arteriosa', '2024-02-11'),
(23, 'Sciroppo per la tosse e riposo per 3 giorni', '2024-02-13');