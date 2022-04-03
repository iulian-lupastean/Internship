CREATE DATABASE UNIT_TESTING_ASSIGNMENT
USE UNIT_TESTING_ASSIGNMENT
CREATE TABLE City(
ID int PRIMARY KEY,
Name varchar(50)
)
CREATE TABLE Locations(
ID int PRIMARY KEY,
Name varchar(50),
City_ID int ,
Address varchar(50),
Price float,
Type varchar(50),
FOREIGN KEY (City_ID) REFERENCES City(ID)
)
INSERT INTO City(ID,Name) VALUES(1,'Madrid')
INSERT INTO City(ID,Name) VALUES(2,'Paris')
INSERT INTO City(ID,Name) VALUES(3,'London')

INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(101,'Muzeu1Madrid',1,'AdresaMuzeu1Madrid',19.99,'Museum')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(102,'Muzeu2Madrid',1,'AdresaMuzeu2Madrid',19.99,'Museum')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(103,'Parc1Madrid',1,'AdresaPark1Madrid',19.99,'Park')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(104,'Parc2Madrid',1,'AdresaPark2Madrid',19.99,'Park')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(105,'Cladire1Madrid',1,'AdresaCladire1Madrid',19.99,'Famous Building')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(106,'Cladire2Madrid',1,'AddresaCladire2Madrid',19.99,'Famous Building')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(107,'Muzeu1Paris',2,'AdresaMuzeu1Paris',19.99,'Museum')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(108,'Muzeu2Paris',2,'AdresaMuzeu2Paris',19.99,'Museum')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(109,'Parc1Paris',2,'AdresaParc1Paris',19.99,'Park')
INSERT INTO Locations(ID,Name,City_ID,Address,Price,Type) VALUES(110,'Parc1London',3,'AdresaParc1London',0,'Park')