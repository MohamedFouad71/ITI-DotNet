


USE Company_SD;

--1.Display (Using Union Function)
	--The name and the gender of the dependence that's gender is Female and depending on Female Employee.
	--And the male dependence that depends on Male Employee.

SELECT 
	D.Dependent_name,
	D.Sex
FROM Dependent D INNER JOIN Employee E
ON D.ESSN = E.SSN
WHERE E.Sex = 'M' AND D.Sex = 'M'

UNION

SELECT 
	D.Dependent_name,
	D.Sex
FROM Dependent D INNER JOIN Employee E
ON D.ESSN = E.SSN
WHERE E.Sex = 'F' AND D.Sex = 'F'; 



--2.For each project, list the project name and the total hours per week (for all employees) spent on that project.

SELECT 
	P.Pname,
	Sum(W.Hours)
FROM 
	Project P,
	Works_for W
WHERE P.Pnumber = W.Pno
GROUP BY P.Pname


--3.Display the data of the department which has the smallest employee ID over all employees' ID.

SELECT * FROM Departments D
WHERE D.Dnum =
(
	SELECT E.Dno FROM Employee E
	WHERE E.SSN = (SELECT MIN(E.SSN) FROM Employee E)
)


--4.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

SELECT 
	D.Dname,
	MAX(E.Salary) MaxSalary,
	MIN(E.Salary) MinSalary,
	AVG(ISNULL(E.Salary , 0)) AverageSalary
FROM 
	Departments D,
	Employee E
WHERE
	E.Dno = D.Dnum
GROUP BY D.Dname

--5.List the full name of all managers who have no dependents.

SELECT CONCAT(E.Fname, ' ', E.Lname) AS FullName
FROM 
	Employee E 
INNER JOIN
	Departments ON E.SSN = Departments.MGRSSN
LEFT JOIN 
	Dependent ON E.SSN = Dependent.ESSN
WHERE
	Dependent.ESSN IS NULL;


--6.For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.




SELECT
	D.Dnum,
	D.Dname,
	COUNT(E.Salary)	AS NumberOfEmployess
FROM 
	Departments D
INNER JOIN 
	Employee E ON Dnum = E.Dno
GROUP BY
	D.Dnum,
	Dname
HAVING AVG(ISNULL(E.Salary , 0)) > (SELECT AVG(ISNULL(E.Salary, 0)) FROM Employee E)


/*
7.Retrieve a list of employees names and the projects names they are working on ordered by department number
and within each department, ordered alphabetically by last name, first name.
*/


SELECT 
	CONCAT(E.Fname, ' ', E.Lname) AS [Employee Name],
	P.Pname AS [Project Name]
FROM 
	Employee E,
	Project P,
	Works_for W
WHERE 
	W.Pno = P.Pnumber AND
	W.ESSn = E.SSN
ORDER BY 
	E.Dno,
	[Employee Name];

--8.Try to get the max 2 salaries using subquery

SELECT MAX(E.Salary) AS [Top Salaries] FROM Employee E 

UNION

SELECT MAX(E.Salary) FROM Employee E
Where Salary < (SELECT MAX(E.Salary) FROM Employee E)

--9.Get the full name of employees that is similar to any dependent name

SELECT CONCAT(E.Fname, ' ', E.Lname) AS [Full Name]
FROM 
	Employee E 
Where 
	CONCAT(E.Fname, ' ', E.Lname) in (SELECT D.Dependent_name FROM Dependent D);

--10.Display the employee number and name if at least one of them have dependents.

SELECT 
	E.SSN,
	CONCAT(E.Fname, ' ', E.Lname) AS [Full Name]
FROM 
	Employee E
WHERE EXISTS (SELECT 1 FROM Dependent D WHERE D.ESSN = E.SSN)


/*
11.In the department table insert new department called "DEPT IT" ,
	with id 100, employee with SSN = 112233 as a manager for this department
.	The start date for this manager is '1-11-2006'
*/

INSERT INTO Departments(Dname, Dnum, MGRSSN, [MGRStart Date])
VALUES ('DEPT IT', 100, 112233,1-11-2006)


/*
12.Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100),
	and they give you(your SSN =102672) her position (Dept. 20 manager) 

		=First try to update her record in the department table
		=Update your record to be department 20 manager.
		=Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)

*/

GO 

UPDATE Departments 
SET MGRSSN = 968574
WHERE Departments.Dnum = 100;

GO

UPDATE Departments
SET MGRSSN = 102672
WHERE Departments.Dnum = 20;

GO

UPDATE Employee
SET Superssn = 102672
WHERE Employee.SSN = 102660

/*
13.Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database
in case you know that you will be temporarily in his position.
Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects and handle these cases).

*/

SELECT * FROM Dependent WHERE ESSN = 223344;

SELECT * FROM Departments WHERE MGRSSN = 223344;

SELECT * FROM Works_for WHERE Works_for.ESSn = 223344;

SELECT * FROM Employee WHERE Superssn = 223344;




UPDATE Employee
SET Superssn = 102672 
WHERE Superssn = 223344

UPDATE Departments 
SET MGRSSN = 102672
WHERE MGRSSN = 223344;

UPDATE Works_for
SET ESSn = 102672
WHERE ESSn = 223344;

DELETE FROM Dependent WHERE ESSN = 223344;




DELETE FROM Employee WHERE SSN = 223344



--14.Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%

UPDATE E
SET Salary *= 1.3
FROM 
	Employee E
INNER JOIN 
	Works_for W
ON W.ESSn = E.SSN
INNER JOIN 
	Project P
ON P.Pnumber = W.Pno
WHERE P.Pname = 'Al Rabwah';