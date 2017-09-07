--solution 1--
SELECT (
    SELECT DISTINCT Salary
    FROM Employee
    ORDER By Salary DESC
    OFFSET 1 ROW FETCH NEXT 1 ROW ONLY
)
AS SecondHighestSalary

--solutioin 2, not consider null--
SELECT TOP 1 Salary
FROM (
      SELECT DISTINCT TOP 2 Salary
      FROM Employee
      ORDER BY Salary DESC
      ) AS Emp
ORDER BY Salary

--solution 3, using Row_Number--
SELECT Salary FROM (
    SELECT Salary, ROW_NUMBER() OVER (ORDER BY salary DESC) AS rn 
    FROM Employee
) AS Emp
WHERE rn = 2; 