USE ITI
--1. Create a scalar function that takes date and returns Month name of that date.
CREATE FUNCTION GetMonthNameByDate (@Date DATE)
RETURNS VARCHAR(10)
BEGIN
	IF(MONTH(@Date) = 1)
		RETURN 'January'
	IF(MONTH(@Date) = 2)
		RETURN 'February'
	IF(MONTH(@Date) = 3)
		RETURN 'March'
	IF(MONTH(@Date) = 4)
		RETURN 'April'
	IF(MONTH(@Date) = 5)
		RETURN 'May'
	IF(MONTH(@Date) = 6)
		RETURN 'June'
	IF(MONTH(@Date) = 7)
		RETURN 'July'
	IF(MONTH(@Date) = 8)
		RETURN 'August'
	IF(MONTH(@Date) = 9)
		RETURN 'September'
	IF(MONTH(@Date) = 10)
		RETURN 'October'
	IF(MONTH(@Date) = 11)
		RETURN 'November'
	IF(MONTH(@Date) = 12)
		RETURN 'December'

	RETURN NULL
END

SELECT dbo.GetMonthNameByDate('2005-10-6')

--2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
CREATE FUNCTION BetweenTwoIntegers (@Num1 INT, @Num2 INT)
RETURNS @T1 TABLE (Value INT)
AS
BEGIN
    DECLARE @Temp INT

    IF (@Num1 < @Num2)
    BEGIN
        SET @Temp = @Num1 + 1
        WHILE (@Temp < @Num2)
        BEGIN
            INSERT INTO @T1 VALUES (@Temp)
            SET @Temp = @Temp + 1
        END
    END
    ELSE IF (@Num1 > @Num2)
    BEGIN
        SET @Temp = @Num2 + 1
        WHILE (@Temp < @Num1)
        BEGIN
            INSERT INTO @T1 VALUES (@Temp)
            SET @Temp = @Temp + 1
        END
    END
    RETURN
END

SELECT * FROM BetweenTwoIntegers(0,50)

--3. Create a tabled valued function that takes Student No and returns Department Name with Student full name.
CREATE FUNCTION GetStudentDataByID(@StudentID INT)
RETURNS @T1 TABLE
(
	StudentFullName VARCHAR(MAX),
	DepartmentName VARCHAR(MAX)
)
AS
	BEGIN
		INSERT INTO @T1
		SELECT S.St_Fname + ' ' + S.St_Lname, D.Dept_Name
		FROM Student S JOIN Department D
		ON S.Dept_Id = D.Dept_Id
		WHERE S.St_Id = @StudentID
	END

SELECT * FROM GetStudentDataByID(2222)


/*4. Create a scalar function that takes Student ID and returns a message to
user
a. If first name and Last name are null then display 'First name & last name are null'
b. If First name is null then display 'first name is null'
c. If Last name is null then display 'last name is null'
d. Else display 'First name & last name are not null'
*/
CREATE FUNCTION GetNameStateByID(@StudentID INT)
RETURNS VARCHAR(MAX)
	BEGIN
		DECLARE @FirstTemp VARCHAR(MAX)
		DECLARE @SecondTemp VARCHAR(MAX)

		SELECT @FirstTemp = St_Fname, @SecondTemp = St_Lname
		FROM Student
		WHERE St_Id = @StudentID

		IF(@FirstTemp IS NULL AND @SecondTemp IS NULL)
			RETURN 'First name & last name are null'
		ELSE IF(@FirstTemp IS NULL)
			RETURN 'first name is null'
		ELSE IF(@SecondTemp IS NULL)
			RETURN 'last name is null'
		ELSE
			RETURN 'First name & last name are not null'

		RETURN NULL
	END

SELECT dbo.GetNameStateByID(11)
/*
5. Create a function that takes integer which represents the format of the
Manager hiring date and displays department name, Manager Name and
hiring date with this format.
*/
USE MyCompany
CREATE FUNCTION GetManagerDataByIntegerDate (@IntegerDate INT)
RETURNS @T1 TABLE
(
	DepartmentName VARCHAR(MAX),
	ManagerName VARCHAR(MAX),
	HiringDate VARCHAR(MAX)
)
AS
	BEGIN
		INSERT INTO @T1
		SELECT D.Dname, E.Fname + ' ' + E.Lname, CONVERT(VARCHAR(MAX), D.[MGRStart Date], @IntegerDate)
		FROM Departments D JOIN Employee E 
		ON E.SSN = D.MGRSSN

		RETURN
	END

SELECT * FROM GetManagerDataByIntegerDate(105)

USE ITI
/*
6. Create multi-statements table-valued function that takes a string
If string='first name' returns student first name
If string='last name' returns student last name
If string='full name' returns Full Name from student table
Note: Use “ISNULL” function
*/
CREATE OR ALTER FUNCTION GetStudentNameByChoice (@Choice VARCHAR(10))
RETURNS @T1 TABLE ( Name VARCHAR(MAX))
AS
	BEGIN
		IF(@Choice = 'first name')
			INSERT INTO @T1
			SELECT ISNULL(St_Fname, '')
			FROM Student
		IF(@Choice = 'last name')
			INSERT INTO @T1
			SELECT ISNULL(St_Lname, '')
			FROM Student
		IF(@Choice = 'full name')
			INSERT INTO @T1
			SELECT ISNULL(St_Fname, '') + ' ' + ISNULL(St_Lname, '')
			FROM Student

		RETURN
	END

SELECT * FROM GetStudentNameByChoice('first name')
SELECT * FROM GetStudentNameByChoice('last name')
SELECT * FROM GetStudentNameByChoice('full name')


USE MyCompany
/*
Note: Use MyCompany DB
1. Create function that takes project number and display all employees in this
project.
*/

CREATE OR ALTER FUNCTION GetEmployeesByProjectID (@ProjectID INT)
RETURNS @T1 TABLE
(
	ID INT,
	FullName VARCHAR(MAX),
	Gender VARCHAR(50),
	Salary INT,
	ProjectName VARCHAR(MAX),
	ProjectID INT
)
AS
	BEGIN
		INSERT INTO @T1
		SELECT
			E.SSN,
			E.Fname + ' ' + E.Lname,
			E.Sex,
			E.Salary,
			P.Pname,
			p.Pnumber
		FROM Employee E JOIN Departments D
		ON D.Dnum = E.Dno JOIN Project P
		ON P.Dnum = D.Dnum
		WHERE P.Pnumber = @ProjectID

		RETURN
	END

SELECT * FROM GetEmployeesByProjectID (600)