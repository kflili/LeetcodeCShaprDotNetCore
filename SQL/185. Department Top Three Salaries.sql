SELECT Department.Name AS Department, Emp.Name AS Employee, Salary
FROM 
(SELECT *, Row_Number() OVER (PARTITION BY DepartmentId ORDER BY Salary DESC) AS rn
FROM Employee)
AS Emp
JOIN Department
ON Emp.DepartmentId = Department.Id
WHERE rn <= 3