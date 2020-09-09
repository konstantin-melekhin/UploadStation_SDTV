use fas
                SELECT fst.FullSTBSN, H.HDCPName, h.HDCPPath, c.CERTName, c.CERTPath,[FullSTBSN],Format([ManufDate],'dd.MM.yyyy', 'de-de'),
                Format([ManufDate],'HH:mm:ss', 'de-de' ), HDCPContent, CertContent
                FROM [FAS].[dbo].[FAS_Start] as FSt
                left join FAS_HDCP as H on H.SerialNumber = FSt.SerialNumber
                left join FAS_CERT as C on C.SerialNumber = FSt.SerialNumber
                where FSt.SerialNumber = 11224435

use fas 
SELECT CONVERT( nvarchar(316),  HDCPContent)
FROM [FAS].[dbo].[FAS_HDCP] where SerialNumber = 11224435
use fas 
SELECT CertContent
FROM [FAS].[dbo].[FAS_CERT] where SerialNumber = 11224435

