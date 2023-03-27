CREATE TABLE [dbo].[EmpData] (
    [EmployeeID]     INT          NOT NULL,
    [EmployeeName]   VARCHAR (50) NOT NULL,
    [Salary]         NUMERIC (18) NULL,
    [BenefitsAmount] NUMERIC (18) NULL,
    [PayrollAmount]  NUMERIC (18) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

