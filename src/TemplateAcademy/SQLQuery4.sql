SELECT Top 1 [p].[ProductID] AS [Id], [p].[ProductName] AS [Name], (
          SELECT  ISNULL(SUM(CAST([o].[Quantity] AS int)), 0)
          FROM [Order Details] AS [o]
          WHERE [p].[ProductID] = [o].[ProductID]) AS [TotalQuantityOrdered]
          FROM [Products] AS [p]
          Order BY [TotalQuantityOrdered] Desc
