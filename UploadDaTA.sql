/****** Script for SelectTopNRows command from SSMS  *****/
use fas
declare @sernum as int
select @sernum = 11224387

SELECT TOP (1000) [SerialNumber],[PCBID],[LineID],[FullSTBSN],[ManufDate]
,[AssemblyDate],[AssemblyByID],[PrintStationID]
  FROM [FAS].[dbo].[FAS_Start]
where SerialNumber = @sernum

SELECT h.HDCPName, h.HDCPPath, c.CERTName, c.CERTPath,[FullSTBSN],Format([ManufDate],'dd.MM.yyyy', 'de-de'),
 Format([ManufDate],'HH:mm:ss', 'de-de')
 FROM [FAS].[dbo].[FAS_Start] as FSt
 left join FAS_HDCP as H on H.SerialNumber = FSt.SerialNumber
 left join FAS_CERT as C on C.SerialNumber = FSt.SerialNumber
 where FSt.SerialNumber = @sernum

 SELECT TOP (1000) [SerialNumber],[HDCPName],[HDCPPath]
  FROM [FAS].[dbo].[FAS_HDCP]
  where SerialNumber = @sernum

  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT  [SerialNumber],[CERTName],[CERTPath]
  FROM [FAS].[dbo].[FAS_CERT]
  where SerialNumber =@sernum