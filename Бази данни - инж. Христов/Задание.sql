SELECT e.FirstName+' '+e.LastName AS N'Работник',m.FirstName+' '+m.LastName AS N'Manager' FROM Employees AS e INNER JOIN Employees AS m ON e.EmployeeID = m.ManagerID
SELECT e.FirstName+' '+e.LastName AS N'Работник',t.Name AS N'Град' FROM Employees AS e INNER JOIN Towns AS t ON e.AddressID = t.TownID
SELECT m.FirstName+' '+m.LastName AS N'Manager' FROM Employees AS e INNER JOIN Employees AS m ON e.EmployeeID = m.ManagerID
SELECT d.Name AS N'Departments',m.FirstName+' '+m.LastName AS N'Manager', t.Name AS N'Town', a.AddressText AS N'Address' FROM Departments AS d INNER JOIN Employees AS m ON d.ManagerID = m.ManagerID INNER JOIN Towns AS t ON d.ManagerID = t.TownID INNER JOIN Addresses AS a ON t.TownID = a.AddressID
