CREATE DATABASE FoodOrderDB
GO

USE FoodOrderDB
GO

CREATE TABLE MenuItems
(
    MenuId INT PRIMARY KEY IDENTITY(1,1),
    ItemName VARCHAR(100) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    FoodType VARCHAR(20) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    AvailableQuantity INT NOT NULL,
    IsAvailable BIT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
)

INSERT INTO MenuItems
(ItemName, Category, FoodType, Price, AvailableQuantity, IsAvailable)
VALUES
('Idli', 'Breakfast', 'Veg', 40, 100, 1),
('Masala Dosa', 'Breakfast', 'Veg', 80, 50, 1),
('Pongal', 'Breakfast', 'Veg', 60, 40, 1),
('Chicken Chettinad', 'Main Course', 'Non-Veg', 220, 25, 1),
('Parotta', 'Dinner', 'Veg', 25, 80, 1),
('Fish Curry Meals', 'Lunch', 'Non-Veg', 180, 30, 1),
('Mini Tiffin', 'Combo', 'Veg', 150, 20, 1),
('Filter Coffee', 'Beverages', 'Veg', 30, 100, 1)
Select * from MenuItems;