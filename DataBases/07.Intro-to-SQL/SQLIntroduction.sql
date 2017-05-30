/* 04. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).*/

USE TelerikAcademy
SELECT * FROM Departments
GO

/* 05. Write a SQL query to find all department names.*/

USE TelerikAcademy
SELECT DISTINCT d.Name FROM Departments d
GO

/* 06. Write a SQL query to find the salary of each employee.*/

USE TelerikAcademy
SELECT FirstName, LastName, Salary FROM Employees
GO

------------------------------------------------------------------------

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(e.Salary)
FROM Employees e
ORDER BY Salary
GO

/* 07. Write a SQL to find the full name of each employee.*/

USE TelerikAcademy
SELECT (FirstName + ' ' + IIF(MiddleName IS NOT NULL, MiddleName + ' ', '') + LastName) AS [Full Name] 
FROM Employees
GO

-----------------------------------------------------------------

USE TelerikAcademy
SELECT (e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name] 
FROM Employees e
GO

/* 08.	Write a SQL query to find the email addresses of each employee (by his first and last name).
	Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com".
	The produced column should be named "Full Email Addresses".*/

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(e.FirstName + '.' + e.LastName + '@telerik.com') AS [Full Email Addresses] 
FROM Employees e
GO

/* 09. Write a SQL query to find all different employee salaries.*/

USE TelerikAcademy
SELECT DISTINCT Salary FROM Employees
GO

-------------------------------------------------------------------------\

USE TelerikAcademy
SELECT DISTINCT e.Salary AS [Different Salaries],
		COUNT(*) AS [Employee with that salary]
FROM Employees e
GROUP BY e.Salary
GO

/* 10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.*/

USE TelerikAcademy
SELECT *
FROM Employees e
WHERE e.JobTitle = 'Sales Representative'
GO

/* 11. Write a SQL query to find the names of all employees whose first name starts with "SA". */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name]
FROM Employees e
WHERE e.FirstName LIKE 'SA%'
GO

/* 12. Write a SQL query to find the names of all employees whose last name contains "ei". */

USE TelerikAcademy
SELECT (e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name]
FROM Employees e
WHERE e.LastName LIKE '%ei%'
GO

/* 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000]. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(e.Salary)
FROM Employees e
WHERE e.Salary BETWEEN 20000 AND 30000
GO

/* 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],	
	(e.Salary)
FROM Employees e
WHERE e.Salary IN (25000, 14000, 12500, 23600)
ORDER BY e.Salary
GO

/* 15. Write a SQL query to find all employees that do not have manager. */

USE TelerikAcademy
SELECT (e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name]
FROM Employees e
WHERE e.ManagerID IS NULL
GO

/* 16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(e.Salary)
FROM Employees e
WHERE e.Salary > 50000
ORDER BY e.Salary DESC
GO

/* 17. Write a SQL query to find the top 5 best paid employees. */

USE TelerikAcademy
SELECT TOP (5)	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
		(e.Salary)
FROM Employees e
ORDER BY e.Salary DESC
GO

/* 18. Write a SQL query to find all employees along with their address. Use inner join with ON clause. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(a.AddressText) AS [Address],
	(t.Name) AS [Town]
FROM Employees e
JOIN Addresses a
	ON e.AddressID = a.AddressID
JOIN Towns t
	ON a.TownID = t.TownID
GO

/* 19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause). */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(a.AddressText) AS [Address],
	(t.Name) AS [Town]	
FROM Employees e, Addresses a, Towns t
WHERE e.AddressID = a.AddressID AND a.TownID = t.TownID
GO

/* 20. Write a SQL query to find all employees along with their manager. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(m.FirstName + ISNULL(' ' + m.MiddleName + ' ', ' ') + m.LastName) AS [Manager]
FROM Employees e
JOIN Employees m
	ON e.ManagerID = m.EmployeeID
ORDER BY m.FirstName, e.FirstName
GO

-----------------------------------------------------------------

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(m.FirstName + ISNULL(' ' + m.MiddleName + ' ', ' ') + m.LastName) AS [Manager]
FROM Employees e, Employees m
WHERE e.ManagerID = m.EmployeeID
ORDER BY m.FirstName, e.FirstName
GO

/* 21.	Write a SQL query to find all employees, along with their manager and their address.
	Join the 3 tables: Employees e, Employees m and Addresses a. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(m.FirstName + ISNULL(' ' + m.MiddleName + ' ', ' ') + m.LastName) AS [Manager],
	(a.AddressText) AS [Address],
	(t.Name) AS [Town]
FROM Employees e
JOIN Employees m
	ON e.ManagerID = m.EmployeeID
JOIN Addresses a
	ON e.AddressID = a.AddressID
JOIN Towns t
	ON a.TownID = t.TownID
ORDER BY e.FirstName, e.MiddleName, e.LastName
GO

/* 22. Write a SQL query to find all departments and all town names as a single list. Use UNION. */

USE TelerikAcademy
SELECT d.Name FROM Departments d
UNION
SELECT t.Name FROM Towns t
GO

/* 23.	Write a SQL query to find all the employees and the manager for each of them 
	along with the employees that do not have manager.Use right outer join. 
	Rewrite the query to use left outer join. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(m.FirstName + ISNULL(' ' + m.MiddleName + ' ', ' ') + m.LastName) AS [Manager]
FROM Employees m
RIGHT JOIN Employees e
	ON m.EmployeeID = e.ManagerID
ORDER BY e.FirstName, e.MiddleName, e.LastName
GO

--------------------------------------------------------------

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(m.FirstName + ISNULL(' ' + m.MiddleName + ' ', ' ') + m.LastName) AS [Manager]
FROM Employees e
LEFT JOIN Employees m
	ON m.EmployeeID = e.ManagerID
ORDER BY e.FirstName, e.MiddleName, e.LastName
GO

/* 24.	Write a SQL query to find the names of all employees 
	from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005. */

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(d.Name) AS [Department],
	(e.HireDate)
FROM Employees e
LEFT JOIN  Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance') AND (year(e.HireDate) BETWEEN 1995 AND 2005)
ORDER BY d.Name, e.HireDate, e.FirstName, e.MiddleName, e.LastName
GO

-----------------------------------------------------------------------------------------------------

USE TelerikAcademy
SELECT	(e.FirstName + ISNULL(' ' + e.MiddleName + ' ', ' ') + e.LastName) AS [Full Name],
	(d.Name) AS [Department],
	(e.HireDate)
FROM Employees e, Departments d
WHERE	e.DepartmentID = d.DepartmentID AND
	d.Name IN ('Sales', 'Finance') AND
	YEAR(e.HireDate) BETWEEN 1995 AND 2005
ORDER BY d.Name, e.HireDate, e.FirstName, e.MiddleName, e.LastName
GO
