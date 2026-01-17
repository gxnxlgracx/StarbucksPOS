CREATE DATABASE StarbucksPOS;
GO

USE StarbucksPOS;
GO

-- 1. Table for User Accounts (Login/Signup)
-- Used in Login.vb and Signup.vb
CREATE TABLE users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) NOT NULL UNIQUE,
    password NVARCHAR(50) NOT NULL
);
GO

-- 2. Table for the current transaction (Cart)
-- Used in Menu.vb
CREATE TABLE orderList (
    ID INT,
    Name NVARCHAR(255),
    Quantity INT,
    Price DECIMAL(10, 2)
);
GO

-- 3. Table for long-term records
-- Used in Menu.vb
CREATE TABLE orderHistory (
    ID INT,
    Name NVARCHAR(255),
    Quantity INT,
    Price DECIMAL(10, 2)
);
GO

-- Optional: Insert a default admin account so you can log in immediately
-- Username: admin, Password: password123
INSERT INTO users (username, password) VALUES ('admin', 'password');
GO