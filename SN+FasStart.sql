/****** Script for SelectTopNRows command from SSMS  ******/
use fas
SELECT top 200 sn.[SerialNumber]
      ,ST.FullSTBSN
	  ,[LOTID]
      ,[IsUsed]
      ,[IsActive]
      ,[IsUploaded]
      ,[IsWeighted]
      ,[IsPacked]
      ,[InRepair]
  FROM [FAS].[dbo].[FAS_SerialNumbers] as SN
  left join FAS_Start as ST On ST.SerialNumber = SN.SerialNumber
  where LOTID = 15
  order by sn.SerialNumber 

Use FAS Select Top 1 SerialNumber FROM [FAS].[dbo].[FAS_SerialNumbers] order by SerialNumber 

--update [FAS].[dbo].[FAS_SerialNumbers] set IsActive = 0, InRepair = 0 where SerialNumber = 11224964