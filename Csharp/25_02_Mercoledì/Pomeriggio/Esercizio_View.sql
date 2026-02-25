create view View_Citta as
select ci.ID, ci.Name, ci.CountryCode, ci.District, ci.Population
from City ci
where ci.CountryCode = 'ITA';

select vwc.Name as Nome_Città, vwc.Population
from view_citta vwc
where vwc.Population < 100000
order by vwc.Population asc;

