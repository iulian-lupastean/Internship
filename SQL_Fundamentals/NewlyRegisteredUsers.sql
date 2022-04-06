Select FirstName
From Users as u
Full OUTER JOIN 
Travels as t on t.User_ID=u.ID
FULL OUTER JOIN 
Locations as l ON l.ID = t.Location_ID
WHERE t.User_ID IS  NULL and u.FirstName is NOT NULL