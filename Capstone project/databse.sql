USE HRManagementDB;

CREATE TABLE Departments (
    DepartmentId INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);

CREATE TABLE Employees (
    EmployeeId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    DepartmentId INT,
    LeaveBalance INT DEFAULT 20
);

CREATE TABLE LeaveRequests (
    LeaveId INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeId INT,
    StartDate DATE,
    EndDate DATE,
    Status VARCHAR(20)
);

INSERT INTO Departments (DepartmentName)
VALUES ('HR'), ('IT'), ('Finance');

INSERT INTO Employees (FirstName, LastName, Email, DepartmentId, LeaveBalance)
VALUES
('pranav','suhane','pranav@email.com',1,18);


SELECT * FROM Employees;
SELECT * FROM LeaveRequests;
SELECT LeaveBalance FROM Employees ;