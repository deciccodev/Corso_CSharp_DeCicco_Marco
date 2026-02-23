SELECT nome, cognome, email FROM clienti
WHERE email LIKE '%gmail.com';

SELECT * FROM clienti
WHERE nome LIKE 'a%';

SELECT cognome FROM clienti
WHERE length(cognome) = 5;

SELECT nome, cognome, eta FROM clienti
WHERE eta BETWEEN 30 AND 40;

SELECT * FROM clienti
WHERE citta LIKE '%roma%';