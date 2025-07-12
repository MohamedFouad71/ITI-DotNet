


---------------------- Lab 3 part 1------------------------

use Company_SD;




--Display the Department id, name and id and the name of its manager.

select
	D.Dnum,
	D.Dname,
	D.MGRSSN ,
	CONCAT(E.Fname , ' ' , E.Lname) as [Manager Name]
from
	Departments D 
left outer join 
	Employee E 
on
	D.MGRSSN = E.SSN;




--Display the name of the departments and the name of the projects under its control.

select
	D.Dname,
	P.Pname
from 
	Departments D
left outer join
	Project P
on
	D.Dnum = P.Dnum;




--Display the full data about all the dependence associated with the name of the employee they depend on him/her.

select 
	D.*,
	CONCAT(E.Fname, ' ', E.Lname) AS [Associated to]
From 
	Employee E inner join Dependent D 
on 
	E.SSN = D.ESSN;



--Display the Id, name and location of the projects in Cairo or Alex city.

select 
	P.Pnumber,
	P.Pname,
	P.Plocation
from 
	Project P
where 
	P.City in('Cairo','Alex');




--Display the Projects full data of the projects with a name starts with "a" letter.

select * from Project
where 
Pname like 'a%'



--display all the employees in department 30 whose salary from 1000 to 2000 LE monthly

select * from Employee
where 
	Dno = 30 
and
	Salary between 1000 and 2000;



--Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.

select DISTINCT Concat(E.Fname, ' ', E.Lname) as [Full Name]
from
	Employee E
inner join
	Works_for W on W.ESSn = E.SSN
inner join
	Project P on P.Dnum = E.Dno
Where
	E.Dno = 10
	AND
	P.Pname = 'Al Rabwah'
	AND
	W.Hours >= 10;
	

--Find the names of the employees who directly supervised with Kamel Mohamed.

SELECT CONCAT(E.Fname, ' ', E.Lname) AS [Full Name]
From
	Employee AS E
INNER JOIN
	Employee AS SV
ON
	E.Superssn = SV.SSN
WHERE 
	SV.Fname + ' ' + SV.Lname = 'Kamel Mohamed'



--Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

SELECT
	CONCAT(E.Fname, ' ', E.Lname) AS [Full Name],
	P.Pname
from 
	Employee AS E
INNER JOIN Works_for AS W
	ON W.ESSn = E.SSN
INNER JOIN Project AS P
	ON W.Pno = P.Pnumber
ORDER BY
	P.Pname;

/*
For each project located in Cairo City ,
find the project number, the controlling department name ,the department manager
last name ,address and birthdate.
*/

SELECT
	P.Pname AS [Project Name],
	D.Dname AS [Department Name],
	M.Lname AS [Department Manager Last Name],
	M.Address AS [Department Manager address],
	M.Bdate AS [Department Manager Birth Date]
FROM
	Project AS P,
	Departments AS D,
	Employee AS M
Where
	P.Dnum = D.Dnum 
	AND D.MGRSSN = M.SSN
	AND P.Plocation = 'Cairo';




--Display All Data of the managers

SELECT DISTINCT
	CONCAT(M.Fname, ' ',M.Lname) AS [Manager Name],
	M.SSN,
	M.Bdate,
	M.Address,
	M.Sex,
	m.Salary,
	M.Superssn,
	D.Dname [Department Name],
	D.[MGRStart Date]
FROM 
	Employee AS M,
	Departments AS D
WHERE
	M.SSN = D.MGRSSN;



--Display All Employees data and the data of their dependents even if they have no dependents

SELECT DISTINCT
	CONCAT(E.Fname, ' ',E.Lname) AS [EmployeeName],
	E.SSN,
	E.Bdate,
	E.Address,
	E.Sex,
	E.Salary,
	E.Superssn,
	E.Dno,
	D.Dependent_name,
	D.Sex as [Dependent_sex],
	D.Bdate AS [Dependent_Bdate]

FROM
	Employee AS E
LEFT OUTER JOIN
	Dependent AS D ON E.SSN = D.ESSN

--Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.

INSERT INTO Employee(Fname,Lname,Address,Dno,SSN,Superssn,Salary)
VALUES ('Mohamed','Fouad','15 New York',30, 102672, 112233, 3000);

Select * FROM Employee
WHERE SSN = 102672;



--Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660,
--but don’t enter any value for salary or supervisor number to him.

INSERT INTO Employee(Fname,Lname,Address,Dno,SSN)
VALUES ('Kareem','Adam','15 New York',30, 102660);

Select * FROM Employee
WHERE SSN = 102660;



--Upgrade your salary by 20 % of its last value.

UPDATE Employee
SET Salary += Salary*0.2
WHERE SSN = 102672;
 
Select * FROM Employee
WHERE SSN = 102672;