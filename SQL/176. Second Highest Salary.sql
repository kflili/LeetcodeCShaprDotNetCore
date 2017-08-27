WITH CTE AS
(
    SELECT Id,Salary,
           ROW_NUMBER() OVER (ORDER BY Salary DESC) AS RwoNumber 
    FROM Employee
)
SELECT Salary as SecondHighestSalary
FROM CTE
WHERE RowNumber = 2