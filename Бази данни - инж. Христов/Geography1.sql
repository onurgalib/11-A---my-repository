SELECT TOP(15) ID AS Идентификатор, RiverName AS Име, Length AS Дължина FROM Rivers

SELECT * FROM Rivers

SELECT TOP(30) 
CountryName AS Name,
CountryCode AS КОД,
AreaInSqKm AS Площ
FROM Countries AS 

SELECT * FROM Peaks

SELECT * FROM Mountains

SELECT * FROM Countries
WHERE ContinentCode = 'EU' AND Population>500000 AND Population<10000000 AND AreaInSqKm>50000