SELECT Cities.Contry , COUNT(Locations.City_ID) AS NumberOfLocationsInCountries FROM Locations
Left Join Cities ON Locations.City_ID = Cities.ID
Group by Contry
Order by NumberOfLocationsInCountries DESC