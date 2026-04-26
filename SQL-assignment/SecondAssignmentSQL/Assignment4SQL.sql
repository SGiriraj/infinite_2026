-- 1. Factorial of a given number
DECLARE @num INT = 5;   
DECLARE @fact BIGINT = 1;

WHILE @num > 0
BEGIN
    SET @fact = @fact * @num;
    SET @num = @num - 1;
END

SELECT @fact AS Factorial;

--2. Multiplication Table
go
CREATE OR ALTER PROCEDURE sp_MultiplicationTable
    @num INT,
    @limit INT
AS
BEGIN
    DECLARE @i INT = 1;

    WHILE @i <= @limit
    BEGIN
        PRINT CONCAT(@num, ' x ', @i, ' = ', @num * @i);
        SET @i = @i + 1;
    END
END;
go;
EXEC sp_MultiplicationTable 5, 10;
--3. Function + Tables for Student Status
CREATE TABLE Student (
    Sid INT PRIMARY KEY,
    Sname VARCHAR(20)
);

CREATE TABLE Marks (
    Mid INT PRIMARY KEY,
    Sid INT,
    Score INT,
    FOREIGN KEY (Sid) REFERENCES Student(Sid)
);

INSERT INTO Student VALUES
(1, 'Jack'),
(2, 'Rithvik'),
(3, 'Jaspreeth'),
(4, 'Praveen'),
(5, 'Bisa'),
(6, 'Suraj');

INSERT INTO Marks VALUES
(1, 1, 23),
(2, 6, 95),
(3, 4, 98),
(4, 2, 17),
(5, 3, 53),
(6, 5, 13);
go
CREATE OR ALTER FUNCTION fn_GetStatus(@score INT)
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @result VARCHAR(10);

    IF @score >= 50
        SET @result = 'PASS';
    ELSE
        SET @result = 'FAIL';

    RETURN @result;
END;
go;
SELECT 
    s.Sid,
    s.Sname,
    m.Score,
    dbo.fn_GetStatus(m.Score) AS Status
FROM Student s
JOIN Marks m ON s.Sid = m.Sid;