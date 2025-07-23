--(1)
USE ITI
GO

CREATE OR ALTER PROCEDURE GetStudentsPerDepartment
AS
BEGIN
    SELECT D.Dept_Name, COUNT(S.St_Id) AS NumberOfStudents
    FROM Department D JOIN Student S
	ON D.Dept_Id = S.Dept_Id
    GROUP BY D.Dept_Name;
END
GO

EXEC GetStudentsPerDepartment
GO

--(2)
USE MyCompany
GO

CREATE OR ALTER PROCEDURE CheckEmployeesInProject
AS
BEGIN
    DECLARE @ProjectID INT;
    SELECT @ProjectID = Pnumber FROM Project WHERE Pname = 'AL Solimaniah';

    DECLARE @EmpCount INT;
    SELECT @EmpCount = COUNT(*) FROM Works_for WHERE Pno = @ProjectID;

    IF @EmpCount >= 3
    BEGIN
        PRINT 'The number of employees in the project p1 is 3 or more';
    END
    ELSE
    BEGIN
        PRINT 'The following employees work for the project p1';
        SELECT E.FName + ' ' + E.LName AS FullName
        FROM Employee E JOIN Works_for W
		ON E.SSN = W.ESSn
        WHERE W.Pno = @ProjectID;
    END
END
GO

EXEC CheckEmployeesInProject
GO


--(3)
CREATE OR ALTER PROCEDURE ReplaceEmployeeInProject @OldEmpID INT, @NewEmpID INT, @ProjectID INT
AS
BEGIN
    DELETE FROM Works_for
    WHERE ESSn = @OldEmpID AND Pno = @ProjectID;

    INSERT INTO Works_for(ESSn, Pno)
    VALUES (@NewEmpID, @ProjectID);
END
GO