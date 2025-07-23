--(1) Retrieve number of students who have a value in their age. 
SELECT [Students] = COUNT(*)
FROM Student
WHERE St_Age IS NOT NULL

--(2) Get all instructors Names without repetition
SELECT DISTINCT Ins_Name
FROM Instructor

--(3) Display instructor Name and Department Name Note: display all the instructors if they are attached to a department or not
SELECT Ins_Name, Dept_Name
FROM Instructor AS E,Department AS D
WHERE E.Dept_Id = D.Dept_Id

--(4) Display student full name and the name of the course he is taking For only courses which have a grade
SELECT [FullName] = S.St_Fname + ' ' + S.St_Lname, Crs.Crs_Name

FROM Student AS S JOIN Stud_Course AS C
ON S.St_Id = C.St_Id JOIN Course AS Crs
ON C.Crs_Id = Crs.Crs_Id

WHERE  C.Grade IS NOT NULL

--(5) Display number of courses for each topic name
SELECT T.Top_Name, COUNT(C.Crs_Id) AS Courses

FROM Topic AS T JOIN Course AS C
ON T.Top_Id = C.Top_Id

GROUP BY T.Top_Name


--(6) Select Student first name and the data of his supervisor

SELECT S.St_Fname, I.*
FROM Student AS S JOIN Instructor AS I
ON S.St_super = I.Ins_Id