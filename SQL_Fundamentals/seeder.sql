USE SQL_FUNDAMENTALS_ASSIGNMENT

INSERT INTO Cities(ID,Name,Contry) VALUES(1,'Madrid','Spain'),(2,'Paris','France'),(3,'London','United Kingdom'),
(4,'Timisoara','Romania'),(5,'Barcelona','Spain'),(6,'Liverpool','United Kingdom'),(7,'Manchester','United Kingdom'),
(8,'New York','USA'),(9,'Los Angeles','USA'),(10,'Berlin','Germany')

INSERT INTO Locations(ID,Name,City_ID,Address,Location_Type,Price) VALUES
(101,'Muzeu1Madrid',1,'AdresaMuzeu1Madrid','Museum',19.99),
(102,'Muzeu1NewYork',8,'AdresaMuzeu1NewYork','Museum',15.99),
(103,'Parc1Barcelona',5,'AdresaPark1Barcelona','Park',0),
(104,'Parc1Timisoara',4,'AdresaPark1Timisoara','Park',0),
(105,'Cladire1Madrid',1,'AdresaCladire1Madrid','Famous Building',5),
(106,'Cladire1Manchester',7,'AddresaCladire2Manchester','Famous Building',5),
(107,'Muzeu1Berlin',10,'AdresaMuzeu1Berlin','Museum',30),
(108,'Muzeu1Paris',2,'AdresaMuzeu1Paris','Museum',20),
(109,'Parc1Liverpool',6,'AdresaParc1Paris','Park',0),
(110,'Parc1Paris',2,'AdresaPark1Paris','Park',0)

INSERT INTO Users(ID,FirstName,LastName,Email,Password,UserType) VALUES
(1,'Ion','Popescu','ion.popescu@yahoo.com','12345','Visitor'),
(2,'Iulian','Lupastean','ilupastean@yahoo.com','54321','Administrator'),
(3,'George','Enescu','george.enescu@yahoo.com','password1','Visitor'),
(4,'Maria','Maiorescu','maria.maiorescu@yahoo.com','password2','Visitor'),
(5,'Ion','Pop','ion.pop@yahoo.com','password3','Visitor'),
(6,'Gina','Popescu','gina.popescu@yahoo.com','password4','Visitor'),
(7,'Alexandra','Popa','alexandra.popa@gmail.com','password5','Visitor'),
(8,'Ion','Popescu','ion.popescu@yahoo.com','password6','Visitor'),
(9,'Ioan','Nascu','ioan.nascu@yahoo.com','Password7','Visitor'),
(10,'Elena','Averescu','elena.averescu@yahoo.com','Password7','Visitor')

INSERT INTO Travels (ID,Location_ID,User_ID,Status,Travel_Date) VALUES
(1,102,1,'Completed','03-11-21'),
(2,103,5,'Completed','03-11-21'),
(3,105,1,'Canceled','03-11-21'),
(4,101,3,'Completed','04-07-21'),
(5,108,5,'Planned','03-07-21'),
(6,107,2,'Planned','03-21-21'),
(7,106,1,'Completed','03-21-21'),
(8,110,4,'Canceled','03-21-21'),
(9,103,6,'Completed','03-21-21'),
(10,101,10,'Completed','03-21-21')