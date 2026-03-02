/*QUERY 1
Mostrare il numero di appuntamenti per ogni medico, ordinati dal più impegnato.*/
select m.id_medico as ID, m.nome as Nome, m.cognome as Cognome, count(a.id_appuntamento) as NumeroAppuntamenti
from medico m
inner join appuntamento a on a.id_medico = m.id_medico
group by m.id_medico, m.nome, m.cognome
order by NumeroAppuntamenti desc;

/*QUERY 2
Mostrare i pazienti che hanno effettuato più di 3 appuntamenti.*/
select p.id_paziente as ID, p.nome as Nome, p.cognome as Cognome, count(a.id_appuntamento) as NumeroAppuntamenti
from paziente p
join appuntamento a on a.id_paziente = p.id_paziente
where a.stato = 'Completato'
group by p.id_paziente, p.nome, p.cognome
having count(a.id_appuntamento) > 3;

/*QUERY 3
Calcolare l’incasso totale per ogni medico.*/
select m.id_medico as ID, m.nome as Nome, m.cognome as Cognome, sum(pag.importo) as Incasso
from medico m
left join appuntamento a on a.id_medico = m.id_medico
inner join pagamento pag on pag.id_appuntamento = a.id_appuntamento
group by m.id_medico, m.nome, m.cognome
order by Incasso desc;

#QUERY 4
#Mostrare il medico con lo stipendio più alto per ogni specializzazione.
#(richiede subquery o window function)
select s.nome, m.nome, m.cognome, m.stipendio 
from specializzazione s 
inner join medico m on m.id_specializzazione = s.id_specializzazione 
where m.stipendio = 
	(
		select MAX(m1.stipendio) 
		from medico m1 
		where m1.id_specializzazione = m.id_specializzazione
	)
order by m.stipendio desc;

#QUERY 5
#Mostrare il paziente che ha speso di più in totale.
#(somma pagamenti + subquery)
select paz.nome, paz.cognome, paz.codice_fiscale, SUM(a.costo) as Spesa
from paziente paz
inner join appuntamento a on paz.id_paziente = a.id_paziente
where a.stato = "Completato"
group by paz.nome, paz.cognome, paz.codice_fiscale
order by Spesa desc limit 1;

#QUERY 6
#Mostrare per ogni reparto il tasso di occupazione attuale.
#(tot ricoverati attuali / numero_posti)
select rep.nome, (COUNT(ric.id_reparto)/rep.numero_posti) as Tasso_occupazione
from reparto rep
left join ricovero ric on ric.id_reparto = rep.id_reparto
where ric.data_dimissione is null
group by rep.id_reparto
order by Tasso_occupazione desc;

#QUERY 7 Mostrare i medici che non hanno avuto appuntamenti negli ultimi 30 giorni. (subquery con NOT EXISTS)
select m.nome, m.cognome
from medico m 
where not exists 
(
	select a.id_appuntamento
	from appuntamento a
	where a.id_medico = m.id_medico and data_appuntamento >= '2026-01-25'
);

#QUERY 8 Mostrare la specializzazione che ha generato più incasso totale. (JOIN + GROUP BY + subquery )
select s.nome, sum(a.costo) as incasso_tot
from specializzazione s
join medico m on s.id_specializzazione = m.id_specializzazione
join appuntamento a on m.id_medico = a.id_medico
group by s.nome
order by incasso_tot desc
limit 1;

#QUERY 9 Mostrare per ogni mese l’incasso totale e la variazione percentuale rispetto al mese precedente.
select anno, mese, incasso_tot,
lag(incasso_tot) over (order by anno, mese) as costo_mese_prec,
incasso_tot - lag(incasso_tot) over (order by anno, mese) as variazione
from (
select year(p.data_pagamento) as anno, month(p.data_pagamento) as mese, sum(p.importo) as incasso_tot
from pagamento p 
group by year(p.data_pagamento), month(p.data_pagamento)
) as t
order by anno, mese;

#QUERY 10
select 
    p.id_paziente,
    p.nome,
    p.cognome,
    count(distinct a.id_appuntamento) as num_appuntamenti, 
    count(distinct Ricovero.id_ricovero) as num_ricoveri,
    sum(a.costo) as spesa_totale
from 
    Paziente p 
join Ricovero 
    on Ricovero.id_paziente = p.id_paziente 
join Appuntamento a
    on p.id_paziente = a.id_paziente
group by 
    p.cognome, p.id_paziente
having
    count(distinct Ricovero.id_ricovero) > 1
and
    count(distinct a.id_appuntamento) > 4
and
    sum(a.costo) > (select 
    avg(a.costo) as spesa_media
from Appuntamento a
order by spesa_media desc);