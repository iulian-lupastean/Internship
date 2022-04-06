Select Cities.Name,Locations.Name
From Locations
INNER JOIN Cities ON Locations.City_ID=Cities.ID
Where Locations.Location_Type  LIKE '% %';