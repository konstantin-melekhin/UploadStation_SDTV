/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [SerialNumber]
      ,[LOTID]
      ,[IsUsed]
      ,[IsActive]
      ,[IsUploaded]
      ,[IsWeighted]
      ,[IsPacked]
      ,[InRepair]
  FROM [FAS].[dbo].[FAS_SerialNumbers]
  where SerialNumber = 11224981
 --update [FAS].[dbo].[FAS_SerialNumbers] set IsWeighted = 0, IsPacked = 0 where SerialNumber = 11224981