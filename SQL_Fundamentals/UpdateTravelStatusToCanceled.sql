UPDATE Travels
Set Status = 'Canceled'
Where convert(varchar,Travel_Date, 1) < CONVERT(varchar, getdate(),1) AND Status='Planned'