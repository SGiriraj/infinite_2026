USE FirstAssignment;
GO

CREATE TABLE Clients (
    Client_ID INT PRIMARY KEY,
    Cname VARCHAR(40) NOT NULL,
    Address VARCHAR(30),
    Email VARCHAR(30) UNIQUE,
    Phone BIGINT,
    Business VARCHAR(20) NOT NULL
);
CREATE TABLE Departments (
    Deptno int PRIMARY KEY,
    Dname VARCHAR(15) NOT NULL,
    Loc VARCHAR(20)
);

CREATE TABLE Employees (
    Empno int PRIMARY KEY,
    Ename VARCHAR(20) NOT NULL,
    Job VARCHAR(15),
    Salary int CHECK (Salary > 0),
    Deptno int,
    CONSTRAINT fk_dept FOREIGN KEY (Deptno)
    REFERENCES Departments(Deptno)
);
CREATE TABLE Projects (
    Project_ID int PRIMARY KEY,
    Descr VARCHAR(30) NOT NULL,
    Start_Date DATE,
    Planned_End_Date DATE,
    Actual_End_Date DATE,
    CONSTRAINT chk_dates CHECK (Actual_End_Date > Planned_End_Date)
);
CREATE TABLE EmpProjectTasks (
    Empno int,
    Project_ID int,
    Task VARCHAR(30),
    Hours_Worked int,
    CONSTRAINT pk_emp_proj PRIMARY KEY (Empno, Project_ID),
    CONSTRAINT fk_emp FOREIGN KEY (Empno) REFERENCES Employees(Empno),
    CONSTRAINT fk_proj FOREIGN KEY (Project_ID) REFERENCES Projects(Project_ID)
);
INSERT INTO Clients VALUES (1, 'Infosys', 'Bangalore', 'abc@gmail.com', 9876543210, 'Manufacturer');
INSERT INTO Clients VALUES (2, 'TCS', 'Chennai', 'xyz@gmail.com', 9123456780, 'Consultant');
INSERT INTO Departments VALUES (10, 'HR', 'Bangalore');
INSERT INTO Departments VALUES (20, 'IT', 'Chennai');

INSERT INTO Employees VALUES (101, 'Ravi', 'Manager', 50000, 10);
INSERT INTO Employees VALUES (102, 'Anu', 'Developer', 40000, 20);

INSERT INTO Projects VALUES 
(1, 'Accounting', '2024-01-01', '2024-06-01', '2024-06-10');

INSERT INTO Projects VALUES 
(2, 'Inventory', '2024-02-01', '2024-07-01', '2024-07-05');

INSERT INTO EmpProjectTasks VALUES (101, 1, 'Design', 120);
INSERT INTO EmpProjectTasks VALUES (102, 2, 'Development', 200);
-- View all clients
SELECT * FROM Clients;

-- View employees with department
SELECT e.Empno, e.Ename, d.Dname
FROM Employees e
JOIN Departments d ON e.Deptno = d.Deptno;

-- View projects
SELECT * FROM Projects;

-- Employee project details
SELECT e.Ename, p.Descr, t.Task, t.Hours_Worked
FROM EmpProjectTasks t
JOIN Employees e ON t.Empno = e.Empno
JOIN Projects p ON t.Project_ID = p.Project_ID;