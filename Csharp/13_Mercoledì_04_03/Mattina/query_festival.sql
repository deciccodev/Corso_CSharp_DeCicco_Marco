#Mostrare il numero di performance per artista. - MARCO
select a.nome as Nome, count(pl.id_performance) as Numero_Performance
from Artisti a
join Performance_live pl on a.id_artista = pl.id_artista
group by a.nome;

#Mostrare il totale incasso per giorno del festival. - BRI
select date(pl.data_performance) as giornoFestival, sum(b.prezzo) as incassoTotale
from performance_live pl
join biglietti b on pl.id_performance = b.id_performance
group by date(pl.data_performance);

#Mostrare gli artisti che si sono esibiti su più di un palco. - GIUSEPPE
select a.nome, a.id_artista, a.tipo, count(distinct pl.id_palco) as numero_palco
from Artisti a
join Performance_live pl on a.id_artista = pl.id_artista
group by a.nome, a.tipo, a.id_artista
having count(distinct pl.id_palco)>1
order by numero_palco desc;

#Mostrare il palco con il maggior numero di spettatori totali. - MARCO
select p.nome as Palco, count(b.id_biglietto) as Spettatori_Totali
from Palchi p
join Performance_live pl on p.id_palco = pl.id_palco
join biglietti b on pl.id_performance=b.id_performance
group by p.id_palco, p.nome
order by spettatori_totali desc
limit 1;

#Mostrare l’artista che ha generato il maggior incasso in biglietti.(richiede join + aggregazioni) - BRI
select a.nome, sum(b.prezzo) as incasso 
from artisti a
join collaborazioni c on a.id_artista = c.id_artista
join biglietti b on c.id_performance = b.id_performance
group by a.nome 
order by incasso desc
limit 1;

#Mostrare le coppie di artisti che hanno collaborato almeno 2 volte.(richiede relazione N–M + grouping) - GIUSEPPE
select a1.nome as artista_1, a2.nome as artista_2, COUNT(*) as numero_collaborazioni
from Collaborazioni c1
join Collaborazioni c2 on c1.id_performance = c2.id_performance and c1.id_artista < c2.id_artista
join Artisti a1 on c1.id_artista = a1.id_artista
join Artisti a2 on c2.id_artista = a2.id_artista
group by a1.id_artista, a1.nome, a2.id_artista, a2.nome
having count(*) >= 2
order by numero_collaborazioni desc;

#Mostrare gli sponsor che hanno sponsorizzato performance in almeno 3 giorni diversi. - BRI
select s.nome from sponsor s 
join sponsor_performance sp on s.id_sponsor = sp.id_sponsor
join performance_live pl on sp.id_performance = pl.id_performance
group by s.nome
having count(distinct date(pl.data_performance)) >= 3;

#Mostrare per ogni giorno il palco con l’incasso più alto.(subquery o window function) - BRI
with incassi_palco as(
select date(pl.data_performance) as giornoFestival, p.nome as nome_palco, sum(b.prezzo) as incasso
from performance_live pl 
join palchi p on pl.id_palco=p.id_palco
join biglietti b on pl.id_performance = b.id_performance
group by date(pl.data_performance), p.nome
)
select ip.giornoFestival, ip.nome_palco, ip.incasso
from incassi_palco ip
where ip.incasso = (
select max(incasso) 
from incassi_palco 
where giornoFestival = ip.giornoFestival
)
order by ip.giornoFestival;

#Mostrare la variazione percentuale di incasso giorno per giorno - MARCO
with incassi as
(select date(data_pagamento) as Giorno, sum(importo) as Incasso_Giornaliero
from Pagamenti
group by date(data_pagamento) 
),
incassi_con_precedente as (
select Giorno, Incasso_Giornaliero, lag(Incasso_Giornaliero, 1, 0) over (order by Giorno) as Incasso_Giorno_precedente
from incassi
)
select Giorno, Incasso_Giornaliero, Incasso_Giorno_precedente, ((Incasso_Giornaliero - Incasso_Giorno_precedente) / Incasso_Giorno_precedente) * 100 as Variazione_Percentuale
from incassi_con_precedente;

#Mostrare tipi di staff presenti in ogni performance
select pl.id_performance, st.ruolo as tipo
from performance_live pl
join staff_performance sp on pl.id_performance = sp.id_performance
join staff_tecnico st on sp.id_staff = st.id_staff
group by pl.id_performance, st.ruolo