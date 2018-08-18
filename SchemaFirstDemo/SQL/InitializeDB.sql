
CREATE TABLE dbo.Departments
(
	ID int primary key	identity,
	Name nvarchar(50),
	Location nvarchar(50) 
)

Create table dbo.Employees
(
	ID int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender nvarchar(50),
	Salary int,
	DepartmentId int foreign key references Departments(Id)
)

insert into dbo.Departments values ('IT','New York')
insert into dbo.Departments values ('HR','London')
insert into dbo.Departments values ('Payroll','Sydney')

insert into dbo.Employees values ('Mark','Hastings','Male', 60000,1)
insert into dbo.Employees values ('Steve','Pound','Male', 45000,3)
insert into dbo.Employees values ('Ben','Hoskins','Male', 70000,1)
insert into dbo.Employees values ('Philip','Hastings','Male', 45000,2)
insert into dbo.Employees values ('Mary','Lambeth','Female', 30000,2)
insert into dbo.Employees values ('Valarie','Vikings','Female', 35000,3)
insert into dbo.Employees values ('John','Stanmore','Male', 80000,1)