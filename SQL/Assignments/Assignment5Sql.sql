use FirstDay;
--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition
go
CREATE OR ALTER PROCEDURE sp_GeneratePayslip
    @EmpId INT
AS
BEGIN
    DECLARE 
        @Name VARCHAR(50),
        @Salary DECIMAL(10,2),
        @HRA DECIMAL(10,2),
        @DA DECIMAL(10,2),
        @PF DECIMAL(10,2),
        @IT DECIMAL(10,2),
        @Deductions DECIMAL(10,2),
        @Gross DECIMAL(10,2),
        @Net DECIMAL(10,2)

    
    SELECT 
        @Name = EmpName,
        @Salary = Salary
    FROM Employee
    WHERE EmpId = @EmpId

    -- Calculations
    SET @HRA = @Salary * 0.10
    SET @DA  = @Salary * 0.20
    SET @PF  = @Salary * 0.08
    SET @IT  = @Salary * 0.05

    SET @Deductions = @PF + @IT
    SET @Gross = @Salary + @HRA + @DA
    SET @Net = @Gross - @Deductions

   
    PRINT '------ PAYSLIP ------'
    PRINT 'Employee ID   : ' + CAST(@EmpId AS VARCHAR)
    PRINT 'Employee Name : ' + @Name
    PRINT 'Salary        : ' + CAST(@Salary AS VARCHAR)

    PRINT '--- Allowances ---'
    PRINT 'HRA (10%)     : ' + CAST(@HRA AS VARCHAR)
    PRINT 'DA (20%)      : ' + CAST(@DA AS VARCHAR)

    PRINT '--- Deductions ---'
    PRINT 'PF (8%)       : ' + CAST(@PF AS VARCHAR)
    PRINT 'IT (5%)       : ' + CAST(@IT AS VARCHAR)
    PRINT 'Total Deduct  : ' + CAST(@Deductions AS VARCHAR)

    PRINT '--- Summary ---'
    PRINT 'Gross Salary  : ' + CAST(@Gross AS VARCHAR)
    PRINT 'Net Salary    : ' + CAST(@Net AS VARCHAR)
END
select * from Employee;
EXEC sp_GeneratePayslip 106
--2.  Create a trigger to restrict data manipulation on EMP table
--during General holidays.
--Display the error message like “Due to Independence day you cannot manipulate data” or
--"Due To Diwali", you cannot manipulate" etc

use Firstday;
select * from holiday;
go
CREATE OR ALTER TRIGGER trg_RestrictHoliday
ON Employee
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @Today DATE = CAST(GETDATE() AS DATE)

    IF EXISTS (
        SELECT 1 
        FROM Holiday 
        WHERE holiday_date = @Today
    )
    BEGIN
        DECLARE @HolidayName VARCHAR(50)

        SELECT TOP 1 @HolidayName = holiday_name
        FROM Holiday
        WHERE holiday_date = @Today

        RAISERROR ('Due to %s you cannot manipulate data', 16, 1, @HolidayName)

        ROLLBACK TRANSACTION
    END
END
