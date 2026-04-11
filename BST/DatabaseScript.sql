/* ============================================
   CATANBUS DATABASE SCRIPT
   Creates database + tables + sample data
   ============================================ */

IF DB_ID('CatanBusDB') IS NOT NULL
DROP DATABASE CatanBusDB
GO

CREATE DATABASE CatanBusDB
GO

USE CatanBusDB
GO


/* ============================================
   USERS TABLE
   ============================================ */

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    IsAdmin BIT DEFAULT 0,
    IsModerator BIT DEFAULT 0
)


/* ============================================
   BUS TABLE
   Max seat capacity = 50
   ============================================ */

CREATE TABLE Bus (
    BusID INT IDENTITY(1,1) PRIMARY KEY,
    BusNumber NVARCHAR(50) NOT NULL,
    SeatsCapacity INT NOT NULL,
    SeatsAvailable INT NOT NULL
)


/* ============================================
   TRIP TABLE
   ============================================ */

CREATE TABLE Trip (
    TripID INT IDENTITY(1,1) PRIMARY KEY,
    BusID INT,
    FromLocation NVARCHAR(100),
    ToLocation NVARCHAR(100),
    Departure DATETIME,
    Arrival DATETIME,
    Price DECIMAL(10,2) DEFAULT 0,
    Status NVARCHAR(50) DEFAULT 'Active',

    FOREIGN KEY (BusID) REFERENCES Bus(BusID)
)


/* ============================================
   TICKET TABLE
   ============================================ */

CREATE TABLE Ticket (
    TicketID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT,
    TripID INT,
    SeatCount INT,
    Price DECIMAL(10,2),
    Status NVARCHAR(50) DEFAULT 'Active',

    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (TripID) REFERENCES Trip(TripID)
)


/* ============================================
   PAYMENT TABLE
   ============================================ */

CREATE TABLE Payment (
    CONSTRAINT FK_Payment_User FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Payment_Trip FOREIGN KEY (TripID) REFERENCES Trip(TripID),
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT,
    TripID INT,
    Amount DECIMAL(10,2),
    Status NVARCHAR(50),
    PaymentDate DATETIME DEFAULT GETDATE()
)


/* ============================================
   PREPOPULATED USERS
   CLIENT REQUIREMENT:
   1 Moderator + 2 Admins
   ============================================ */

INSERT INTO Users (Username,Email,Password,IsAdmin,IsModerator)
VALUES
('Moderator','moderator@catanbus.com','Mod@123',0,1),

('Admin One','admin1@catanbus.com','Admin@123',1,0),
('Admin Two','admin2@catanbus.com','Admin@123',1,0),

('User One','user1@catanbus.com','User@123',0,0),
('User Two','user2@catanbus.com','User@123',0,0),
('User Three','user3@catanbus.com','User@123',0,0)


/* ============================================
   BUSES
   All buses capacity = 50 seats
   ============================================ */

INSERT INTO Bus (BusNumber,SeatsCapacity,SeatsAvailable)
VALUES
('BUS-001',50,50),
('BUS-002',50,50),
('BUS-003',50,50),
('BUS-004',50,50),
('BUS-005',50,50)


/* ============================================
   EUROPEAN TRIPS (15 ROUTES)
   ============================================ */

INSERT INTO Trip (BusID,FromLocation,ToLocation,Departure,Arrival,Price)
VALUES

(1,'Paris','Brussels','2026-05-01 08:00','2026-5-01 11:00',45),

(1,'Paris','Amsterdam','2026-05-02 07:00','2026-05-02 12:00',55),

(2,'Berlin','Prague','2026-05-01 09:00','2026-05-01 13:00',40),

(2,'Berlin','Vienna','2026-05-02 08:00','2026-05-02 15:00',60),

(3,'Rome','Florence','2026-05-01 10:00','2026-05-01 13:00',35),

(3,'Rome','Milan','2026-05-03 09:00','2026-05-03 15:00',50),

(4,'Madrid','Barcelona','2026-05-01 07:30','2026-05-01 12:30',45),

(4,'Madrid','Valencia','2026-05-02 08:00','2026-05-02 12:00',40),

(5,'Zurich','Munich','2026-05-01 06:00','2026-05-01 10:00',55),

(5,'Zurich','Vienna','2026-05-03 06:30','2026-05-03 13:00',65),

(1,'Brussels','Paris','2026-06-04 09:00','2026-06-04 12:00',45),

(2,'Prague','Berlin','2026-06-04 07:00','2026-06-04 11:00',40),

(3,'Florence','Rome','2026-06-05 08:00','2026-06-05 11:00',35),

(4,'Barcelona','Madrid','2026-06-05 09:00','2026-06-05 14:00',45),

(5,'Munich','Zurich','2026-06-06 07:00','2026-06-06 11:00',55)


/* ============================================
   SAMPLE BOOKINGS
   ============================================ */

INSERT INTO Ticket (UserID,TripID,SeatCount,Price,Status)
VALUES
(4,1,2,90,'Active'),
(5,3,1,40,'Active')


INSERT INTO Payment (UserID,TripID,Amount,Status)
VALUES
(4,1,90,'Paid'),
(5,3,40,'Paid')