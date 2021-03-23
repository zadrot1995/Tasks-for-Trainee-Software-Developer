﻿USE MyShop
INSERT INTO [Categories]
VALUES 
(1, 'Beverages', 'Soft drinks, coffees, teas, beers, and ales' ),
(2, 'Condiments', 'Sweet and savory sauces, relishes, spreads, and seasonings'),
(3, 'Confections', 'Desserts, candies, and sweet breads'),
(4, 'Dairy Products', 'Cheeses'),
(5, 'Grains/Cereals', 'Breads, crackers, pasta, and cereal');

INSERT INTO [Suppliers]
VALUES 
(1, 'Exotic Liquid', 'London', 'UK'),
(2, 'New Orleans Cajun Delights', 'New Orleans', 'USA'),
(3, 'Grandma Kelly’s Homestead', 'Ann Arbor', 'USA'),
(4, 'Tokyo Traders', 'Tokyo', 'Japan'),
(5, 'Cooperativa de Quesos ‘Las Cabras’', 'Oviedo', 'Spain');

INSERT INTO [Products]
VALUES 
(1, 'Chais', 1, 1, 18.00),
(2, 'Chang', 1, 1, 19.00),
(3, 'Aniseed Syrup', 1, 2, 10.00),
(4, 'Chef Anton’s Cajun Seasoning', 2, 2, 22.00),
(5, 'Chef Anton’s Gumbo Mix', 2, 2, 21.35);

