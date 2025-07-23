--(1)Insert your personal data to the Student table as a new Student in department number 30.
INSERT INTO Student(St_Id,St_Fname,St_Lname,St_Age,Dept_Id)
VALUES(45,'Ali','Emad',20,30)

SELECT * FROM Student


--(2)Insert Instructor with personal data of your friend as new Instructor in department number 30, Salary= 4000, but don’t enter any value for bonus.
INSERT INTO Instructor(Ins_Id,Ins_Name,Ins_Degree,Salary,Dept_Id)
VALUES(9573,'Omar Ahmed','Bachelor',4000,30)

SELECT * FROM Instructor

--(3)Upgrade Instructor salary by 20 % of its last value.
UPDATE Instructor
SET Salary = Salary*1.2
WHERE Ins_Id = 9573

SELECT * FROM Instructor
