CREATE TABLE [dbo].[Employees] (
    [EmployeeID]      VARCHAR (50) NOT NULL,
    [EmployeeName]    VARCHAR (50) NULL,
    [EmployeeAddress] VARCHAR (50) NULL,
    [EmployeePhone]   VARCHAR (50) NULL,
    [EmployeeEmail]   VARCHAR (50) NULL,
    [dept_name]       NCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

