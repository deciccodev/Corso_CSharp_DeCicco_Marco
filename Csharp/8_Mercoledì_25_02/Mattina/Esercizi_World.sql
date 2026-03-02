use world;

select ci.Name as Città, co.Name as Nazione, cl.Language as Lingua
from City ci
inner join Country co on ci.CountryCode = co.Code
inner join CountryLanguage cl on co.Code = cl.CountryCode
order by co.Name, ci.Name;

select co.Name as Nome_Nazione, count(ci.ID) as Numero_Di_Città 
from Country co
inner join City ci on ci.CountryCode = co.Code
group by co.Name
order by Numero_Di_Città desc;

select co.Name as Nome_Città, co.GovernmentForm as Tipo_Di_Governo, co.LifeExpectancy as Aspettativa_Di_Vita, cl.Language as Lingua
from Country co
inner join CountryLanguage cl on co.Code = cl.CountryCode
where lower(co.GovernmentForm) like '%republic%' and co.LifeExpectancy > 70;