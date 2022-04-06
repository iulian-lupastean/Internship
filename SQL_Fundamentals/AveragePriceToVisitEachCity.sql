SELECT Cities.Name,  AVG(Price) AS PretulMediuAlOrasului From Locations
INNER JOIN Cities on Locations.City_ID = Cities.ID
Group by Cities.Name
ORDER BY PretulMediuAlOrasului ASC