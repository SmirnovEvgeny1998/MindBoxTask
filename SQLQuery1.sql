CREATE TABLE Products(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Product nvarchar(50) NOT NULL
	)

CREATE TABLE Categories(
	ID int IDENTITY(1,1) PRIMARY KEY,
	Category nvarchar(50) NOT NULL
	)

CREATE TABLE ProductsCategories(
	ProductID int FOREIGN KEY REFERENCES Products(ID),
	CategoryID int FOREIGN KEY REFERENCES Categories(ID)
	)

INSERT INTO Products (Product)
VALUES 
('Pen'),
('Electronic scales'),
('"Don quixote"'),
('Diary'),
('Refrigerator'),
('Rivets'),
('Dumbbells'),
('Shorts')

INSERT INTO Categories (Category)
VALUES 
('Miscellaneous'),
('Writing materials'),
('Books'),
('Electronics'),
('For kitchen'),
('Illumination')

INSERT INTO ProductsCategories (ProductID,CategoryID)
VALUES 
(1,1),
(1,2),
(2,1),
(2,4),
(3,3),
(4,2),
(4,3),
(5,4),
(5,5),
(6,1),
(7,NULL),
(8,NULL),
(NULL,6)

SELECT Product,Category
FROM Products
FULL OUTER JOIN ProductsCategories ON Products.ID=ProductsCategories.ProductID
FULL OUTER JOIN Categories ON Categories.ID=ProductsCategories.CategoryID
