/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (10000) [ID]
      ,[Barcode]
      ,[SerialNumber]
      ,[ProductionOrderID]
      ,[ProductID]
      ,[ParentID]
      ,[ProductionAreaID]
      ,[StateCodeID]
      ,[StateCodeDate]
      ,[StateCodeBy]
      ,[RegDate]
      ,[RegBy]
      ,[IsScrap]
      ,[AssemblyNumber]
      ,[LOTID]
      ,[ModelID]
  FROM [PSIGMA.FLAT].[dbo].[TRC_Unit]
  order by id desc