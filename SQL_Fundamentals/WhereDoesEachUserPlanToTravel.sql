Select FirstName,LastName,Name
From Users as u
inner join 
Travels as t on t.User_ID =u.ID AND t.Status='Planned'
inner join 
Locations as l On l.ID = t.Location_ID 
ORDER BY LastName ASC