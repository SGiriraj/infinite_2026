CREATE DATABASE Employeemanagement;
USE Employeemanagement;
CREATE TABLE Employee_Details
(
    Empno INT,

    EmpName VARCHAR(50) NOT NULL,

    Empsal DECIMAL(10,2),

    Emptype CHAR(1),

    CONSTRAINT PK_Employee PRIMARY KEY (Empno),

    CONSTRAINT CHK_Salary
    CHECK (Empsal >= 25000),

    CONSTRAINT CHK_Type
    CHECK (Emptype='F' OR Emptype='P')
);
go
CREATE PROCEDURE sp_InsertEmployee
(
    @EmpName VARCHAR(50),
    @Empsal DECIMAL(10,2),
    @Emptype CHAR(1)
)
AS
BEGIN

    DECLARE @Empno INT

    SELECT @Empno = ISNULL(MAX(Empno),0)+1
    FROM Employee_Details

    INSERT INTO Employee_Details
    VALUES(@Empno,@EmpName,@Empsal,@Emptype)

END
go;
EXEC sp_InsertEmployee
'Giri',
45000,
'F'
EXEC sp_InsertEmployee
'Ravi',
30000,
'P'

EXEC sp_InsertEmployee
'Arun',
55000,
'F'

EXEC sp_InsertEmployee
'Sneha',
40000,
'P'
select * from Employee_Details;
