/*Exercise 1 – Northwind Queries*/

/*1.1 Write a query that lists all Customers 
in either Paris or London. Include Customer ID, 
Company Name and all address fields.*/

--SELECT CustomerID, CompanyName, Address + ' ' + City + ' ' + PostalCode + ' ' + Country AS "Address"
--FROM Customers
--WHERE city = 'Paris' OR city = 'London';

/*1.2 List all products stored in bottles.*/

--SELECT ProductName AS "Products in Bottles"
--FROM Products
--WHERE QuantityPerUnit LIKE '%Bottles%';

/*1.3 Repeat question above, but add in the Supplier Name and Country.*/
--SELECT CompanyName AS "Supplier Name", Country AS "Country", ProductName AS "Products in Bottles"
--FROM products pro
--  JOIN Suppliers sup
--  ON pro.SupplierID = sup.SupplierID
--WHERE QuantityPerUnit LIKE '%Bottles%';

/*1.4 Write an SQL Statement that shows how many products there are in each category. 
Include Category Name in result set and list the highest number first.*/

--SELECT SUM(pro.UnitsInStock) AS "Total Units in Stock", cat.CategoryName
--FROM products pro
--  JOIN Categories cat
--  ON pro.CategoryID = cat.CategoryID
--  GROUP BY cat.CategoryName, pro.UnitsInStock
--  ORDER BY pro.UnitsInStock DESC

/* 1.5 List all UK employees using concatenation to join their title of courtesy, 
first name and last name together. Also include their city of residence. */

--SELECT titleofcourtesy + ' ' + firstname + ' ' + lastname + ' ' + city
--FROM employees
--WHERE country = 'UK'

/*1.6 Count how many Orders have a Freight amount greater 
than 100.00 and either USA or UK as Ship Country.*/

--SELECT COUNT (orderid) AS "Count", freight AS "Freight Amount above £100" 
--FROM orders
--WHERE shipcountry = 'USA' OR shipcountry = 'UK'
--GROUP BY freight 
--HAVING (freight) > 100


/*1.7 Write an SQL statement which finds the Orderline with the highest discount applied.
Report the Order Number of the order which contains this order line, 
and the discount applied.*/

--SELECT ord.orderID AS "Order ID", MAX(discount) AS "Discount"
--FROM [Order Details] ordd
--JOIN orders ord
--ON ordd.OrderID = ord.OrderID
--GROUP BY ord.OrderID
--ORDER BY MAX(ordd.discount) DESC

---- 1.8 List all Employees from the Employees table and who they report to.

--SELECT FirstName + ' ' + LastName AS "Employee Details", ReportsTo AS "Reports To"
--FROM Employees
