USE SQL_FUNDAMENTALS_ASSIGNMENT
Select Cities.Name AS City ,Locations.Name AS Location
from Cities 
inner join Locations on Locations.City_ID=Cities.ID
where Cities.Contry Like 'F%'
