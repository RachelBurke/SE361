CREATE TABLE [dbo].[tblTransactions] (
    [transactionDate]   DATETIME2 (7) NOT NULL,
    [accountName]       VARCHAR (50)  NOT NULL,
    [transactionType]   VARCHAR (50)  NOT NULL,
    [transactionAmount] DECIMAL (18)  NOT NULL,
    [orderOf]           VARCHAR (50)  NOT NULL,
    [transactionId]     VARCHAR (100) NOT NULL
);
