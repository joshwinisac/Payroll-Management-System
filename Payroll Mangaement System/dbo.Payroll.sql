CREATE TABLE [dbo].[Payroll] (
    [PayrollID]     VARCHAR (50)    NOT NULL,
    [EmployeeID]    VARCHAR (50)    NOT NULL,
    [GrossPay]      NUMERIC (18, 2) NULL,
    [Deductions]    NUMERIC (18, 2) NULL,
    [NetPay]        NUMERIC (18, 2) NULL,
    [PaymentMethod] VARCHAR (50)    NULL,
    CONSTRAINT [PK_Payroll] PRIMARY KEY CLUSTERED ([PayrollID] ASC),
    CONSTRAINT [FK_Payroll_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

