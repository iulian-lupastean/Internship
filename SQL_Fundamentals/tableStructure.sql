--CREATE DATABASE SQL_FUNDAMENTALS_ASSIGNMENT
USE SQL_FUNDAMENTALS_ASSIGNMENT
CREATE TABLE Cities(
ID int PRIMARY KEY,
Name varchar(50),
Contry varchar(50)
)
CREATE TABLE Locations(
ID int PRIMARY KEY,
Name varchar(50),
City_ID int ,
Address varchar(50),
Location_Type varchar(50),
Price float,
FOREIGN KEY (City_ID) REFERENCES Cities(ID)
)
CREATE TABLE Users(
ID int PRIMARY KEY,
FirstName varchar(50),
LastName varchar(50),
Email varchar(50),
Password varchar(50),
UserType varchar(50)
)
CREATE TABLE Travels(
ID int PRIMARY KEY,
Location_ID int,
User_ID int ,
Status varchar(50),
Travel_Date varchar(50),
FOREIGN KEY (Location_ID) REFERENCES Locations(ID),
FOREIGN KEY (User_ID) REFERENCES Users(ID)
)