CREATE TABLE Artisti (
    id_artista INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    tipo ENUM('singolo', 'band') NOT NULL
);

CREATE TABLE Palchi (
    id_palco INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL UNIQUE,
    capienza INT NOT NULL CHECK (capienza > 0)
);

CREATE TABLE Performance_live (
    id_performance INT PRIMARY KEY AUTO_INCREMENT,
    id_artista INT NOT NULL,
    id_palco INT NOT NULL,
    data_performance DATETIME NOT NULL,
    FOREIGN KEY (id_artista) REFERENCES Artisti(id_artista),
    FOREIGN KEY (id_palco) REFERENCES Palchi(id_palco),
    UNIQUE (id_palco, data_performance)
);

CREATE TABLE Biglietti (
    id_biglietto INT PRIMARY KEY AUTO_INCREMENT,
    id_performance INT NOT NULL,
    prezzo DECIMAL(10,2) NOT NULL CHECK (prezzo > 0),
    tipo ENUM('base', 'vip') NOT NULL,
    FOREIGN KEY (id_performance) REFERENCES Performance_live(id_performance)
);

CREATE TABLE Spettatori (
    id_spettatore INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL
);

CREATE TABLE Sponsor (
    id_sponsor INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE Sponsor_artisti (
    id_sponsor INT NOT NULL,
    id_artista INT NOT NULL,
    PRIMARY KEY (id_sponsor, id_artista),
    FOREIGN KEY (id_sponsor) REFERENCES Sponsor(id_sponsor),
    FOREIGN KEY (id_artista) REFERENCES Artisti(id_artista)
);

CREATE TABLE Sponsor_performance (
    id_sponsor INT NOT NULL,
    id_performance INT NOT NULL,
    PRIMARY KEY (id_sponsor, id_performance),
    FOREIGN KEY (id_sponsor) REFERENCES Sponsor(id_sponsor),
    FOREIGN KEY (id_performance) REFERENCES Performance_live(id_performance)
);

CREATE TABLE Collaborazioni (
    id_performance INT NOT NULL,
    id_artista INT NOT NULL,
    PRIMARY KEY (id_performance, id_artista),
    FOREIGN KEY (id_performance) REFERENCES Performance_live(id_performance),
    FOREIGN KEY (id_artista) REFERENCES Artisti(id_artista)
);

CREATE TABLE Pagamenti (
    id_pagamento INT PRIMARY KEY AUTO_INCREMENT,
    id_spettatore INT NOT NULL,
    id_biglietto INT NOT NULL UNIQUE,
    importo DECIMAL(10,2) NOT NULL CHECK (importo > 0),
    data_pagamento DATETIME NOT NULL,
    FOREIGN KEY (id_spettatore) REFERENCES Spettatori(id_spettatore),
    FOREIGN KEY (id_biglietto) REFERENCES Biglietti(id_biglietto)
);

CREATE TABLE Staff_tecnico (
    id_staff INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    ruolo VARCHAR(100) NOT NULL,
    id_palco INT NOT NULL,
    FOREIGN KEY (id_palco) REFERENCES Palchi(id_palco)
);

CREATE TABLE Staff_performance (
    id_staff INT NOT NULL,
    id_performance INT NOT NULL,
    PRIMARY KEY (id_staff, id_performance),
    FOREIGN KEY (id_staff) REFERENCES Staff_tecnico(id_staff),
    FOREIGN KEY (id_performance) REFERENCES Performance_live(id_performance)
);