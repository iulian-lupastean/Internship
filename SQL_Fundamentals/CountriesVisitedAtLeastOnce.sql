use SQL_FUNDAMENTALS_ASSIGNMENT
SELECT Cities.Contry FROM Cities WHERE
Cities.ID IN (SELECT Locations.City_ID From Locations WHERE Locations.ID IN (SELECT Travels.Location_ID FROM Travels WHERE Travels.Status='Completed'))
