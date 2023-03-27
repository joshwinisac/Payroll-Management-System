CREATE TABLE [dbo].[benefits] (
    [BenefitsID]     VARCHAR (50) NOT NULL,
    [EmployeeID]     VARCHAR (50) NULL,
    [BenefitsType]   VARCHAR (50) NULL,
    [EnrollmentDate] DATE         NULL,
    [ExpirationDate] DATE         NULL,
    [BenefitsAmount] NCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([BenefitsID] ASC)
);

