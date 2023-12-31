SELECT COUNT(Id) AS 'Count' FROM WizzardDeposits
go

SELECT  MAX(Age) AS 'OldestWizard' FROM WizzardDeposits

SELECT TOP(1)  Age AS 'OldestWizard' FROM WizzardDeposits
ORDER BY AGE DESC

go

SELECT DepositGroup, MAX(Age) - MIN(Age) AS [MaxAgeDifference] FROM WizzardDeposits
GROUP BY DepositGroup
go

SELECT  wd.DepositGroup, FORMAT(AVG(wd.DepositAmount), 'F2') AS 'AverageDepAmmount' FROM WizzardDeposits as wd
GROUP BY wd.DepositGroup
ORDER BY  AverageDepAmmount
go

SELECT  wd.DepositGroup, SUM(wd.DepositAmount) AS 'TotalDepositsSum' FROM WizzardDeposits as wd
GROUP BY wd.DepositGroup
ORDER BY  TotalDepositsSum DESC
go

SELECT  wd.DepositGroup, SUM(wd.DepositAmount) AS 'TotalDepositsSum' FROM WizzardDeposits as wd
WHERE wd.MagicWandCreator LIKE 'Ollivander family'
GROUP BY wd.DepositGroup
--HAVING SUM(wd.DepositAmount)>60000
ORDER BY  TotalDepositsSum DESC
go

SELECT  wd.DepositGroup, wd.MagicWandCreator, MIN(WD.DepositCharge) AS 'MinDepositCharge' FROM WizzardDeposits as wd
GROUP BY wd.DepositGroup,wd.MagicWandCreator
ORDER BY wd.DepositGroup,wd.MagicWandCreator
go

SELECT 
	CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END AS [AgeGroup],
COUNT(*) AS [WizardCount]
	FROM WizzardDeposits AS w
GROUP BY CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END
	go

	SELECT 
	CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END AS [AgeGroup],
SUM(w.DepositAmount) AS [TotalAmmount]
	FROM WizzardDeposits AS w
GROUP BY CASE
	  WHEN w.Age BETWEEN 0 AND 10 THEN '[0-10]'
	  WHEN w.Age BETWEEN 11 AND 20 THEN '[11-20]'
	  WHEN w.Age BETWEEN 21 AND 30 THEN '[21-30]'
	  WHEN w.Age BETWEEN 31 AND 40 THEN '[31-40]'
	  WHEN w.Age BETWEEN 41 AND 50 THEN '[41-50]'
	  WHEN w.Age BETWEEN 51 AND 60 THEN '[51-60]'
	  WHEN w.Age >= 61 THEN '[61+]'
	END