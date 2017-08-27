select distinct l1.Num as ConsecutiveNums
from Logs l1
join Logs l2 on l1.Id = l2.Id -1
join Logs l3 on l1.Id = l3.Id - 2
WHERE l1.Num = l2.Num and l2.Num = l3.Num;