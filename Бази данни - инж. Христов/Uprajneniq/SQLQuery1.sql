SELECT wd.DepositGroup,AVG(DepositAmount) AS 'AveragedDepAmmount' FROM WizzardDeposits AS wd
GROUP BY DepositGroup
ORDER BY AveragedDepAmmount

SELECT wd.DepositGroup,SUM(DepositAmount) AS 'SumDepAmmount' FROM WizzardDeposits AS wd
GROUP BY DepositGroup
ORDER BY SumDepAmmount

SELECT wd.DepositGroup,SUM(DepositAmount) AS 'SumDepAmmount' FROM WizzardDeposits AS wd
GROUP BY DepositGroup
ORDER BY SumDepAmmount

SELECT * FROM WizzardDeposits

SELECT wd.DepositGroup,SUM(DepositAmount) AS 'SumDepAmmount' FROM WizzardDeposits AS wd
WHERE MagicWandCreator='Ollivander family'
GROUP BY DepositGroup
ORDER BY SumDepAmmount

SELECT wd.DepositGroup, wd.MagicWandCreator, MIN(WD.DepositCharge) AS 'MinDepositCharge' FROM WizzardDeposits as wd
GROUP BY wd.DepositGroup, wd.MagicWandCreator
ORDER BY wd.DepositGroup, wd.MagicWandCreator

SELECT wd.DepositGroup,wd.IsDepositExpired,AVG(DepositInterest) AS 'AverageInterest' FROM WizzardDeposits AS wd
WHERE wd.DepositStartDate > CONVERT(DATETIME,'01/01/1985')
GROUP BY wd.DepositGroup, wd.IsDepositExpired

SELECT * FROM WizzardDeposits AS wd
WHERE wd.DepositStartDate > CONVERT(DATETIME,'01/01/1985')

USE SoftUni
SELECT Name AS 'DepartmentName',SUM(e.Salary)AS 'TotalSalary',COUNT(e.EmployeeId)AS 'Workers' FROM Departments AS d
LEFT JOIN Employees AS e ON d.DepartmentID = e.DepartmentID
GROUP BY d.Name

