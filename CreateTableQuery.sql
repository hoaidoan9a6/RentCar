CREATE TABLE Cars (
    Id int NOT NULL,
    BrandId int NOT NULL,
    ColorId int NOT NULL,
    CarName varchar(255) NOT NULL,
    ModelYear varchar(255) NOT NULL,
    DailyPrice decimal(18) NOT NULL,
    Description varchar(255) NOT NULL,
    CONSTRAINT PK_Cars PRIMARY KEY (Id)
);

CREATE TABLE Brands (
    BrandId int NOT NULL,
    BrandName varchar(255) NOT NULL,
    CONSTRAINT PK_Brands PRIMARY KEY (BrandId)
);

CREATE TABLE Colors (
    ColorId int NOT NULL,
    ColorName varchar(255) NOT NULL,
    CONSTRAINT PK_Colors PRIMARY KEY (ColorId)
);

CREATE TABLE Users (
    Id int NOT NULL,
    FirstName varchar(255) NOT NULL,
    LastName varchar(255) NOT NULL,
    Email varchar(255) NOT NULL,
    Password varchar(255) NOT NULL,
    CONSTRAINT PK_Users PRIMARY KEY (Id)
);

CREATE TABLE Customers (
    UserId int NOT NULL,
    CompanyName varchar(255) NOT NULL,
    CONSTRAINT PK_Customers PRIMARY KEY (UserId),
    FOREIGN KEY (UserId) REFERENCES Users(Id)
);

CREATE TABLE Rentals (
    RentalId int NOT NULL,
    CarId int NOT NULL,
    CustomerId int NOT NULL,
    RentDate varchar(255) NOT NULL,
    ReturnDate varchar(255) DEFAULT NULL,
    CONSTRAINT PK_Rentals PRIMARY KEY (RentalId),
    FOREIGN KEY (CarId) REFERENCES Cars(Id),
    FOREIGN KEY (CustomerId) REFERENCES Customers(UserId)
);