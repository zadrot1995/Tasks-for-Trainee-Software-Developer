USE MyShop
SELECT [Price] FROM Products
INNER JOIN [Suppliers]
ON Products.SupplierID = Suppliers.SupplierID
 WHERE Suppliers.Country LIKE 'USA';