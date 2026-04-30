use FirstAssignment;
--List all MANAGERS
SELECT * 
FROM EMP
WHERE job = 'MANAGER';
--2. Employees earning > 1000
SELECT ename, sal
FROM EMP
WHERE sal > 1000;

--3. All employees except JAMES
SELECT ename, sal
FROM EMP
WHERE ename <> 'JAMES';

--4. Names starting with ‘S’
SELECT *
FROM EMP
WHERE ename LIKE 'S%';

--5. Names containing ‘A’ anywhere
SELECT ename
FROM EMP
WHERE ename LIKE '%A%';

--6. ‘L’ as 3rd character
SELECT ename
FROM EMP
WHERE ename LIKE '__L%';

--7. Daily salary of JONES
SELECT ename, sal/30 AS Daily_Salary
FROM EMP
WHERE ename = 'JONES';
--8. Total monthly salary
SELECT SUM(sal) AS Total_Salary
FROM EMP;
--9. Average annual salary
SELECT AVG(sal * 12) AS Avg_Annual_Salary
FROM EMP;
--10. Employees except SALESMAN in dept 30
SELECT ename, job, sal, deptno
FROM EMP
WHERE job <> 'SALESMAN'
  AND deptno = 30;
--11. Unique departments in EMP
SELECT DISTINCT deptno
FROM EMP;
--12. Employees >1500 in dept 10 or 30
SELECT ename AS Employee, sal AS [Monthly Salary]
FROM EMP
WHERE sal > 1500
  AND deptno IN (10, 30);
--13. MANAGER or ANALYST
SELECT ename, job, sal
FROM EMP
WHERE job IN ('MANAGER', 'ANALYST')
  AND sal NOT IN (1000, 3000, 5000);
--14. Commission > salary + 10%
SELECT ename, sal, comm
FROM EMP
WHERE comm > sal * 1.10;
--15. Two ‘L’s in name + condition
SELECT ename
FROM EMP
WHERE (ename LIKE '%L%L%' AND deptno = 30)
   OR mgr = 7782;
--16. Experience between 30 and 40 years + count
SELECT ename,
       DATEDIFF(YEAR, hiredate, GETDATE()) AS Experience
FROM EMP
WHERE DATEDIFF(YEAR, hiredate, GETDATE()) BETWEEN 30 AND 40;

-- Count
SELECT COUNT(*) AS Total_Employees
FROM EMP;
--17. Departments ASC, employees DESC
SELECT d.dname, e.ename
FROM DEPT d
JOIN EMP e ON d.deptno = e.deptno
ORDER BY d.dname ASC, e.ename DESC;
--18. Experience of MILLER
SELECT ename,
       DATEDIFF(YEAR, hiredate, GETDATE()) AS Experience
FROM EMP
WHERE ename = 'MILLER';


