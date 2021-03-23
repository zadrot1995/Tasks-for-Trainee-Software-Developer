CREATE TABLE [dbo].[Products] (
    [ProductID]   INT          NOT NULL,
    [ProductName] TEXT NOT NULL, 
    [SupplierID] INT NOT NULL,
    [CategoryID] INT NOT NULL,
    [Price]       SMALLMONEY   NOT NULL,


    PRIMARY KEY CLUSTERED ([ProductID] ASC), 
    CONSTRAINT [FK_CategoryID] FOREIGN KEY ([CategoryID]) REFERENCES [Categories]([CategoryID]), 
    CONSTRAINT [FK_SupplierID] FOREIGN KEY ([SupplierID]) REFERENCES [Suppliers]([SupplierID])
);
