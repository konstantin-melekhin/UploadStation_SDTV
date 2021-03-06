--/****** Script for SelectTopNRows command from SSMS  ******/
--use fas

--select * FROM [FAS].[dbo].[FAS_SerialNumbers] where SerialNumber = 11224981

--select * FROM [FAS].[dbo].[FAS_Start] where SerialNumber = 11224982

--SELECT *  FROM [FAS].[dbo].[FAS_Upload] as UP

--select * FROM [FAS].[dbo].[FAS_PackingGS] 
  
----insert into  [FAS].[dbo].[FAS_PackingGS] ( [SerialNumber],[LiterID],[LiterIndex],[PalletNum],[BoxNum],[UnitNum],[PackingDate],[PackingByID]) values
----(11224981, 2,0,1,1,1,CURRENT_TIMESTAMP, 11)

Use FAS 
SELECT Un.Barcode, Fst.FullSTBSN,[SmartCardID], L.LineName,FORMAT([UploadDate],'dd.MM.yyyy HH:mm:ss', 'de-de') as 'Upload Date',u.UserName,
sn.IsPacked, lit.LiterName,[LiterIndex],[PalletNum],[BoxNum],[UnitNum],FORMAT([PackingDate],'dd.MM.yyyy HH:mm:ss', 'de-de') as 'Packing Date', Us.UserName
FROM [FAS].[dbo].[FAS_Upload] As UpSt
left join FAS_SerialNumbers as SN On sn.SerialNumber = UpSt.SerialNumber
left join FAS_Lines as L on L.LineID = UpSt.LineID
left join FAS_Start As FSt on Fst.SerialNumber = UpSt.SerialNumber
left join [PSIGMA.FLAT].[dbo].[TRC_Unit]as Un on Un.ID = Fst.PCBID
left join FAS_PackingGS As Pack On Pack.SerialNumber = UpSt.SerialNumber
left join FAS_Users as U on U.UserID = UpSt.UploadByID
left join FAS_Users as Us on Us.UserID = Pack.PackingByID
left join FAS_Liter as Lit On lit.ID = pack.LiterID
where UpSt.SmartCardID = 45040905333567



--Use FAS 
--SELECT Fst.FullSTBSN,l.LiterName,[LiterIndex],[PalletNum],[BoxNum],[UnitNum],FORMAT([PackingDate],'dd.MM.yyyy HH:mm:ss', 'de-de') as 'Packing Date', U.UserName
--FROM [FAS].[dbo].[FAS_PackingGS] As Pack
--left join FAS_Upload as UpSt On UpSt.SerialNumber = Pack.SerialNumber
--left join FAS_Start As FSt on Fst.SerialNumber = Pack.SerialNumber
--left join FAS_Users as U on U.UserID = Pack.PackingByID

--where UpSt.SmartCardID = 45040905333567