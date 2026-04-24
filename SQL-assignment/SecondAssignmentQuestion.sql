use FirstAssignment;
CREATE TABLE DEPT (
    deptno INT PRIMARY KEY,
    dname VARCHAR(20),
    loc VARCHAR(20)
);
CREATE TABLE EMP (
    empno INT PRIMARY KEY,
    ename VARCHAR(20),
    job VARCHAR(20),
    mgr INT NULL,
    hiredate DATE,
    sal INT,
    comm INT NULL,
    deptno INT,
    FOREIGN KEY (deptno) REFERENCES DEPT(deptno)
);
INSERT INTO DEPT VALUES
(10, 'ACCOUNTING', 'MUMBAI'),
(20, 'RESEARCH', 'BENGALURU'),
(30, 'SALES', 'CHENNAI'),
(40, 'OPERATIONS', 'DELHI');
INSERT INTO EMP VALUES
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);
--1. Employees whose name begins with 'A'
SELECT * 
FROM EMP
WHERE ename LIKE 'A%';
--2. Employees who don’t have a manager
SELECT * 
FROM EMP
WHERE mgr IS NULL;
--3. Employees with salary between 1200 and 1400
SELECT empno, ename, sal
FROM EMP
WHERE sal BETWEEN 1200 AND 1400;
--4. Give RESEARCH dept employees 10% raise + verify
--Before update
SELECT * 
FROM EMP
WHERE deptno = (
    SELECT deptno FROM DEPT WHERE dname = 'RESEARCH'
);
--Update
UPDATE EMP
SET sal = sal * 1.10
WHERE deptno = (
    SELECT deptno FROM DEPT WHERE dname = 'RESEARCH'
);
--After update
SELECT * 
FROM EMP
WHERE deptno = (
    SELECT deptno FROM DEPT WHERE dname = 'RESEARCH'
);
--5. Number of CLERKS
SELECT COUNT(*) AS Number_of_Clerks
FROM EMP
WHERE job = 'CLERK';
--6. Avg salary & count per job
SELECT job, AVG(sal) AS Avg_Salary, COUNT(*) AS Employee_Count
FROM EMP
GROUP BY job;
--7. Employees with lowest & highest salary
SELECT *
FROM EMP
WHERE sal = (SELECT MIN(sal) FROM EMP)
   OR sal = (SELECT MAX(sal) FROM EMP);
--8. Departments with no employees
SELECT *
FROM DEPT d
WHERE NOT EXISTS (
    SELECT 1 FROM EMP e WHERE e.deptno = d.deptno
);
--9. Analysts earning >1200 in dept 20 (sorted)
SELECT ename, sal
FROM EMP
WHERE job = 'ANALYST'
  AND sal > 1200
  AND deptno = 20
ORDER BY ename ASC;
--10. Dept name, number & total salary
SELECT d.deptno, d.dname, SUM(e.sal) AS Total_Salary
FROM DEPT d
LEFT JOIN EMP e ON d.deptno = e.deptno
GROUP BY d.deptno, d.dname;
--11. Salary of MILLER and SMITH
SELECT ename, sal
FROM EMP
WHERE ename IN ('MILLER', 'SMITH');

--12. Names starting with A or M
SELECT ename
FROM EMP
WHERE ename LIKE 'A%' OR ename LIKE 'M%';
--13. Yearly salary of SMITH
SELECT ename, sal * 12 AS Yearly_Salary
FROM EMP
WHERE ename = 'SMITH';
--14. Employees NOT in salary range 1500–2850
SELECT ename, sal
FROM EMP
WHERE sal NOT BETWEEN 1500 AND 2850;
--15. Managers with more than 2 employees reporting
SELECT mgr, COUNT(*) AS Employee_Count
FROM EMP
WHERE mgr IS NOT NULL
GROUP BY mgr
HAVING COUNT(*) > 2;

