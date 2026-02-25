select co.Name as Nazione, cl.Language as Lingua, cl.Percentage as Percentuale
from Country co
inner join CountryLanguage cl on co.Code = cl.CountryCode
order by co.Name, cl.Percentage desc;

select co.Name as Nazione, cl.Percentage as Percentuale
from Country co
inner join CountryLanguage cl on co.Code = cl.CountryCode
where cl.Percentage = 
	(
		select max(subCl.Percentage)
		from CountryLanguage subCl
		where subCl.CountryCode = cl.CountryCode
	)
order by cl.Percentage desc;

select co.Name as Nazione, cl.Language as Lingua, cl.Percentage as Percentuale
from CountryLanguage cl
inner join 
    (
        select CountryCode, max(Percentage) as MaxPercentage
        from CountryLanguage
        group by CountryCode
    ) as sub
    on cl.CountryCode = sub.CountryCode 
    and cl.Percentage = sub.MaxPercentage
inner join 
    Country co
    on co.Code = cl.CountryCode
order by co.Name;

/*-------- ESERCIZIO EXTRA --------
Per ogni continente, mostra le 3 lingue più parlate in termini di popolazione totale, considerando la popolazione di ogni nazione moltiplicata per la percentuale della lingua.
(Usa Country e CountryLanguage /
Calcola la popolazione che parla ogni lingua (Population * Percentage / 100) /
Usa subquery per ottenere il ranking per continente /
Ordina i risultati per continente e popolazione decrescente ) */