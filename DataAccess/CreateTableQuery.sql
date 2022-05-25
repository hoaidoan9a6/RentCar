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
SET IDENTITY_INSERT Cars　ON;

CREATE TABLE Brands (
    BrandId int NOT NULL,
    BrandName varchar(255) NOT NULL,
    CONSTRAINT PK_Brands PRIMARY KEY (BrandId)
);
SET IDENTITY_INSERT Brands　ON;

CREATE TABLE Colors (
    ColorId int NOT NULL,
    ColorName varchar(255) NOT NULL,
    CONSTRAINT PK_Colors PRIMARY KEY (ColorId)
);
SET IDENTITY_INSERT Colors　ON;
