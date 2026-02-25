select Name AS Nazione,
    case 
        when SurfaceArea > 100000 then 'Sì' 
        else 'No' 
    end as Superficie_maggiore_100k,
    coalesce(IndepYear, 'Non presente') as Anno_Indipendenza
from country;

-- codice nazione simulato: 'ITA', ordinamento: crescente, filtro popolazione: 50000, mostrare nome nazione riferimento codice: si
select ci.Name as Città, ci.CountryCode as Codice_Nazione, ci.Population as Popolazione
from City ci
inner join Country co on ci.CountryCode = co.Code
where ci.CountryCode = 'ITA' and ci.Population >= 50000
order by ci.Population asc; -- se l'ordinamento va fatto su città ci.Population diventa ci.Name, ma non mi piace ordinarlo in quel modo, preferisco per popolazione 
