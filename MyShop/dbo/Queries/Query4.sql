USE MyShop
SELECT * FROM [Suppliers] 
WHERE [SupplierID] IN 
(SELECT [SupplierID] FROM Products
INNER JOIN [Categories]
ON Products.CategoryID = Categories.CategoryID
WHERE Categories.CategoriesName LIKE 'Condiments');