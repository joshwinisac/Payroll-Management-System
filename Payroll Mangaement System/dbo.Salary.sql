CREATE TABLE [dbo].[Salary] (
    [SalaryID]     VARCHAR (50)    NOT NULL,
    [EmployeeID]   VARCHAR (50)  NOT NULL,
    [SalaryAmount] NUMERIC (18, 3) NULL,
    [dept_name]    VARCHAR (50)    NULL,
    [SalaryDate]   DATE            NULL,
    CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED ([SalaryID] ASC), 
    CONSTRAINT [FK_Salary_sampemp] FOREIGN KEY ([EmployeeID]) REFERENCES [Salary]([EmployeeID]),
	);

