--(1)
CREATE OR ALTER PROCEDURE GetMonthNameByDate_SP @Date DATE, @MonthName VARCHAR(20) OUTPUT
AS
BEGIN
    SET @MonthName = DATENAME(MONTH, @Date)
END
GO

DECLARE @MonthName VARCHAR(20)
EXEC GetMonthNameByDate_SP '2005-11-06', @MonthName OUTPUT
PRINT @MonthName
GO

--(2)
CREATE OR ALTER PROCEDURE BetweenTwoIntegers_SP @Num1 INT, @Num2 INT
AS
BEGIN
    DECLARE @Temp INT

    IF (@Num1 < @Num2)
    BEGIN
        SET @Temp = @Num1 + 1
        WHILE (@Temp < @Num2)
        BEGIN
            SELECT @Temp AS Value
            SET @Temp += 1
        END
    END
    ELSE IF (@Num1 > @Num2)
    BEGIN
        SET @Temp = @Num2 + 1
        WHILE (@Temp < @Num1)
        BEGIN
            SELECT @Temp AS Value
            SET @Temp += 1
        END
    END
END
GO

EXEC BetweenTwoIntegers_SP 0, 5
GO

--(3)
CREATE OR ALTER PROCEDURE GetStudentDataByID_SP @StudentID INT
AS
BEGIN
    SELECT S.St_Fname + ' ' + S.St_Lname AS StudentFullName, D.Dept_Name AS DepartmentName
    FROM Student S JOIN Department D
	ON S.Dept_Id = D.Dept_Id
    WHERE S.St_Id = @StudentID
END
GO

EXEC GetStudentDataByID_SP 2222
GO

--(4)
CREATE OR ALTER PROCEDURE GetNameStateByID_SP @StudentID INT, @Message VARCHAR(MAX) OUTPUT
AS
BEGIN
    DECLARE @FName VARCHAR(MAX), @LName VARCHAR(MAX)

    SELECT @FName = St_Fname, @LName = St_Lname
    FROM Student
    WHERE St_Id = @StudentID

    IF @FName IS NULL AND @LName IS NULL
        SET @Message = 'First name & last name are null'
    ELSE IF @FName IS NULL
        SET @Message = 'first name is null'
    ELSE IF @LName IS NULL
        SET @Message = 'last name is null'
    ELSE
        SET @Message = 'First name & last name are not null'
END
GO

DECLARE @Msg VARCHAR(MAX)
EXEC GetNameStateByID_SP 11, @Msg OUTPUT
PRINT @Msg
GO

--(5)
USE MyCompany
GO
CREATE OR ALTER PROCEDURE GetManagerDataByIntegerDate_SP
    @IntegerDate INT
AS
BEGIN
    SELECT D.Dname AS DepartmentName, E.Fname + ' ' + E.Lname AS ManagerName, 
	CONVERT(VARCHAR(MAX), D.[MGRStart Date], @IntegerDate) AS HiringDate

    FROM Departments D JOIN Employee E
	ON E.SSN = D.MGRSSN
END
GO

EXEC GetManagerDataByIntegerDate_SP 105
GO



--(6)
USE ITI
GO
CREATE OR ALTER PROCEDURE GetStudentNameByChoice_SP @Choice VARCHAR(10)
AS
BEGIN
    IF @Choice = 'first name'
    BEGIN
        SELECT ISNULL(St_Fname, '') AS Name
        FROM Student
    END
    ELSE IF @Choice = 'last name'
    BEGIN
        SELECT ISNULL(St_Lname, '') AS Name
        FROM Student
    END
    ELSE IF @Choice = 'full name'
    BEGIN
        SELECT ISNULL(St_Fname, '') + ' ' + ISNULL(St_Lname, '') AS Name
        FROM Student
    END
END
GO

EXEC GetStudentNameByChoice_SP 'first name'
EXEC GetStudentNameByChoice_SP 'last name'
EXEC GetStudentNameByChoice_SP 'full name'
GO



--(7)
USE MyCompany
GO
CREATE OR ALTER PROCEDURE GetEmployeesByProjectID_SP @ProjectID INT
AS
BEGIN
    SELECT E.SSN AS ID,
           E.Fname + ' ' + E.Lname AS FullName,
           E.Sex AS Gender,
           E.Salary,
           P.Pname AS ProjectName,
           P.Pnumber AS ProjectID
    FROM Employee E JOIN Departments D
	ON D.Dnum = E.Dno JOIN Project P
	ON P.Dnum = D.Dnum
    WHERE P.Pnumber = @ProjectID
END
GO

EXEC GetEmployeesByProjectID_SP 600
GO
