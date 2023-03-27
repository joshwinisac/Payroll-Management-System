CREATE TABLE [dbo].[TimeAndAttendance] (
    [TimeID]     VARCHAR (50) NOT NULL,
    [EmployeeID] VARCHAR (50) NOT NULL,
    [ClockIn]    TIME (7)     NULL,
    [ClockOut]   TIME (7)     NULL,
    [leave]      NUMERIC (10) NULL,
    CONSTRAINT [PK_TimeAndAttendance] PRIMARY KEY CLUSTERED ([TimeID] ASC),
    CONSTRAINT [FK_TimeAndAttendance_Employees] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([EmployeeID])
);

