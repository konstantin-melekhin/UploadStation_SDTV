/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [SerialNumber]
      ,[MAC]
      ,[LineID]
      ,[SmartCardID]
      ,[CASID]
      ,[SWversion]
      ,[SWGS1version]
      ,[LDS]
      ,[UploadDate]
      ,[UploadByID]
  FROM [FAS].[dbo].[FAS_Upload]

  --delete [FAS].[dbo].[FAS_Upload] where SmartCardID = 45040905333567