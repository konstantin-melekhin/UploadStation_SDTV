/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [SerialNumber]
      ,[LiterID]
      ,[LiterIndex]
      ,[PalletNum]
      ,[BoxNum]
      ,[UnitNum]
      ,[PackingDate]
      ,[PackingByID]
  FROM [FAS].[dbo].[FAS_PackingGS]

  --truncate table [FAS].[dbo].[FAS_PackingGS]
