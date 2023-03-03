﻿SELECT CONCAT(c.FirstName, ' ', c.LastName) AS FullName,
       c.Age,
       o.OrderID,
       o.DateCreated,
       o.MethodOfPurchase AS PurchaseMethod,
       od.ProductNumber,
       od.ProductOrigin
FROM Customers c
INNER JOIN Orders o ON c.PersonID = o.PersonID
INNER JOIN OrderDetails od ON o.OrderID = od.OrderID
WHERE od.ProductID = 1112222333