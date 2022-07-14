IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Cities')
BEGIN
    CREATE TABLE Cities
    (
        Id INT IDENTITY(1, 1) PRIMARY KEY,
        Caption varchar(20) NOT NULL,
    )
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Drivers')
BEGIN
    CREATE TABLE Drivers
    (
        Id INT IDENTITY(1, 1) PRIMARY KEY,
        FirstName varchar(20) NOT NULL,
        Surname varchar(30) NOT NULL,
        Patronymic varchar(30) NOT NULL,
        BirthDate DATETIME NULL
    )
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Transports')
BEGIN
    CREATE TABLE Transports
    (
        Id INT IDENTITY(1, 1) PRIMARY KEY,
        Mark varchar(20) NOT NULL,
        CarNumber varchar(10) NOT NULL,
    )
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Passengers')
BEGIN
    CREATE TABLE Passengers
    (
        Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        FirstName varchar(20) NOT NULL,
        Surname varchar(30) NOT NULL,
        Patronymic varchar(30) NOT NULL,
        PhoneNumber varchar(15) NOT NULL,
    )
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'Rides')
BEGIN
    CREATE TABLE Rides
    (
        Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        StartCityId INT FOREIGN KEY REFERENCES Cities(Id),
        FinishCityId INT FOREIGN KEY REFERENCES Cities(Id),
        StartDate DATETIME NOT NULL,
        FinishDate DATETIME NULL,
        DriverId INT FOREIGN KEY REFERENCES Drivers(Id),
        TransportId INT FOREIGN KEY REFERENCES Transports(Id),
    )
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'PassengerRides')
BEGIN
    CREATE TABLE PassengerRides
    (
        PassengerId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Passengers(Id),
        RideId UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Rides(Id),

        CONSTRAINT Pk_Passenger_Ride PRIMARY KEY (PassengerId, RideId)
    )
END