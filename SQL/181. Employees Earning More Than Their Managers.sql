Select a.Name as Employee
from Employee a join Employee b
on a.ManagerId = b.Id and a.Salary > b.Salary
;