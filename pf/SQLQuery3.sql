Create table dbo.Employee(
EmployeeId int identity(1,1),
EmployeeName varchar(500),
Department varchar(500),
DateofJoining date,
PhotofileName varchar(500)
)

insert into dbo.Employee values('zain','IT','2020-06-01','anonymous.png');

Select*from dbo.Employee;
